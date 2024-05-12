namespace Gym
{
    partial class O_MemberReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Refresh = new Button();
            DataView = new DataGridView();
            comboBox1 = new ComboBox();
            lname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Black;
            Refresh.Cursor = Cursors.Hand;
            Refresh.FlatStyle = FlatStyle.Flat;
            Refresh.ForeColor = Color.Gold;
            Refresh.Location = new Point(941, 626);
            Refresh.Margin = new Padding(2);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(132, 43);
            Refresh.TabIndex = 64;
            Refresh.Text = "Generate";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // DataView
            // 
            DataView.BackgroundColor = SystemColors.ActiveCaptionText;
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.GridColor = SystemColors.Info;
            DataView.Location = new Point(100, 54);
            DataView.Name = "DataView";
            DataView.Size = new Size(973, 533);
            DataView.TabIndex = 65;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Details of members of one specific gym that get training from 1 specific trainer.", "Details of members from one specific gym that follow a specific diet plan.", "Details of members across all gyms of a specific trainer that follow a specific diet plan.", "New membership data in last 3 months (Gym Owner).", "Comparison of total members in multiple gyms, in the past 6 months." });
            comboBox1.Location = new Point(100, 626);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(546, 23);
            comboBox1.TabIndex = 66;
            // 
            // lname
            // 
            lname.BackColor = Color.FromArgb(255, 255, 192);
            lname.BorderStyle = BorderStyle.None;
            lname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lname.Location = new Point(822, 627);
            lname.Margin = new Padding(2);
            lname.Multiline = true;
            lname.Name = "lname";
            lname.Size = new Size(89, 28);
            lname.TabIndex = 95;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(704, 666);
            label2.Name = "label2";
            label2.Size = new Size(188, 13);
            label2.TabIndex = 97;
            label2.Text = "Enter Input Related to Query. Leave";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(743, 683);
            label1.Name = "label1";
            label1.Size = new Size(87, 13);
            label1.TabIndex = 98;
            label1.Text = "Blank if not any";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(689, 627);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 28);
            textBox1.TabIndex = 99;
            // 
            // O_MemberReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1164, 700);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lname);
            Controls.Add(comboBox1);
            Controls.Add(DataView);
            Controls.Add(Refresh);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "O_MemberReport";
            Text = "MemberReportF";
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Refresh;
        private DataGridView DataView;
        private ComboBox comboBox1;
        private TextBox lname;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}