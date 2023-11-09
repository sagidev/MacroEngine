namespace MacroEngine.Macro.Actions.Mouse
{
    partial class MouseActionForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mouseDelayBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.ComboBox();
            this.actionTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xTextbox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.yTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mouseDelayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Key";
            // 
            // mouseDelayBar
            // 
            this.mouseDelayBar.LargeChange = 200;
            this.mouseDelayBar.Location = new System.Drawing.Point(40, 128);
            this.mouseDelayBar.Maximum = 5000;
            this.mouseDelayBar.Name = "mouseDelayBar";
            this.mouseDelayBar.Size = new System.Drawing.Size(212, 56);
            this.mouseDelayBar.SmallChange = 50;
            this.mouseDelayBar.TabIndex = 13;
            this.mouseDelayBar.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(40, 303);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 37);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // keyBox
            // 
            this.keyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyBox.FormattingEnabled = true;
            this.keyBox.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.keyBox.Location = new System.Drawing.Point(131, 260);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(121, 24);
            this.keyBox.TabIndex = 10;
            this.keyBox.SelectedIndexChanged += new System.EventHandler(this.keyBox_SelectedIndexChanged);
            // 
            // actionTypeBox
            // 
            this.actionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionTypeBox.FormattingEnabled = true;
            this.actionTypeBox.Items.AddRange(new object[] {
            "Move",
            "Drag",
            "Press",
            "Hold"});
            this.actionTypeBox.Location = new System.Drawing.Point(99, 98);
            this.actionTypeBox.Name = "actionTypeBox";
            this.actionTypeBox.Size = new System.Drawing.Size(153, 24);
            this.actionTypeBox.TabIndex = 9;
            this.actionTypeBox.SelectedIndexChanged += new System.EventHandler(this.actionTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insert Mouse Movement";
            // 
            // xTextbox
            // 
            this.xTextbox.Location = new System.Drawing.Point(131, 187);
            this.xTextbox.Name = "xTextbox";
            this.xTextbox.Size = new System.Drawing.Size(88, 22);
            this.xTextbox.TabIndex = 16;
            this.xTextbox.Visible = false;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(96, 190);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 16);
            this.xLabel.TabIndex = 17;
            this.xLabel.Text = "X";
            this.xLabel.Visible = false;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(96, 218);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(16, 16);
            this.yLabel.TabIndex = 19;
            this.yLabel.Text = "Y";
            this.yLabel.Visible = false;
            // 
            // yTextbox
            // 
            this.yTextbox.Location = new System.Drawing.Point(131, 215);
            this.yTextbox.Name = "yTextbox";
            this.yTextbox.Size = new System.Drawing.Size(88, 22);
            this.yTextbox.TabIndex = 18;
            this.yTextbox.Visible = false;
            // 
            // MouseActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 395);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.yTextbox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mouseDelayBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.actionTypeBox);
            this.Controls.Add(this.label1);
            this.Name = "MouseActionForm";
            this.Text = "MouseActionForm";
            ((System.ComponentModel.ISupportInitialize)(this.mouseDelayBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar mouseDelayBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox keyBox;
        private System.Windows.Forms.ComboBox actionTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xTextbox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yTextbox;
    }
}