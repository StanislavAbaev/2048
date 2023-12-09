using _2048.Common;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace _2048WinformsApp
{
    public partial class MainForm : Form
    {
        public static int MapSize = 4;
        private static Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private User user = new User();

        KeyEventArgs e;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var setUserNameForm = new SetUserNameForm();
            setUserNameForm.ShowDialog();
            user.Name = setUserNameForm.GetUserName();

            ResizeWindow();

            InitMap();
            GenerateNumber();
        }

        private void ResizeWindow()
        {
            if (MapSize >= 5)
            {
                this.Width = 85 * MapSize;
                this.Height = 100 * MapSize;
                scoreTextLabel.Location = new Point(5 * MapSize, 85 * MapSize);
                scoreLabel.Location = new Point(scoreTextLabel.Location.X + 40, scoreTextLabel.Location.Y);
            }
        }

        private void InitMap()
        {
            labelsMap = new Label[MapSize, MapSize];
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GenerateNumber()
        {
            if (!GameHasEnded())
                while (true)
                {
                    var randomNextNumber = random.Next(MapSize * MapSize);
                    var indexRow = randomNextNumber / MapSize;
                    var indexColumn = randomNextNumber % MapSize;
                    if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                    {
                        var randomNumber = random.Next(0, 100);
                        if (randomNumber >= 75)
                            labelsMap[indexRow, indexColumn].Text = "4";
                        else labelsMap[indexRow, indexColumn].Text = "2";
                        CheckCellBackgroundColor();
                        break;
                    }
                }
            else
            {
                MessageBox.Show($"Игра окончена, ваш счёт: {score} очков.");
                user.Score = score;
                UserResultsStorage.AddResultToStorage(user);
                Close();
            }

        }



        private Label CreateLabel(int indexRow, int indexColumn)
        {
            int distanceBetweenLabels = 6;
            int labelSidePixelsLength = 70;
            int xStartPosition = 10;
            int yStartPosition = 30;

            var label = new Label();
            label.BackColor = SystemColors.ActiveBorder;
            label.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.Name = "matrixLabel1";
            label.Size = new Size(labelSidePixelsLength, labelSidePixelsLength);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = xStartPosition + indexColumn * (labelSidePixelsLength + distanceBetweenLabels);
            int y = yStartPosition + indexRow * (labelSidePixelsLength + distanceBetweenLabels);
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            keyRightPressed(null, e);
            keyLeftPressed(null, e);
            keyUpPressed(null, e);
            keyDownPressed(null, e);
            scoreLabel.Text = score.ToString();
        }

        private void CheckCellBackgroundColor()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2" || labelsMap[i, j].Text == "4")
                        labelsMap[i, j].BackColor = Color.FromArgb(209, 188, 138);

                    else if (labelsMap[i, j].Text == "8") labelsMap[i, j].BackColor = Color.FromArgb(218, 165, 32);
                    else if (labelsMap[i, j].Text == "16") labelsMap[i, j].BackColor = Color.FromArgb(210, 105, 30);
                    else if (labelsMap[i, j].Text == "32") labelsMap[i, j].BackColor = Color.FromArgb(205, 92, 92);
                    else if (labelsMap[i, j].Text == "64") labelsMap[i, j].BackColor = Color.FromArgb(255, 0, 0);
                    else if (labelsMap[i, j].Text == "128") labelsMap[i, j].BackColor = Color.FromArgb(218, 165, 32);
                    else if (labelsMap[i, j].Text == "256") labelsMap[i, j].BackColor = Color.FromArgb(184, 134, 11);
                    else if (labelsMap[i, j].Text == "512") labelsMap[i, j].BackColor = Color.FromArgb(205, 133, 63);

                    else if (labelsMap[i, j].Text == "1024" || labelsMap[i, j].Text == "2048")
                        labelsMap[i, j].BackColor = Color.FromArgb(210, 105, 30);

                    else labelsMap[i, j].BackColor = SystemColors.ActiveBorder;
                }
            }
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)

                {
                    Controls.RemoveByKey("matrixLabel1");
                }
            }
            score = 0;
            scoreLabel.Text = score.ToString();
            InitMap();
            GenerateNumber();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение действия", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Двигайте цифры вверх вниз влево или право соединяя одинаковые цифры.\r\n" +
                "Для того, чтобы передвигать цифры водите пальцем в нужную сторону " +
                "или, в случае игры с компьютера, нажимайте по клавишам ← ↑ ↓ →", "Правила игры");
        }
        private void keyRightPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, k].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = MapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
                GenerateNumber();
            }
        }
        private void keyLeftPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, k].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < MapSize; i++)
                {
                    for (int j = 0; j < MapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < MapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
                GenerateNumber();
            }
        }
        private void keyUpPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = 0; i < MapSize; i++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[k, j].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = 0; i < MapSize; i++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < MapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
                GenerateNumber();
            }
        }
        private void keyDownPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = MapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[k, j].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < MapSize; j++)
                {
                    for (int i = MapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
                GenerateNumber();
            }
        }


        private int CountEmptyCells()
        {
            int clearCells = 0;
            for (int i = 0; i < MapSize; i++)

            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty) clearCells++;
                }
            }
            return clearCells;

        }

        private bool GameHasEnded()
        {
            if (CountEmptyCells() == 0) return true;
            return false;
        }

        private void showResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResults = new ShowAllResultsForm();
            userResults.ShowDialog();
        }

        private void deployResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.OverwritePrompt = true;

                var usersList = UserResultsStorage.GetUsersList();
                var textString = UserResultsStorage.SerializeList(usersList);

                using (var sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(textString);
                }
            }
        }
    }
}
