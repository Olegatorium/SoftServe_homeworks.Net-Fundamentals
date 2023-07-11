namespace FinalProject
{
    partial class DoctorRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorRecords));
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.doctorNumber_label = new System.Windows.Forms.Label();
            this.DoctorSpecialty_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfDeclaredPatient_label = new System.Windows.Forms.Label();
            this.NumberOfPerformedOperations_label = new System.Windows.Forms.Label();
            this.Experience_label = new System.Windows.Forms.Label();
            this.Salary_label = new System.Windows.Forms.Label();
            this.Surname_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkExperience_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataFilter_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.DeleteDoctor_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NextButton.Location = new System.Drawing.Point(558, 26);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(42, 32);
            this.NextButton.TabIndex = 48;
            this.NextButton.Text = ">>";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.White;
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PreviousButton.Location = new System.Drawing.Point(92, 26);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(42, 32);
            this.PreviousButton.TabIndex = 47;
            this.PreviousButton.Text = "<<";
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // doctorNumber_label
            // 
            this.doctorNumber_label.AutoSize = true;
            this.doctorNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorNumber_label.Location = new System.Drawing.Point(301, 28);
            this.doctorNumber_label.Name = "doctorNumber_label";
            this.doctorNumber_label.Size = new System.Drawing.Size(72, 25);
            this.doctorNumber_label.TabIndex = 46;
            this.doctorNumber_label.Text = "1 of 2";
            // 
            // DoctorSpecialty_label
            // 
            this.DoctorSpecialty_label.AutoSize = true;
            this.DoctorSpecialty_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorSpecialty_label.Location = new System.Drawing.Point(242, 92);
            this.DoctorSpecialty_label.Name = "DoctorSpecialty_label";
            this.DoctorSpecialty_label.Size = new System.Drawing.Size(35, 20);
            this.DoctorSpecialty_label.TabIndex = 45;
            this.DoctorSpecialty_label.Text = "Id: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Doctor\'s Specialty: ";
            // 
            // NumberOfDeclaredPatient_label
            // 
            this.NumberOfDeclaredPatient_label.AutoSize = true;
            this.NumberOfDeclaredPatient_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfDeclaredPatient_label.Location = new System.Drawing.Point(314, 321);
            this.NumberOfDeclaredPatient_label.Name = "NumberOfDeclaredPatient_label";
            this.NumberOfDeclaredPatient_label.Size = new System.Drawing.Size(108, 20);
            this.NumberOfDeclaredPatient_label.TabIndex = 43;
            this.NumberOfDeclaredPatient_label.Text = "Blood Type: ";
            // 
            // NumberOfPerformedOperations_label
            // 
            this.NumberOfPerformedOperations_label.AutoSize = true;
            this.NumberOfPerformedOperations_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfPerformedOperations_label.Location = new System.Drawing.Point(314, 367);
            this.NumberOfPerformedOperations_label.Name = "NumberOfPerformedOperations_label";
            this.NumberOfPerformedOperations_label.Size = new System.Drawing.Size(145, 20);
            this.NumberOfPerformedOperations_label.TabIndex = 42;
            this.NumberOfPerformedOperations_label.Text = "Donations Date: ";
            // 
            // Experience_label
            // 
            this.Experience_label.AutoSize = true;
            this.Experience_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Experience_label.Location = new System.Drawing.Point(242, 219);
            this.Experience_label.Name = "Experience_label";
            this.Experience_label.Size = new System.Drawing.Size(35, 20);
            this.Experience_label.TabIndex = 41;
            this.Experience_label.Text = "Id: ";
            // 
            // Salary_label
            // 
            this.Salary_label.AutoSize = true;
            this.Salary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary_label.Location = new System.Drawing.Point(241, 261);
            this.Salary_label.Name = "Salary_label";
            this.Salary_label.Size = new System.Drawing.Size(92, 20);
            this.Salary_label.TabIndex = 40;
            this.Salary_label.Text = "Social ID: ";
            // 
            // Surname_label
            // 
            this.Surname_label.AutoSize = true;
            this.Surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_label.Location = new System.Drawing.Point(241, 175);
            this.Surname_label.Name = "Surname_label";
            this.Surname_label.Size = new System.Drawing.Size(91, 20);
            this.Surname_label.TabIndex = 39;
            this.Surname_label.Text = "Surname: ";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(241, 131);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(65, 20);
            this.Name_label.TabIndex = 38;
            this.Name_label.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Number Of Performed Operations: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Number of Declared Patients: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Surname: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Salary In Dollars: ";
            // 
            // WorkExperience_label
            // 
            this.WorkExperience_label.AutoSize = true;
            this.WorkExperience_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkExperience_label.Location = new System.Drawing.Point(18, 219);
            this.WorkExperience_label.Name = "WorkExperience_label";
            this.WorkExperience_label.Size = new System.Drawing.Size(178, 20);
            this.WorkExperience_label.TabIndex = 29;
            this.WorkExperience_label.Text = "Working Experience: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(182, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Records of our Doctors";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.DataFilter_button);
            this.groupBox1.Controls.Add(this.NextButton);
            this.groupBox1.Controls.Add(this.PreviousButton);
            this.groupBox1.Controls.Add(this.doctorNumber_label);
            this.groupBox1.Controls.Add(this.DoctorSpecialty_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NumberOfDeclaredPatient_label);
            this.groupBox1.Controls.Add(this.NumberOfPerformedOperations_label);
            this.groupBox1.Controls.Add(this.Experience_label);
            this.groupBox1.Controls.Add(this.Salary_label);
            this.groupBox1.Controls.Add(this.Surname_label);
            this.groupBox1.Controls.Add(this.Name_label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.WorkExperience_label);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records";
            // 
            // DataFilter_button
            // 
            this.DataFilter_button.BackColor = System.Drawing.Color.White;
            this.DataFilter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DataFilter_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFilter_button.Location = new System.Drawing.Point(498, 185);
            this.DataFilter_button.Name = "DataFilter_button";
            this.DataFilter_button.Size = new System.Drawing.Size(135, 63);
            this.DataFilter_button.TabIndex = 24;
            this.DataFilter_button.Text = "Make Task Data Filter";
            this.DataFilter_button.UseVisualStyleBackColor = false;
            this.DataFilter_button.Click += new System.EventHandler(this.DataFilter_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.White;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(540, 504);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(154, 32);
            this.Exit_button.TabIndex = 23;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // DeleteDoctor_button
            // 
            this.DeleteDoctor_button.BackColor = System.Drawing.Color.White;
            this.DeleteDoctor_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteDoctor_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDoctor_button.Location = new System.Drawing.Point(12, 502);
            this.DeleteDoctor_button.Name = "DeleteDoctor_button";
            this.DeleteDoctor_button.Size = new System.Drawing.Size(163, 36);
            this.DeleteDoctor_button.TabIndex = 22;
            this.DeleteDoctor_button.Text = "Delete";
            this.DeleteDoctor_button.UseVisualStyleBackColor = false;
            this.DeleteDoctor_button.Click += new System.EventHandler(this.DeleteDoctor_button_Click);
            // 
            // DoctorRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 554);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.DeleteDoctor_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorRecords";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WorkExperience_label;
        private System.Windows.Forms.Label Experience_label;
        private System.Windows.Forms.Label Salary_label;
        private System.Windows.Forms.Label Surname_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label NumberOfDeclaredPatient_label;
        private System.Windows.Forms.Label NumberOfPerformedOperations_label;
        private System.Windows.Forms.Label DoctorSpecialty_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label doctorNumber_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button DeleteDoctor_button;
        private System.Windows.Forms.Button DataFilter_button;
    }
}