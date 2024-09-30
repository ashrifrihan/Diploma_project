using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diploma_project
{
    public partial class registerform : Form
    {

        private static string connectionString = "Data Source=DESKTOP-IEPCDN4\\SQLEXPRESS;Initial Catalog=Final_project;Integrated Security=True";

        public registerform()
        {
            InitializeComponent();

            LoadRegistrationNumbers();

            cmbRegNo.SelectedIndexChanged += cmbReg_SelectedIndexChanged;
        }



        private void registerform_Load(object sender, EventArgs e)
        {

        }

        private void LoadRegistrationNumbers()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select regNo from Registration";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbRegNo.Items.Add(reader["regNo"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading registration numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbRegNo.SelectedIndex != -1)
            {
                int selectedRegNo = Convert.ToInt32(cmbRegNo.SelectedItem.ToString());
                LoadFormData(selectedRegNo);
            }
        }

        private void LoadFormData(int regNo)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from Registration where regNo = @regNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@regNo", regNo);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        Firstname_txt.Text = reader["firstname"].ToString();
                        Lastname_txt.Text = reader["lastname"].ToString();
                        dateofBirth.Value = Convert.ToDateTime(reader["dateofbirth"]);
                        if (reader["gender"].ToString().Equals("Male", StringComparison.OrdinalIgnoreCase))
                            rdoMale.Checked = true;
                        else if (reader["gender"].ToString().Equals("Female", StringComparison.OrdinalIgnoreCase))
                            rdoFemale.Checked = true;
                        address_txt.Text = reader["address"].ToString();
                        email_txt.Text = reader["email"].ToString();
                        mobile_txt.Text = reader["mobilephone"].ToString();
                        homeNum_txt.Text = reader["homephone"].ToString();
                        Perantsname_txt.Text = reader["parentname"].ToString();
                        NIC_txt.Text = reader["nic"].ToString();
                        contact_txt.Text = reader["contactno"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {

            Firstname_txt.Clear();
            Lastname_txt.Clear();
            dateofBirth.Value = DateTime.Now;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            address_txt.Clear();
            email_txt.Clear();
            mobile_txt.Clear();
            homeNum_txt.Clear();
            Perantsname_txt.Clear();
            NIC_txt.Clear();
            contact_txt.Clear();
            cmbRegNo.SelectedIndex = -1;
            cmbRegNo.Text.Clone();
        }

        private void DeleteFormData(int regNo)
        {

            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Delete this Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "delete from Registration where regNo = @regNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@regNo", regNo);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            cmbRegNo.Items.Clear();
                            LoadRegistrationNumbers();

                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Registration (firstname , lastname,dateofbirth,gender,address,email,mobilephone,homephone,parentname,nic,contactno) " + "VALUES (@firstname, @lastname, @dateofbirth, @gender, @address, @email, @mobilephone, @homephone, @parentname, @nic, @contactno)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@firstname", Firstname_txt.Text);
                command.Parameters.AddWithValue("@lastname", Lastname_txt.Text);
                command.Parameters.AddWithValue("@dateofbirth", dateofBirth.Value);
                string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : "");
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@address", address_txt.Text);
                command.Parameters.AddWithValue("@email", email_txt.Text);
                command.Parameters.AddWithValue("@mobilephone", mobile_txt.Text);
                command.Parameters.AddWithValue("@homephone", homeNum_txt.Text);
                command.Parameters.AddWithValue("@parentname", Perantsname_txt.Text);
                command.Parameters.AddWithValue("@nic", NIC_txt.Text);
                command.Parameters.AddWithValue("@contactno", contact_txt.Text);
                command.Parameters.AddWithValue("@regNo", cmbRegNo.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Add Succssfully", "Student Register", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        ClearForm();


                        cmbRegNo.Items.Clear();
                        LoadRegistrationNumbers();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Registration SET firstname = @firstname, lastname = @lastname, " + "dateofbirth = @dateofbirth, gender = @gender, address = @address, " + "email = @email, mobilephone = @mobilephone, homephone = @homephone, " + "parentname = @parentname, nic = @nic, contactno = @contactno " + "where regNo = @regNo";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@firstname", Firstname_txt.Text);
                command.Parameters.AddWithValue("@lastname", Lastname_txt.Text);
                command.Parameters.AddWithValue("@dateofbirth", dateofBirth.Value);
                string gender = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : "");
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@address", address_txt.Text);
                command.Parameters.AddWithValue("@email", email_txt.Text);
                command.Parameters.AddWithValue("@mobilephone", mobile_txt.Text);
                command.Parameters.AddWithValue("@homephone", homeNum_txt.Text);
                command.Parameters.AddWithValue("@parentname", Perantsname_txt.Text);
                command.Parameters.AddWithValue("@nic", NIC_txt.Text);
                command.Parameters.AddWithValue("@contactno", contact_txt.Text);
                command.Parameters.AddWithValue("@regNo", cmbRegNo.SelectedItem.ToString());

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex != -1)
            {
                int selectedRegNo = Convert.ToInt32(cmbRegNo.SelectedItem.ToString());
                DeleteFormData(selectedRegNo);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out", "logged out",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
    
}
