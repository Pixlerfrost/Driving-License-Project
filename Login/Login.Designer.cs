namespace FullWindowsFormProject
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Location = new System.Drawing.Point(160, 86);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(203, 22);
            this.UserNameTxtBox.TabIndex = 1;
            this.UserNameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTxtBox_Validating);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(160, 121);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(203, 22);
            this.PasswordTxtBox.TabIndex = 2;
            this.PasswordTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTxtBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login to your account";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(160, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Remember Me.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(270, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(160, 199);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 34);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UserNameTxtBox);
            this.panel1.Controls.Add(this.PasswordTxtBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(72, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 253);
            this.panel1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 335);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

