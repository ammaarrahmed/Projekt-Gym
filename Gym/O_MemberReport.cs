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

namespace Gym
{
    public partial class O_MemberReport : Form
    {
        public O_MemberReport()
        {
            InitializeComponent();
        }

        void O_MemeberReport_Load(object sender, EventArgs e)
        {
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Data Source=SANI-PC\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                string option = comboBox1.SelectedItem?.ToString();
                string input2 = lname.Text.Trim();
                string input1 = textBox1.Text.Trim();
                if (option == "Details of members of one specific gym that get training from 1 specific trainer.")
                {
                    string query = @"SELECT FlexTrainerDataMemberCSV.MemberID, FlexTrainerDataMemberCSV.FirstName, FlexTrainerDataMemberCSV.LastName, FlexTrainerDataMemberCSV.DateOfBirth, FlexTrainerDataMemberCSV.Weight, FlexTrainerDataMemberCSV.Height, FlexTrainerDataMemberCSV.Gender,
                        FlexTrainerDataMemberCSV.Experience_Level, FlexTrainerDataMemberCSV.Goal, FlexTrainerDataMemberCSV.Registeration_Date
                        FROM FlexTrainerDataGymCSV 
                        JOIN FlexTrainerDataTrainer_GymCSV ON FlexTrainerDataTrainer_GymCSV.GymID = FlexTrainerDataGymCSV.GymID 
                        JOIN FlexTrainerDataTrainerCSV ON FlexTrainerDataTrainer_GymCSV.TrainerID = FlexTrainerDataTrainerCSV.TrainerID 
                        JOIN FlexTrainerDataMember_GymCSV ON FlexTrainerDataTrainer_GymCSV.GymID = FlexTrainerDataMember_GymCSV.GymID 
                        JOIN FlexTrainerDataMemberCSV ON FlexTrainerDataMemberCSV.MemberID = FlexTrainerDataMember_GymCSV.MemberID 
                        WHERE Name = @input1 AND FlexTrainerDataTrainerCSV.FirstName = @input2";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@input1", input1);
                        cmd.Parameters.AddWithValue("@input2", input2);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Check and remove the password column
                        if (dt.Columns.Contains("password"))
                            dt.Columns.Remove("password");

                        // Change the data display color
                        DataView.DataSource = dt;
                        DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                        DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.GridColor = Color.Black; // Change it to your desired color
                    }
                }





                else if (option == "Details of members from one specific gym that follow a specific diet plan.")
                {
                    string query = @"SELECT FlexTrainerDataMemberCSV.MemberID, FlexTrainerDataMemberCSV.FirstName, FlexTrainerDataMemberCSV.LastName, FlexTrainerDataMemberCSV.DateOfBirth, FlexTrainerDataMemberCSV.Weight, FlexTrainerDataMemberCSV.Height, FlexTrainerDataMemberCSV.Gender,
                        FROM FlexTrainerDataGymCSV AS Gym
                        JOIN FlexTrainerDataMember_GymCSV AS MemberGym ON Gym.GymID = MemberGym.GymID 
                        JOIN FlexTrainerDataMemberCSV AS Member ON Member.MemberID = MemberGym.MemberID
						join FlexTrainerDataDietPlanCSV on FlexTrainerDataDietPlanCSV.TrainerID = TrainerID
						join FlexTrainerDataMember_DietPlanCSV on FlexTrainerDataMember_DietPlanCSV.DPlanID = FlexTrainerDataDietPlanCSV.DPlanID
                        WHERE Gym.Name = @input1 AND FlexTrainerDataDietPlanCSV.Type = @input2";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@input1", input1);
                        cmd.Parameters.AddWithValue("@input2", input2);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Check and remove the password column
                        if (dt.Columns.Contains("password"))
                            dt.Columns.Remove("password");

                        // Change the data display color
                        DataView.DataSource = dt;
                        DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                        DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.GridColor = Color.Black; // Change it to your desired color
                    }


                }

                else if (option == "Details of members across all gyms of a specific trainer that follow a specific diet plan.")
                {
                    string query = @"SELECT Distinct Member.MemberID, Member.FirstName, Member.LastName, Member.DateOfBirth, Member.Weight, Member.Height, Member.Gender
                        FROM FlexTrainerDataGymCSV AS Gym
                        JOIN FlexTrainerDataMember_GymCSV AS MemberGym ON Gym.GymID = MemberGym.GymID 
                        JOIN FlexTrainerDataMemberCSV AS Member ON Member.MemberID = MemberGym.MemberID
						JOIN FlexTrainerDataTrainer_GymCSV AS TrainerGym ON Gym.GymID = TrainerGym.GymID
						JOIN FlexTrainerDataTrainerCSV AS Trainer ON Trainer.TrainerID = TrainerGym.TrainerID
						join FlexTrainerDataMember_GymCSV on FlexTrainerDataMember_GymCSV.GymID = Gym.GymID
						join FlexTrainerDataMemberCSV on FlexTrainerDataMemberCSV.MemberID = FlexTrainerDataMember_GymCSV.MemberID
						join FlexTrainerDataMember_DietPlanCSV on FlexTrainerDataMember_DietPlanCSV.MemberID = FlexTrainerDataMember_GymCSV.MemberID
						join FlexTrainerDataDietPlanCSV on FlexTrainerDataMember_DietPlanCSV.DPlanID = FlexTrainerDataDietPlanCSV.DPlanID
                        WHERE Gym.Name = @input1 AND FlexTrainerDataDietPlanCSV.Type = @input2";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@input1", input1);
                        cmd.Parameters.AddWithValue("@input2", input2);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Check and remove the password column
                        if (dt.Columns.Contains("password"))
                            dt.Columns.Remove("password");

                        // Change the data display color
                        DataView.DataSource = dt;
                        DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                        DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.GridColor = Color.Black; // Change it to your desired color
                    }
                }

                else if (option == "New membership data in last 3 months (Gym Owner).")
                {
                    string query = @"SELECT DISTINCT Member.MemberID, Member.FirstName, Member.LastName, Member.DateOfBirth, Member.Weight, Member.Height, Member.Gender
                    FROM FlexTrainerDataGymCSV AS Gym
                    JOIN FlexTrainerDataMember_GymCSV AS MemberGym ON Gym.GymID = MemberGym.GymID 
                    JOIN FlexTrainerDataMemberCSV AS Member ON Member.MemberID = MemberGym.MemberID
                    join FlexTrainerDataOwner_GymCSV on FlexTrainerDataOwner_GymCSV.GymID = Gym.GymID
                    join FlexTrainerDataOwnerCSV on FlexTrainerDataOwnerCSV.OwnerID = FlexTrainerDataOwner_GymCSV.OwnerID
                    WHERE FlexTrainerDataOwnerCSV.FirstName = @input1 AND Member.Registeration_Date >= DATEADD(month, -3, GETDATE());";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@input1", input1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                    

                        // Change the data display color
                        DataView.DataSource = dt;
                        DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                        DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                        DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                        DataView.GridColor = Color.Black; // Change it to your desired color
                    }
                }

                else if (option == "Comparison of total members in multiple gyms, in the past 6 months.")
                {
                   
                        string query = @"SELECT Gym.Name AS GymName, COUNT(DISTINCT Member.MemberID) AS TotalMembers
                        FROM FlexTrainerDataGymCSV AS Gym
                        JOIN FlexTrainerDataMember_GymCSV AS MemberGym ON Gym.GymID = MemberGym.GymID 
                        JOIN FlexTrainerDataMemberCSV AS Member ON Member.MemberID = MemberGym.MemberID
                        WHERE MemberGym.Registeration_Date >= DATEADD(month, -6, GETDATE())
                        GROUP BY Gym.Name";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            // Change column names for better representation
                            dt.Columns["GymName"].ColumnName = "Gym Name";
                            dt.Columns["TotalMembers"].ColumnName = "Total Members";

                            // Change the data display color
                            DataView.DataSource = dt;
                            DataView.DefaultCellStyle.ForeColor = Color.Goldenrod; // Change it to your desired color
                            DataView.DefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                            DataView.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet; // Change it to your desired color
                            DataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; // Change it to your desired color
                            DataView.GridColor = Color.Black; // Change it to your desired color
                        }
                    


                }
            }
        }


    }
}
