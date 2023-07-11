using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DoctorRecords : Form
    {
        private readonly List<string> records;
        private int currentIndex;

        public DoctorRecords()
        {
            InitializeComponent();

            DoctorData doctorData = new DoctorData();

            records = doctorData.GetDoctorRecords();

            currentIndex = 0;

            if (records.Count > 0)
            {
                ShowRecord(currentIndex);
            }
            else
            {
                ClearLabelsAndControls();
            }

            UpdateDoсtorNumberLabel();
            UpdateNavigationButtons();
        }

        private void ShowRecord(int index)
        {
            if (index >= 0 && index < records.Count)
            {
                string record = records[index];
                string[] fields = record.Split('|');

                DoctorSpecialty_label.Text = fields[0];
                Name_label.Text = fields[1];
                Surname_label.Text = fields[2];
                Experience_label.Text = fields[3] + " years";
                Salary_label.Text = fields[4] + "$";

                if (fields.Length > 5 && fields[0] == "Pediatrician")
                {
                    NumberOfDeclaredPatient_label.Text = fields[5];
                }
                else
                {
                    NumberOfDeclaredPatient_label.Text = "Only for Pediatrician";
                }

                if (fields.Length > 5 && fields[0] == "Surgeon")
                {
                    NumberOfPerformedOperations_label.Text = fields[5];
                }
                else
                {
                    NumberOfPerformedOperations_label.Text = "Only for Surgeon";
                }
            }
        }
        private void UpdateDoсtorNumberLabel()
        {
            int currentNumber = currentIndex + 1;
            int totalNumber = records.Count;

            if (totalNumber > 0)
            {
                doctorNumber_label.Text = $"{currentNumber} of {totalNumber}";
            }
            else
            {                
                doctorNumber_label.Text = $"0 of 0";
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = records.Count - 1;
            }

            UpdateDoсtorNumberLabel();
            ShowRecord(currentIndex);

            NextButton.Enabled = true;

            if (currentIndex == 0)
            {
                PreviousButton.Enabled = false;
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= records.Count)
            {
                currentIndex = 0;
            }

            UpdateDoсtorNumberLabel();
            ShowRecord(currentIndex);

            PreviousButton.Enabled = true;

            if (currentIndex == records.Count - 1)
            {
                NextButton.Enabled = false;
            }
        }
        private void UpdateDataFile()
        {
            File.WriteAllLines("StaffData.txt", records);
        }

        private void UpdateNavigationButtons()
        {
            NextButton.Enabled = currentIndex < records.Count - 1;

            PreviousButton.Enabled = currentIndex > 0;
        }

        private void DeleteDoctor_button_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < records.Count)
            {
                string currentRecord = records[currentIndex];

                DialogResult result = MessageBox.Show("Are you sure you want to delete this doctor?",
                    
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    records.RemoveAt(currentIndex);

                    if (currentIndex >= records.Count)
                    {
                        currentIndex = records.Count - 1;
                    }

                    if (currentIndex >= 0 && currentIndex < records.Count)
                    {
                        ShowRecord(currentIndex);
                    }
                    else
                    {
                        ClearLabelsAndControls();
                    }

                    UpdateDoсtorNumberLabel();

                    UpdateNavigationButtons();

                    UpdateDataFile();

                    MessageBox.Show("Donor deleted successfully.", "Success", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
        }

        private void ClearLabelsAndControls()
        {
            DoctorSpecialty_label.Text = string.Empty;
            Name_label.Text = string.Empty;
            Surname_label.Text = string.Empty;
            Experience_label.Text = string.Empty;
            Salary_label.Text = string.Empty;
            NumberOfDeclaredPatient_label.Text = string.Empty;
            NumberOfPerformedOperations_label.Text = string.Empty;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataFilter_button_Click(object sender, EventArgs e)
        {
            DoctorData doctorData = new DoctorData();

            doctorData.FilterData();

            MessageBox.Show("You have successfully completed the filtering task!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

            DataFilter_button.Enabled = false;
        }
    }
}
