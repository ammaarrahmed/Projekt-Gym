using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gym
{
    public partial class Dashboard_Trainer : Form
    {
        private Control? frmDashBoard_Vrb;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        public Dashboard_Trainer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentB_Click(object sender, EventArgs e)
        {
            NavPanel.Height = AppointmentB.Height;
            NavPanel.Top = AppointmentB.Top;
            NavPanel.Left = AppointmentB.Left;
            AppointmentB.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Appointments";
            this.PanelMain.Controls.Clear();
            T_Appointment frmDashBoard_Vrb = new T_Appointment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void CreateWorkoutPlanB_Click(object sender, EventArgs e)
        {
            NavPanel.Height = CreateWorkoutPlanB.Height;
            NavPanel.Top = CreateWorkoutPlanB.Top;
            NavPanel.Left = CreateWorkoutPlanB.Left;
            CreateWorkoutPlanB.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Create Workout Plan";
            this.PanelMain.Controls.Clear();
            T_CreateWorkoutPlan frmDashBoard_Vrb = new T_CreateWorkoutPlan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void ReviewWorkoutPlanB_Click(object sender, EventArgs e)
        {
            NavPanel.Height = ReviewWorkoutPlanB.Height;
            NavPanel.Top = ReviewWorkoutPlanB.Top;
            NavPanel.Left = ReviewWorkoutPlanB.Left;
            ReviewWorkoutPlanB.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Workout Plan Reviewer";
            this.PanelMain.Controls.Clear();
            T_TrainerWorkoutPlan frmDashBoard_Vrb = new T_TrainerWorkoutPlan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void CreateDietPlanB_Click(object sender, EventArgs e)
        {
            NavPanel.Height = CreateDietPlanB.Height;
            NavPanel.Top = CreateDietPlanB.Top;
            NavPanel.Left = CreateDietPlanB.Left;
            CreateDietPlanB.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Diet Plan Creator";
            this.PanelMain.Controls.Clear();
            T_CreateDietPlan frmDashBoard_Vrb = new T_CreateDietPlan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void ReviewDietPlansB_Click(object sender, EventArgs e)
        {
            NavPanel.Height = ReviewDietPlansB.Height;
            NavPanel.Top = ReviewDietPlansB.Top;
            NavPanel.Left = ReviewDietPlansB.Left;
            ReviewDietPlansB.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Diet Plan Reviewer";
            this.PanelMain.Controls.Clear();
            T_TrainerDietPlans frmDashBoard_Vrb = new T_TrainerDietPlans() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void FeedbackB_Click(object sender, EventArgs e)
        {
            NavPanel.Height = FeedbackB.Height;
            NavPanel.Top = FeedbackB.Top;
            NavPanel.Left = FeedbackB.Left;
            FeedbackB.BackColor = Color.FromArgb(46, 51, 73);

            LabelTitle.Text = "Feedback";
            this.PanelMain.Controls.Clear();
            T_Feedback frmDashBoard_Vrb = new T_Feedback() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashBoard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelMain.Controls.Add(frmDashBoard_Vrb);
            frmDashBoard_Vrb.Show();
        }

        private void AppointmentB_Leave(object sender, EventArgs e)
        {
            AppointmentB.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void CreateWorkoutPlanB_Leave(object sender, EventArgs e)
        {
            CreateWorkoutPlanB.BackColor = Color.FromArgb(20, 20, 20);

        }

        private void CreateDietPlanB_Leave(object sender, EventArgs e)
        {
            CreateDietPlanB.BackColor = Color.FromArgb(20, 20, 20);

        }

        private void ReviewWorkoutPlanB_Leave(object sender, EventArgs e)
        {
            ReviewWorkoutPlanB.BackColor = Color.FromArgb(20, 20, 20);

        }

        private void ReviewDietPlansB_Leave(object sender, EventArgs e)
        {
            ReviewDietPlansB.BackColor = Color.FromArgb(20, 20, 20);

        }

        private void FeedbackB_Leave(object sender, EventArgs e)
        {
            FeedbackB.BackColor = Color.FromArgb(20, 20, 20);

        }
    }
}
