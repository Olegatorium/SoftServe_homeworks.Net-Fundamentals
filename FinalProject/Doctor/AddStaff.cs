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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void Exit_toolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveData_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_textBox.Text) || string.IsNullOrWhiteSpace(Surname_textBox.Text) ||
                string.IsNullOrWhiteSpace(Experience_textBox.Text) || string.IsNullOrWhiteSpace(Salary_textBox.Text) ||
                string.IsNullOrWhiteSpace(ChooseDoctor_comboBox.Text))
            {
                MessageBox.Show("You have to provide all information!");
                return;
            }
            else if (!Name_textBox.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name can only contain letters!");
                return;
            }
            else if (!Surname_textBox.Text.All(char.IsLetter))
            {
                MessageBox.Show("Surname can only contain letters!");
                return;

            }

            if (!int.TryParse(Experience_textBox.Text, out int doctorExperience))
            {
                MessageBox.Show("Please enter only digits in the Working Experience field!");
                return;
            }
            else if (!Decimal.TryParse(Salary_textBox.Text, out decimal salary))
            {
                MessageBox.Show("Please enter only digits in the Salary field!");
                return;
            }

            string selectedValue = ChooseDoctor_comboBox.SelectedItem.ToString();

            if (selectedValue == "Pediatrician")
            {
                if (!int.TryParse(NumberOfDeclaredPatients_textBox.Text, out int numberOfDeclaredPatients))
                {
                    MessageBox.Show("Please enter only digits in the Number of Declared Patients field!");
                    return;
                }
            }
            else if (selectedValue == "Surgeon")
            {
                if (!int.TryParse(NumberOfPerformedOperations_textBox.Text, out int numberOfPerformedOperations))
                {
                    MessageBox.Show("Please enter only digits in the 'Number Of Performed Operations' field!");
                    return;
                }
            }
            
            DoctorData doctor = new DoctorData();

            doctor.SaveData(ChooseDoctor_comboBox.Text, Name_textBox.Text, Surname_textBox.Text, Experience_textBox.Text,
                Salary_textBox.Text, NumberOfDeclaredPatients_textBox.Text, NumberOfPerformedOperations_textBox.Text);

            ClearTextBoxes();
        }

        private void ChooseDoctor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ChooseDoctor_comboBox.SelectedItem.ToString();
            if (selectedValue == "Pediatrician")
            {
                NumberOfDeclaredPatients_textBox.Enabled = true;
            }
            else
            {
                NumberOfDeclaredPatients_textBox.Enabled = false;
            }

            if (selectedValue == "Surgeon")
            {
                NumberOfPerformedOperations_textBox.Enabled = true;
            }
            else
            {
                NumberOfPerformedOperations_textBox.Enabled = false;
            }
        }

        private void ClearTextBoxes() 
        {
            ChooseDoctor_comboBox.ResetText();
            Name_textBox.ResetText();
            Surname_textBox.ResetText();
            Experience_textBox.ResetText();
            Salary_textBox.ResetText();
            NumberOfDeclaredPatients_textBox.ResetText();
            NumberOfPerformedOperations_textBox.ResetText();
        }
    }
}
