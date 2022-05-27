using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace BIVT_21_15_Liamin_Borodin.D.A._LV_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int X { get; } = 50;
        public int Y { get; set; } = 80;
        public int Motion { get; set; } = 0;
        public int Score_1 { get; set; }
        public int Score_2 { get; set; }
        public int[,] Table { get; } = new int[3, 3];
        public int Win { get; set; } = 0;
        public int Winx0 { get; set; } = 0;
        public int Winy0 { get; set; } = 0;
        public int Winx1 { get; set; } = 0;
        public int Winy1 { get; set; } = 0;
        public int First_Move { get; set; } = 0;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }
        private void Label5_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using Graphics g = e.Graphics;
            g.TranslateTransform(X, Y);
            g.DrawRectangle(new Pen(Color.Black, 3.0f), 0, 0, 450, 450);
            for (int i = 0; i < 450; i += 150)
            {
                g.DrawLine(new Pen(Color.Black, 1.0f), 0, i, 450, i);
                g.DrawLine(new Pen(Color.Black, 1.0f), i, 0, i, 450);
            }
            if ((Motion + First_Move) % 2 == 0)
            {
                Gamer1.BackColor = Color.BlanchedAlmond;
                Gamer2.BackColor = Color.White;
            }
            else
            {
                Gamer2.BackColor = Color.BlanchedAlmond;
                Gamer1.BackColor = Color.White;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Table[i, j] == 1)
                    {
                        g.DrawLine(new Pen(Color.Red, 5.0f), 10 + i * 150, 10 + j * 150, 140 + i * 150, 140 + j * 150);
                        g.DrawLine(new Pen(Color.Red, 5.0f), 140 + i * 150, 10 + j * 150, 10 + i * 150, 140 + j * 150);
                    }
                    if (Table[i, j] == 2)
                    {
                        g.DrawEllipse(new Pen(Color.Green, 5.0f), 10 + i * 150, 10 + j * 150, 130, 130);
                    }
                }
            }
            Score1.Text = Score_1.ToString();
            Score2.Text = Score_2.ToString();
            if (Win != 0)
            {
                g.DrawLine(new Pen(Color.Blue, 8.0f), Winx0, Winy0, Winx1, Winy1);
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button != MouseButtons.Left) || (e.X < X) || (e.X > X + 450) || (e.Y < Y) || (e.Y > Y + 450) ||
                (Table[(e.X - X) / 150, (e.Y - Y) / 150] != 0) || (Win != 0))
            {
                return;
            }

            if (Motion % 2 == 0)
            {
                Table[(e.X - X) / 150, (e.Y - Y) / 150] = 1;
            }
            else
            {
                Table[(e.X - X) / 150, (e.Y - Y) / 150] = 2;
            }

            Motion++;
            Invalidate();
            if (Table[0, 0] == 1 && Table[0, 1] == 1 && Table[0, 2] == 1)
            {
                Winx0 = 75;
                Winy0 = 10;
                Winx1 = 75;
                Winy1 = 440;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[0, 0] == 2 && Table[0, 1] == 2 && Table[0, 2] == 2)
            {
                Winx0 = 75;
                Winy0 = 10;
                Winx1 = 75;
                Winy1 = 440;
                Win = 1;
                Score_2++;
                MessageBox.Show("В этом матче выиграл игрок номер 2");
            }
            if (Table[1, 0] == 1 && Table[1, 1] == 1 && Table[1, 2] == 1)
            {
                Winx0 = 225;
                Winy0 = 10;
                Winx1 = 225;
                Winy1 = 440;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[1, 0] == 2 && Table[1, 1] == 2 && Table[1, 2] == 2)
            {
                Winx0 = 225;
                Winy0 = 10;
                Winx1 = 225;
                Winy1 = 440;
                Win = 1;
                Score_2++;
                MessageBox.Show("В этом матче выиграл игрок номер 2");
            }
            if (Table[2, 0] == 1 && Table[2, 1] == 1 && Table[2, 2] == 1)
            {
                Winx0 = 375;
                Winy0 = 10;
                Winx1 = 375;
                Winy1 = 440;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[0, 0] == 1 && Table[1, 0] == 1 & Table[2, 0] == 1)
            {
                Winx0 = 10;
                Winy0 = 75;
                Winx1 = 440;
                Winy1 = 75;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[0, 0] == 2 && Table[1, 0] == 2 && Table[2, 0] == 2)
            {
                Winx0 = 10;
                Winy0 = 75;
                Winx1 = 440;
                Winy1 = 75;
                Win = 1;
                Score_2++;
                MessageBox.Show("В этом матче выиграл игрок номер 2");
            }
            if (Table[0, 1] == 1 && Table[1, 1] == 1 && Table[2, 1] == 1)
            {
                Winx0 = 10;
                Winy0 = 225;
                Winx1 = 440;
                Winy1 = 225;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[0, 1] == 2 && Table[1, 1] == 2 && Table[2, 1] == 2)
            {
                Winx0 = 10;
                Winy0 = 225;
                Winx1 = 440;
                Winy1 = 225;
                Win = 1;
                Score_2++;
                MessageBox.Show("В этом матче выиграл игрок номер 2");
            }
            if (Table[0, 2] == 1 && Table[1, 2] == 1 && Table[2, 2] == 1)
            {
                Winx0 = 10;
                Winy0 = 375;
                Winx1 = 440;
                Winy1 = 375;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[0, 2] == 2 && Table[1, 2] == 2 && Table[2, 2] == 2)
            {
                Winx0 = 10;
                Winy0 = 375;
                Winx1 = 440;
                Winy1 = 375;
                Win = 1;
                Score_2++;
                MessageBox.Show("В этом матче выиграл игрок номер 2");
            }
            if (Table[0, 0] == 1 && Table[1, 1] == 1 && Table[2, 2] == 1)
            {
                Winx0 = 10;
                Winy0 = 10;
                Winx1 = 440;
                Winy1 = 440;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[0, 0] == 2 && Table[1, 1] == 2 && Table[2, 2] == 2)
            {
                Winx0 = 10;
                Winy0 = 10;
                Winx1 = 440;
                Winy1 = 440;
                Win = 1;
                Score_2++;
                MessageBox.Show("В этом матче выиграл игрок номер 2");
            }
            if (Table[2, 0] == 1 && Table[1, 1] == 1 && Table[0, 2] == 1)
            {
                Winx0 = 10;
                Winy0 = 440;
                Winx1 = 440;
                Winy1 = 10;
                Win = 1;
                Score_1++;
                MessageBox.Show("В этом матче выиграл игрок номер 1");
            }
            if (Table[0, 2] == 2 && Table[1, 1] == 2 && Table[2, 0] == 2)
            {
                Winx0 = 10;
                Winy0 = 440;
                Winx1 = 440;
                Winy1 = 10;
                Win = 1;
                Score_2++;
                MessageBox.Show("В этом матче выиграл игрок номер 2");
            }

            if ((Motion == 9) && (Win == 0))
            {
                MessageBox.Show("Поздравляю у вас ничья");
            }
        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }
        private void RebootGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetScore1();
        }
        private void SaveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Результаты игры.txt", string.Empty);
            using StreamWriter save = File.AppendText("Результаты игры.txt");
            save.WriteLine(Convert.ToString(Score_1));
            save.WriteLine(Convert.ToString(Score_2));
            save.Close();
        }
        private void DeleteGameResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Результаты игры.txt", string.Empty);
            using StreamWriter del = File.AppendText("Результаты игры.txt");
            del.WriteLine("0");
            del.WriteLine("0");
            del.Close();
        }
        private void UploadSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] res = File.ReadAllLines("Результаты игры.txt");
            Score1.Text = res[0].ToString();
            Score2.Text = res[1].ToString();
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            New();
        }
        private void ResetScore_Click(object sender, EventArgs e)
        {
            ResetScore1();
        }
        private void ResetScore1()
        {
            Score_1 = Score_2 = 0;
            New();
        }
        private void New()
        {
            Win = 0;
            Motion = 0;
            First_Move = 1 - First_Move;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Table[i, j] = 0;
                }
            }
            Invalidate();
        }
    }
}