namespace FullWindowsFormProject.Users
{
    partial class AddOrEditUsers
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonInfoPage = new System.Windows.Forms.TabPage();
            this.NextBtn = new System.Windows.Forms.Button();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlShowPersonDetails1 = new FullWindowsFormProject.ctrlShowPersonDetails();
            this.LoginInfoPage = new System.Windows.Forms.TabPage();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.UserIDLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.PersonInfoPage.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            this.LoginInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonInfoPage);
            this.tabControl1.Controls.Add(this.LoginInfoPage);
            this.tabControl1.Location = new System.Drawing.Point(20, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // PersonInfoPage
            // 
            this.PersonInfoPage.Controls.Add(this.NextBtn);
            this.PersonInfoPage.Controls.Add(this.FilterGroupBox);
            this.PersonInfoPage.Controls.Add(this.ctrlShowPersonDetails1);
            this.PersonInfoPage.Location = new System.Drawing.Point(4, 25);
            this.PersonInfoPage.Name = "PersonInfoPage";
            this.PersonInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfoPage.Size = new System.Drawing.Size(804, 472);
            this.PersonInfoPage.TabIndex = 0;
            this.PersonInfoPage.Text = "Person Info";
            this.PersonInfoPage.UseVisualStyleBackColor = true;
            this.PersonInfoPage.Click += new System.EventHandler(this.PersonInfoPage_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Location = new System.Drawing.Point(709, 427);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(76, 39);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.SearchBtn);
            this.FilterGroupBox.Controls.Add(this.AddBtn);
            this.FilterGroupBox.Controls.Add(this.FilterTextBox);
            this.FilterGroupBox.Controls.Add(this.FilterComboBox);
            this.FilterGroupBox.Controls.Add(this.label2);
            this.FilterGroupBox.Location = new System.Drawing.Point(20, 25);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(765, 65);
            this.FilterGroupBox.TabIndex = 1;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(672, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(76, 32);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(607, 20);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(59, 32);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(226, 29);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(130, 22);
            this.FilterTextBox.TabIndex = 2;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo"});
            this.FilterComboBox.Location = new System.Drawing.Point(90, 29);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 24);
            this.FilterComboBox.TabIndex = 1;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Find By:";
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(20, 106);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(765, 314);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // LoginInfoPage
            // 
            this.LoginInfoPage.Controls.Add(this.IsActiveCheckBox);
            this.LoginInfoPage.Controls.Add(this.ConfirmPasswordTxtBox);
            this.LoginInfoPage.Controls.Add(this.PasswordTxtBox);
            this.LoginInfoPage.Controls.Add(this.UserNameTxtBox);
            this.LoginInfoPage.Controls.Add(this.UserIDLbl);
            this.LoginInfoPage.Controls.Add(this.label6);
            this.LoginInfoPage.Controls.Add(this.label5);
            this.LoginInfoPage.Controls.Add(this.label4);
            this.LoginInfoPage.Controls.Add(this.label3);
            this.LoginInfoPage.Location = new System.Drawing.Point(4, 25);
            this.LoginInfoPage.Name = "LoginInfoPage";
            this.LoginInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfoPage.Size = new System.Drawing.Size(804, 472);
            this.LoginInfoPage.TabIndex = 1;
            this.LoginInfoPage.Text = "LoginInfo";
            this.LoginInfoPage.UseVisualStyleBackColor = true;
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.Location = new System.Drawing.Point(201, 247);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(79, 20);
            this.IsActiveCheckBox.TabIndex = 8;
            this.IsActiveCheckBox.Text = "Is Active";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmPasswordTxtBox
            // 
            this.ConfirmPasswordTxtBox.Location = new System.Drawing.Point(201, 205);
            this.ConfirmPasswordTxtBox.Name = "ConfirmPasswordTxtBox";
            this.ConfirmPasswordTxtBox.PasswordChar = '*';
            this.ConfirmPasswordTxtBox.Size = new System.Drawing.Size(144, 22);
            this.ConfirmPasswordTxtBox.TabIndex = 7;
            this.ConfirmPasswordTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.ConfirmPassword_Validating);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(201, 165);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(144, 22);
            this.PasswordTxtBox.TabIndex = 6;
            this.PasswordTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTxtBox_Validating);
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Location = new System.Drawing.Point(201, 121);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(144, 22);
            this.UserNameTxtBox.TabIndex = 5;
            this.UserNameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTxtBox_Validating);
            // 
            // UserIDLbl
            // 
            this.UserIDLbl.AutoSize = true;
            this.UserIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLbl.Location = new System.Drawing.Point(198, 89);
            this.UserIDLbl.Name = "UserIDLbl";
            this.UserIDLbl.Size = new System.Drawing.Size(35, 18);
            this.UserIDLbl.TabIndex = 4;
            this.UserIDLbl.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "UserName: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Users";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(122, 659);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(77, 37);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(24, 659);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(77, 37);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddOrEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 708);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddOrEditUsers";
            this.Text = "AddOrEditUsers";
            this.Load += new System.EventHandler(this.AddOrEditUsers_Load);
            this.tabControl1.ResumeLayout(false);
            this.PersonInfoPage.ResumeLayout(false);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.LoginInfoPage.ResumeLayout(false);
            this.LoginInfoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonInfoPage;
        private System.Windows.Forms.TabPage LoginInfoPage;
        private System.Windows.Forms.Label label1;
        private ctrlShowPersonDetails ctrlShowPersonDetails1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConfirmPasswordTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Label UserIDLbl;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}