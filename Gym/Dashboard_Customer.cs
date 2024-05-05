namespace Gym
{
    public partial class Dashboard_Customer : Form
    {
        public Dashboard_Customer()
        {
            InitializeComponent();
            pnlNav.Height = btnDashBoard.Height;
            pnlNav.Top = btnDashBoard.Top;
            pnlNav.Left = btnDashBoard.Left;
            btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "DashBoard";
            this.PnlfrmLoader.Controls.Clear();
            //FrmDashBoard frmDashBoard_Vrb = new FrmDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            //this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
            //frmDashBoard_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //private void btnDashBoard_Click(object sender, EventArgs e)
        //{
        //    pnlNav.Height = btnDashBoard.Height;
        //    pnlNav.Top = btnDashBoard.Top;
        //    pnlNav.Left = btnDashBoard.Left;
        //    btnDashBoard.BackColor = Color.FromArgb(46, 51, 73);

        //    lblTitle.Text = "DashBoard";
        //    this.PnlfrmLoader.Controls.Clear();
        //    FrmDashBoard frmDashBoard_Vrb = new FrmDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
        //    this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
        //    frmDashBoard_Vrb.Show();

        //}

        //private void BtnGymPerformance_Click(object sender, EventArgs e)
        //{
        //    pnlNav.Height = BtnGymPerformance.Height;
        //    pnlNav.Top = BtnGymPerformance.Top;

        //    BtnGymPerformance.BackColor = Color.FromArgb(46, 51, 73);

        //    lblTitle.Text = "Gym Performance";
        //    this.PnlfrmLoader.Controls.Clear();
        //    FrmGymPerformance frmDashBoard_Vrb = new FrmGymPerformance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
        //    this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
        //    frmDashBoard_Vrb.Show();

        //}

        //private void btnGymRequest_Click(object sender, EventArgs e)
        //{
        //    pnlNav.Height = btnGymRequest.Height;
        //    pnlNav.Top = btnGymRequest.Top;

        //    btnGymRequest.BackColor = Color.FromArgb(46, 51, 73);

        //    lblTitle.Text = "Gym Request";
        //    this.PnlfrmLoader.Controls.Clear();
        //    FrmApproveGym frmDashBoard_Vrb = new FrmApproveGym() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
        //    this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
        //    frmDashBoard_Vrb.Show();
        //}

        //private void btnRemoveGym_Click(object sender, EventArgs e)
        //{
        //    pnlNav.Height = btnRemoveGym.Height;
        //    pnlNav.Top = btnRemoveGym.Top;

        //    btnRemoveGym.BackColor = Color.FromArgb(46, 51, 73);

        //    lblTitle.Text = "Revoke Membership";
        //    this.PnlfrmLoader.Controls.Clear();
        //    FrmRevokeGym frmDashBoard_Vrb = new FrmRevokeGym() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
        //    this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
        //    frmDashBoard_Vrb.Show();
        //}

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    pnlNav.Height = button1.Height;
        //    pnlNav.Top = button1.Top;

        //    button1.BackColor = Color.FromArgb(46, 51, 73);

        //    lblTitle.Text = "Leave Feedback";
        //    this.PnlfrmLoader.Controls.Clear();
        //    LeaveFeedback frmDashBoard_Vrb = new LeaveFeedback() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
        //    this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
        //    frmDashBoard_Vrb.Show();
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    pnlNav.Height = button2.Height;
        //    pnlNav.Top = button2.Top;

        //    button2.BackColor = Color.FromArgb(46, 51, 73);

        //    lblTitle.Text = "Browse Workout Plans";
        //    this.PnlfrmLoader.Controls.Clear();
        //    browseWorkout frmDashBoard_Vrb = new browseWorkout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
        //    this.PnlfrmLoader.Controls.Add(frmDashBoard_Vrb);
        //    frmDashBoard_Vrb.Show();
        //}
    }
}
