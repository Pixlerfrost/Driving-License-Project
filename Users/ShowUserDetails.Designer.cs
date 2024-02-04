namespace FullWindowsFormProject.Users
{
    partial class ShowUserDetails
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
            this.ctrlShowUserInfo1 = new FullWindowsFormProject.Users.Controls.CtrlShowUserInfo();
            this.SuspendLayout();
            // 
            // ctrlShowUserInfo1
            // 
            this.ctrlShowUserInfo1.Location = new System.Drawing.Point(17, 12);
            this.ctrlShowUserInfo1.Name = "ctrlShowUserInfo1";
            this.ctrlShowUserInfo1.Size = new System.Drawing.Size(795, 461);
            this.ctrlShowUserInfo1.TabIndex = 0;
            // 
            // ShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 485);
            this.Controls.Add(this.ctrlShowUserInfo1);
            this.Name = "ShowUserDetails";
            this.Text = "ShowUserDetails";
            this.Load += new System.EventHandler(this.ShowUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CtrlShowUserInfo ctrlShowUserInfo1;
    }
}