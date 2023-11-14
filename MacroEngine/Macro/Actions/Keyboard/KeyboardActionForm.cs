using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MacroEngine.Macro.Actions.KeyboardAction;

namespace MacroEngine.Macro.Actions.Keyboard
{
    public partial class KeyboardActionForm : Form
    {
        public event EventHandler SubmitButtonClicked;

        public KeyboardActionType keyboardActionType = KeyboardActionType.None;
        public string keyboardKey = "None";

        public KeyboardActionForm()
        {
            InitializeComponent();
            keyBox.Items.AddRange(Enum.GetNames(typeof(Keys)));
            keyBox.SelectedIndex = 0;
            
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
            switch (actionTypeBox.SelectedIndex)
            {
                case 0:
                    keyboardActionType = KeyboardActionType.PressAndRelease;
                    keyboardDelayBar.Visible = false;
                    barLabel.Visible = false;
                    break;

                case 1:
                    keyboardActionType = KeyboardActionType.HoldAndRelease;
                    keyboardDelayBar.Visible = true;
                    barLabel.Visible = true;
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (keyboardActionType == KeyboardActionType.None || keyboardKey == "None")
            {
                MessageBox.Show("Please select an action type.", "Invalid parameters");
                return;
            }

            string val = keyBox.Text;
            string desc = "";
            switch (keyboardActionType)
            {
                case KeyboardActionType.PressAndRelease:
                    desc += "Press and Release";
                    break;
                case KeyboardActionType.HoldAndRelease:
                    val += " [" + keyboardDelayBar.Value.ToString() + "ms]";
                    desc += "Hold and Release";
                    break;
            }
            KeyboardAction action = new KeyboardAction(val, desc, keyboardActionType, keyboardKey);
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void keyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyboardKey = keyBox.SelectedItem.ToString();
        }
    }
}