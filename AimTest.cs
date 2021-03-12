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
    public partial class AimTest : Form
    {
        public float score;
        Stopwatch stopwatch = new Stopwatch();
        int targetsLeft;
        public int misses;
        bool gameStarted = false;
        public AimTest()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
  
            lbl_Restart.Left = ClientSize.Width / 2 - lbl_Restart.Width / 2;
            lbl_Restart.Top = ClientSize.Height / 2 - lbl_Restart.Height / 2;

            lbl_Quit.Left = ClientSize.Width / 2 - lbl_Quit.Width / 2;
            lbl_Quit.Top = (ClientSize.Height / 2 - lbl_Quit.Height / 2) + lbl_Restart.Height;
        }

        public void MakeTarget()
        {
            if (targetsLeft == 0)
            {
                EndGame();
                return;
            }
            targetsLeft--;

            Target target = new Target();
            target.aimTest = this;
            target.SpawnTarget();
        }

        public void ReloadStats()
        {
            lbl_Score.Text = "Score - " + score;
            lbl_Misses.Text = "Misses - " + misses;
        }

        private void EndGame()
        {
            stopwatch.Stop();
            updateTimer.Stop();
            MessageBox.Show(lbl_Misses.Text + "\nTargets Per Minute - " + Convert.ToInt32((score / stopwatch.Elapsed.Seconds) * 60));
            gameStarted = false;
            lbl_Restart.Show();
            lbl_Quit.Show();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds / 10);

            if (elapsedTime == "60:00:00")
            {
                MessageBox.Show("Really? You just spent an entire hour in here? Oh god...");
                Application.Exit();
            }
            lbl_Time.Text = "Time - " + elapsedTime;
        }

        private void AimTest_MouseClick(object sender, MouseEventArgs e)
        {
            if (!gameStarted)
            {
                gameStarted = true;

                score = 0;
                misses = 0;
                targetsLeft = 50;

                lbl_Restart.Hide();
                lbl_Quit.Hide();

                stopwatch.Restart();
                updateTimer.Enabled = true;
                MakeTarget();
            }
        }

        private void AimTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Menu().Show();
        }

        private void AimTest_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
