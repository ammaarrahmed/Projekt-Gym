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
    public partial class O_TrainerReport : Form
    {
        public O_TrainerReport()
        {
            InitializeComponent();
        }


        private void Refresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=SANI-PC\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM FlexTrainerDataMemberCSV", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataView.DataSource = dt;
                dt.Columns.Remove("password");
                // Change the data display color
                DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color

                DataView.GridColor = Color.Black; // Change it to your desired color
            }
        }
    }
}
