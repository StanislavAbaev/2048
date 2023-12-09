namespace _2048WinformsApp
{
    partial class ShowAllResultsForm
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
            dataGridView1 = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            userScoreColumn = new DataGridViewTextBoxColumn();
            bestResultLabel = new Label();
            userBestResultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, userScoreColumn });
            dataGridView1.Location = new Point(11, 10);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(485, 196);
            dataGridView1.TabIndex = 0;
            // 
            // userNameColumn
            // 
            userNameColumn.HeaderText = "Имя";
            userNameColumn.MinimumWidth = 10;
            userNameColumn.Name = "userNameColumn";
            userNameColumn.ReadOnly = true;
            userNameColumn.Width = 200;
            // 
            // userScoreColumn
            // 
            userScoreColumn.HeaderText = "Результат";
            userScoreColumn.MinimumWidth = 10;
            userScoreColumn.Name = "userScoreColumn";
            userScoreColumn.ReadOnly = true;
            userScoreColumn.Width = 200;
            // 
            // bestResultLabel
            // 
            bestResultLabel.AutoSize = true;
            bestResultLabel.Location = new Point(34, 257);
            bestResultLabel.Name = "bestResultLabel";
            bestResultLabel.Size = new Size(109, 15);
            bestResultLabel.TabIndex = 1;
            bestResultLabel.Text = "Лучший результат";
            // 
            // userBestResultLabel
            // 
            userBestResultLabel.AutoSize = true;
            userBestResultLabel.Location = new Point(158, 257);
            userBestResultLabel.Name = "userBestResultLabel";
            userBestResultLabel.Size = new Size(0, 15);
            userBestResultLabel.TabIndex = 2;
            // 
            // ShowAllResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 327);
            Controls.Add(userBestResultLabel);
            Controls.Add(bestResultLabel);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ShowAllResultsForm";
            Text = "ShowAllResults";
            Load += ShowAllResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn userScoreColumn;
        private Label bestResultLabel;
        private Label userBestResultLabel;
    }
}