namespace FullWindowsFormProject.Applications
{
    partial class DrivingLicenseFrm
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
            this.driversLicenseInfoCtrl1 = new FullWindowsFormProject.Driving_Licenses.Controls.DriversLicenseInfoCtrl();
            this.SuspendLayout();
            // 
            // driversLicenseInfoCtrl1
            // 
            this.driversLicenseInfoCtrl1.Location = new System.Drawing.Point(91, 76);
            this.driversLicenseInfoCtrl1.Name = "driversLicenseInfoCtrl1";
            this.driversLicenseInfoCtrl1.Size = new System.Drawing.Size(635, 276);
            this.driversLicenseInfoCtrl1.TabIndex = 0;
            // 
            // DrivingLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.driversLicenseInfoCtrl1);
            this.Name = "DrivingLicenseFrm";
            this.Text = "DrivingLicenceFrm";
            this.Load += new System.EventHandler(this.DrivingLicenseFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Driving_Licenses.Controls.DriversLicenseInfoCtrl driversLicenseInfoCtrl1;
    }
}