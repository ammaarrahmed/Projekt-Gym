using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym
{
    public partial class O_Managment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SANI-PC\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True");

        public O_Managment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void O_Management_Load(object sender, EventArgs e)
        {
            TableName.Items.Add("Member");
            TableName.Items.Add("Trainer");
            TableName.Items.Add("Equipment");



        }
        private void Trainer_B_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SANI-PC\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FlexTrainerDataTrainerCSV", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dt.Columns.Remove("password");
                O_Management_DataView.DataSource = dt;

                // Change the data display color
                O_Management_DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                O_Management_DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                O_Management_DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                O_Management_DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                O_Management_DataView.GridColor = Color.Black; // Change it to your desired color
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SANI-PC\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FlexTrainerDataMemberCSV", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.Columns.Remove("password");
                O_Management_DataView.DataSource = dt;

                // Change the data display color
                O_Management_DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                O_Management_DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                O_Management_DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                O_Management_DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                O_Management_DataView.GridColor = Color.Black; // Change it to your desired color
            }
        }

        private void Equipment_B_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SANI-PC\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FlexTrainerDataEquipmentCSV", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                O_Management_DataView.DataSource = dt;

                // Change the data display color
                O_Management_DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                O_Management_DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                O_Management_DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                O_Management_DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                O_Management_DataView.GridColor = Color.Black; // Change it to your desired color
            }
        }

        private void IDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TableName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=SANI-PC\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                if (TableName.Text == "Member")
                {

                        sqlConnection.Open();
                        string query = "Delete FROM [dbo].[FlexTrainerDataMemberCSV] WHERE MemberID=@ID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
                            int result = (int)sqlCommand.ExecuteScalar();

                            if (result == 1)
                            {
                                MessageBox.Show("Deletion successful.");
                                // Continue to the next part of your application
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Login failed. Please check your username and password.");

                                con.Close();
                            }
                        }
                    

                }

                if (TableName.Text == "Trainer")
                {

                    sqlConnection.Open();
                    string query = "DELETE FROM [dbo].[FlexTrainerDataTrainerCSV] WHERE TrainerID=@ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
                        // ExecuteNonQuery returns the number of rows affected
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deletion successful.");
                            // Continue with your application logic
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided ID.");
                        }
                    }

                    // Close the connection outside of the using block
                    sqlConnection.Close();


                }

                if (TableName.Text == "Equipment")
                {

                        sqlConnection.Open();
                        string query = "Delete FROM [dbo].[FlexTrainerDataEquipmentCSV] WHERE EquipmentID=@ID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@ID", txtID.Text);
                            int result = (int)sqlCommand.ExecuteScalar();

                            if (result == 1)
                            {
                                MessageBox.Show("Deletion successful.");
                                // Continue to the next part of your application
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Login failed. Please check your username and password.");

                                con.Close();
                            }
                            }
                }

            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
