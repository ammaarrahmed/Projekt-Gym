using Gym;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
    public partial class Dashboard_Admin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S1SQUE8\\SQLEXPRESS;Initial Catalog=FLEXTRAINER;Integrated Security=True;Trust Server Certificate=True");
        public Dashboard_Admin(string fullname)
        {
            InitializeComponent();
            label1.Text=fullname;


            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(255,215,0);

            lblTitle.Text = "DashBoard";
            this.PnlfrmLoader.Controls.Clear();
            A_Dashboard frmDashBoard_Vrb = new A_Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(255, 215, 0);

            lblTitle.Text = "DashBoard";
            this.PnlfrmLoader.Controls.Clear();
            A_Dashboard frmDashBoard_Vrb = new A_Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();

        }

        private void BtnGymPerformance_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGymPerformance.Height;
            pnlNav.Top = BtnGymPerformance.Top;

            BtnGymPerformance.BackColor = Color.FromArgb(255, 215, 0);

            lblTitle.Text = "Gym Performance";
            this.PnlfrmLoader.Controls.Clear();
            A_GymPerfomance frmDashBoard_Vrb = new A_GymPerfomance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();

        }

        private void btnGymRequest_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGymRequest.Height;
            pnlNav.Top = btnGymRequest.Top;

            btnGymRequest.BackColor = Color.FromArgb(255, 215, 0);

            lblTitle.Text = "Gym Request";
            this.PnlfrmLoader.Controls.Clear();
            A_ApproveGym frmDashBoard_Vrb = new A_ApproveGym() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void btnRemoveGym_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRemoveGym.Height;
            pnlNav.Top = btnRemoveGym.Top;

            btnRemoveGym.BackColor = Color.FromArgb(255, 215, 0);

            lblTitle.Text = "Revoke Membership";
            this.PnlfrmLoader.Controls.Clear();
            A_RevokeGym frmDashBoard_Vrb = new A_RevokeGym() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
