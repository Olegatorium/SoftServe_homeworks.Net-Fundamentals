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
    public partial class DonorForm : Form
    {
        public DonorForm()
        {
            InitializeComponent();
        }

        private void AddDonner_button1_Click(object sender, EventArgs e)
        {
            AddDonor addDonner = new AddDonor();
           
            addDonner.ShowDialog();           
        }

        private void Exit_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AllRecords_button2_Click(object sender, EventArgs e)
        {
            DonorRecords allRecords = new DonorRecords();
            
            allRecords.ShowDialog();          
        }
    }
}
