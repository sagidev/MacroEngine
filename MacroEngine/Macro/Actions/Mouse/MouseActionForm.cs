﻿using System;
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

        private MouseActionKey mouseActionKey = MouseActionKey.None;
        private MouseActionType mouseActionType = MouseActionType.None;

        public MouseActionForm()
        {
            InitializeComponent();
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
            if (mouseActionKey == MouseActionKey.None || mouseActionType == MouseActionType.None)
            {
                MessageBox.Show("Please select a mouse key and action type.", "Invalid parameters");
                return;
            }

            string val = keyBox.Text;
            string description = mouseActionType.ToString();
            switch (mouseActionType)
            {
                case MouseActionType.Move:
                    val += "[" + xTextbox.Text + "," + yTextbox.Text + "]";
                    break;

                case MouseActionType.Drag:
                    val += "[" + xTextbox.Text + "," + yTextbox.Text + "]";
                    break;

                case MouseActionType.Press:
                    break;

                case MouseActionType.Hold:
                    val += "[" + mouseDelayBar.Value + "ms]";
                    break;
            }

            MouseAction action = new MouseAction(val, description, mouseActionType);
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