namespace FullWindowsFormProject
{
    partial class ManagePeople
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctrlShowPeople1 = new FullWindowsFormProject.ctrlShowPeople();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(1677, 735);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(116, 39);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(813, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Managing People";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ctrlShowPeople1
            // 
            this.ctrlShowPeople1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ctrlShowPeople1.Location = new System.Drawing.Point(192, 212);
            this.ctrlShowPeople1.Name = "ctrlShowPeople1";
            this.ctrlShowPeople1.Size = new System.Drawing.Size(1645, 517);
            this.ctrlShowPeople1.TabIndex = 4;
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 756);
            this.Controls.Add(this.ctrlShowPeople1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.MinimumSize = new System.Drawing.Size(18, 70);
            this.Name = "ManagePeople";
            this.Text = "ManagePeople";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ctrlShowPeople ctrlShowPeople1;
    }
}