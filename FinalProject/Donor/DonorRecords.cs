using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalProject
{
    public partial class DonorRecords : Form
    {
        private Image initialPhoto;
        private readonly List<string> records;
        private int currentIndex;

        public DonorRecords()
        {
            InitializeComponent();

            initialPhoto = DonorPhoto_pictureBox1.Image;

            records = Donor.GetAllRecords();
            currentIndex = 0;

            if (records.Count > 0)
            {
                ShowRecord(currentIndex);
            }
            else
            {
                ClearLabelsAndControls();
            }

            UpdateDonorNumberLabel();
            UpdateNavigationButtons();
        }


        private void ShowRecord(int index)
        {
            if (index >= 0 && index < records.Count)
            {
                string record = records[index];
                string[] fields = record.Split('|');

                donorId_label.Text = fields[0];
                donationsDate_label.Text = fields[1];
                name_label.Text = fields[2];
                surname_label.Text = fields[3];
                socialID_label.Text = fields[4];
                number_label.Text = fields[5];
                email_label.Text = fields[6];
                bloodType_label.Text = fields[7];

                string photoPath = fields[8];
                if (!string.IsNullOrEmpty(photoPath) && Donor.IsImageFile(photoPath))
                {
                    DonorPhoto_pictureBox1.Image = Image.FromFile(photoPath);
                }
                else
                {
                    DonorPhoto_pictureBox1.Image = null;
                }
            }


        }
        private void UpdateDonorNumberLabel()
        {
            int currentNumber = currentIndex + 1;
            int totalNumber = records.Count;

            if (totalNumber > 0)
            {
                donorNumber_label.Text = $"{currentNumber} of {totalNumber}";
            }
            else
            {
                DonorPhoto_pictureBox1.Image = initialPhoto;
                donorNumber_label.Text = $"0 of 0";
            }
        }

        private void PreviousButton_Click_1(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = records.Count - 1;
            }

            UpdateDonorNumberLabel();
            ShowRecord(currentIndex);

            NextButton.Enabled = true;

            if (currentIndex == 0)
            {
                PreviousButton.Enabled = false;

            }

        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= records.Count)
            {
                currentIndex = 0;
            }

            UpdateDonorNumberLabel();
            ShowRecord(currentIndex);

            PreviousButton.Enabled = true;

            if (currentIndex == records.Count - 1)
            {
                NextButton.Enabled = false;


            }
        }

        private void BackToMenu_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateDataFile()
        {
            File.WriteAllLines("DonorsData.txt", records);
        }


        private void UpdateNavigationButtons()
        {
            NextButton.Enabled = currentIndex < records.Count - 1;

            PreviousButton.Enabled = currentIndex > 0;
        }

        private void deleteDonor_button_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < records.Count)
            {
                string currentRecord = records[currentIndex];

                DialogResult result = MessageBox.Show("Are you sure you want to delete this donor?",
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

                    UpdateDonorNumberLabel();

                    UpdateNavigationButtons();

                    UpdateDataFile();

                    MessageBox.Show("Donor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearLabelsAndControls()
        {
            donorId_label.Text = string.Empty;
            donationsDate_label.Text = string.Empty;
            name_label.Text = string.Empty;
            surname_label.Text = string.Empty;
            socialID_label.Text = string.Empty;
            number_label.Text = string.Empty;
            email_label.Text = string.Empty;
            bloodType_label.Text = string.Empty;
            DonorPhoto_pictureBox1.Image = null;
        }
    }
}