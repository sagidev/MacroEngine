using MacroEngine.External;
using MacroEngine.Macro;
using MacroEngine.Macro.Actions;
using MacroEngine.Macro.Actions.Delay;
using MacroEngine.Macro.Actions.Keyboard;
using MacroEngine.Macro.Actions.Mouse;
using System;
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
     * - Add macro recording [done]
     * - Add macro start on hotkey
     * - Add global settings in droptown top menu in application
     *
     * wzorzec command - https://www.codeproject.com/Articles/15207/Design-Patterns-Command-Pattern
    */

    public partial class Form1 : Form
    {
        private readonly DelayedAction delay = new DelayedAction();
        public static Timer updateTimer;
        public static int selectedActionIndex = 0;

        public Point lastMousePos = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            MacroManager.Initialize();
            macroListBox.Items.Add(MacroManager.macroList[MacroManager.macroList.Count - 1].Name);
            macroListBox.SelectedIndex = MacroManager.currentMacroIndex;

            updateTimer = new Timer();
            updateTimer.Interval = 100;
            updateTimer.Tick += UpdateTimer_Tick;

            Hooks.Initialize();

            FillMacroGrid();
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

        private void Hooks_UpdateDataGrid(object sender, EventArgs e)
        {
            FillMacroGrid();
        }

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
            if (MacroManager.macroList.Count > 0)
                MacroManager.macroList[MacroManager.currentMacroIndex].Play();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            delay.Update();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            if (MacroManager.macroList.Count <= 0)
            {
                MessageBox.Show("Please create a macro first.", "No macro");
                return;
            }
            if (!Hooks.IsRecording)
            {
                Hooks.Subscribe();
                Hooks.IsRecording = true;
                Hooks.ResetTimeStamp();
                Hooks.UpdateDataGridEvent += Hooks_UpdateDataGrid;
                return;
            }
            Hooks.Unsubscribe();
            Hooks.IsRecording = false;
        }

        private void macroGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.RemoveAt(e.Row.Index);
        }

        private void macroGrid_SelectionChanged(object sender, EventArgs e)
        {
            //if (macroGrid.SelectedRows[0].Index != -1)
            //{
            //    selectedActionIndex = macroGrid.SelectedRows[0].Index;
            //    Console.WriteLine(selectedActionIndex);
            //}
        }
    }
}