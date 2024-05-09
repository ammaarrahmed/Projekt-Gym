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
    public partial class Owner_Reg : Form
    {
        public Owner_Reg()
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

            if (EmailExists(txtusername.Text))
            {
                MessageBox.Show("Email already exists. Please choose another one.");
                return;
            }

            if (txtpass.Text != txtconfirmpass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (comboBox4.Enabled && comboBox4.SelectedItem != null)
            {
                // Existing gym selected
                AddOwnerToExistingGym();
            }
            else if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // New gym name entered
                AddNewGymRequest();
            }
            else
            {
                MessageBox.Show("Please select a gym or enter a new gym name.");
            }
        }

        private bool AreFieldsEmpty()
        {
            bool areFieldsEmpty = string.IsNullOrWhiteSpace(fname.Text) ||
                                  string.IsNullOrWhiteSpace(lname.Text) ||
                                  string.IsNullOrWhiteSpace(txtusername.Text) ||
                                  string.IsNullOrWhiteSpace(txtpass.Text) ||
                                  string.IsNullOrWhiteSpace(txtconfirmpass.Text) ||
                                  (string.IsNullOrWhiteSpace(textBox1.Text) && comboBox4.SelectedIndex == -1) ||
                                  (!string.IsNullOrWhiteSpace(textBox1.Text) && comboBox4.SelectedIndex != -1);

            if (areFieldsEmpty)
            {
                MessageBox.Show("Please ensure all fields are filled correctly and select either an existing gym or enter a new gym name, not both.");
            }

            return areFieldsEmpty;
        }

        private bool EmailExists(string email)
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM [dbo].[FlexTrainerDataOwnerCSV] WHERE Email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("An account with this email already exists.");
                    return true;
                }
                return false;
            }
        }




        private void AddOwnerToExistingGym()
          {

            int memid = GetNextOwnerID();
            string gymName = comboBox4.SelectedItem?.ToString();
            int gid = GetGymID(gymName);

            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[FlexTrainerDataOwnerCSV] (OwnerID,FirstName, LastName, Email, Password)  VALUES (@Oid,@FirstName, @LastName, @Email, @Password)",conn);
                cmd.Parameters.AddWithValue("@FirstName", fname.Text);
                cmd.Parameters.AddWithValue("@LastName", lname.Text);
                cmd.Parameters.AddWithValue("@Email", txtusername.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text); // Consider hashing the password
                cmd.Parameters.AddWithValue("@Oid",memid);
                cmd.ExecuteNonQuery();

                try
                {
                       // Execute and get the newly inserted OwnerID

                    // Now, insert the MemberID and GymID into the junction table
                    SqlCommand cmdJunction = new SqlCommand("INSERT INTO [dbo].[FlexTrainerDataOwner_GymCSV] (OwnerID, GymID) VALUES (@OwnerID, @GymID)", conn);
                    cmdJunction.Parameters.AddWithValue("@GymID", gid);
                    cmdJunction.Parameters.AddWithValue("@OwnerID", memid);
                    cmdJunction.ExecuteNonQuery();

                    MessageBox.Show("Owner and gym association added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add owner or association: " + ex.Message);
                }
            }
        }



        private void AddNewGymRequest()
        {
            int memid = GetNextOwnerID();
            int gid = GetNextGymID();
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO gym_request (GID, GName, FirstName, LastName, Email, Password, Oid) VALUES (@GID, @GName, @FirstName, @LastName, @Email, @Password, @Oid)", conn);
                cmd.Parameters.AddWithValue("@GID", gid);
                cmd.Parameters.AddWithValue("@GName", textBox1.Text); // Make sure textBox1 is the correct control for gym name
                cmd.Parameters.AddWithValue("@FirstName", fname.Text);
                cmd.Parameters.AddWithValue("@LastName", lname.Text);
                cmd.Parameters.AddWithValue("@Email", txtusername.Text); // Assuming txtusername holds the email
                cmd.Parameters.AddWithValue("@Password", txtpass.Text); // Consider hashing the password
                cmd.Parameters.AddWithValue("@Oid", memid);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New gym request added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add new gym request: " + ex.Message);
                }
            }
        }

        private int GetNextOwnerID()
        {
            int nextOwnerID = 0;
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Get the maximum OwnerID from Owner table
                string ownerQuery = "SELECT MAX(OwnerID) FROM [dbo].[FlexTrainerDataOwnerCSV]";
                SqlCommand ownerCmd = new SqlCommand(ownerQuery, con);
                object ownerResult = ownerCmd.ExecuteScalar();
                int maxOwnerID = (ownerResult != DBNull.Value && ownerResult != null) ? Convert.ToInt32(ownerResult) : 0;

                // Get the maximum Oid from gym_request table
                string gymRequestQuery = "SELECT MAX(Oid) FROM gym_request";
                SqlCommand gymRequestCmd = new SqlCommand(gymRequestQuery, con);
                object gymRequestResult = gymRequestCmd.ExecuteScalar();
                int maxGymRequestID = (gymRequestResult != DBNull.Value && gymRequestResult != null) ? Convert.ToInt32(gymRequestResult) : 0;

                // Determine the next OwnerID
                nextOwnerID = Math.Max(maxOwnerID, maxGymRequestID) + 1;
            }

            return nextOwnerID;
        }


        private int GetNextGymID()
        {
            int maxGymID = 0;
            int maxGID = 0;
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Query to get the maximum GymID from the FlexTrainerDataGymCSV table
                string gymQuery = "SELECT MAX(GymID) FROM [dbo].[FlexTrainerDataGymCSV]";
                SqlCommand gymCmd = new SqlCommand(gymQuery, con);
                object gymResult = gymCmd.ExecuteScalar();
                maxGymID = (gymResult != DBNull.Value && gymResult != null) ? Convert.ToInt32(gymResult) : 0;

                // Query to get the maximum GID from the gym_request table
                string gidQuery = "SELECT MAX(GID) FROM gym_request";
                SqlCommand gidCmd = new SqlCommand(gidQuery, con);
                object gidResult = gidCmd.ExecuteScalar();
                maxGID = (gidResult != DBNull.Value && gidResult != null) ? Convert.ToInt32(gidResult) : 0;
            }

            // Calculate the next ID, which should be one greater than the maximum ID found
            return Math.Max(maxGymID, maxGID) + 1;
        }

        private int GetGymID(string gymname)
        {
            int memid = 0;
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT GymID FROM [dbo].[FlexTrainerDataGymCSV] where Name=@GymName";
        
                using (SqlCommand cmdGym = new SqlCommand(query, con))
                {
                    con.Open();
                    cmdGym.Parameters.AddWithValue("@GymName", gymname);
                    object result = cmdGym.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        memid = Convert.ToInt32(result);
                    }
                    else
                    {
                        memid = 1; // Start at 1 if there are no entries
                    }
                }
            }
            return memid;
        }
    }
}