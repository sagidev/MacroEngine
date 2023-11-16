using MacroEngine.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MacroEngine.Macro.Actions.MouseAction;

namespace MacroEngine.Macro.Actions.Mouse
{
    public partial class MouseActionForm : Form
    {
        public event EventHandler SubmitButtonClicked;

        private MouseButton mouseActionKey = MouseButton.None;
        private MouseActionType mouseActionType = MouseActionType.None;
        private Value value;

        public MouseActionForm()
        {
            InitializeComponent();
            keyBox.Items.AddRange(Enum.GetNames(typeof(MouseButton)));
            keyBox.SelectedIndex = 0;
        }

        private void actionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (actionTypeBox.SelectedIndex)
            {
                case 0:
                    mouseActionType = MouseActionType.Move;
                    mouseDelayBar.Visible = false;
                    barLabel.Visible = false;
                    xLabel.Visible = true;
                    yLabel.Visible = true;
                    xTextbox.Visible = true;
                    yTextbox.Visible = true;
                    break;

                case 1:
                    mouseActionType = MouseActionType.Drag;
                    mouseDelayBar.Visible = false;
                    barLabel.Visible = false;
                    xLabel.Visible = true;
                    yLabel.Visible = true;
                    xTextbox.Visible = true;
                    yTextbox.Visible = true;
                    break;

                case 2:
                    mouseActionType = MouseActionType.Press;
                    mouseDelayBar.Visible = false;
                    barLabel.Visible = false;
                    xLabel.Visible = false;
                    yLabel.Visible = false;
                    xTextbox.Visible = false;
                    yTextbox.Visible = false;
                    break;

                case 3:
                    mouseActionType = MouseActionType.Hold;
                    mouseDelayBar.Visible = true;
                    barLabel.Visible = true;
                    xLabel.Visible = false;
                    yLabel.Visible = false;
                    xTextbox.Visible = false;
                    yTextbox.Visible = false;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (keyBox.SelectedIndex)
            {
                case 0:
                    mouseActionKey = MouseButton.Left;
                    break;

                case 1:
                    mouseActionKey = MouseButton.Middle;
                    break;

                case 2:
                    mouseActionKey = MouseButton.Right;
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (mouseActionKey == MouseButton.None || mouseActionType == MouseActionType.None)
            {
                MessageBox.Show("Please select a mouse key and action type.", "Invalid parameters");
                return;
            }
            this.value = new Value();
            string val = keyBox.Text;
            string description = mouseActionType.ToString();
            switch (mouseActionType)
            {
                case MouseActionType.Move:
                    this.value.x = float.Parse(xTextbox.Text);
                    this.value.y = float.Parse(yTextbox.Text);
                    break;

                case MouseActionType.Drag:
                    this.value.x = float.Parse(xTextbox.Text);
                    this.value.y = float.Parse(yTextbox.Text);
                    break;

                case MouseActionType.Press:
                    break;

                case MouseActionType.Hold:
                    this.value.delay = mouseDelayBar.Value;
                    break;
            }
            this.value.key = mouseActionKey.ToString();

            MouseAction action = new MouseAction(this.value, description, mouseActionType);
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void mouseDelayBar_Scroll(object sender, EventArgs e)
        {
            barLabel.Text = mouseDelayBar.Value + "ms";
        }
    }
}