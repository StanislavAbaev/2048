using _2048.Common;
using Newtonsoft.Json;
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
    public partial class ShowAllResultsForm : Form
    {
        public ShowAllResultsForm()
        {
            InitializeComponent();
        }

        private void ShowAllResultsForm_Load(object sender, EventArgs e)
        {
            var usersString = FileProvider.GetData("results.json");
            if (usersString.Length >=1)
            {
                var usersList = JsonConvert.DeserializeObject<List<User>>(usersString);

                foreach (var user in usersList)
                {
                    dataGridView1.Rows.Add(user.Name, user.Score);
                }

                usersList = usersList.OrderBy(x => x.Score).ToList();

                userBestResultLabel.Text = $"Имя: {usersList[usersList.Count - 1].Name}  Рекрод: { usersList[usersList.Count - 1].Score}";
            }

        }

    }
}
