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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;

namespace FinalProject
{

    public partial class AddDonor : Form
    {
        private Image initialPhoto; 

        public AddDonor()
        {
            InitializeComponent();

            Data_label2.Text = DateTime.Now.ToString();

            
            initialPhoto = DonorPhoto_pictureBox1.Image;
        }

        private void BackToMenu_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveData_button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_textBox1.Text) || string.IsNullOrWhiteSpace(Surname_textBox2.Text) ||
       string.IsNullOrWhiteSpace(ID_textBox3.Text) || string.IsNullOrWhiteSpace(Number_textBox4.Text) ||
       string.IsNullOrWhiteSpace(Email_textBox5.Text) || string.IsNullOrWhiteSpace(BloodType_comboBox1.Text) ||
                  string.IsNullOrWhiteSpace(Donor.CurrentPhotoPath))
            {
                MessageBox.Show("You have to provide all information!");
                return; 
            }
            else if (!Name_textBox1.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name can only contain letters!");
                return;
            }
            else if (!Surname_textBox2.Text.All(char.IsLetter))
            {
                MessageBox.Show("Surname can only contain letters!");
                return;
            }

            if (!int.TryParse(Number_textBox4.Text, out int phoneNumber))
            {
                MessageBox.Show("Please enter only digits in the Phone Number field!");
                return;
            }
            else if (!int.TryParse(ID_textBox3.Text, out int socialId))
            {
                MessageBox.Show("Please enter only digits in the Social ID field!");
                return;
            }

            string email = Email_textBox5.Text;

            try
            {
                MailAddress mailAddress = new MailAddress(email);
                
            }
            catch (FormatException)
            {

                MessageBox.Show("Invalid email format!");
                return;
            }

            Donor.SaveData(Data_label2.Text, Name_textBox1.Text, Surname_textBox2.Text, ID_textBox3.Text,
                Number_textBox4.Text, Email_textBox5.Text, BloodType_comboBox1.Text, Donor.CurrentPhotoPath);

            Name_textBox1.ResetText();
            Surname_textBox2.ResetText();
            ID_textBox3.ResetText();
            Number_textBox4.ResetText();
            Email_textBox5.ResetText();
            BloodType_comboBox1.ResetText();

            
            DonorPhoto_pictureBox1.Image = initialPhoto;
            Donor.CurrentPhotoPath = null;
        }

        private void AddPhoto_button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                
                if (Donor.IsImageFile(selectedFilePath))
                {
                   
                    DonorPhoto_pictureBox1.Image = Image.FromFile(selectedFilePath);

                    
                    Donor.CurrentPhotoPath = selectedFilePath;
                }
                else
                {
                    MessageBox.Show("Please select a valid image file.");
                }
            }
        }

    }
}
