namespace _2048WinformsApp
{
    partial class MainForm
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
            scoreLabel = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            restartGameToolStripMenuItem = new ToolStripMenuItem();
            gameRulesToolStripMenuItem = new ToolStripMenuItem();
            выходИзИгрыToolStripMenuItem = new ToolStripMenuItem();
            showResultsToolStripMenuItem = new ToolStripMenuItem();
            scoreTextLabel = new Label();
            deployResultsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(69, 351);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(13, 15);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(322, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartGameToolStripMenuItem, gameRulesToolStripMenuItem, выходИзИгрыToolStripMenuItem, showResultsToolStripMenuItem, deployResultsToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // restartGameToolStripMenuItem
            // 
            restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            restartGameToolStripMenuItem.Size = new Size(196, 22);
            restartGameToolStripMenuItem.Text = "Перезапустить игру";
            restartGameToolStripMenuItem.Click += restartGameToolStripMenuItem_Click;
            // 
            // gameRulesToolStripMenuItem
            // 
            gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            gameRulesToolStripMenuItem.Size = new Size(196, 22);
            gameRulesToolStripMenuItem.Text = "Правила игры";
            gameRulesToolStripMenuItem.Click += gameRulesToolStripMenuItem_Click;
            // 
            // выходИзИгрыToolStripMenuItem
            // 
            выходИзИгрыToolStripMenuItem.Name = "выходИзИгрыToolStripMenuItem";
            выходИзИгрыToolStripMenuItem.Size = new Size(196, 22);
            выходИзИгрыToolStripMenuItem.Text = "Выход из игры";
            выходИзИгрыToolStripMenuItem.Click += exitGameToolStripMenuItem_Click;
            // 
            // showResultsToolStripMenuItem
            // 
            showResultsToolStripMenuItem.Name = "showResultsToolStripMenuItem";
            showResultsToolStripMenuItem.Size = new Size(196, 22);
            showResultsToolStripMenuItem.Text = "Показать результаты";
            showResultsToolStripMenuItem.Click += showResultsToolStripMenuItem_Click;
            // 
            // scoreTextLabel
            // 
            scoreTextLabel.AutoSize = true;
            scoreTextLabel.Location = new Point(27, 351);
            scoreTextLabel.Name = "scoreTextLabel";
            scoreTextLabel.Size = new Size(36, 15);
            scoreTextLabel.TabIndex = 2;
            scoreTextLabel.Text = "Счет:";
            // 
            // deployResultsToolStripMenuItem
            // 
            deployResultsToolStripMenuItem.Name = "deployResultsToolStripMenuItem";
            deployResultsToolStripMenuItem.Size = new Size(196, 22);
            deployResultsToolStripMenuItem.Text = "Выгрузить результаты";
            deployResultsToolStripMenuItem.Click += deployResultsToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 394);
            Controls.Add(scoreTextLabel);
            Controls.Add(scoreLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem restartGameToolStripMenuItem;
        private ToolStripMenuItem gameRulesToolStripMenuItem;
        private ToolStripMenuItem выходИзИгрыToolStripMenuItem;
        private Label label1;
        private Label scoreTextLabel;
        private ToolStripMenuItem showResultsToolStripMenuItem;
        private ToolStripMenuItem deployResultsToolStripMenuItem;
    }
}