namespace Gym
{
    partial class Dashboard_Trainer
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
            NavPanel = new Panel();
            FeedbackB = new Button();
            ReviewDietPlansB = new Button();
            ReviewWorkoutPlanB = new Button();
            CreateDietPlanB = new Button();
            CreateWorkoutPlanB = new Button();
            AppointmentB = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            LabelTitle = new Label();
            PanelMain = new Panel();
            NavPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.FromArgb(12, 9, 10);
            NavPanel.Controls.Add(FeedbackB);
            NavPanel.Controls.Add(ReviewDietPlansB);
            NavPanel.Controls.Add(ReviewWorkoutPlanB);
            NavPanel.Controls.Add(CreateDietPlanB);
            NavPanel.Controls.Add(CreateWorkoutPlanB);
            NavPanel.Controls.Add(AppointmentB);
            NavPanel.Controls.Add(panel2);
            NavPanel.Dock = DockStyle.Left;
            NavPanel.Location = new Point(0, 0);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(200, 577);
            NavPanel.TabIndex = 0;
            // 
            // FeedbackB
            // 
            FeedbackB.AccessibleRole = AccessibleRole.MenuBar;
            FeedbackB.BackColor = Color.FromArgb(20, 20, 20);
            FeedbackB.Dock = DockStyle.Top;
            FeedbackB.FlatStyle = FlatStyle.Flat;
            FeedbackB.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            FeedbackB.ForeColor = Color.Gold;
         //   FeedbackB.Image = Properties.Resources.appointmen;
            FeedbackB.ImageAlign = ContentAlignment.MiddleLeft;
            FeedbackB.Location = new Point(0, 507);
            FeedbackB.Name = "FeedbackB";
            FeedbackB.Size = new Size(200, 68);
            FeedbackB.TabIndex = 7;
            FeedbackB.Text = "Feedbacks";
            FeedbackB.TextAlign = ContentAlignment.MiddleRight;
            FeedbackB.TextImageRelation = TextImageRelation.ImageBeforeText;
            FeedbackB.UseVisualStyleBackColor = false;
            FeedbackB.Click += FeedbackB_Click;
            FeedbackB.Leave += FeedbackB_Leave;
            // 
            // ReviewDietPlansB
            // 
            ReviewDietPlansB.AccessibleRole = AccessibleRole.MenuBar;
            ReviewDietPlansB.BackColor = Color.FromArgb(20, 20, 20);
            ReviewDietPlansB.Dock = DockStyle.Top;
            ReviewDietPlansB.FlatStyle = FlatStyle.Flat;
            ReviewDietPlansB.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            ReviewDietPlansB.ForeColor = Color.Gold;
          //  ReviewDietPlansB.Image = Properties.Resources.appointmen;
            ReviewDietPlansB.ImageAlign = ContentAlignment.MiddleLeft;
            ReviewDietPlansB.Location = new Point(0, 439);
            ReviewDietPlansB.Name = "ReviewDietPlansB";
            ReviewDietPlansB.Size = new Size(200, 68);
            ReviewDietPlansB.TabIndex = 6;
            ReviewDietPlansB.Text = "Review Diet Plans";
            ReviewDietPlansB.TextAlign = ContentAlignment.MiddleRight;
            ReviewDietPlansB.TextImageRelation = TextImageRelation.ImageBeforeText;
            ReviewDietPlansB.UseVisualStyleBackColor = false;
            ReviewDietPlansB.Click += ReviewDietPlansB_Click;
            ReviewDietPlansB.Leave += ReviewDietPlansB_Leave;
            // 
            // ReviewWorkoutPlanB
            // 
            ReviewWorkoutPlanB.AccessibleRole = AccessibleRole.MenuBar;
            ReviewWorkoutPlanB.BackColor = Color.FromArgb(20, 20, 20);
            ReviewWorkoutPlanB.Dock = DockStyle.Top;
            ReviewWorkoutPlanB.FlatStyle = FlatStyle.Flat;
            ReviewWorkoutPlanB.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            ReviewWorkoutPlanB.ForeColor = Color.Gold;
           // ReviewWorkoutPlanB.Image = Properties.Resources.appointmen;
            ReviewWorkoutPlanB.ImageAlign = ContentAlignment.MiddleLeft;
            ReviewWorkoutPlanB.Location = new Point(0, 371);
            ReviewWorkoutPlanB.Name = "ReviewWorkoutPlanB";
            ReviewWorkoutPlanB.Size = new Size(200, 68);
            ReviewWorkoutPlanB.TabIndex = 5;
            ReviewWorkoutPlanB.Text = "Review Workout Planns";
            ReviewWorkoutPlanB.TextAlign = ContentAlignment.MiddleRight;
            ReviewWorkoutPlanB.TextImageRelation = TextImageRelation.ImageBeforeText;
            ReviewWorkoutPlanB.UseVisualStyleBackColor = false;
            ReviewWorkoutPlanB.Click += ReviewWorkoutPlanB_Click;
            ReviewWorkoutPlanB.Leave += ReviewWorkoutPlanB_Leave;
            // 
            // CreateDietPlanB
            // 
            CreateDietPlanB.AccessibleRole = AccessibleRole.MenuBar;
            CreateDietPlanB.BackColor = Color.FromArgb(20, 20, 20);
            CreateDietPlanB.Dock = DockStyle.Top;
            CreateDietPlanB.FlatStyle = FlatStyle.Flat;
            CreateDietPlanB.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            CreateDietPlanB.ForeColor = Color.Gold;
           // CreateDietPlanB.Image = Properties.Resources.appointmen;
            CreateDietPlanB.ImageAlign = ContentAlignment.MiddleLeft;
            CreateDietPlanB.Location = new Point(0, 303);
            CreateDietPlanB.Name = "CreateDietPlanB";
            CreateDietPlanB.Size = new Size(200, 68);
            CreateDietPlanB.TabIndex = 4;
            CreateDietPlanB.Text = "Diet Plan Creation";
            CreateDietPlanB.TextAlign = ContentAlignment.MiddleRight;
            CreateDietPlanB.TextImageRelation = TextImageRelation.ImageBeforeText;
            CreateDietPlanB.UseVisualStyleBackColor = false;
            CreateDietPlanB.Click += CreateDietPlanB_Click;
            CreateDietPlanB.Leave += CreateDietPlanB_Leave;
            // 
            // CreateWorkoutPlanB
            // 
            CreateWorkoutPlanB.AccessibleRole = AccessibleRole.MenuBar;
            CreateWorkoutPlanB.BackColor = Color.FromArgb(20, 20, 20);
            CreateWorkoutPlanB.Dock = DockStyle.Top;
            CreateWorkoutPlanB.FlatStyle = FlatStyle.Flat;
            CreateWorkoutPlanB.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            CreateWorkoutPlanB.ForeColor = Color.Gold;
         //   CreateWorkoutPlanB.Image = Properties.Resources.appointmen;
            CreateWorkoutPlanB.ImageAlign = ContentAlignment.MiddleLeft;
            CreateWorkoutPlanB.Location = new Point(0, 235);
            CreateWorkoutPlanB.Name = "CreateWorkoutPlanB";
            CreateWorkoutPlanB.Size = new Size(200, 68);
            CreateWorkoutPlanB.TabIndex = 3;
            CreateWorkoutPlanB.Text = "Create a Workout Plan";
            CreateWorkoutPlanB.TextAlign = ContentAlignment.MiddleRight;
            CreateWorkoutPlanB.TextImageRelation = TextImageRelation.ImageBeforeText;
            CreateWorkoutPlanB.UseVisualStyleBackColor = false;
            CreateWorkoutPlanB.Click += CreateWorkoutPlanB_Click;
            CreateWorkoutPlanB.Leave += CreateWorkoutPlanB_Leave;
            // 
            // AppointmentB
            // 
            AppointmentB.AccessibleRole = AccessibleRole.MenuBar;
            AppointmentB.BackColor = Color.FromArgb(20, 20, 20);
            AppointmentB.Dock = DockStyle.Top;
            AppointmentB.FlatStyle = FlatStyle.Flat;
            AppointmentB.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            AppointmentB.ForeColor = Color.Gold;
         //   AppointmentB.Image = Properties.Resources.appointmen;
            AppointmentB.ImageAlign = ContentAlignment.MiddleLeft;
            AppointmentB.Location = new Point(0, 167);
            AppointmentB.Name = "AppointmentB";
            AppointmentB.Size = new Size(200, 68);
            AppointmentB.TabIndex = 2;
            AppointmentB.Text = "Appointment";
            AppointmentB.TextAlign = ContentAlignment.MiddleRight;
            AppointmentB.TextImageRelation = TextImageRelation.ImageBeforeText;
            AppointmentB.UseVisualStyleBackColor = false;
            AppointmentB.Click += AppointmentB_Click;
            AppointmentB.Leave += AppointmentB_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 9, 10);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 167);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(46, 128);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Best Superhero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(68, 103);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Batman";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
        //    pictureBox1.Image = Properties.Resources.batmanarkham;
            pictureBox1.Location = new Point(58, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitle.ForeColor = Color.Gold;
            LabelTitle.Location = new Point(259, 26);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(0, 36);
            LabelTitle.TabIndex = 8;
            // 
            // PanelMain
            // 
            PanelMain.Location = new Point(236, 65);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(678, 475);
            PanelMain.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 40, 42);
            ClientSize = new Size(951, 577);
            Controls.Add(PanelMain);
            Controls.Add(LabelTitle);
            Controls.Add(NavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            NavPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel NavPanel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button AppointmentB;
        private Button FeedbackB;
        private Button ReviewDietPlansB;
        private Button ReviewWorkoutPlanB;
        private Button CreateDietPlanB;
        private Button CreateWorkoutPlanB;
        private Label LabelTitle;
        private Panel PanelMain;
    }
}
