using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Macro.Actions.Delay
{
    public partial class DelayActionForm : Form
    {
        public event EventHandler SubmitButtonClicked;

        public DelayActionForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int val = delayBar.Value;
            DelayAction action = new DelayAction(val + "ms", "Delay", val);
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void delayBar_Scroll(object sender, EventArgs e)
        {
            barLabel.Text = delayBar.Value + "ms";
        }
    }
}