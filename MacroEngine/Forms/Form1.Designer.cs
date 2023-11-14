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
            this.delayActionButton = new System.Windows.Forms.Button();
            this.keyboardActionButton = new System.Windows.Forms.Button();
            this.mouseActionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.macroListBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.macroGrid = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createNewMacroBtn = new System.Windows.Forms.Button();
            this.deleteMacroBtn = new System.Windows.Forms.Button();
            this.moveBtn = new System.Windows.Forms.Button();
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
            this.playButton.Location = new System.Drawing.Point(5, 21);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.macroBox.Location = new System.Drawing.Point(13, 14);
            this.macroBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.macroBox.Name = "macroBox";
            this.macroBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.macroBox.Size = new System.Drawing.Size(328, 130);
            this.macroBox.TabIndex = 1;
            this.macroBox.TabStop = false;
            this.macroBox.Text = "Macro";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(219, 21);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 100);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(112, 21);
            this.recordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.InputBox.Location = new System.Drawing.Point(339, 14);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Size = new System.Drawing.Size(333, 130);
            this.InputBox.TabIndex = 2;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "Input";
            // 
            // delayActionButton
            // 
            this.delayActionButton.Location = new System.Drawing.Point(221, 21);
            this.delayActionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delayActionButton.Name = "delayActionButton";
            this.delayActionButton.Size = new System.Drawing.Size(100, 100);
            this.delayActionButton.TabIndex = 3;
            this.delayActionButton.Text = "Insert Delay (ms)";
            this.delayActionButton.UseVisualStyleBackColor = true;
            this.delayActionButton.Click += new System.EventHandler(this.delayActionButton_Click);
            // 
            // keyboardActionButton
            // 
            this.keyboardActionButton.Location = new System.Drawing.Point(115, 21);
            this.keyboardActionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyboardActionButton.Name = "keyboardActionButton";
            this.keyboardActionButton.Size = new System.Drawing.Size(100, 100);
            this.keyboardActionButton.TabIndex = 2;
            this.keyboardActionButton.Text = "Insert Keyboard Action";
            this.keyboardActionButton.UseVisualStyleBackColor = true;
            this.keyboardActionButton.Click += new System.EventHandler(this.keyboardActionButton_Click);
            // 
            // mouseActionButton
            // 
            this.mouseActionButton.Location = new System.Drawing.Point(9, 21);
            this.mouseActionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mouseActionButton.Name = "mouseActionButton";
            this.mouseActionButton.Size = new System.Drawing.Size(100, 100);
            this.mouseActionButton.TabIndex = 1;
            this.mouseActionButton.Text = "Insert Mouse Action";
            this.mouseActionButton.UseVisualStyleBackColor = true;
            this.mouseActionButton.Click += new System.EventHandler(this.mouseActionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteMacroBtn);
            this.groupBox1.Controls.Add(this.createNewMacroBtn);
            this.groupBox1.Controls.Add(this.macroListBox);
            this.groupBox1.Location = new System.Drawing.Point(665, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(135, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager";
            // 
            // macroListBox
            // 
            this.macroListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.macroListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.macroListBox.FormattingEnabled = true;
            this.macroListBox.Location = new System.Drawing.Point(6, 97);
            this.macroListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.macroListBox.Name = "macroListBox";
            this.macroListBox.Size = new System.Drawing.Size(119, 24);
            this.macroListBox.TabIndex = 0;
            this.macroListBox.SelectedIndexChanged += new System.EventHandler(this.macroListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moveBtn);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Location = new System.Drawing.Point(797, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(141, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Macro";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(11, 91);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 30);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(11, 21);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(119, 30);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.macroGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(927, 289);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // macroGrid
            // 
            this.macroGrid.AllowUserToAddRows = false;
            this.macroGrid.AllowUserToDeleteRows = false;
            this.macroGrid.AllowUserToResizeColumns = false;
            this.macroGrid.AllowUserToResizeRows = false;
            this.macroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.macroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Value,
            this.Label});
            this.macroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macroGrid.Location = new System.Drawing.Point(3, 17);
            this.macroGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.macroGrid.MultiSelect = false;
            this.macroGrid.Name = "macroGrid";
            this.macroGrid.ReadOnly = true;
            this.macroGrid.RowHeadersWidth = 51;
            this.macroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.macroGrid.RowTemplate.Height = 24;
            this.macroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.macroGrid.ShowCellToolTips = false;
            this.macroGrid.ShowEditingIcon = false;
            this.macroGrid.Size = new System.Drawing.Size(921, 270);
            this.macroGrid.TabIndex = 0;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.Label.HeaderText = "Description";
            this.Label.MinimumWidth = 6;
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            this.Label.Width = 300;
            // 
            // createNewMacroBtn
            // 
            this.createNewMacroBtn.Location = new System.Drawing.Point(6, 21);
            this.createNewMacroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNewMacroBtn.Name = "createNewMacroBtn";
            this.createNewMacroBtn.Size = new System.Drawing.Size(119, 30);
            this.createNewMacroBtn.TabIndex = 1;
            this.createNewMacroBtn.Text = "Create new";
            this.createNewMacroBtn.UseVisualStyleBackColor = true;
            this.createNewMacroBtn.Click += new System.EventHandler(this.createNewMacroBtn_Click);
            // 
            // deleteMacroBtn
            // 
            this.deleteMacroBtn.Location = new System.Drawing.Point(6, 56);
            this.deleteMacroBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteMacroBtn.Name = "deleteMacroBtn";
            this.deleteMacroBtn.Size = new System.Drawing.Size(119, 30);
            this.deleteMacroBtn.TabIndex = 2;
            this.deleteMacroBtn.Text = "Delete";
            this.deleteMacroBtn.UseVisualStyleBackColor = true;
            this.deleteMacroBtn.Click += new System.EventHandler(this.deleteMacroBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(11, 56);
            this.moveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(119, 30);
            this.moveBtn.TabIndex = 2;
            this.moveBtn.Text = "Move";
            this.moveBtn.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox macroListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        public System.Windows.Forms.DataGridView macroGrid;
        private System.Windows.Forms.Button deleteMacroBtn;
        private System.Windows.Forms.Button createNewMacroBtn;
        private System.Windows.Forms.Button moveBtn;
    }
}

