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

namespace UI_FOR_ADMIN
{
    public partial class A_ApproveGym : Form
    {
        public A_ApproveGym()
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
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM gym_request", con))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Adjust the SQL query to your needs
                string query = "SELECT RequestID,GID,GName,Location,FirstName FROM gym_request";
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
            approveButtonColumn.Name = "Approve";
            approveButtonColumn.Text = "Approve";
            approveButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn disapproveButtonColumn = new DataGridViewButtonColumn();
            disapproveButtonColumn.Name = "Disapprove";
            disapproveButtonColumn.Text = "Disapprove";
            disapproveButtonColumn.UseColumnTextForButtonValue = true;

            buttonview.Columns.Add(approveButtonColumn);
            buttonview.Columns.Add(disapproveButtonColumn);
            buttonview.ColumnHeadersVisible = false;

            DataTable dt = (DataTable)approvegymview.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                buttonview.Rows.Add();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int requestId = Convert.ToInt32(approvegymview.Rows[e.RowIndex].Cells["RequestID"].Value);

                if (buttonview.Columns[e.ColumnIndex].Name == "Approve")
                {
                    ApproveRequest(requestId);
                }
                else if (buttonview.Columns[e.ColumnIndex].Name == "Disapprove")
                {
                    DisapproveRequest(requestId);
                }

                // Remove the corresponding rows from both DataGridViews
                approvegymview.Rows.RemoveAt(e.RowIndex);
                buttonview.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void ApproveRequest(int requestId)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                // Start a transaction
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Insert into FlexTrainerDataGymCSV
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[FlexTrainerDataGymCSV] (GymID, Name, Address) SELECT GID, GName, Location FROM gym_request WHERE RequestID = @RequestID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", requestId);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert into FlexTrainerDataOwnerCSV
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[FlexTrainerDataOwnerCSV] (OwnerID, FirstName, LastName, Email, Password) SELECT Oid, FirstName, LastName, Email, Password FROM gym_request WHERE RequestID = @RequestID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", requestId);
                        cmd.ExecuteNonQuery();
                    }

                    // Delete the record from gym_request
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM gym_request WHERE RequestID = @RequestID", con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", requestId);
                        cmd.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();
                    MessageBox.Show("Request approved and data stored. ID: " + requestId);
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

        private void DisapproveRequest(int requestId)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM gym_request WHERE RequestID = @RequestID", con))
                {
                    cmd.Parameters.AddWithValue("@RequestID", requestId);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Request disapproved and record deleted. ID: " + requestId);
                        UpdateRecordCountLabel();
                    }
                    else
                        MessageBox.Show("No record found to delete. ID: " + requestId);
                }
            }
        }
        private void A_ApproveGym_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
