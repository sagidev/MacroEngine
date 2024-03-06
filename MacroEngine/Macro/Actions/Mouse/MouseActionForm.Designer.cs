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
            this.barLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mouseDelayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Key";
            // 
            // mouseDelayBar
            // 
            this.mouseDelayBar.LargeChange = 200;
            this.mouseDelayBar.Location = new System.Drawing.Point(30, 104);
            this.mouseDelayBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mouseDelayBar.Maximum = 5000;
            this.mouseDelayBar.Name = "mouseDelayBar";
            this.mouseDelayBar.Size = new System.Drawing.Size(159, 45);
            this.mouseDelayBar.SmallChange = 50;
            this.mouseDelayBar.TabIndex = 13;
            this.mouseDelayBar.Visible = false;
            this.mouseDelayBar.Scroll += new System.EventHandler(this.mouseDelayBar_Scroll);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(30, 246);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 30);
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
            this.keyBox.Location = new System.Drawing.Point(98, 211);
            this.keyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(92, 21);
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
            this.actionTypeBox.Location = new System.Drawing.Point(74, 80);
            this.actionTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionTypeBox.Name = "actionTypeBox";
            this.actionTypeBox.Size = new System.Drawing.Size(116, 21);
            this.actionTypeBox.TabIndex = 9;
            this.actionTypeBox.SelectedIndexChanged += new System.EventHandler(this.actionTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insert Mouse Movement";
            // 
            // xTextbox
            // 
            this.xTextbox.Location = new System.Drawing.Point(66, 149);
            this.xTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xTextbox.Name = "xTextbox";
            this.xTextbox.Size = new System.Drawing.Size(124, 20);
            this.xTextbox.TabIndex = 16;
            this.xTextbox.Visible = false;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(40, 151);
            this.xLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 17;
            this.xLabel.Text = "X";
            this.xLabel.Visible = false;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(40, 174);
            this.yLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 19;
            this.yLabel.Text = "Y";
            this.yLabel.Visible = false;
            // 
            // yTextbox
            // 
            this.yTextbox.Location = new System.Drawing.Point(66, 172);
            this.yTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yTextbox.Name = "yTextbox";
            this.yTextbox.Size = new System.Drawing.Size(123, 20);
            this.yTextbox.TabIndex = 18;
            this.yTextbox.Visible = false;
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Location = new System.Drawing.Point(194, 114);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(13, 13);
            this.barLabel.TabIndex = 20;
            this.barLabel.Text = "0";
            this.barLabel.Visible = false;
            // 
            // MouseActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 321);
            this.Controls.Add(this.barLabel);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MouseActionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Mouse Action";
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
        private System.Windows.Forms.Label barLabel;
    }
}