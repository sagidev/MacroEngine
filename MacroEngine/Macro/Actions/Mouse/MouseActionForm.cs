using MacroEngine.External;
using MacroEngine.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private bool isMinimized = false;
        private Point clickedPoint;
        private OverlayForm overlayForm;

        public MouseActionForm()
        {
            InitializeComponent();
            keyBox.Items.AddRange(Enum.GetNames(typeof(MouseButton)));
            keyBox.SelectedIndex = 0;
            MouseClick += MainForm_MouseClick;
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
                    keyBox.Visible = false;
                    break;

                case 1:
                    mouseActionType = MouseActionType.Drag;
                    mouseDelayBar.Visible = false;
                    barLabel.Visible = false;
                    xLabel.Visible = true;
                    yLabel.Visible = true;
                    xTextbox.Visible = true;
                    yTextbox.Visible = true;
                    keyBox.Visible = true;
                    break;

                case 2:
                    mouseActionType = MouseActionType.Press;
                    mouseDelayBar.Visible = false;
                    barLabel.Visible = false;
                    xLabel.Visible = false;
                    yLabel.Visible = false;
                    xTextbox.Visible = false;
                    yTextbox.Visible = false;
                    keyBox.Visible = true;
                    break;

                case 3:
                    mouseActionType = MouseActionType.Hold;
                    mouseDelayBar.Visible = true;
                    barLabel.Visible = true;
                    xLabel.Visible = false;
                    yLabel.Visible = false;
                    xTextbox.Visible = false;
                    yTextbox.Visible = false;
                    keyBox.Visible = true;
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
            if (mouseActionType == MouseActionType.None)
            {
                MessageBox.Show("Please select a mouse key and action type.", "Invalid parameters");
                return;
            }
            this.value = new Value();
            string description = mouseActionType.ToString();
            switch (mouseActionType)
            {
                case MouseActionType.Move:
                    if (xTextbox.Text == "" || yTextbox.Text == "")
                    {
                        MessageBox.Show("Please enter a valid x and y value.", "Invalid parameters");
                        return;
                    }
                    this.value.x = float.Parse(xTextbox.Text);
                    this.value.y = float.Parse(yTextbox.Text);
                    break;

                case MouseActionType.Drag:
                    if (xTextbox.Text == "" || yTextbox.Text == "")
                    {
                        MessageBox.Show("Please enter a valid x and y value.", "Invalid parameters");
                        return;
                    }
                    this.value.x = float.Parse(xTextbox.Text);
                    this.value.y = float.Parse(yTextbox.Text);
                    if (mouseActionKey == MouseButton.None)
                    {
                        MessageBox.Show("Please select a mouse key.", "Invalid parameters");
                        return;
                    }
                    this.value.key = mouseActionKey.ToString();
                    break;

                case MouseActionType.Press:
                    if (mouseActionKey == MouseButton.None)
                    {
                        MessageBox.Show("Please select a mouse key.", "Invalid parameters");
                        return;
                    }
                    this.value.key = mouseActionKey.ToString();
                    break;

                case MouseActionType.Hold:
                    this.value.delay = mouseDelayBar.Value;
                    if (mouseActionKey == MouseButton.None)
                    {
                        MessageBox.Show("Please select a mouse key.", "Invalid parameters");
                        return;
                    }
                    this.value.key = mouseActionKey.ToString();
                    break;
            }

            MouseAction action = new MouseAction(this.value, description, mouseActionType);
            //MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            //Add action to macroList actionList in the index selectedActionIndex
            if (Form1.selectedActionIndex == -1 || Form1.selectedActionIndex == 0)
            {
                MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            }
            else
            {
                MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Insert(Form1.selectedActionIndex, action);
            }
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void mouseDelayBar_Scroll(object sender, EventArgs e)
        {
            barLabel.Text = mouseDelayBar.Value + "ms";
        }

        private void setPositionBtn_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (isMinimized && e.Button == MouseButtons.Left)
            {
                clickedPoint = Cursor.Position;
                Point cursorPosition = new Point(clickedPoint.X, clickedPoint.Y);
                MessageBox.Show($"Cursor Position: X={cursorPosition.X}, Y={cursorPosition.Y}");
                WindowState = FormWindowState.Normal;
                isMinimized = false;
            }
        }
    }

    public class OverlayForm : Form
    {
        private const int WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = -20;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        public OverlayForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            IntPtr extendedStyle = GetWindowLongPtr(Handle, GWL_EXSTYLE);
            SetWindowLongPtr(Handle, GWL_EXSTYLE, new IntPtr(extendedStyle.ToInt64() | WS_EX_LAYERED | WS_EX_TRANSPARENT));
            TransparencyKey = Color.Magenta;
            SetLayeredWindowAttributes(Handle, 0, 5, LWA_ALPHA);
        }

        private const int LWA_ALPHA = 0x2;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);
    }
}