namespace Gym
{
    partial class O_Managment
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
            O_Management_DataView = new DataGridView();
            Trainer_B = new Button();
            Customer_B = new Button();
            label1 = new Label();
            label2 = new Label();
            TableName = new ComboBox();
            label3 = new Label();
            DeleteB = new Button();
            Equipment_B = new Button();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)O_Management_DataView).BeginInit();
            SuspendLayout();
            // 
            // O_Management_DataView
            // 
            O_Management_DataView.BackgroundColor = SystemColors.ActiveCaptionText;
            O_Management_DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            O_Management_DataView.GridColor = SystemColors.Info;
            O_Management_DataView.Location = new Point(95, 128);
            O_Management_DataView.Name = "O_Management_DataView";
            O_Management_DataView.Size = new Size(973, 449);
            O_Management_DataView.TabIndex = 0;
            // 
            // Trainer_B
            // 
            Trainer_B.BackColor = Color.Black;
            Trainer_B.Cursor = Cursors.Hand;
            Trainer_B.FlatStyle = FlatStyle.Flat;
            Trainer_B.ForeColor = Color.Gold;
            Trainer_B.Location = new Point(709, 33);
            Trainer_B.Margin = new Padding(2);
            Trainer_B.Name = "Trainer_B";
            Trainer_B.Size = new Size(132, 43);
            Trainer_B.TabIndex = 16;
            Trainer_B.Text = "Trainer";
            Trainer_B.UseVisualStyleBackColor = false;
            Trainer_B.Click += Trainer_B_Click;
            // 
            // Customer_B
            // 
            Customer_B.BackColor = Color.Black;
            Customer_B.Cursor = Cursors.Hand;
            Customer_B.FlatStyle = FlatStyle.Flat;
            Customer_B.ForeColor = Color.Gold;
            Customer_B.Location = new Point(882, 33);
            Customer_B.Margin = new Padding(2);
            Customer_B.Name = "Customer_B";
            Customer_B.Size = new Size(132, 43);
            Customer_B.TabIndex = 18;
            Customer_B.Text = "Member";
            Customer_B.UseVisualStyleBackColor = false;
            Customer_B.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 39);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 19;
            label1.Text = "Display Data for: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 614);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 20;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // TableName
            // 
            TableName.BackColor = Color.FromArgb(255, 255, 192);
            TableName.DropDownStyle = ComboBoxStyle.DropDownList;
            TableName.FlatStyle = FlatStyle.Flat;
            TableName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TableName.FormattingEnabled = true;
            TableName.Items.AddRange(new object[] { "Equipment", "Trainer", "Member" });
            TableName.Location = new Point(614, 610);
            TableName.Margin = new Padding(2);
            TableName.Name = "TableName";
            TableName.Size = new Size(190, 29);
            TableName.TabIndex = 57;
            TableName.SelectedIndexChanged += TableName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(524, 614);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 58;
            label3.Text = "From:";
            label3.Click += label3_Click;
            // 
            // DeleteB
            // 
            DeleteB.BackColor = Color.Black;
            DeleteB.Cursor = Cursors.Hand;
            DeleteB.FlatStyle = FlatStyle.Flat;
            DeleteB.ForeColor = Color.Gold;
            DeleteB.Location = new Point(882, 604);
            DeleteB.Margin = new Padding(2);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(132, 43);
            DeleteB.TabIndex = 59;
            DeleteB.Text = "Delete";
            DeleteB.UseVisualStyleBackColor = false;
            DeleteB.Click += button1_Click_1;
            // 
            // Equipment_B
            // 
            Equipment_B.BackColor = Color.Black;
            Equipment_B.Cursor = Cursors.Hand;
            Equipment_B.FlatStyle = FlatStyle.Flat;
            Equipment_B.ForeColor = Color.Gold;
            Equipment_B.Location = new Point(536, 33);
            Equipment_B.Margin = new Padding(2);
            Equipment_B.Name = "Equipment_B";
            Equipment_B.Size = new Size(132, 43);
            Equipment_B.TabIndex = 60;
            Equipment_B.Text = "Equipment";
            Equipment_B.UseVisualStyleBackColor = false;
            Equipment_B.Click += Equipment_B_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(255, 255, 192);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(274, 611);
            txtID.Margin = new Padding(2);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(223, 28);
            txtID.TabIndex = 61;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // O_Managment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1164, 700);
            Controls.Add(txtID);
            Controls.Add(Equipment_B);
            Controls.Add(DeleteB);
            Controls.Add(label3);
            Controls.Add(TableName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Customer_B);
            Controls.Add(Trainer_B);
            Controls.Add(O_Management_DataView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "O_Managment";
            Text = "FrmManagment";
            ((System.ComponentModel.ISupportInitialize)O_Management_DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView O_Management_DataView;
        private Button Trainer_B;
        private Button Customer_B;
        private Label label1;
        private Label label2;
        private ComboBox TableName;
        private Label label3;
        private Button DeleteB;
        private Button Equipment_B;
        private TextBox txtID;
    }
}