namespace FinalProject
{
    partial class DonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AddDonner_button1 = new System.Windows.Forms.Button();
            this.AllRecords_button2 = new System.Windows.Forms.Button();
            this.Exit_button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Bank";
            // 
            // AddDonner_button1
            // 
            this.AddDonner_button1.BackColor = System.Drawing.Color.White;
            this.AddDonner_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDonner_button1.Location = new System.Drawing.Point(83, 85);
            this.AddDonner_button1.Name = "AddDonner_button1";
            this.AddDonner_button1.Size = new System.Drawing.Size(173, 48);
            this.AddDonner_button1.TabIndex = 1;
            this.AddDonner_button1.Text = "Add Donner";
            this.AddDonner_button1.UseVisualStyleBackColor = false;
            this.AddDonner_button1.Click += new System.EventHandler(this.AddDonner_button1_Click);
            // 
            // AllRecords_button2
            // 
            this.AllRecords_button2.BackColor = System.Drawing.Color.White;
            this.AllRecords_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllRecords_button2.Location = new System.Drawing.Point(83, 156);
            this.AllRecords_button2.Name = "AllRecords_button2";
            this.AllRecords_button2.Size = new System.Drawing.Size(173, 48);
            this.AllRecords_button2.TabIndex = 2;
            this.AllRecords_button2.Text = "All Records";
            this.AllRecords_button2.UseVisualStyleBackColor = false;
            this.AllRecords_button2.Click += new System.EventHandler(this.AllRecords_button2_Click);
            // 
            // Exit_button3
            // 
            this.Exit_button3.BackColor = System.Drawing.Color.White;
            this.Exit_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button3.Location = new System.Drawing.Point(83, 262);
            this.Exit_button3.Name = "Exit_button3";
            this.Exit_button3.Size = new System.Drawing.Size(173, 48);
            this.Exit_button3.TabIndex = 3;
            this.Exit_button3.Text = "Exit";
            this.Exit_button3.UseVisualStyleBackColor = false;
            this.Exit_button3.Click += new System.EventHandler(this.Exit_button3_Click);
            // 
            // DonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(354, 356);
            this.Controls.Add(this.Exit_button3);
            this.Controls.Add(this.AllRecords_button2);
            this.Controls.Add(this.AddDonner_button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDonner_button1;
        private System.Windows.Forms.Button AllRecords_button2;
        private System.Windows.Forms.Button Exit_button3;
    }
}

