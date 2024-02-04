namespace FullWindowsFormProject.Driving_Licenses
{
    partial class NewLocalDrivingLicenseFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonalInfoPg = new System.Windows.Forms.TabPage();
            this.searchPerson1 = new FullWindowsFormProject.Users.Controls.SearchPerson();
            this.NextBtn = new System.Windows.Forms.Button();
            this.ApplicationInfoPg = new System.Windows.Forms.TabPage();
            this.UserThatCreated = new System.Windows.Forms.Label();
            this.ApplicationFee = new System.Windows.Forms.Label();
            this.LicenseClassComboBox = new System.Windows.Forms.ComboBox();
            this.ApplicationDate = new System.Windows.Forms.Label();
            this.DrivingApplicationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PersonalInfoPg.SuspendLayout();
            this.ApplicationInfoPg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonalInfoPg);
            this.tabControl1.Controls.Add(this.ApplicationInfoPg);
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 505);
            this.tabControl1.TabIndex = 2;
            // 
            // PersonalInfoPg
            // 
            this.PersonalInfoPg.BackColor = System.Drawing.SystemColors.Control;
            this.PersonalInfoPg.Controls.Add(this.searchPerson1);
            this.PersonalInfoPg.Controls.Add(this.NextBtn);
            this.PersonalInfoPg.Location = new System.Drawing.Point(4, 25);
            this.PersonalInfoPg.Name = "PersonalInfoPg";
            this.PersonalInfoPg.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfoPg.Size = new System.Drawing.Size(830, 476);
            this.PersonalInfoPg.TabIndex = 0;
            this.PersonalInfoPg.Text = "Personal Info";
            // 
            // searchPerson1
            // 
            this.searchPerson1._Person = null;
            this.searchPerson1.BackColor = System.Drawing.SystemColors.Control;
            this.searchPerson1.Location = new System.Drawing.Point(16, 6);
            this.searchPerson1.Name = "searchPerson1";
            this.searchPerson1.Size = new System.Drawing.Size(792, 420);
            this.searchPerson1.TabIndex = 2;
            this.searchPerson1.Load += new System.EventHandler(this.searchPerson1_Load_1);
            // 
            // NextBtn
            // 
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Location = new System.Drawing.Point(716, 432);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(76, 34);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // ApplicationInfoPg
            // 
            this.ApplicationInfoPg.BackColor = System.Drawing.SystemColors.Control;
            this.ApplicationInfoPg.Controls.Add(this.UserThatCreated);
            this.ApplicationInfoPg.Controls.Add(this.ApplicationFee);
            this.ApplicationInfoPg.Controls.Add(this.LicenseClassComboBox);
            this.ApplicationInfoPg.Controls.Add(this.ApplicationDate);
            this.ApplicationInfoPg.Controls.Add(this.DrivingApplicationID);
            this.ApplicationInfoPg.Controls.Add(this.label6);
            this.ApplicationInfoPg.Controls.Add(this.label5);
            this.ApplicationInfoPg.Controls.Add(this.label4);
            this.ApplicationInfoPg.Controls.Add(this.label3);
            this.ApplicationInfoPg.Controls.Add(this.label2);
            this.ApplicationInfoPg.Location = new System.Drawing.Point(4, 25);
            this.ApplicationInfoPg.Name = "ApplicationInfoPg";
            this.ApplicationInfoPg.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfoPg.Size = new System.Drawing.Size(830, 476);
            this.ApplicationInfoPg.TabIndex = 1;
            this.ApplicationInfoPg.Text = "Application Info";
            // 
            // UserThatCreated
            // 
            this.UserThatCreated.AutoSize = true;
            this.UserThatCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserThatCreated.Location = new System.Drawing.Point(284, 259);
            this.UserThatCreated.Name = "UserThatCreated";
            this.UserThatCreated.Size = new System.Drawing.Size(0, 18);
            this.UserThatCreated.TabIndex = 9;
            // 
            // ApplicationFee
            // 
            this.ApplicationFee.AutoSize = true;
            this.ApplicationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationFee.Location = new System.Drawing.Point(284, 216);
            this.ApplicationFee.Name = "ApplicationFee";
            this.ApplicationFee.Size = new System.Drawing.Size(26, 18);
            this.ApplicationFee.TabIndex = 8;
            this.ApplicationFee.Text = "15";
            // 
            // LicenseClassComboBox
            // 
            this.LicenseClassComboBox.FormattingEnabled = true;
            this.LicenseClassComboBox.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle"});
            this.LicenseClassComboBox.Location = new System.Drawing.Point(287, 166);
            this.LicenseClassComboBox.Name = "LicenseClassComboBox";
            this.LicenseClassComboBox.Size = new System.Drawing.Size(234, 24);
            this.LicenseClassComboBox.TabIndex = 7;
            this.LicenseClassComboBox.SelectedIndexChanged += new System.EventHandler(this.LicenseClassComboBox_SelectedIndexChanged);
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.AutoSize = true;
            this.ApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationDate.Location = new System.Drawing.Point(284, 130);
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.Size = new System.Drawing.Size(0, 18);
            this.ApplicationDate.TabIndex = 6;
            // 
            // DrivingApplicationID
            // 
            this.DrivingApplicationID.AutoSize = true;
            this.DrivingApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrivingApplicationID.Location = new System.Drawing.Point(284, 87);
            this.DrivingApplicationID.Name = "DrivingApplicationID";
            this.DrivingApplicationID.Size = new System.Drawing.Size(45, 18);
            this.DrivingApplicationID.TabIndex = 5;
            this.DrivingApplicationID.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.Application ID:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(106, 629);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(76, 34);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(12, 629);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(76, 34);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NewLocalDrivingLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 683);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "NewLocalDrivingLicenseFrm";
            this.Text = "NewLocalDrivingLicenseFrm";
            this.Load += new System.EventHandler(this.NewLocalDrivingLicenseFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.PersonalInfoPg.ResumeLayout(false);
            this.ApplicationInfoPg.ResumeLayout(false);
            this.ApplicationInfoPg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonalInfoPg;
        private System.Windows.Forms.TabPage ApplicationInfoPg;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ApplicationFee;
        private System.Windows.Forms.ComboBox LicenseClassComboBox;
        private System.Windows.Forms.Label ApplicationDate;
        private System.Windows.Forms.Label DrivingApplicationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserThatCreated;
        private Users.Controls.SearchPerson searchPerson1;
    }
}