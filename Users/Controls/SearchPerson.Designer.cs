namespace FullWindowsFormProject.Users.Controls
{
    partial class SearchPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.ctrlShowPersonDetails1 = new FullWindowsFormProject.ctrlShowPersonDetails();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FilterComboBox);
            this.groupBox1.Controls.Add(this.FilterTextBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(675, 23);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(73, 34);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(601, 23);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(57, 34);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By:";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo"});
            this.FilterComboBox.Location = new System.Drawing.Point(108, 29);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 24);
            this.FilterComboBox.TabIndex = 1;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(245, 31);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(141, 22);
            this.FilterTextBox.TabIndex = 0;
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(14, 98);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(765, 319);
            this.ctrlShowPersonDetails1.TabIndex = 1;
            // 
            // SearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ctrlShowPersonDetails1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchPerson";
            this.Size = new System.Drawing.Size(792, 420);
            this.Load += new System.EventHandler(this.SearchPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddButton;
        private ctrlShowPersonDetails ctrlShowPersonDetails1;
    }
}
