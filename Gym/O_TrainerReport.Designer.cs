namespace Gym
{
    partial class O_TrainerReport
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
            DataView = new DataGridView();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)DataView).BeginInit();
            SuspendLayout();
            // 
            // DataView
            // 
            DataView.BackgroundColor = SystemColors.ActiveCaptionText;
            DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataView.GridColor = SystemColors.Info;
            DataView.Location = new Point(68, 46);
            DataView.Name = "DataView";
            DataView.Size = new Size(973, 533);
            DataView.TabIndex = 67;

            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Black;
            Refresh.Cursor = Cursors.Hand;
            Refresh.FlatStyle = FlatStyle.Flat;
            Refresh.ForeColor = Color.Gold;
            Refresh.Location = new Point(500, 615);
            Refresh.Margin = new Padding(2);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(132, 43);
            Refresh.TabIndex = 66;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // O_TrainerReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1146, 700);
            Controls.Add(DataView);
            Controls.Add(Refresh);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "O_TrainerReport";
            Text = "FrmTrainerReport";
            ((System.ComponentModel.ISupportInitialize)DataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataView;
        private Button Refresh;
    }
}