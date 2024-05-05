namespace Gym
{
    partial class Dashboard_Owner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Owner));
            panel1 = new Panel();
            pnlNav = new Panel();
            btnManagement = new Button();
            btnlogout = new Button();
            btnaddtrainer = new Button();
            btntrainerreport = new Button();
            btnMemberReport = new Button();
            btnDashBoard = new Button();
            panel2 = new Panel();
            PnlFormLoader = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            PnlfrmLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnManagement);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnaddtrainer);
            panel1.Controls.Add(btntrainerreport);
            panel1.Controls.Add(btnMemberReport);
            panel1.Controls.Add(btnDashBoard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 589);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 205);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 200);
            pnlNav.TabIndex = 2;
            // 
            // btnManagement
            // 
            btnManagement.Dock = DockStyle.Top;
            btnManagement.FlatAppearance.BorderSize = 0;
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManagement.ForeColor = Color.FromArgb(0, 126, 249);
            btnManagement.Image = (Image)resources.GetObject("btnManagement.Image");
            btnManagement.ImageAlign = ContentAlignment.MiddleRight;
            btnManagement.Location = new Point(0, 395);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(186, 61);
            btnManagement.TabIndex = 2;
            btnManagement.Text = "Management";
            btnManagement.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnManagement.UseVisualStyleBackColor = true;
            btnManagement.Click += btnManagement_Click;
            btnManagement.Leave += btnManagement_Leave;
            // 
            // btnlogout
            // 
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.FromArgb(0, 126, 249);
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.Location = new Point(0, 519);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(183, 55);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Log Out";
            btnlogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnLogOut_Click;
            btnlogout.Leave += btnlogout_Leave;
            // 
            // btnaddtrainer
            // 
            btnaddtrainer.Dock = DockStyle.Top;
            btnaddtrainer.FlatAppearance.BorderSize = 0;
            btnaddtrainer.FlatStyle = FlatStyle.Flat;
            btnaddtrainer.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddtrainer.ForeColor = Color.FromArgb(0, 126, 249);
            btnaddtrainer.Image = (Image)resources.GetObject("btnaddtrainer.Image");
            btnaddtrainer.ImageAlign = ContentAlignment.MiddleRight;
            btnaddtrainer.Location = new Point(0, 331);
            btnaddtrainer.Name = "btnaddtrainer";
            btnaddtrainer.Size = new Size(186, 64);
            btnaddtrainer.TabIndex = 1;
            btnaddtrainer.Text = "Add Trainer";
            btnaddtrainer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnaddtrainer.UseVisualStyleBackColor = true;
            btnaddtrainer.Click += btnAddTrainer_Click;
            btnaddtrainer.Leave += btnaddtrainer_Leave;
            // 
            // btntrainerreport
            // 
            btntrainerreport.Dock = DockStyle.Top;
            btntrainerreport.FlatAppearance.BorderSize = 0;
            btntrainerreport.FlatStyle = FlatStyle.Flat;
            btntrainerreport.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntrainerreport.ForeColor = Color.FromArgb(0, 126, 249);
            btntrainerreport.Image = (Image)resources.GetObject("btntrainerreport.Image");
            btntrainerreport.Location = new Point(0, 268);
            btntrainerreport.Name = "btntrainerreport";
            btntrainerreport.Size = new Size(186, 63);
            btntrainerreport.TabIndex = 1;
            btntrainerreport.Text = "Trainer Report";
            btntrainerreport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btntrainerreport.UseVisualStyleBackColor = true;
            btntrainerreport.Click += btnTrainerReport_Click;
            btntrainerreport.Leave += btntrainerreport_Leave;
            // 
            // btnMemberReport
            // 
            btnMemberReport.Dock = DockStyle.Top;
            btnMemberReport.FlatAppearance.BorderSize = 0;
            btnMemberReport.FlatStyle = FlatStyle.Flat;
            btnMemberReport.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMemberReport.ForeColor = Color.FromArgb(0, 126, 249);
            btnMemberReport.Image = (Image)resources.GetObject("btnMemberReport.Image");
            btnMemberReport.Location = new Point(0, 205);
            btnMemberReport.Name = "btnMemberReport";
            btnMemberReport.Size = new Size(186, 63);
            btnMemberReport.TabIndex = 1;
            btnMemberReport.Text = "Member Report";
            btnMemberReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMemberReport.UseVisualStyleBackColor = true;
            btnMemberReport.Click += btnMemberReports_Click;
            btnMemberReport.Leave += btnMemberReport_Leave;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Dock = DockStyle.Top;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashBoard.ForeColor = Color.FromArgb(0, 126, 249);
            //btnDashBoard.Image = Properties.Resources.blue_home1;
            btnDashBoard.Location = new Point(0, 144);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(186, 61);
            btnDashBoard.TabIndex = 1;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            btnDashBoard.Leave += btnDashBoard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(PnlFormLoader);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // PnlFormLoader
            // 
            PnlFormLoader.Location = new Point(189, 78);
            PnlFormLoader.Name = "PnlFormLoader";
            PnlFormLoader.Size = new Size(810, 511);
            PnlFormLoader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(38, 92);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(200, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 29);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "DashBoard";
            lblTitle.Click += label2_Click;
            // 
            // PnlfrmLoader
            // 
            PnlfrmLoader.Dock = DockStyle.Bottom;
            PnlfrmLoader.Location = new Point(186, 78);
            PnlfrmLoader.Name = "PnlfrmLoader";
            PnlfrmLoader.Size = new Size(807, 511);
            PnlfrmLoader.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(993, 589);
            Controls.Add(PnlfrmLoader);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnDashBoard;
        private Button btnlogout;
        private Button btntrainerreport;
        private Button btnMemberReport;
        private Button btnaddtrainer;
        private Button btnManagement;
        private Panel pnlNav;
        private Label lblTitle;
        private Panel PnlFormLoader;
        private Panel PnlfrmLoader;
    }
}
