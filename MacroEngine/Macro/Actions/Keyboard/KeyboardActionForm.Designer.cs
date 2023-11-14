namespace MacroEngine.Macro.Actions.Keyboard
{
    partial class KeyboardActionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.actionTypeBox = new System.Windows.Forms.ComboBox();
            this.keyBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.keyboardDelayBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardDelayBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(144, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Key";
            // 
            // actionTypeBox
            // 
            this.actionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionTypeBox.FormattingEnabled = true;
            this.actionTypeBox.Items.AddRange(new object[] {
            "Press & Instant Release",
            "Press & Hold then Release"});
            this.actionTypeBox.Location = new System.Drawing.Point(149, 89);
            this.actionTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actionTypeBox.Name = "actionTypeBox";
            this.actionTypeBox.Size = new System.Drawing.Size(153, 24);
            this.actionTypeBox.TabIndex = 1;
            this.actionTypeBox.SelectedIndexChanged += new System.EventHandler(this.actionTypeBox_SelectedIndexChanged);
            // 
            // keyBox
            // 
            this.keyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyBox.FormattingEnabled = true;
            this.keyBox.Location = new System.Drawing.Point(181, 180);
            this.keyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(121, 24);
            this.keyBox.TabIndex = 2;
            this.keyBox.SelectedIndexChanged += new System.EventHandler(this.keyBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(91, 223);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 37);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 223);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keyboardDelayBar
            // 
            this.keyboardDelayBar.LargeChange = 200;
            this.keyboardDelayBar.Location = new System.Drawing.Point(91, 118);
            this.keyboardDelayBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyboardDelayBar.Maximum = 5000;
            this.keyboardDelayBar.Name = "keyboardDelayBar";
            this.keyboardDelayBar.Size = new System.Drawing.Size(212, 56);
            this.keyboardDelayBar.SmallChange = 50;
            this.keyboardDelayBar.TabIndex = 5;
            this.keyboardDelayBar.Visible = false;
            this.keyboardDelayBar.Scroll += new System.EventHandler(this.keyboardDelayBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Location = new System.Drawing.Point(311, 122);
            this.barLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(14, 16);
            this.barLabel.TabIndex = 8;
            this.barLabel.Text = "0";
            this.barLabel.Visible = false;
            // 
            // KeyboardActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 289);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyboardDelayBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.actionTypeBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KeyboardActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeyboardActionForm";
            ((System.ComponentModel.ISupportInitialize)(this.keyboardDelayBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox actionTypeBox;
        private System.Windows.Forms.ComboBox keyBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar keyboardDelayBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label barLabel;
    }
}