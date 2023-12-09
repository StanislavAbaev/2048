using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinformsApp
{
    public partial class SetUserNameForm : Form
    {
        public SetUserNameForm()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTextBox.Text)) startGameButton.Enabled = true;
            else startGameButton.Enabled = false;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            GetUserName();
            Close();
        }
        public string GetUserName()
        {
            return userNameTextBox.Text;
        }

        private void SetUserNameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text))
                userNameTextBox.Text = "Неизвестный пользватель";
            GetUserName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) MainForm.MapSize = 5;

            if (comboBox1.SelectedIndex == 1) MainForm.MapSize = 6;

            if (comboBox1.SelectedIndex == 2) MainForm.MapSize = 7;

        }
    }
}
