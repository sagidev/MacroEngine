namespace MacroEngine
{
    partial class Form1
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
            this.playButton = new System.Windows.Forms.Button();
            this.macroBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.mouseActionButton = new System.Windows.Forms.Button();
            this.keyboardActionButton = new System.Windows.Forms.Button();
            this.delayActionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.macroGrid = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macroBox.SuspendLayout();
            this.InputBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(6, 21);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 100);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // macroBox
            // 
            this.macroBox.Controls.Add(this.stopButton);
            this.macroBox.Controls.Add(this.recordButton);
            this.macroBox.Controls.Add(this.playButton);
            this.macroBox.Location = new System.Drawing.Point(13, 13);
            this.macroBox.Name = "macroBox";
            this.macroBox.Size = new System.Drawing.Size(328, 130);
            this.macroBox.TabIndex = 1;
            this.macroBox.TabStop = false;
            this.macroBox.Text = "Macro";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(218, 21);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 100);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(112, 21);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(100, 100);
            this.recordButton.TabIndex = 1;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            // 
            // InputBox
            // 
            this.InputBox.Controls.Add(this.delayActionButton);
            this.InputBox.Controls.Add(this.keyboardActionButton);
            this.InputBox.Controls.Add(this.mouseActionButton);
            this.InputBox.Location = new System.Drawing.Point(338, 13);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(333, 130);
            this.InputBox.TabIndex = 2;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "Input";
            // 
            // mouseActionButton
            // 
            this.mouseActionButton.Location = new System.Drawing.Point(9, 21);
            this.mouseActionButton.Name = "mouseActionButton";
            this.mouseActionButton.Size = new System.Drawing.Size(100, 100);
            this.mouseActionButton.TabIndex = 1;
            this.mouseActionButton.Text = "Insert Mouse Action";
            this.mouseActionButton.UseVisualStyleBackColor = true;
            // 
            // keyboardActionButton
            // 
            this.keyboardActionButton.Location = new System.Drawing.Point(115, 21);
            this.keyboardActionButton.Name = "keyboardActionButton";
            this.keyboardActionButton.Size = new System.Drawing.Size(100, 100);
            this.keyboardActionButton.TabIndex = 2;
            this.keyboardActionButton.Text = "Insert Keyboard Action";
            this.keyboardActionButton.UseVisualStyleBackColor = true;
            // 
            // delayActionButton
            // 
            this.delayActionButton.Location = new System.Drawing.Point(221, 21);
            this.delayActionButton.Name = "delayActionButton";
            this.delayActionButton.Size = new System.Drawing.Size(100, 100);
            this.delayActionButton.TabIndex = 3;
            this.delayActionButton.Text = "Insert Delay (ms)";
            this.delayActionButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(665, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Macro List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(797, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.macroGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(927, 289);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // macroGrid
            // 
            this.macroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.macroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Value,
            this.Label});
            this.macroGrid.Location = new System.Drawing.Point(6, 12);
            this.macroGrid.Name = "macroGrid";
            this.macroGrid.RowHeadersWidth = 51;
            this.macroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.macroGrid.RowTemplate.Height = 24;
            this.macroGrid.Size = new System.Drawing.Size(915, 271);
            this.macroGrid.TabIndex = 0;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 150;
            // 
            // Label
            // 
            this.Label.HeaderText = "Label";
            this.Label.MinimumWidth = 6;
            this.Label.Name = "Label";
            this.Label.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.macroBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Macro Engine";
            this.macroBox.ResumeLayout(false);
            this.InputBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.macroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.GroupBox macroBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.Button delayActionButton;
        private System.Windows.Forms.Button keyboardActionButton;
        private System.Windows.Forms.Button mouseActionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView macroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
    }
}

