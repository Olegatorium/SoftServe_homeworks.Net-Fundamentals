using FinalProject.Properties;
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
    public partial class LoginToGame : Form
    {
        public LoginToGame()
        {
            InitializeComponent();
        }

        private void play_button1_Click(object sender, EventArgs e)
        {
            game_form game = new game_form();

            if (string.IsNullOrWhiteSpace(Name_textBox1.Text))
            {
                MessageBox.Show("You must write name", "Just write name)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Name_textBox1.Text.All(char.IsLetter))
            {
                MessageBox.Show("Name can only contain letters!");
                return;
            }
            else
            {
                FinalProject.Properties.Settings.Default.Name_player = Name_textBox1.Text;
                
                game.ShowDialog();               
            }
            
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
