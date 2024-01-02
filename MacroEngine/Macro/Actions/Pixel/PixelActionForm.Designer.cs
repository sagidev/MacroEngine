namespace MacroEngine.Macro.Actions.Pixel
{
    partial class PixelActionForm
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
            this.triesLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hexTextbox = new System.Windows.Forms.TextBox();
            this.triesNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delayBar = new System.Windows.Forms.TrackBar();
            this.delayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.triesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // triesLabel
            // 
            this.triesLabel.AutoSize = true;
            this.triesLabel.Location = new System.Drawing.Point(175, 78);
            this.triesLabel.Name = "triesLabel";
            this.triesLabel.Size = new System.Drawing.Size(13, 13);
            this.triesLabel.TabIndex = 34;
            this.triesLabel.Text = "0";
            this.triesLabel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(45, 263);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 30);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Insert Pixerl color search";
            // 
            // hexTextbox
            // 
            this.hexTextbox.Location = new System.Drawing.Point(68, 220);
            this.hexTextbox.Name = "hexTextbox";
            this.hexTextbox.Size = new System.Drawing.Size(100, 20);
            this.hexTextbox.TabIndex = 35;
            // 
            // triesNumeric
            // 
            this.triesNumeric.Location = new System.Drawing.Point(48, 76);
            this.triesNumeric.Name = "triesNumeric";
            this.triesNumeric.Size = new System.Drawing.Size(120, 20);
            this.triesNumeric.TabIndex = 36;
            this.triesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.triesNumeric.ValueChanged += new System.EventHandler(this.triesNumeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "hex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "number of tries";
            // 
            // delayBar
            // 
            this.delayBar.LargeChange = 1000;
            this.delayBar.Location = new System.Drawing.Point(64, 136);
            this.delayBar.Maximum = 10000;
            this.delayBar.Minimum = 100;
            this.delayBar.Name = "delayBar";
            this.delayBar.Size = new System.Drawing.Size(104, 45);
            this.delayBar.SmallChange = 100;
            this.delayBar.TabIndex = 39;
            this.delayBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.delayBar.Value = 100;
            this.delayBar.Scroll += new System.EventHandler(this.delayBar_Scroll);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(171, 136);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(13, 13);
            this.delayLabel.TabIndex = 40;
            this.delayLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "delay between tries";
            // 
            // PixelActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.delayBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.triesNumeric);
            this.Controls.Add(this.hexTextbox);
            this.Controls.Add(this.triesLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "PixelActionForm";
            this.Text = "PixelActionForm";
            ((System.ComponentModel.ISupportInitialize)(this.triesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label triesLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hexTextbox;
        private System.Windows.Forms.NumericUpDown triesNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar delayBar;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Label label4;
    }
}