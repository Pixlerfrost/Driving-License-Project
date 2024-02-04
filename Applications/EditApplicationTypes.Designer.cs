namespace FullWindowsFormProject.Applications
{
    partial class EditApplicationTypes
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
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.FeesTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Application Types";
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(338, 230);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(68, 36);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(253, 230);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(68, 36);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fees:";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLbl.Location = new System.Drawing.Point(179, 108);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(0, 18);
            this.IDLbl.TabIndex = 6;
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.Location = new System.Drawing.Point(154, 138);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.Size = new System.Drawing.Size(252, 22);
            this.TitleTxtBox.TabIndex = 7;
            // 
            // FeesTxtBox
            // 
            this.FeesTxtBox.Location = new System.Drawing.Point(154, 181);
            this.FeesTxtBox.Name = "FeesTxtBox";
            this.FeesTxtBox.Size = new System.Drawing.Size(252, 22);
            this.FeesTxtBox.TabIndex = 8;
            // 
            // EditApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 305);
            this.Controls.Add(this.FeesTxtBox);
            this.Controls.Add(this.TitleTxtBox);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label1);
            this.Name = "EditApplicationTypes";
            this.Text = "EditApplicationTypes";
            this.Load += new System.EventHandler(this.EditApplicationTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.TextBox FeesTxtBox;
    }
}