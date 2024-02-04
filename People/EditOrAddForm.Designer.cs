namespace FullWindowsFormProject
{
    partial class EditOrAddForm
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
            this.ctrlEditOrAdd1 = new FullWindowsFormProject.CtrlEditOrAdd();
            this.SuspendLayout();
            // 
            // ctrlEditOrAdd1
            // 
            this.ctrlEditOrAdd1.Location = new System.Drawing.Point(12, 50);
            this.ctrlEditOrAdd1.Name = "ctrlEditOrAdd1";
            this.ctrlEditOrAdd1.Size = new System.Drawing.Size(863, 416);
            this.ctrlEditOrAdd1.TabIndex = 0;
            this.ctrlEditOrAdd1.Load += new System.EventHandler(this.ctrlEditOrAdd1_Load);
            // 
            // EditOrAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 550);
            this.Controls.Add(this.ctrlEditOrAdd1);
            this.Name = "EditOrAddForm";
            this.Text = "EditOrAddForm";
            this.Load += new System.EventHandler(this.EditOrAddForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlEditOrAdd ctrlEditOrAdd1;
    }
}