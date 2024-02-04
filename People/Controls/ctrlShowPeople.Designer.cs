namespace FullWindowsFormProject
{
    partial class ctrlShowPeople
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.RecordsLbl = new System.Windows.Forms.Label();
            this.AmonuntOfRecords = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridInfo = new System.Windows.Forms.DataGridView();
            this.FilterTxtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By:";
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "None",
            "NationalNo",
            "PersonID"});
            this.ComboBoxFilter.Location = new System.Drawing.Point(112, 10);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxFilter.TabIndex = 2;
            // 
            // RecordsLbl
            // 
            this.RecordsLbl.AutoSize = true;
            this.RecordsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsLbl.Location = new System.Drawing.Point(13, 500);
            this.RecordsLbl.Name = "RecordsLbl";
            this.RecordsLbl.Size = new System.Drawing.Size(86, 16);
            this.RecordsLbl.TabIndex = 3;
            this.RecordsLbl.Text = "# Records :";
            // 
            // AmonuntOfRecords
            // 
            this.AmonuntOfRecords.AutoSize = true;
            this.AmonuntOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmonuntOfRecords.Location = new System.Drawing.Point(105, 500);
            this.AmonuntOfRecords.Name = "AmonuntOfRecords";
            this.AmonuntOfRecords.Size = new System.Drawing.Size(0, 16);
            this.AmonuntOfRecords.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DataGridInfo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 437);
            this.panel1.TabIndex = 5;
            // 
            // DataGridInfo
            // 
            this.DataGridInfo.AllowUserToAddRows = false;
            this.DataGridInfo.AllowUserToDeleteRows = false;
            this.DataGridInfo.AllowUserToOrderColumns = true;
            this.DataGridInfo.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridInfo.Location = new System.Drawing.Point(19, 13);
            this.DataGridInfo.Name = "DataGridInfo";
            this.DataGridInfo.ReadOnly = true;
            this.DataGridInfo.RowHeadersWidth = 51;
            this.DataGridInfo.RowTemplate.Height = 24;
            this.DataGridInfo.Size = new System.Drawing.Size(1540, 246);
            this.DataGridInfo.TabIndex = 0;
            // 
            // FilterTxtBox
            // 
            this.FilterTxtBox.Location = new System.Drawing.Point(239, 10);
            this.FilterTxtBox.Name = "FilterTxtBox";
            this.FilterTxtBox.Size = new System.Drawing.Size(168, 22);
            this.FilterTxtBox.TabIndex = 6;
            this.FilterTxtBox.TextChanged += new System.EventHandler(this.FilterTxtBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 160);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.callPhoneToolStripMenuItem.Text = "Call Phone";
            this.callPhoneToolStripMenuItem.Click += new System.EventHandler(this.callPhoneToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1539, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlShowPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilterTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AmonuntOfRecords);
            this.Controls.Add(this.RecordsLbl);
            this.Controls.Add(this.ComboBoxFilter);
            this.Controls.Add(this.label1);
            this.Name = "ctrlShowPeople";
            this.Size = new System.Drawing.Size(1645, 517);
            this.Load += new System.EventHandler(this.ctrlShowPeople_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridInfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.Label RecordsLbl;
        private System.Windows.Forms.Label AmonuntOfRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FilterTxtBox;
        private System.Windows.Forms.DataGridView DataGridInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
