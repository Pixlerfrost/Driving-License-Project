namespace FullWindowsFormProject
{
    partial class CtrlEditOrAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AddressTxtBox = new System.Windows.Forms.RichTextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.NationalNoTxtBox = new System.Windows.Forms.TextBox();
            this.LastTxtBox = new System.Windows.Forms.TextBox();
            this.ThirdTxtBox = new System.Windows.Forms.TextBox();
            this.SecondTxtBox = new System.Windows.Forms.TextBox();
            this.FirstTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOrEditLabel = new System.Windows.Forms.Label();
            this.PersonIDLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.CountryComboBox);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.FemaleRadioBtn);
            this.panel1.Controls.Add(this.MaleRadioBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.AddressTxtBox);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PhoneTxtBox);
            this.panel1.Controls.Add(this.EmailTxtBox);
            this.panel1.Controls.Add(this.NationalNoTxtBox);
            this.panel1.Controls.Add(this.LastTxtBox);
            this.panel1.Controls.Add(this.ThirdTxtBox);
            this.panel1.Controls.Add(this.SecondTxtBox);
            this.panel1.Controls.Add(this.FirstTxtBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 324);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2024, 1, 6, 0, 0, 0, 0);
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(511, 184);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(142, 24);
            this.CountryComboBox.TabIndex = 12;
            this.CountryComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountryComboBox_Validating);
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(668, 262);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(83, 44);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(227, 140);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(74, 20);
            this.FemaleRadioBtn.TabIndex = 7;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.Text = "Female";
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Location = new System.Drawing.Point(159, 140);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(58, 20);
            this.MaleRadioBtn.TabIndex = 6;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(772, 262);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(81, 44);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTxtBox.Location = new System.Drawing.Point(159, 232);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(494, 74);
            this.AddressTxtBox.TabIndex = 9;
            this.AddressTxtBox.Text = "";
            this.AddressTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressTxtBox_Validating);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(743, 29);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(32, 16);
            this.lbl4.TabIndex = 22;
            this.lbl4.Text = "Last";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(569, 29);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(38, 16);
            this.lbl3.TabIndex = 21;
            this.lbl3.Text = "Third";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Second";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "First";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(421, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Country:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date Of Birth:";
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Location = new System.Drawing.Point(511, 138);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(142, 22);
            this.PhoneTxtBox.TabIndex = 11;
            this.PhoneTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneTxtBox_Validating);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(159, 186);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(142, 22);
            this.EmailTxtBox.TabIndex = 8;
            // 
            // NationalNoTxtBox
            // 
            this.NationalNoTxtBox.Location = new System.Drawing.Point(159, 94);
            this.NationalNoTxtBox.Name = "NationalNoTxtBox";
            this.NationalNoTxtBox.Size = new System.Drawing.Size(142, 22);
            this.NationalNoTxtBox.TabIndex = 5;
            this.NationalNoTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.NationalNoTxtBox_Validating);
            // 
            // LastTxtBox
            // 
            this.LastTxtBox.Location = new System.Drawing.Point(687, 48);
            this.LastTxtBox.Name = "LastTxtBox";
            this.LastTxtBox.Size = new System.Drawing.Size(142, 22);
            this.LastTxtBox.TabIndex = 4;
            this.LastTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.LastTxtBox_Validating);
            // 
            // ThirdTxtBox
            // 
            this.ThirdTxtBox.Location = new System.Drawing.Point(511, 48);
            this.ThirdTxtBox.Name = "ThirdTxtBox";
            this.ThirdTxtBox.Size = new System.Drawing.Size(142, 22);
            this.ThirdTxtBox.TabIndex = 3;
            // 
            // SecondTxtBox
            // 
            this.SecondTxtBox.Location = new System.Drawing.Point(335, 48);
            this.SecondTxtBox.Name = "SecondTxtBox";
            this.SecondTxtBox.Size = new System.Drawing.Size(142, 22);
            this.SecondTxtBox.TabIndex = 2;
            this.SecondTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.SecondTxtBox_Validating);
            // 
            // FirstTxtBox
            // 
            this.FirstTxtBox.Location = new System.Drawing.Point(159, 48);
            this.FirstTxtBox.Name = "FirstTxtBox";
            this.FirstTxtBox.Size = new System.Drawing.Size(142, 22);
            this.FirstTxtBox.TabIndex = 1;
            this.FirstTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.FirstTxtBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "National No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gendor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person ID:";
            // 
            // AddOrEditLabel
            // 
            this.AddOrEditLabel.AutoSize = true;
            this.AddOrEditLabel.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrEditLabel.Location = new System.Drawing.Point(281, 0);
            this.AddOrEditLabel.Name = "AddOrEditLabel";
            this.AddOrEditLabel.Size = new System.Drawing.Size(301, 42);
            this.AddOrEditLabel.TabIndex = 2;
            this.AddOrEditLabel.Text = "Add New Person";
            // 
            // PersonIDLbl
            // 
            this.PersonIDLbl.AutoSize = true;
            this.PersonIDLbl.Location = new System.Drawing.Point(108, 58);
            this.PersonIDLbl.Name = "PersonIDLbl";
            this.PersonIDLbl.Size = new System.Drawing.Size(0, 16);
            this.PersonIDLbl.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CtrlEditOrAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.PersonIDLbl);
            this.Controls.Add(this.AddOrEditLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CtrlEditOrAdd";
            this.Size = new System.Drawing.Size(874, 474);
            this.Load += new System.EventHandler(this.CtrlEditOrAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondTxtBox;
        private System.Windows.Forms.TextBox FirstTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox NationalNoTxtBox;
        private System.Windows.Forms.TextBox LastTxtBox;
        private System.Windows.Forms.TextBox ThirdTxtBox;
        private System.Windows.Forms.RichTextBox AddressTxtBox;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton FemaleRadioBtn;
        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.Label AddOrEditLabel;
        private System.Windows.Forms.Label PersonIDLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
