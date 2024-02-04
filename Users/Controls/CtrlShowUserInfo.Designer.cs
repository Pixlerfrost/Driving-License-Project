namespace FullWindowsFormProject.Users.Controls
{
    partial class CtrlShowUserInfo
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
            this.ctrlShowPersonDetails1 = new FullWindowsFormProject.ctrlShowPersonDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsActiveLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserIDLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(15, 12);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(765, 319);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IsActiveLbl);
            this.groupBox1.Controls.Add(this.UserNameLbl);
            this.groupBox1.Controls.Add(this.UserIDLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // IsActiveLbl
            // 
            this.IsActiveLbl.AutoSize = true;
            this.IsActiveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveLbl.Location = new System.Drawing.Point(649, 45);
            this.IsActiveLbl.Name = "IsActiveLbl";
            this.IsActiveLbl.Size = new System.Drawing.Size(0, 18);
            this.IsActiveLbl.TabIndex = 4;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(409, 45);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(0, 18);
            this.UserNameLbl.TabIndex = 3;
            // 
            // UserIDLbl
            // 
            this.UserIDLbl.AutoSize = true;
            this.UserIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLbl.Location = new System.Drawing.Point(183, 45);
            this.UserIDLbl.Name = "UserIDLbl";
            this.UserIDLbl.Size = new System.Drawing.Size(0, 18);
            this.UserIDLbl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "IsActive:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID:";
            // 
            // CtrlShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlShowPersonDetails1);
            this.Name = "CtrlShowUserInfo";
            this.Size = new System.Drawing.Size(795, 477);
            this.Load += new System.EventHandler(this.ShowUserInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowPersonDetails ctrlShowPersonDetails1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IsActiveLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label UserIDLbl;
    }
}
