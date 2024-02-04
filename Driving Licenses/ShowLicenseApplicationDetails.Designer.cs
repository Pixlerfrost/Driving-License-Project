namespace FullWindowsFormProject.Driving_Licenses
{
    partial class ShowLicenseApplicationDetails
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
            this.licenseApplicationInfo1 = new FullWindowsFormProject.Driving_Licenses.Controls.LicenseApplicationInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // licenseApplicationInfo1
            // 
            this.licenseApplicationInfo1.Location = new System.Drawing.Point(16, 115);
            this.licenseApplicationInfo1.Name = "licenseApplicationInfo1";
            this.licenseApplicationInfo1.Size = new System.Drawing.Size(772, 317);
            this.licenseApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application Details";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(689, 451);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(82, 42);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ShowLicenseApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licenseApplicationInfo1);
            this.Name = "ShowLicenseApplicationDetails";
            this.Text = "ShowLicenseApplicationDetails";
            this.Load += new System.EventHandler(this.ShowLicenseApplicationDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.LicenseApplicationInfo licenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseBtn;
    }
}