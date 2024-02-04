namespace FullWindowsFormProject
{
    partial class ShowPersonDetails
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
            this.ctrlShowPersonDetails1 = new FullWindowsFormProject.ctrlShowPersonDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlShowPersonDetails1
            // 
            this.ctrlShowPersonDetails1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ctrlShowPersonDetails1.Location = new System.Drawing.Point(12, 170);
            this.ctrlShowPersonDetails1.Name = "ctrlShowPersonDetails1";
            this.ctrlShowPersonDetails1.Size = new System.Drawing.Size(765, 319);
            this.ctrlShowPersonDetails1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(670, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlShowPersonDetails1);
            this.Name = "ShowPersonDetails";
            this.Text = "Person Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowPersonDetails ctrlShowPersonDetails1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}