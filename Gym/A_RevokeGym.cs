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

namespace Gym
{
    public partial class A_RevokeGym : Form
    {
        public A_RevokeGym()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            SetupButtonViewDataGridView();
            UpdateRecordCountLabel();

        }

        private void UpdateRecordCountLabel()
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [dbo].[FlexTrainerDataGymCSV]", con))
                    {
                        int recordCount = (int)cmd.ExecuteScalar();
                        label2.Text = $"{recordCount}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update record count: " + ex.Message);
                }
            }
        }

    
        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Adjust the SQL query to your needs
                string query = "SELECT GymID,Name,Address FROM [dbo].[FlexTrainerDataGymCSV]";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd); // Using SqlDataAdapter to fill DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Fill DataTable with data

                    approvegymview.DataSource = dt; // Set DataGridView source to DataTable
                }
            }
        }


        private void SetupButtonViewDataGridView()
        {
            DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn();
            approveButtonColumn.Name = "Delete";
            approveButtonColumn.Text = "DELETE";
            approveButtonColumn.UseColumnTextForButtonValue = true;

          

            buttonview.Columns.Add(approveButtonColumn);
          
            buttonview.ColumnHeadersVisible = false;

            DataTable dt = (DataTable)approvegymview.DataSource;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                buttonview.Rows.Add();
            }
        }

        private void buttonview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int GymID = Convert.ToInt32(approvegymview.Rows[e.RowIndex].Cells["GymID"].Value);

                if (buttonview.Columns[e.ColumnIndex].Name == "Delete")
                {
                    ApproveRequest(GymID);
                }
                 // Remove the corresponding rows from both DataGridViews
                approvegymview.Rows.RemoveAt(e.RowIndex);
                buttonview.Rows.RemoveAt(e.RowIndex);
            }
        }


        private void ApproveRequest(int GymID)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {

                con.Open();
                // Start a transaction
                SqlTransaction transaction = con.BeginTransaction();


                try
                {
                    // Insert into FlexTrainerDataGymCSV
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[FlexTrainerDataGym_AdminCSV] WHERE GymID = @GymID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@GymID", GymID);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert into FlexTrainerDataOwnerCSV
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[FlexTrainerDataMember_GymCSV] WHERE GymID = @GymID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@GymID", GymID);
                        cmd.ExecuteNonQuery();
                    }

                    // Delete the record from gym_request
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[FlexTrainerDataTrainer_GymCSV] WHERE GymID = @GymID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@GymID", GymID);
                        cmd.ExecuteNonQuery();
                    }


                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[FlexTrainerDataOwner_GymCSV] WHERE GymID = @GymID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@GymID", GymID);
                        cmd.ExecuteNonQuery();
                    }


                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[FlexTrainerDataGymCSV] WHERE GymID = @GymID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@GymID", GymID);
                        cmd.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();
                    MessageBox.Show("Gym Deleted. ID: " + GymID);
                    UpdateRecordCountLabel();
                }
                catch (Exception ex)
                {
                    // Roll back the transaction
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }




  

    }
}
