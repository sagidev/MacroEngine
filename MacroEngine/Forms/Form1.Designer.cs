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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.playButton = new System.Windows.Forms.Button();
            this.macroBox = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.colorActionButton = new System.Windows.Forms.Button();
            this.delayActionButton = new System.Windows.Forms.Button();
            this.keyboardActionButton = new System.Windows.Forms.Button();
            this.mouseActionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveMacroBtn = new System.Windows.Forms.Button();
            this.deleteMacroBtn = new System.Windows.Forms.Button();
            this.createNewMacroBtn = new System.Windows.Forms.Button();
            this.macroListBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.macroGrid = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importBtn = new System.Windows.Forms.Button();
            this.macroBox.SuspendLayout();
            this.InputBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(4, 17);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 81);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play [F10]";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // macroBox
            // 
            this.macroBox.BackColor = System.Drawing.Color.Black;
            this.macroBox.Controls.Add(this.stopButton);
            this.macroBox.Controls.Add(this.recordButton);
            this.macroBox.Controls.Add(this.playButton);
            this.macroBox.Location = new System.Drawing.Point(10, 11);
            this.macroBox.Margin = new System.Windows.Forms.Padding(2);
            this.macroBox.Name = "macroBox";
            this.macroBox.Padding = new System.Windows.Forms.Padding(2);
            this.macroBox.Size = new System.Drawing.Size(246, 106);
            this.macroBox.TabIndex = 1;
            this.macroBox.TabStop = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(164, 17);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 81);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop [F8]";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recordButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.Location = new System.Drawing.Point(84, 17);
            this.recordButton.Margin = new System.Windows.Forms.Padding(2);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 81);
            this.recordButton.TabIndex = 1;
            this.recordButton.Text = "Record [F9]";
            this.recordButton.UseVisualStyleBackColor = false;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.Black;
            this.InputBox.Controls.Add(this.colorActionButton);
            this.InputBox.Controls.Add(this.delayActionButton);
            this.InputBox.Controls.Add(this.keyboardActionButton);
            this.InputBox.Controls.Add(this.mouseActionButton);
            this.InputBox.Location = new System.Drawing.Point(254, 11);
            this.InputBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Padding = new System.Windows.Forms.Padding(2);
            this.InputBox.Size = new System.Drawing.Size(328, 106);
            this.InputBox.TabIndex = 2;
            this.InputBox.TabStop = false;
            // 
            // colorActionButton
            // 
            this.colorActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorActionButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.colorActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorActionButton.Location = new System.Drawing.Point(245, 17);
            this.colorActionButton.Margin = new System.Windows.Forms.Padding(2);
            this.colorActionButton.Name = "colorActionButton";
            this.colorActionButton.Size = new System.Drawing.Size(75, 81);
            this.colorActionButton.TabIndex = 4;
            this.colorActionButton.Text = "Insert Color Detection";
            this.colorActionButton.UseVisualStyleBackColor = false;
            this.colorActionButton.Click += new System.EventHandler(this.colorActionButton_Click);
            // 
            // delayActionButton
            // 
            this.delayActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delayActionButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delayActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delayActionButton.Location = new System.Drawing.Point(166, 17);
            this.delayActionButton.Margin = new System.Windows.Forms.Padding(2);
            this.delayActionButton.Name = "delayActionButton";
            this.delayActionButton.Size = new System.Drawing.Size(75, 81);
            this.delayActionButton.TabIndex = 3;
            this.delayActionButton.Text = "Insert Delay (ms)";
            this.delayActionButton.UseVisualStyleBackColor = false;
            this.delayActionButton.Click += new System.EventHandler(this.delayActionButton_Click);
            // 
            // keyboardActionButton
            // 
            this.keyboardActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keyboardActionButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.keyboardActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyboardActionButton.Location = new System.Drawing.Point(86, 17);
            this.keyboardActionButton.Margin = new System.Windows.Forms.Padding(2);
            this.keyboardActionButton.Name = "keyboardActionButton";
            this.keyboardActionButton.Size = new System.Drawing.Size(75, 81);
            this.keyboardActionButton.TabIndex = 2;
            this.keyboardActionButton.Text = "Insert Keyboard Action";
            this.keyboardActionButton.UseVisualStyleBackColor = false;
            this.keyboardActionButton.Click += new System.EventHandler(this.keyboardActionButton_Click);
            // 
            // mouseActionButton
            // 
            this.mouseActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mouseActionButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.mouseActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mouseActionButton.Location = new System.Drawing.Point(7, 17);
            this.mouseActionButton.Margin = new System.Windows.Forms.Padding(2);
            this.mouseActionButton.Name = "mouseActionButton";
            this.mouseActionButton.Size = new System.Drawing.Size(75, 81);
            this.mouseActionButton.TabIndex = 1;
            this.mouseActionButton.Text = "Insert Mouse Action";
            this.mouseActionButton.UseVisualStyleBackColor = false;
            this.mouseActionButton.Click += new System.EventHandler(this.mouseActionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.importBtn);
            this.groupBox1.Controls.Add(this.saveMacroBtn);
            this.groupBox1.Controls.Add(this.deleteMacroBtn);
            this.groupBox1.Controls.Add(this.createNewMacroBtn);
            this.groupBox1.Controls.Add(this.macroListBox);
            this.groupBox1.Location = new System.Drawing.Point(580, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(186, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // saveMacroBtn
            // 
            this.saveMacroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveMacroBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveMacroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMacroBtn.Location = new System.Drawing.Point(4, 43);
            this.saveMacroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveMacroBtn.Name = "saveMacroBtn";
            this.saveMacroBtn.Size = new System.Drawing.Size(91, 22);
            this.saveMacroBtn.TabIndex = 3;
            this.saveMacroBtn.Text = "Save";
            this.saveMacroBtn.UseVisualStyleBackColor = false;
            this.saveMacroBtn.Click += new System.EventHandler(this.saveMacroBtn_Click);
            // 
            // deleteMacroBtn
            // 
            this.deleteMacroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteMacroBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteMacroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMacroBtn.Location = new System.Drawing.Point(99, 17);
            this.deleteMacroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteMacroBtn.Name = "deleteMacroBtn";
            this.deleteMacroBtn.Size = new System.Drawing.Size(83, 22);
            this.deleteMacroBtn.TabIndex = 2;
            this.deleteMacroBtn.Text = "Delete";
            this.deleteMacroBtn.UseVisualStyleBackColor = false;
            this.deleteMacroBtn.Click += new System.EventHandler(this.deleteMacroBtn_Click);
            // 
            // createNewMacroBtn
            // 
            this.createNewMacroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createNewMacroBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createNewMacroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewMacroBtn.Location = new System.Drawing.Point(4, 17);
            this.createNewMacroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createNewMacroBtn.Name = "createNewMacroBtn";
            this.createNewMacroBtn.Size = new System.Drawing.Size(91, 22);
            this.createNewMacroBtn.TabIndex = 1;
            this.createNewMacroBtn.Text = "Create new";
            this.createNewMacroBtn.UseVisualStyleBackColor = false;
            this.createNewMacroBtn.Click += new System.EventHandler(this.createNewMacroBtn_Click);
            // 
            // macroListBox
            // 
            this.macroListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.macroListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.macroListBox.FormattingEnabled = true;
            this.macroListBox.Location = new System.Drawing.Point(6, 77);
            this.macroListBox.Margin = new System.Windows.Forms.Padding(2);
            this.macroListBox.Name = "macroListBox";
            this.macroListBox.Size = new System.Drawing.Size(176, 21);
            this.macroListBox.TabIndex = 0;
            this.macroListBox.SelectedIndexChanged += new System.EventHandler(this.macroListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.macroGrid);
            this.groupBox3.Location = new System.Drawing.Point(10, 121);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(756, 516);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // macroGrid
            // 
            this.macroGrid.AllowUserToAddRows = false;
            this.macroGrid.AllowUserToResizeColumns = false;
            this.macroGrid.AllowUserToResizeRows = false;
            this.macroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.macroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.macroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.macroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Value,
            this.Label});
            this.macroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macroGrid.EnableHeadersVisualStyles = false;
            this.macroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.macroGrid.Location = new System.Drawing.Point(2, 15);
            this.macroGrid.Margin = new System.Windows.Forms.Padding(2);
            this.macroGrid.MultiSelect = false;
            this.macroGrid.Name = "macroGrid";
            this.macroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.macroGrid.RowHeadersWidth = 51;
            this.macroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.macroGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.macroGrid.RowTemplate.Height = 24;
            this.macroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.macroGrid.ShowCellToolTips = false;
            this.macroGrid.ShowEditingIcon = false;
            this.macroGrid.Size = new System.Drawing.Size(752, 499);
            this.macroGrid.TabIndex = 0;
            this.macroGrid.SelectionChanged += new System.EventHandler(this.macroGrid_SelectionChanged);
            this.macroGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.macroGrid_UserDeletingRow);
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Action.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Value.Width = 250;
            // 
            // Label
            // 
            this.Label.HeaderText = "Description";
            this.Label.MinimumWidth = 6;
            this.Label.Name = "Label";
            this.Label.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Label.Width = 300;
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.importBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Location = new System.Drawing.Point(99, 43);
            this.importBtn.Margin = new System.Windows.Forms.Padding(2);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(83, 22);
            this.importBtn.TabIndex = 4;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(774, 647);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.macroBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Macro Engine";
            this.macroBox.ResumeLayout(false);
            this.InputBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox macroListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView macroGrid;
        private System.Windows.Forms.Button deleteMacroBtn;
        private System.Windows.Forms.Button createNewMacroBtn;
        private System.Windows.Forms.Button colorActionButton;
        private System.Windows.Forms.Button saveMacroBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.Button importBtn;
    }
}

