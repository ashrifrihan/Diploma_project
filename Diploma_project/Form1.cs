using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show.Checked == true)
            {
                Password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Password_txt.UseSystemPasswordChar = true;
            }
        }

        private void btuLogin_Click_1(object sender, EventArgs e)
        {
            if (userName_txt.Text == "Admin" && Password_txt.Text == "Skills@123")
            {
                MessageBox.Show("Login Success", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                registerform registrationForm = new registerform();
                registrationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Credential, Please check Username and Password and Try Again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btuClear_Click(object sender, EventArgs e)
        {
            userName_txt.Clear();
            Password_txt.Clear();
        }

        

        private void btuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you Really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox_Show_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_Show.Checked == true)
            {
                Password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Password_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
