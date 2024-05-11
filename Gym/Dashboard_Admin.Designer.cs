namespace UI_FOR_ADMIN
{
    partial class Dashboard_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            panel1 = new Panel();
            BtnGymPerformance = new Button();
            pnlNav = new Panel();
            btnlogout = new Button();
            btnRemoveGym = new Button();
            btnGymRequest = new Button();
            btnDashBoard = new Button();
            panel2 = new Panel();
            PnlFormLoader = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PnlfrmLoader = new Panel();
            lblTitle = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(BtnGymPerformance);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnRemoveGym);
            panel1.Controls.Add(btnGymRequest);
            panel1.Controls.Add(btnDashBoard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 806);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnGymPerformance
            // 
            BtnGymPerformance.Dock = DockStyle.Top;
            BtnGymPerformance.FlatAppearance.BorderSize = 0;
            BtnGymPerformance.FlatStyle = FlatStyle.Flat;
            BtnGymPerformance.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGymPerformance.ForeColor = Color.Black;
            BtnGymPerformance.Image = Gym.Properties.Resources.black_performance;
            BtnGymPerformance.ImageAlign = ContentAlignment.MiddleRight;
            BtnGymPerformance.Location = new Point(0, 361);
            BtnGymPerformance.Name = "BtnGymPerformance";
            BtnGymPerformance.Size = new Size(186, 64);
            BtnGymPerformance.TabIndex = 8;
            BtnGymPerformance.Text = "Gym Performance";
            BtnGymPerformance.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnGymPerformance.UseVisualStyleBackColor = true;
            BtnGymPerformance.Click += BtnGymPerformance_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Black;
            pnlNav.Location = new Point(3, 205);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 200);
            pnlNav.TabIndex = 3;
            // 
            // btnlogout
            // 
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.Black;
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.Location = new Point(3, 739);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(183, 55);
            btnlogout.TabIndex = 7;
            btnlogout.Text = "Log Out";
            btnlogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnRemoveGym
            // 
            btnRemoveGym.Dock = DockStyle.Top;
            btnRemoveGym.FlatAppearance.BorderSize = 0;
            btnRemoveGym.FlatStyle = FlatStyle.Flat;
            btnRemoveGym.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveGym.ForeColor = Color.Black;
            btnRemoveGym.Image = Gym.Properties.Resources.remove_black_gym;
            btnRemoveGym.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveGym.Location = new Point(0, 297);
            btnRemoveGym.Name = "btnRemoveGym";
            btnRemoveGym.Size = new Size(186, 64);
            btnRemoveGym.TabIndex = 3;
            btnRemoveGym.Text = "Remove Gym";
            btnRemoveGym.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRemoveGym.UseVisualStyleBackColor = true;
            btnRemoveGym.Click += btnRemoveGym_Click;
            // 
            // btnGymRequest
            // 
            btnGymRequest.Dock = DockStyle.Top;
            btnGymRequest.FlatAppearance.BorderSize = 0;
            btnGymRequest.FlatStyle = FlatStyle.Flat;
            btnGymRequest.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGymRequest.ForeColor = Color.Black;
            btnGymRequest.Image = Gym.Properties.Resources.black_request;
            btnGymRequest.Location = new Point(0, 234);
            btnGymRequest.Name = "btnGymRequest";
            btnGymRequest.Size = new Size(186, 63);
            btnGymRequest.TabIndex = 4;
            btnGymRequest.Text = "Gym Request";
            btnGymRequest.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGymRequest.UseVisualStyleBackColor = true;
            btnGymRequest.Click += btnGymRequest_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Dock = DockStyle.Top;
            btnDashBoard.FlatAppearance.BorderSize = 0;
            btnDashBoard.FlatStyle = FlatStyle.Flat;
            btnDashBoard.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashBoard.ForeColor = Color.Black;
            btnDashBoard.Image = Gym.Properties.Resources.black_home;
            btnDashBoard.Location = new Point(0, 173);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(186, 61);
            btnDashBoard.TabIndex = 6;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(PnlFormLoader);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 173);
            panel2.TabIndex = 1;
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
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(37, 92);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Gym.Properties.Resources.USER_PROFILE_GOLD;
            pictureBox1.Location = new Point(64, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PnlfrmLoader
            // 
            PnlfrmLoader.Dock = DockStyle.Bottom;
            PnlfrmLoader.Location = new Point(186, 106);
            PnlfrmLoader.Name = "PnlfrmLoader";
            PnlfrmLoader.Size = new Size(1241, 700);
            PnlfrmLoader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(216, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 29);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "DashBoard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(1078, 29);
            label2.Name = "label2";
            label2.Size = new Size(236, 46);
            label2.TabIndex = 5;
            label2.Text = "yes yes flexing";
            // 
            // Dashboard_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1427, 806);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(PnlfrmLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_Admin";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnRemoveGym;
        private Button btnGymRequest;
        private Button btnGymPerformance;
        private Button btnDashBoard;
        private Panel panel2;
        private Panel PnlFormLoader;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel PnlfrmLoader;
        private Panel pnlNav;
        private Button btnlogout;
        private Label lblTitle;
        private Button BtnGymPerformance;
        private Label label2;
    }
}
