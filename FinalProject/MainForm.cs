using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetTime();

            GetCalendarDate();
        }

        private void GetTime()
        {
            this.CurrentTime_label.Text = DateTime.Now.ToString("HH:mm");
        }

        private void GetCalendarDate()
        {
            System.Globalization.GregorianCalendar gregorianCalendar
                = new System.Globalization.GregorianCalendar();
            System.Globalization.CultureInfo englishCulture
                = new System.Globalization.CultureInfo("en-US");


            DateTime currentDate = DateTime.Now;


            Month_label.Text = englishCulture.DateTimeFormat.GetMonthName(gregorianCalendar.GetMonth(currentDate));
            Day_label.Text = gregorianCalendar.GetDayOfMonth(currentDate).ToString();
            NameOfDay_label.Text = gregorianCalendar.GetDayOfWeek(currentDate).ToString();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetTime();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Donor_button_Click(object sender, EventArgs e)
        {
            DonorForm donorForm = new DonorForm();

            donorForm.ShowDialog(); 
        }

        private void AddStaff_toolStripButton_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();

            addStaff.ShowDialog();
        }

        private void PatientRecors_toolStripButton_Click(object sender, EventArgs e)
        {
            DoctorRecords doctorRecords = new DoctorRecords();

            doctorRecords.ShowDialog();
        }

        private void Game_Button_Click(object sender, EventArgs e)
        {
            LoginToGame game = new LoginToGame();

            game.ShowDialog();
        }

        private void About_toolStripButton_Click(object sender, EventArgs e)
        {
            About aboutCompany = new About();

            aboutCompany.ShowDialog();
        }

        private void Calculator_toolStripButton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            calculator.ShowDialog();
        }
    }
}
