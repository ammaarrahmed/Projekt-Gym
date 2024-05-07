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
using Microsoft.Data.SqlClient;

namespace Gym
{
    public partial class Login_Page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True");

        public Login_Page()
        {
            InitializeComponent();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FLEX_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Member");
            comboBox1.Items.Add("Trainer");
            comboBox1.Items.Add("Owner");
            comboBox1.Items.Add("Admin");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtusername.Focus();


        }

        private void checkBoxShowPS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPS.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPS.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True"))
            {
                if (comboBox1.Text == "Member")
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT COUNT(1) FROM [dbo].[FlexTrainerDataMemberCSV] WHERE Email=@Username AND Password=@Password";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                            sqlCommand.Parameters.AddWithValue("@Password", txtpassword.Text);
                            int result = (int)sqlCommand.ExecuteScalar();

                            if (result == 1)
                            {
                                MessageBox.Show("Login successful.");
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message);
                    }
                }

                else if (comboBox1.Text == "Trainer")
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT COUNT(1) FROM [dbo].[FlexTrainerDataTrainerCSV] WHERE Email=@Username AND Password=@Password";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                            sqlCommand.Parameters.AddWithValue("@Password", txtpassword.Text);
                            int result = (int)sqlCommand.ExecuteScalar();

                            if (result == 1)
                            {
                                MessageBox.Show("Login successful.");
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message);
                    }
                }

                else if (comboBox1.Text == "Owner")
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT COUNT(1) FROM [dbo].[FlexTrainerDataOwnerCSV] WHERE Email=@Username AND Password=@Password";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                            sqlCommand.Parameters.AddWithValue("@Password", txtpassword.Text);
                            int result = (int)sqlCommand.ExecuteScalar();

                            if (result == 1)
                            {
                                MessageBox.Show("Login successful.");
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message);
                    }
                }

                else if (comboBox1.Text == "Admin")
                {
                    try
                    {
                        sqlConnection.Open();
                        string query = "SELECT COUNT(1) FROM [dbo].[FlexTrainerDataAdminCSV] WHERE Email=@Username AND Password=@Password";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@Username", txtusername.Text);
                            sqlCommand.Parameters.AddWithValue("@Password", txtpassword.Text);
                            int result = (int)sqlCommand.ExecuteScalar();

                            if (result == 1)
                            {
                                MessageBox.Show("Login successful.");
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message);
                    }
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Select an Account Type");
            }
            else if (comboBox1.Text == "Member")
            {
                new Member_Reg().Show();
                this.Hide();
            }

            else if (comboBox1.Text == "Trainer")
            {
                new Trainer_Reg().Show();
                this.Hide();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class TransparentTextBox : TextBox
    {
        public TransparentTextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }
    }
}
