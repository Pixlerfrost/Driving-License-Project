namespace FullWindowsFormProject.Driving_License_Tests
{
    partial class DrivingLicenseTest
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
            this.AppointmentLbl = new System.Windows.Forms.Label();
            this.AppointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordsLbl = new System.Windows.Forms.Label();
            this.licenseApplicationInfo1 = new FullWindowsFormProject.Driving_Licenses.Controls.LicenseApplicationInfo();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentLbl
            // 
            this.AppointmentLbl.AutoSize = true;
            this.AppointmentLbl.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentLbl.Location = new System.Drawing.Point(165, 57);
            this.AppointmentLbl.Name = "AppointmentLbl";
            this.AppointmentLbl.Size = new System.Drawing.Size(451, 42);
            this.AppointmentLbl.TabIndex = 1;
            this.AppointmentLbl.Text = "Vision Test Appointments";
            // 
            // AppointmentDataGrid
            // 
            this.AppointmentDataGrid.AllowUserToAddRows = false;
            this.AppointmentDataGrid.AllowUserToDeleteRows = false;
            this.AppointmentDataGrid.AllowUserToOrderColumns = true;
            this.AppointmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentDataGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AppointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDataGrid.Location = new System.Drawing.Point(12, 490);
            this.AppointmentDataGrid.Name = "AppointmentDataGrid";
            this.AppointmentDataGrid.ReadOnly = true;
            this.AppointmentDataGrid.RowHeadersWidth = 51;
            this.AppointmentDataGrid.RowTemplate.Height = 24;
            this.AppointmentDataGrid.Size = new System.Drawing.Size(758, 187);
            this.AppointmentDataGrid.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(712, 450);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(58, 34);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(696, 700);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(74, 34);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "# Records: ";
            // 
            // RecordsLbl
            // 
            this.RecordsLbl.AutoSize = true;
            this.RecordsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsLbl.Location = new System.Drawing.Point(114, 707);
            this.RecordsLbl.Name = "RecordsLbl";
            this.RecordsLbl.Size = new System.Drawing.Size(0, 18);
            this.RecordsLbl.TabIndex = 6;
            // 
            // licenseApplicationInfo1
            // 
            this.licenseApplicationInfo1.Location = new System.Drawing.Point(12, 118);
            this.licenseApplicationInfo1.Name = "licenseApplicationInfo1";
            this.licenseApplicationInfo1.Size = new System.Drawing.Size(771, 317);
            this.licenseApplicationInfo1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // DrivingLicenseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 751);
            this.Controls.Add(this.RecordsLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AppointmentDataGrid);
            this.Controls.Add(this.AppointmentLbl);
            this.Controls.Add(this.licenseApplicationInfo1);
            this.Name = "DrivingLicenseTest";
            this.Text = "Vision_Test";
            this.Load += new System.EventHandler(this.Vision_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Driving_Licenses.Controls.LicenseApplicationInfo licenseApplicationInfo1;
        private System.Windows.Forms.Label AppointmentLbl;
        private System.Windows.Forms.DataGridView AppointmentDataGrid;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RecordsLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}