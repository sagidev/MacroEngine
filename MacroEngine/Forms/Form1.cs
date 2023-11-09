using MacroEngine.Macro;
using MacroEngine.Macro.Actions.Keyboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Action = MacroEngine.Macro.Action;

namespace MacroEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MacroManager.Initialize();
        }

        private void mouseActionButton_Click(object sender, EventArgs e)
        {

        }

        private void keyboardActionButton_Click(object sender, EventArgs e)
        {
            KeyboardActionForm keyboardForm = new KeyboardActionForm();
            keyboardForm.ShowDialog();
        }

        private void macroListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MacroManager.currentMacroIndex = macroListBox.SelectedIndex;
        }

        public void FillMacroGrid()
        {
            macroGrid.Rows.Clear();
            foreach (Action action in MacroManager.macroList[MacroManager.currentMacroIndex].actionList)
            {
                macroGrid.Rows.Add(action.ActionType, action.Value, action.Description, action.HoldTime);
            }
        }

        private void macroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            FillMacroGrid();
        }
    }
}
