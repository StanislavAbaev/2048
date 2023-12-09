namespace _2048WinformsApp
{
    partial class SetUserNameForm
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
            startGameButton = new Button();
            userNameTextBox = new TextBox();
            printUserNameLabel = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.Enabled = false;
            startGameButton.Location = new Point(68, 176);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(126, 23);
            startGameButton.TabIndex = 0;
            startGameButton.Text = "Начать игру";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(28, 67);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(207, 23);
            userNameTextBox.TabIndex = 1;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // printUserNameLabel
            // 
            printUserNameLabel.AutoSize = true;
            printUserNameLabel.Location = new Point(55, 34);
            printUserNameLabel.Name = "printUserNameLabel";
            printUserNameLabel.Size = new Size(153, 15);
            printUserNameLabel.TabIndex = 2;
            printUserNameLabel.Text = "Введите имя пользователя";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5x5", "6x6", "7x7" });
            comboBox1.Location = new Point(90, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(77, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 107);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 4;
            label1.Text = "Размер поля";
            // 
            // SetUserNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 220);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(printUserNameLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(startGameButton);
            Name = "SetUserNameForm";
            Text = "SetUserNameForm";
            FormClosed += SetUserNameForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameButton;
        private TextBox userNameTextBox;
        private Label printUserNameLabel;
        private ComboBox comboBox1;
        private Label label1;
    }
}