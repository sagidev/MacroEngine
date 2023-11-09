using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Macro.Actions.Mouse
{
    public enum MouseActionKey
    {
        Left,
        Middle,
        Right
    }
    public enum MouseActionType
    {
        Move,
        Drag,
        Hold,
        Press
    }
    public partial class MouseActionForm : Form
    {
        MouseActionKey mouseActionKey;
        MouseActionType mouseActionType;
        public MouseActionForm()
        {
            InitializeComponent();
        }

        private void actionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(actionTypeBox.SelectedIndex)
            {
                case 0:
                    mouseActionType = MouseActionType.Move;
                    mouseDelayBar.Visible = false;
                    xLabel.Visible = true;
                    yLabel.Visible = true;
                    xTextbox.Visible = true;
                    yTextbox.Visible = true;
                    break;
                case 1:
                    mouseActionType = MouseActionType.Drag;
                    mouseDelayBar.Visible = false;
                    xLabel.Visible = true;
                    yLabel.Visible = true;
                    xTextbox.Visible = true;
                    yTextbox.Visible = true;
                    break;
                case 2:
                    mouseActionType = MouseActionType.Press;
                    mouseDelayBar.Visible = false;
                    xLabel.Visible = false;
                    yLabel.Visible = false;
                    xTextbox.Visible = false;
                    yTextbox.Visible = false;
                    break;
                case 3:
                    mouseActionType = MouseActionType.Hold;
                    mouseDelayBar.Visible = true;
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
                    mouseActionKey = MouseActionKey.Left;
                    break;
                case 1:
                    mouseActionKey = MouseActionKey.Middle;
                    break;
                case 2:
                    mouseActionKey = MouseActionKey.Right;
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string val = keyBox.Text;
            switch(mouseActionType)
            {
                case MouseActionType.Move:
                    
                    break;
                case MouseActionType.Drag:
                    break;
                case MouseActionType.Press:
                    break;
                case MouseActionType.Hold:
                    break;
            }

            MouseAction action = new MouseAction(val, mouseActionType.ToString());
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
            this.Close();
        }
    }
}
