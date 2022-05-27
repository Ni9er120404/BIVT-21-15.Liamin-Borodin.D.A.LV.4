namespace BIVT_21_15_Liamin_Borodin.D.A._LV_4
{
    partial class Form1
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
            this.Gamer1 = new System.Windows.Forms.Label();
            this.Gamer2 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RebootGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteResultForGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadLastTheSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.Button();
            this.ResetScore = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gamer1
            // 
            this.Gamer1.AutoSize = true;
            this.Gamer1.Location = new System.Drawing.Point(12, 28);
            this.Gamer1.Name = "Gamer1";
            this.Gamer1.Size = new System.Drawing.Size(80, 20);
            this.Gamer1.TabIndex = 0;
            this.Gamer1.Text = "Игрок №1";
            this.Gamer1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Gamer2
            // 
            this.Gamer2.AutoSize = true;
            this.Gamer2.Location = new System.Drawing.Point(490, 28);
            this.Gamer2.Name = "Gamer2";
            this.Gamer2.Size = new System.Drawing.Size(80, 20);
            this.Gamer2.TabIndex = 1;
            this.Gamer2.Text = "Игрок №2";
            this.Gamer2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Location = new System.Drawing.Point(12, 48);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(17, 20);
            this.Score1.TabIndex = 2;
            this.Score1.Text = "0";
            this.Score1.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Location = new System.Drawing.Point(553, 48);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(17, 20);
            this.Score2.TabIndex = 3;
            this.Score2.Text = "0";
            this.Score2.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(276, 48);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(40, 20);
            this.Score.TabIndex = 4;
            this.Score.Text = "Счет";
            this.Score.Click += new System.EventHandler(this.Label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.RebootGameToolStripMenuItem,
            this.SaveGameToolStripMenuItem,
            this.DeleteResultForGameToolStripMenuItem,
            this.LoadLastTheSaveToolStripMenuItem});
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.GameToolStripMenuItem.Text = "Игра";
            this.GameToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.NewGameToolStripMenuItem.Text = "Новая игра";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // RebootGameToolStripMenuItem
            // 
            this.RebootGameToolStripMenuItem.Name = "RebootGameToolStripMenuItem";
            this.RebootGameToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.RebootGameToolStripMenuItem.Text = "Перезагрузить игру";
            this.RebootGameToolStripMenuItem.Click += new System.EventHandler(this.RebootGameToolStripMenuItem_Click);
            // 
            // SaveGameToolStripMenuItem
            // 
            this.SaveGameToolStripMenuItem.Name = "SaveGameToolStripMenuItem";
            this.SaveGameToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.SaveGameToolStripMenuItem.Text = "Сохранить игру";
            this.SaveGameToolStripMenuItem.Click += new System.EventHandler(this.SaveGameToolStripMenuItem_Click);
            // 
            // DeleteResultForGameToolStripMenuItem
            // 
            this.DeleteResultForGameToolStripMenuItem.Name = "DeleteResultForGameToolStripMenuItem";
            this.DeleteResultForGameToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.DeleteResultForGameToolStripMenuItem.Text = "Удалить результаты игры";
            this.DeleteResultForGameToolStripMenuItem.Click += new System.EventHandler(this.DeleteGameResultsToolStripMenuItem_Click);
            // 
            // LoadLastTheSaveToolStripMenuItem
            // 
            this.LoadLastTheSaveToolStripMenuItem.Name = "LoadLastTheSaveToolStripMenuItem";
            this.LoadLastTheSaveToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.LoadLastTheSaveToolStripMenuItem.Text = "Загрузить сохранение";
            this.LoadLastTheSaveToolStripMenuItem.Click += new System.EventHandler(this.UploadSaveToolStripMenuItem_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(12, 572);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(270, 29);
            this.NewGame.TabIndex = 6;
            this.NewGame.Text = "Новая игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // ResetScore
            // 
            this.ResetScore.Location = new System.Drawing.Point(300, 572);
            this.ResetScore.Name = "ResetScore";
            this.ResetScore.Size = new System.Drawing.Size(270, 29);
            this.ResetScore.TabIndex = 7;
            this.ResetScore.Text = "Сбросить счет";
            this.ResetScore.UseVisualStyleBackColor = true;
            this.ResetScore.Click += new System.EventHandler(this.ResetScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 613);
            this.Controls.Add(this.ResetScore);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.Gamer2);
            this.Controls.Add(this.Gamer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крестики нолики";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label Gamer1;
        private System.Windows.Forms.Label Gamer2;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RebootGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteResultForGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadLastTheSaveToolStripMenuItem;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button ResetScore;
    }
}