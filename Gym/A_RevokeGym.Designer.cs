namespace Gym
{
    partial class A_RevokeGym
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            approvegymview = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            buttonview = new DataGridView();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)approvegymview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonview).BeginInit();
            SuspendLayout();
            // 
            // approvegymview
            // 
            approvegymview.AllowUserToAddRows = false;
            approvegymview.AllowUserToDeleteRows = false;
            approvegymview.AllowUserToOrderColumns = true;
            approvegymview.AllowUserToResizeColumns = false;
            approvegymview.AllowUserToResizeRows = false;
            approvegymview.BackgroundColor = Color.Black;
            approvegymview.BorderStyle = BorderStyle.None;
            approvegymview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            approvegymview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            approvegymview.ColumnHeadersVisible = false;
            approvegymview.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            approvegymview.DefaultCellStyle = dataGridViewCellStyle3;
            approvegymview.EnableHeadersVisualStyles = false;
            approvegymview.GridColor = Color.FromArgb(255, 255, 192);
            approvegymview.Location = new Point(63, 143);
            approvegymview.Name = "approvegymview";
            approvegymview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            approvegymview.RowHeadersVisible = false;
            approvegymview.RowHeadersWidth = 62;
            approvegymview.Size = new Size(783, 529);
            approvegymview.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "RequestID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 20F;
            Column2.HeaderText = "GymID";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Gym Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Visible = false;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Location";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Visible = false;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Owner Name";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Visible = false;
            Column5.Width = 150;
            // 
            // buttonview
            // 
            buttonview.BackgroundColor = Color.Black;
            buttonview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Gold;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            buttonview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            buttonview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            buttonview.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7 });
            buttonview.GridColor = Color.White;
            buttonview.Location = new Point(867, 143);
            buttonview.Name = "buttonview";
            buttonview.RowHeadersVisible = false;
            buttonview.RowHeadersWidth = 62;
            buttonview.Size = new Size(263, 529);
            buttonview.TabIndex = 13;
            buttonview.CellContentClick += buttonview_CellContentClick;
            // 
            // Column6
            // 
            Column6.FlatStyle = FlatStyle.Flat;
            Column6.HeaderText = "Approve";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Visible = false;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Disapprove";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            Column7.Visible = false;
            Column7.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(478, 101);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 17;
            label5.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(251, 101);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 16;
            label4.Text = "Gym Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(76, 101);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 15;
            label3.Text = "GymID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(478, 29);
            label2.Name = "label2";
            label2.Size = new Size(35, 37);
            label2.TabIndex = 19;
            label2.Text = "8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(76, 29);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 18;
            label1.Text = "Total Gyms:";
            // 
            // A_RevokeGym
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1161, 700);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonview);
            Controls.Add(approvegymview);
            FormBorderStyle = FormBorderStyle.None;
            Name = "A_RevokeGym";
            Text = "FrmRevokeGym";
            ((System.ComponentModel.ISupportInitialize)approvegymview).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView approvegymview;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView buttonview;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}