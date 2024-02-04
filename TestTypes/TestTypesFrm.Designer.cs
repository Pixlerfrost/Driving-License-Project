namespace FullWindowsFormProject.Applications
{
    partial class TestTypesFrm
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
            this.Closebtn = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.Label();
            this.TestTypesDG = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordsLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TestTypesDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Closebtn
            // 
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Location = new System.Drawing.Point(716, 484);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(84, 38);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k.Location = new System.Drawing.Point(255, 59);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(313, 37);
            this.k.TabIndex = 2;
            this.k.Text = "Manage Test Types";
            // 
            // TestTypesDG
            // 
            this.TestTypesDG.AllowUserToAddRows = false;
            this.TestTypesDG.AllowUserToDeleteRows = false;
            this.TestTypesDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestTypesDG.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TestTypesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestTypesDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestTypesDG.Location = new System.Drawing.Point(0, 0);
            this.TestTypesDG.Name = "TestTypesDG";
            this.TestTypesDG.ReadOnly = true;
            this.TestTypesDG.RowHeadersWidth = 51;
            this.TestTypesDG.RowTemplate.Height = 24;
            this.TestTypesDG.Size = new System.Drawing.Size(787, 247);
            this.TestTypesDG.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TestTypesDG);
            this.panel1.Location = new System.Drawing.Point(12, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 249);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Records: ";
            // 
            // RecordsLabel
            // 
            this.RecordsLabel.AutoSize = true;
            this.RecordsLabel.Location = new System.Drawing.Point(102, 506);
            this.RecordsLabel.Name = "RecordsLabel";
            this.RecordsLabel.Size = new System.Drawing.Size(0, 16);
            this.RecordsLabel.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 28);
            // 
            // editTestTypesToolStripMenuItem
            // 
            this.editTestTypesToolStripMenuItem.Name = "editTestTypesToolStripMenuItem";
            this.editTestTypesToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.editTestTypesToolStripMenuItem.Text = "Edit Test Types";
            this.editTestTypesToolStripMenuItem.Click += new System.EventHandler(this.editTestTypesToolStripMenuItem_Click);
            // 
            // TestTypesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 534);
            this.Controls.Add(this.RecordsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.k);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.panel1);
            this.Name = "TestTypesFrm";
            this.Text = "Applications";
            this.Load += new System.EventHandler(this.Applications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestTypesDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label k;
        private System.Windows.Forms.DataGridView TestTypesDG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecordsLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTestTypesToolStripMenuItem;
    }
}