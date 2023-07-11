namespace FinalProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Donor_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameOfDay_label = new System.Windows.Forms.Label();
            this.Day_label = new System.Windows.Forms.Label();
            this.Month_label = new System.Windows.Forms.Label();
            this.CurrentTime_label = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddStaff_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PatientRecors_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Calculator_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Game_Button = new System.Windows.Forms.ToolStripButton();
            this.About_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Donor_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CurrentTime_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 907);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(94, 875);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exit";
            // 
            // Exit_button
            // 
            this.Exit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_button.BackgroundImage")));
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_button.Location = new System.Drawing.Point(81, 806);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(80, 66);
            this.Exit_button.TabIndex = 4;
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 722);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Donor Management";
            // 
            // Donor_button
            // 
            this.Donor_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Donor_button.BackgroundImage")));
            this.Donor_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Donor_button.Location = new System.Drawing.Point(51, 592);
            this.Donor_button.Name = "Donor_button";
            this.Donor_button.Size = new System.Drawing.Size(150, 117);
            this.Donor_button.TabIndex = 2;
            this.Donor_button.UseVisualStyleBackColor = true;
            this.Donor_button.Click += new System.EventHandler(this.Donor_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.NameOfDay_label);
            this.panel2.Controls.Add(this.Day_label);
            this.panel2.Controls.Add(this.Month_label);
            this.panel2.Location = new System.Drawing.Point(-1, 166);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 313);
            this.panel2.TabIndex = 1;
            // 
            // NameOfDay_label
            // 
            this.NameOfDay_label.BackColor = System.Drawing.Color.Transparent;
            this.NameOfDay_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameOfDay_label.Location = new System.Drawing.Point(-12, 190);
            this.NameOfDay_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameOfDay_label.Name = "NameOfDay_label";
            this.NameOfDay_label.Size = new System.Drawing.Size(282, 61);
            this.NameOfDay_label.TabIndex = 2;
            this.NameOfDay_label.Text = "Wednesday";
            this.NameOfDay_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Day_label
            // 
            this.Day_label.BackColor = System.Drawing.Color.Transparent;
            this.Day_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Day_label.Location = new System.Drawing.Point(-10, 129);
            this.Day_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Day_label.Name = "Day_label";
            this.Day_label.Size = new System.Drawing.Size(282, 61);
            this.Day_label.TabIndex = 1;
            this.Day_label.Text = "19";
            this.Day_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Month_label
            // 
            this.Month_label.BackColor = System.Drawing.Color.Transparent;
            this.Month_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Month_label.Location = new System.Drawing.Point(-12, 68);
            this.Month_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Month_label.Name = "Month_label";
            this.Month_label.Size = new System.Drawing.Size(282, 61);
            this.Month_label.TabIndex = 0;
            this.Month_label.Text = "November";
            this.Month_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentTime_label
            // 
            this.CurrentTime_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentTime_label.Font = new System.Drawing.Font("Leelawadee UI", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime_label.ForeColor = System.Drawing.Color.White;
            this.CurrentTime_label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CurrentTime_label.Location = new System.Drawing.Point(-1, 0);
            this.CurrentTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentTime_label.Name = "CurrentTime_label";
            this.CurrentTime_label.Size = new System.Drawing.Size(268, 81);
            this.CurrentTime_label.TabIndex = 0;
            this.CurrentTime_label.Text = "19:11";
            this.CurrentTime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStaff_toolStripButton,
            this.toolStripSeparator1,
            this.PatientRecors_toolStripButton,
            this.toolStripSeparator2,
            this.Calculator_toolStripButton,
            this.toolStripSeparator3,
            this.Game_Button,
            this.About_toolStripButton,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(268, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1251, 58);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddStaff_toolStripButton
            // 
            this.AddStaff_toolStripButton.Image = global::FinalProject.Properties.Resources.patient__4_;
            this.AddStaff_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddStaff_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStaff_toolStripButton.Name = "AddStaff_toolStripButton";
            this.AddStaff_toolStripButton.Size = new System.Drawing.Size(119, 55);
            this.AddStaff_toolStripButton.Text = "Add New Staff";
            this.AddStaff_toolStripButton.Click += new System.EventHandler(this.AddStaff_toolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // PatientRecors_toolStripButton
            // 
            this.PatientRecors_toolStripButton.Image = global::FinalProject.Properties.Resources.document__2_;
            this.PatientRecors_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PatientRecors_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PatientRecors_toolStripButton.Name = "PatientRecors_toolStripButton";
            this.PatientRecors_toolStripButton.Size = new System.Drawing.Size(90, 55);
            this.PatientRecors_toolStripButton.Text = "Our Staff";
            this.PatientRecors_toolStripButton.Click += new System.EventHandler(this.PatientRecors_toolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // Calculator_toolStripButton
            // 
            this.Calculator_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Calculator_toolStripButton.Image")));
            this.Calculator_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Calculator_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Calculator_toolStripButton.Name = "Calculator_toolStripButton";
            this.Calculator_toolStripButton.Size = new System.Drawing.Size(97, 55);
            this.Calculator_toolStripButton.Text = "Calculator";
            this.Calculator_toolStripButton.Click += new System.EventHandler(this.Calculator_toolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // Game_Button
            // 
            this.Game_Button.Image = ((System.Drawing.Image)(resources.GetObject("Game_Button.Image")));
            this.Game_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Game_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Game_Button.Name = "Game_Button";
            this.Game_Button.Size = new System.Drawing.Size(126, 55);
            this.Game_Button.Text = "Intresting game";
            this.Game_Button.Click += new System.EventHandler(this.Game_Button_Click);
            // 
            // About_toolStripButton
            // 
            this.About_toolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.About_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("About_toolStripButton.Image")));
            this.About_toolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.About_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.About_toolStripButton.Name = "About_toolStripButton";
            this.About_toolStripButton.Size = new System.Drawing.Size(131, 55);
            this.About_toolStripButton.Text = "About Company";
            this.About_toolStripButton.Click += new System.EventHandler(this.About_toolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1519, 907);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameOfDay_label;
        private System.Windows.Forms.Label Day_label;
        private System.Windows.Forms.Label Month_label;
        private System.Windows.Forms.Label CurrentTime_label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddStaff_toolStripButton;
        private System.Windows.Forms.ToolStripButton PatientRecors_toolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Donor_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Game_Button;
        private System.Windows.Forms.ToolStripButton Calculator_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton About_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Timer Timer;
    }
}