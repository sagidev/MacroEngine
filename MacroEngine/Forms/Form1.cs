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

namespace MacroEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MacroManager.Initialize();
            macroBox.Text = MacroManager.macroList[MacroManager.currentMacroIndex].Name;
            macroListBox.Items.Add(MacroManager.macroList[MacroManager.macroList.Count - 1].Name);
            macroListBox.SelectedIndex = MacroManager.currentMacroIndex;
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
            MacroManager.macroList.Add(new Macro.Macro("Macro"+ (MacroManager.macroList.Count + 1).ToString()));
            macroListBox.Items.Add(MacroManager.macroList[MacroManager.macroList.Count - 1].Name);
            MacroManager.currentMacroIndex = MacroManager.macroList.Count - 1;
            macroListBox.SelectedIndex = MacroManager.currentMacroIndex;
            FillMacroGrid();
        }

        private void deleteMacroBtn_Click(object sender, EventArgs e)
        {
            MacroManager.macroList.RemoveAt(MacroManager.currentMacroIndex);
            macroListBox.Items.RemoveAt(MacroManager.currentMacroIndex);
            MacroManager.currentMacroIndex = MacroManager.macroList.Count - 1;
            macroListBox.SelectedIndex = MacroManager.currentMacroIndex;
            FillMacroGrid();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            MacroManager.macroList[MacroManager.currentMacroIndex].Play();
        }
    }
}