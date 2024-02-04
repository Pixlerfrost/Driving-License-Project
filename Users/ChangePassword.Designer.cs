namespace FullWindowsFormProject.Users
{
    partial class ChangePassword
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
            this.ctrlShowUserInfo1 = new FullWindowsFormProject.Users.Controls.CtrlShowUserInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlShowUserInfo1
            // 
            this.ctrlShowUserInfo1.Location = new System.Drawing.Point(12, 3);
            this.ctrlShowUserInfo1.Name = "ctrlShowUserInfo1";
            this.ctrlShowUserInfo1.Size = new System.Drawing.Size(795, 477);
            this.ctrlShowUserInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password:";
            // 
            // CurrentPasswordTxtBox
            // 
            this.CurrentPasswordTxtBox.Location = new System.Drawing.Point(218, 500);
            this.CurrentPasswordTxtBox.Name = "CurrentPasswordTxtBox";
            this.CurrentPasswordTxtBox.PasswordChar = '*';
            this.CurrentPasswordTxtBox.Size = new System.Drawing.Size(145, 22);
            this.CurrentPasswordTxtBox.TabIndex = 4;
            this.CurrentPasswordTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.CurrentPasswordTxtBox_Validating);
            // 
            // NewPasswordTxtBox
            // 
            this.NewPasswordTxtBox.Location = new System.Drawing.Point(218, 537);
            this.NewPasswordTxtBox.Name = "NewPasswordTxtBox";
            this.NewPasswordTxtBox.PasswordChar = '*';
            this.NewPasswordTxtBox.Size = new System.Drawing.Size(145, 22);
            this.NewPasswordTxtBox.TabIndex = 5;
            this.NewPasswordTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.NewPasswordTxtBox_Validating);
            // 
            // ConfirmPasswordTxtBox
            // 
            this.ConfirmPasswordTxtBox.Location = new System.Drawing.Point(218, 574);
            this.ConfirmPasswordTxtBox.Name = "ConfirmPasswordTxtBox";
            this.ConfirmPasswordTxtBox.PasswordChar = '*';
            this.ConfirmPasswordTxtBox.Size = new System.Drawing.Size(145, 22);
            this.ConfirmPasswordTxtBox.TabIndex = 6;
            this.ConfirmPasswordTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.ConfirmPasswordTxtBox_Validating);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(699, 688);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(86, 39);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(597, 688);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(86, 39);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 749);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ConfirmPasswordTxtBox);
            this.Controls.Add(this.NewPasswordTxtBox);
            this.Controls.Add(this.CurrentPasswordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlShowUserInfo1);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlShowUserInfo ctrlShowUserInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CurrentPasswordTxtBox;
        private System.Windows.Forms.TextBox NewPasswordTxtBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTxtBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}