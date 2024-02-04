namespace FullWindowsFormProject.Driving_Licenses
{
    partial class ManageLocalDrivingApplications
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
            this.LocalDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RecordsLbl = new System.Windows.Forms.Label();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.TextBoxFilter = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicensesFirstTImeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LocalDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Driving License Applications";
            // 
            // LocalDataGrid
            // 
            this.LocalDataGrid.AllowUserToAddRows = false;
            this.LocalDataGrid.AllowUserToDeleteRows = false;
            this.LocalDataGrid.AllowUserToOrderColumns = true;
            this.LocalDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalDataGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LocalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalDataGrid.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.LocalDataGrid.Location = new System.Drawing.Point(33, 206);
            this.LocalDataGrid.Name = "LocalDataGrid";
            this.LocalDataGrid.ReadOnly = true;
            this.LocalDataGrid.RowHeadersWidth = 51;
            this.LocalDataGrid.RowTemplate.Height = 24;
            this.LocalDataGrid.Size = new System.Drawing.Size(1319, 356);
            this.LocalDataGrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "# Records: ";
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(1283, 157);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(69, 37);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RecordsLbl
            // 
            this.RecordsLbl.AutoSize = true;
            this.RecordsLbl.Location = new System.Drawing.Point(146, 587);
            this.RecordsLbl.Name = "RecordsLbl";
            this.RecordsLbl.Size = new System.Drawing.Size(0, 16);
            this.RecordsLbl.TabIndex = 5;
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "None",
            "LocalDrivingLicenseApplicationID",
            "NationalNo",
            "FullName",
            "Status"});
            this.ComboBoxFilter.Location = new System.Drawing.Point(105, 174);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(192, 24);
            this.ComboBoxFilter.TabIndex = 6;
            this.ComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilter_SelectedIndexChanged);
            // 
            // TextBoxFilter
            // 
            this.TextBoxFilter.Location = new System.Drawing.Point(313, 175);
            this.TextBoxFilter.Name = "TextBoxFilter";
            this.TextBoxFilter.Size = new System.Drawing.Size(192, 22);
            this.TextBoxFilter.TabIndex = 7;
            this.TextBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.issueDrivingLicensesFirstTImeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showPersonLicenseHistoryToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(299, 260);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(295, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(295, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(295, 6);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestsToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionTestsToolStripMenuItem
            // 
            this.scheduleVisionTestsToolStripMenuItem.Name = "scheduleVisionTestsToolStripMenuItem";
            this.scheduleVisionTestsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.scheduleVisionTestsToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestsToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestsToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(295, 6);
            // 
            // issueDrivingLicensesFirstTImeToolStripMenuItem
            // 
            this.issueDrivingLicensesFirstTImeToolStripMenuItem.Enabled = false;
            this.issueDrivingLicensesFirstTImeToolStripMenuItem.Name = "issueDrivingLicensesFirstTImeToolStripMenuItem";
            this.issueDrivingLicensesFirstTImeToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.issueDrivingLicensesFirstTImeToolStripMenuItem.Text = "Issue Driving Licenses (First Time)";
            this.issueDrivingLicensesFirstTImeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicensesFirstTImeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(295, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show License";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(295, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem1
            // 
            this.showPersonLicenseHistoryToolStripMenuItem1.Name = "showPersonLicenseHistoryToolStripMenuItem1";
            this.showPersonLicenseHistoryToolStripMenuItem1.Size = new System.Drawing.Size(298, 24);
            this.showPersonLicenseHistoryToolStripMenuItem1.Text = "Show Person License History";
            // 
            // ManageLocalDrivingApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 676);
            this.Controls.Add(this.TextBoxFilter);
            this.Controls.Add(this.ComboBoxFilter);
            this.Controls.Add(this.RecordsLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocalDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "ManageLocalDrivingApplications";
            this.Text = "ManageLocalDrivingApplications";
            this.Load += new System.EventHandler(this.ManageLocalDrivingApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LocalDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LocalDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label RecordsLbl;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.TextBox TextBoxFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicensesFirstTImeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem1;
    }
}