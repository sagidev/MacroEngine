using MacroEngine.External;
using MacroEngine.Macro;
using MacroEngine.Macro.Actions;
using MacroEngine.Macro.Actions.Delay;
using MacroEngine.Macro.Actions.Keyboard;
using MacroEngine.Macro.Actions.Mouse;
using System;
using Loamen.KeyMouseHook;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Action = MacroEngine.Macro.Action;
using Gma.System.MouseKeyHook;

namespace MacroEngine
{
    /* TODO
     * - Load/Save macros from PC
     * - Handle Mouse/Keyboard Press&Move at once
     * - Make Delay class working (inside updateTimer)
     * - Add PixelSearch function to Form1 menu
     * - Add macro editing in GUI
     * - Add Action moving in GUI
     * - Add macro recording
     * - Add macro start on hotkey
     * - Add global settings in droptown top menu in application
     *
     * wzorzec command - https://www.codeproject.com/Articles/15207/Design-Patterns-Command-Pattern
    */

    public partial class Form1 : Form
    {
        private readonly DelayedAction delay = new DelayedAction();
        public static Timer updateTimer;

        private bool IsRecording = false;

        public const Keys Key_Play = Keys.F10;
        public const Keys Key_Record = Keys.F9;

        private readonly KeyMouseFactory hookSub = new KeyMouseFactory(Hook.GlobalEvents());
        private readonly KeyboardWatcher keyboardSub;
        private readonly KeyboardWatcher keybindSub;
        private readonly MouseWatcher mouseSub;

        public Point lastMousePos = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            MacroManager.Initialize();
            macroBox.Text = MacroManager.macroList[MacroManager.currentMacroIndex].Name;
            macroListBox.Items.Add(MacroManager.macroList[MacroManager.macroList.Count - 1].Name);
            macroListBox.SelectedIndex = MacroManager.currentMacroIndex;

            updateTimer = new Timer();
            updateTimer.Interval = 100;
            updateTimer.Tick += UpdateTimer_Tick;

            keyboardSub = hookSub.GetKeyboardWatcher();
            mouseSub = hookSub.GetMouseWatcher();
            keyboardSub.OnKeyboardInput += GlobalHookHandler;
            keybindSub = new KeyMouseFactory(Hook.GlobalEvents()).GetKeyboardWatcher();
            keybindSub.OnKeyboardInput += ShortcutHandler;
            keybindSub.Start(Hook.GlobalEvents());
            mouseSub.OnMouseInput += GlobalHookHandler;

            FillMacroGrid();
        }

        private void ShortcutHandler(object sender, MacroEvent e)
        {
            if (e.KeyMouseEventType != MacroEventType.KeyUp) return;
            var keyEvent = (KeyEventArgs)e.EventArgs;
            switch (keyEvent.KeyCode)
            {
                case Key_Record:
                    RecordHook();
                    break;
            }
        }

        public void RecordHook()
        {
            if (IsRecording)
            {
                Console.WriteLine("Disabling Hook");
                IsRecording = false;
            }
            else
            {
                Console.WriteLine("Enabling Hook");
                IsRecording = true;
                StartWatch(Hook.GlobalEvents());
            }
        }

        private void GlobalHookHandler(object sender, MacroEvent e)
        {
            if (!IsRecording)
                return;

            var currentMacro = MacroManager.macroList[MacroManager.currentMacroIndex];
            Value value;
            switch (e.EventArgs)
            {
                case MouseEventExtArgs mouseEvent:
                    e.EventArgs = new MouseEventArgs(mouseEvent.Button, mouseEvent.Clicks, mouseEvent.X, mouseEvent.Y, mouseEvent.Delta);
                    if (mouseEvent.Button == MouseButtons.None && lastMousePos != new Point(0, 0))
                    {
                        break;
                    }
                    Console.WriteLine(mouseEvent.Button);

                    if (mouseEvent.X != lastMousePos.X && mouseEvent.Y != lastMousePos.Y)
                    {
                        Value mouseMoveValue = new Value();
                        mouseMoveValue.x = mouseEvent.X;
                        mouseMoveValue.y = mouseEvent.Y;
                        MouseAction mouseMoveAction = new MouseAction(mouseMoveValue, MacroEventType.MouseMove.ToString(), MouseAction.MouseActionType.Move);
                        currentMacro.actionList.Add(mouseMoveAction);
                    }

                    value = new Value();
                    value.x = mouseEvent.X;
                    value.y = mouseEvent.Y;
                    value.key = mouseEvent.Button.ToString();
                    MouseAction mouse_action = new MouseAction(value, e.KeyMouseEventType.ToString() + "[" + e.TimeSinceLastEvent + "ms]", MouseAction.MouseActionType.Press);
                    currentMacro.actionList.Add(mouse_action);

                    FillMacroGrid();
                    lastMousePos = new Point(mouseEvent.X, mouseEvent.Y);
                    break;

                case KeyEventArgsExt keyEvent:
                    e.EventArgs = new KeyEventArgs(keyEvent.KeyData);
                    if (keyEvent.KeyData == Keys.Escape)
                    {
                        RecordHook();
                        return;
                    }
                    Console.WriteLine(keyEvent.KeyData);
                    value = new Value();
                    value.key = keyEvent.KeyData.ToString();
                    KeyboardAction action = new KeyboardAction(value, e.KeyMouseEventType.ToString() + "[" + e.TimeSinceLastEvent + "ms]", KeyboardAction.KeyboardActionType.PressAndRelease, keyEvent.KeyData.ToString());
                    currentMacro.actionList.Add(action);
                    FillMacroGrid();
                    break;
            }
        }

        public void FillMacroGrid()
        {
            macroGrid.Rows.Clear();
            if (MacroManager.macroList.Count <= 0)
                return;
            foreach (Action action in MacroManager.macroList[MacroManager.currentMacroIndex].actionList)
            {
                macroGrid.Rows.Add(action.actionType, action.value, action.Description);
            }
        }

        private void mouseActionButton_Click(object sender, EventArgs e)
        {
            MouseActionForm mouseActionForm = new MouseActionForm();
            mouseActionForm.SubmitButtonClicked += MouseActionForm_SubmitButtonClicked;
            mouseActionForm.ShowDialog();
        }

        private void keyboardActionButton_Click(object sender, EventArgs e)
        {
            KeyboardActionForm keyboardForm = new KeyboardActionForm();
            keyboardForm.SubmitButtonClicked += KeyboardActionForm_SubmitButtonClicked;
            keyboardForm.ShowDialog();
        }

        private void macroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MacroManager.currentMacroIndex = macroListBox.SelectedIndex;
            FillMacroGrid();
        }

        private void delayActionButton_Click(object sender, EventArgs e)
        {
            DelayActionForm delayActionForm = new DelayActionForm();
            delayActionForm.SubmitButtonClicked += DelayActionForm_SubmitButtonClicked;
            delayActionForm.ShowDialog();
        }

        // --- Events ---

        private void MouseActionForm_SubmitButtonClicked(object sender, EventArgs e)
        {
            FillMacroGrid();
        }

        private void KeyboardActionForm_SubmitButtonClicked(object sender, EventArgs e)
        {
            FillMacroGrid();
        }

        private void DelayActionForm_SubmitButtonClicked(object sender, EventArgs e)
        {
            FillMacroGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.RemoveAt(macroGrid.SelectedRows[0].Index);
            FillMacroGrid();
        }

        private void createNewMacroBtn_Click(object sender, EventArgs e)
        {
            MacroManager.macroList.Add(new Macro.Macro("Macro" + (MacroManager.macroList.Count + 1).ToString()));
            macroListBox.Items.Add(MacroManager.macroList[MacroManager.macroList.Count - 1].Name);
            MacroManager.currentMacroIndex = MacroManager.macroList.Count - 1;
            macroListBox.SelectedIndex = MacroManager.currentMacroIndex;
            FillMacroGrid();
        }

        private void deleteMacroBtn_Click(object sender, EventArgs e)
        {
            MacroManager.macroList.RemoveAt(MacroManager.currentMacroIndex);
            macroListBox.Items.RemoveAt(MacroManager.currentMacroIndex);
            if (MacroManager.macroList.Count > 0)
            {
                MacroManager.currentMacroIndex = MacroManager.macroList.Count - 1;
                macroListBox.SelectedIndex = MacroManager.currentMacroIndex;
            }
            FillMacroGrid();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            updateTimer.Start();
            MacroManager.macroList[MacroManager.currentMacroIndex].Play();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            delay.Update();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            RecordHook();
        }

        private void StartWatch(IKeyboardMouseEvents events = null)
        {
            keyboardSub.Start(events);
            mouseSub.Start(events);
        }
    }
}