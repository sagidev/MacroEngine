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
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Keyboard Action";
            // 
            // actionTypeBox
            // 
            this.actionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionTypeBox.FormattingEnabled = true;
            this.actionTypeBox.Items.AddRange(new object[] {
            "Press & Instant Release",
            "Press & Hold then Release"});
            this.actionTypeBox.Location = new System.Drawing.Point(100, 69);
            this.actionTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionTypeBox.Name = "actionTypeBox";
            this.actionTypeBox.Size = new System.Drawing.Size(146, 21);
            this.actionTypeBox.TabIndex = 1;
            this.actionTypeBox.SelectedIndexChanged += new System.EventHandler(this.actionTypeBox_SelectedIndexChanged);
            // 
            // keyBox
            // 
            this.keyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyBox.FormattingEnabled = true;
            this.keyBox.Location = new System.Drawing.Point(100, 145);
            this.keyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(146, 21);
            this.keyBox.TabIndex = 2;
            this.keyBox.SelectedIndexChanged += new System.EventHandler(this.keyBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(67, 181);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 30);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keyboardDelayBar
            // 
            this.keyboardDelayBar.LargeChange = 200;
            this.keyboardDelayBar.Location = new System.Drawing.Point(67, 97);
            this.keyboardDelayBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyboardDelayBar.Maximum = 5000;
            this.keyboardDelayBar.Name = "keyboardDelayBar";
            this.keyboardDelayBar.Size = new System.Drawing.Size(161, 45);
            this.keyboardDelayBar.SmallChange = 50;
            this.keyboardDelayBar.TabIndex = 5;
            this.keyboardDelayBar.Visible = false;
            this.keyboardDelayBar.Scroll += new System.EventHandler(this.keyboardDelayBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Location = new System.Drawing.Point(233, 97);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(13, 13);
            this.barLabel.TabIndex = 8;
            this.barLabel.Text = "0";
            this.barLabel.Visible = false;
            // 
            // KeyboardActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 235);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyboardDelayBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.actionTypeBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "KeyboardActionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Keyboard Action";
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