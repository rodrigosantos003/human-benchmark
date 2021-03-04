using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanBenchmark
{
    public partial class ReactionTime : Form
    {
        Stopwatch timer = new Stopwatch();
        Random random = new Random();
        bool roundStarted = false;
        bool gameStarted = false;
        bool onTime = false;
        int testes;
        int ronda;
        long totalTime = 0;
        public ReactionTime()
        {
            InitializeComponent();
        }

        private void onClick()
        {
            if (!gameStarted && totalTime > 0)
            {
                totalTime = 0;
                writeLabel("Click to start!");
                panel_testAmount.Enabled = true;
                panel_testAmount.Visible = true;
                return;
            }
            if (!gameStarted)
            {
                bool success = Int32.TryParse(txt_amountTests.Text, out testes);
                
                if(!success || testes <= 0)
                {
                    MessageBox.Show("You need to write a number bigger then 0!");
                    return;
                }
                ronda = testes;
                panel_testAmount.Enabled = false;
                panel_testAmount.Visible = false;
                gameStarted = true;
            }
            if (!roundStarted)
            {
                timer.Reset();
                this.BackColor = Color.DarkRed;
                writeLabel("Click when the \nscreen turns green!");
                delay.Interval = random.Next(500, 3000);
                delay.Enabled = true;
                roundStarted = true;
            }
            else if(roundStarted)
            {
                if (onTime)
                {
                    timer.Stop();
                    writeLabel(timer.ElapsedMilliseconds.ToString() + "ms\n Click to play again");
                    totalTime += timer.ElapsedMilliseconds;
                    roundStarted = false;
                    ronda--;
                    if (ronda == 0) finishGame();
                }
                else if(!onTime)
                {
                    delay.Stop();
                    timer.Stop();
                    writeLabel("You clicked too fast!\n Click to try again");
                    roundStarted = false;
                }
            }
        }
        private void ReactionTime_MouseClick(object sender, MouseEventArgs e)
        {
            onClick();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            onClick();
        }
        private void delay_Tick(object sender, EventArgs e)
        {
            onTime = true;

            label1.Text = "You can click now!";
            label1.Left = (this.ClientSize.Width / 2) - (label1.Width / 2);
            label1.Top = (this.ClientSize.Height / 2) - (label1.Height / 2);

            this.BackColor = Color.LimeGreen;

            delay.Enabled = false;

            timer.Start();
        }
        private void writeLabel(string text)
        {
            label1.Text = text;
            label1.Left = (this.ClientSize.Width / 2) - (label1.Width / 2);
            label1.Top = (this.ClientSize.Height / 2) - (label1.Height / 2);
        }
        private void finishGame()
        {
            gameStarted = false;
            this.BackColor = SystemColors.ActiveBorder;
            writeLabel("Reaction time:\n " + totalTime / testes + "ms\n Click to try again");
        }

        private void ReactionTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Menu().Show();
        }
    }
}
