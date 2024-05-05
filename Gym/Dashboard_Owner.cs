namespace Gym
{ 
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

    public partial class Dashboard_Owner : Form
    {
        private Control? frmDashBoard_Vrb;

        public Dashboard_Owner()
        {
            InitializeComponent();
            // Ensure the Load event is connected
            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "DashBoard";
            this.PnlFormLoader.Controls.Clear();
            Dashboard_Owner frmDashBoard_Vrb = new Dashboard_Owner() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        /* private void SetRoundedCorners(int radius)
         {
             Rectangle bounds = this.Bounds;
             GraphicsPath path = new GraphicsPath();
             path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
             path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
             path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
             path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
             path.CloseAllFigures();

             this.Region = new Region(path);
         }
 */
        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None; // Optional: remove the border and title bar
                                                         //  this.SetRoundedCorners(30); // You can adjust the radius as needed

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "DashBoard";
            this.PnlfrmLoader.Controls.Clear();
            Dashboard_Owner frmDashBoard_Vrb = new Dashboard_Owner() { Dock = DockStyle.Fill, TopLevel = false,TopMost=true };
            frmDashBoard_Vrb.FormBorderStyle=FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();

        }



        private void btnMemberReports_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnMemberReport.Height;
            pnlNav.Top = btnMemberReport.Top;

            btnMemberReport.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Member Report";
            this.PnlfrmLoader.Controls.Clear();
            O_MemberReport frmDashBoard_Vrb = new O_MemberReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();

        }

        private void btnTrainerReport_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btntrainerreport.Height;
            pnlNav.Top = btntrainerreport.Top;

            btntrainerreport.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Trainer Report";
            this.PnlfrmLoader.Controls.Clear();
            O_TrainerReport frmDashBoard_Vrb = new O_TrainerReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();

        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnManagement.Height;
            pnlNav.Top = btnManagement.Top;

            btnManagement.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Management";
            this.PnlfrmLoader.Controls.Clear();
            O_Managment frmDashBoard_Vrb = new O_Managment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnlogout.Height;
            pnlNav.Top = btnlogout.Top;

            btnlogout.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnaddtrainer.Height;
            pnlNav.Top = btnaddtrainer.Top;

            btnaddtrainer.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Add Trainer";
            this.PnlfrmLoader.Controls.Clear();
            O_AddTrainer frmDashBoard_Vrb = new O_AddTrainer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();

        }

        private void btnDashBoard_Leave(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btnMemberReport_Leave(object sender, EventArgs e)
        {
            btnMemberReport.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btntrainerreport_Leave(object sender, EventArgs e)
        {
            btntrainerreport.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnaddtrainer_Leave(object sender, EventArgs e)
        {
            btnaddtrainer.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnManagement_Leave(object sender, EventArgs e)
        {
            btnManagement.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnlogout_Leave(object sender, EventArgs e)
        {
            btnlogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}