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

namespace MacroEngine.Macro.Actions.Pixel
{
    public partial class PixelActionForm : Form
    {
        public event EventHandler SubmitButtonClicked;

        public PixelActionForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (hexTextbox.Text == "")
            {
                MessageBox.Show("Please enter a hex value.");
                return;
            }

            if (triesNumeric.Value == 0)
            {
                MessageBox.Show("Please enter a number of tries.");
                return;
            }

            if (delayBar.Value == 0)
            {
                MessageBox.Show("Please enter a delay.");
                return;
            }

            if (hexTextbox.Text.Contains("#"))
            {
                hexTextbox.Text = hexTextbox.Text.Replace("#", "");
            }

            if (hexTextbox.Text.Length != 6 && hexTextbox.Text.Length != 8)
            {
                MessageBox.Show("Please enter a valid hex value.");
                return;
            }

            Value value = new Value();
            value.hex = hexTextbox.Text;
            value.tries = Convert.ToInt32(triesNumeric.Value);
            value.delay = Convert.ToInt32(delayBar.Value);
            PixelAction action = new PixelAction(value, "PixelSearch");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void triesNumeric_ValueChanged(object sender, EventArgs e)
        {
            triesLabel.Text = triesNumeric.Value.ToString();
        }

        private void delayBar_Scroll(object sender, EventArgs e)
        {
            delayLabel.Text = delayBar.Value.ToString() + "ms";
        }
    }
}