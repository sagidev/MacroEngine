using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Macro.Actions.Keyboard
{
    public partial class KeyboardActionForm : Form
    {
        public KeyboardActionForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyboardDelayBar_Scroll(object sender, EventArgs e)
        {
            barLabel.Text = keyboardDelayBar.Value + "ms";
        }

        private void actionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionTypeBox.SelectedIndex == 1)
            {
                keyboardDelayBar.Visible = true;
            }
            else
            {
                keyboardDelayBar.Visible = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string val = keyBox.Text;
            if (actionTypeBox.SelectedIndex == 0)
            {
                KeyboardAction action = new KeyboardAction(val, "Click", KeyboardAction.KeyboardActionType.PressAndRelease, 0);
                MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            }
            else
            {
                KeyboardAction action = new KeyboardAction(val + "[" + keyboardDelayBar.Value + "ms]", "Hold", KeyboardAction.KeyboardActionType.HoldAndRelease);
                MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            }
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        public event EventHandler SubmitButtonClicked;
    }
}