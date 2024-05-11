using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;



namespace Gym
{
    public partial class Admin_Reg : Form
    {
        public Admin_Reg()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            string query = "SELECT Name FROM [dbo].[FlexTrainerDataGymCSV]";  // Adjust the query to match your table and column

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox4.Items.Add(reader["Name"].ToString());  // Ensure the field is correct
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during database operation: " + ex.Message);
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Some fields are empty", "Registration Failed");
                return;
            }

            if (UsernameExists(txtusername.Text))
            {
                MessageBox.Show("Username already exists. Please choose another one.");
                return;
            }

            if (PasswordExists(txtpass.Text))
            {
                MessageBox.Show("Password already exists. Please choose another one.");
                return;
            }

            if (txtpass.Text != txtconfirmpass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            AddAdminRecord();


        }



        private bool AreFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(fname.Text) || string.IsNullOrWhiteSpace(lname.Text)
                   || string.IsNullOrWhiteSpace(txtusername.Text) ||
                      string.IsNullOrWhiteSpace(txtpass.Text) || string.IsNullOrWhiteSpace(txtconfirmpass.Text);
        }

        private void AddAdminRecord()
        {
            int memid = GetNextTrainerID();
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO [dbo].[FlexTrainerDataAdminCSV] (AdminID, FirstName, LastName, Email, Password) VALUES (@MemID, @FirstName, @LastName, @Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MemID", memid);
                    cmd.Parameters.AddWithValue("@FirstName", fname.Text);
                    cmd.Parameters.AddWithValue("@LastName", lname.Text);
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text);  // Consider encrypting this


                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Admin record added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add admin record: " + ex.Message);
                    }
                }
            }

            AddMembershipRecord(memid);
        }

        private int GetNextTrainerID()
        {
            int memid = 0;
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(AdminID) FROM [dbo].[FlexTrainerDataAdminCSV]";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        memid = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        memid = 1; // Start at 1 if there are no entries
                    }
                }
            }
            return memid;
        }

        private bool UsernameExists(string username)
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM [dbo].[FlexTrainerDataAdminCSV] WHERE Email = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
        }

        private bool PasswordExists(string pass)
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM [dbo].[FlexTrainerDataAdminCSV] WHERE Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Password", pass);
                    con.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
        }


        private void AddMembershipRecord(int memberId)
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            string gymName = comboBox4.SelectedItem?.ToString();  // Using null-conditional operator for safety

            if (string.IsNullOrEmpty(gymName))
            {
                MessageBox.Show("Please select a gym.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // First, find the GymID corresponding to the selected gym name
                string gymIdQuery = "SELECT GymID FROM [dbo].[FlexTrainerDataGymCSV] WHERE Name = @GymName";
                SqlCommand cmdGym = new SqlCommand(gymIdQuery, conn);
                cmdGym.Parameters.AddWithValue("@GymName", gymName);

                object result = cmdGym.ExecuteScalar(); // ExecuteScalar returns the first column of the first row in the result set, or null if no result

                if (result == null)
                {
                    MessageBox.Show("Gym not found. Please ensure the selected gym is correct.");
                    return;
                }

                int gymId = Convert.ToInt32(result);  // Use Convert.ToInt32 to safely convert object to int

                // Now, insert the MemberID and GymID into the junction table
                string junctionInsertQuery = "INSERT INTO [dbo].[FlexTrainerDataGym_AdminCSV] (GymID,AdminID) VALUES (@GymID,@MemberID)";
                SqlCommand cmdJunction = new SqlCommand(junctionInsertQuery, conn);
                cmdJunction.Parameters.AddWithValue("@MemberID", memberId);
                cmdJunction.Parameters.AddWithValue("@GymID", gymId);

                try
                {
                    cmdJunction.ExecuteNonQuery();
                    MessageBox.Show("Admin-Gym association added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add admin-gym association: " + ex.Message);
                }
            }
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
