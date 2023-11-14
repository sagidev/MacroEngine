namespace MacroEngine.Macro.Actions.Delay
{
    partial class DelayActionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barLabel = new System.Windows.Forms.Label();
            this.delayBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Location = new System.Drawing.Point(229, 82);
            this.barLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(14, 16);
            this.barLabel.TabIndex = 17;
            this.barLabel.Text = "0";
            // 
            // delayBar
            // 
            this.delayBar.LargeChange = 200;
            this.delayBar.Location = new System.Drawing.Point(9, 79);
            this.delayBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delayBar.Maximum = 5000;
            this.delayBar.Name = "delayBar";
            this.delayBar.Size = new System.Drawing.Size(212, 56);
            this.delayBar.SmallChange = 50;
            this.delayBar.TabIndex = 14;
            this.delayBar.Scroll += new System.EventHandler(this.delayBar_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 139);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 37);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insert Delay";
            // 
            // DelayActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 210);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.delayBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DelayActionForm";
            this.ShowIcon = false;
            this.Text = "Add Delay Action";
            ((System.ComponentModel.ISupportInitialize)(this.delayBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barLabel;
        private System.Windows.Forms.TrackBar delayBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
    }
}