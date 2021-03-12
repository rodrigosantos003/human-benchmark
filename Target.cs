using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanBenchmark
{
    class Target
    {
        public AimTest aimTest;
        Random random = new Random();
        Timer timer = new Timer();
        PictureBox target = new PictureBox();
        bool dies = true;
        bool dead = false;

        public void SpawnTarget()
        {
            target.Size = new Size(50, 50);
            target.BackColor = Color.Red;
            target.Location = new Point(random.Next(0, aimTest.Width - target.Width), random.Next(0, aimTest.Height - target.Height));
            target.Click += Target_Click;
            aimTest.Controls.Add(target);

            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 100;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!dies || dead) return;

            target.Size = new Size(target.Height - 2, target.Width - 2);
            target.Location = new Point(target.Left + 1, target.Top + 1);

            if (target.Width == 2)
            {
                target.Dispose();
                timer.Dispose();

                aimTest.MakeTarget();
                aimTest.misses++;
                aimTest.ReloadStats();
                dead = true;
            }
        }

        private void Target_Click(object sender, EventArgs e)
        {
            var target = (PictureBox)sender;
            aimTest.score++;
            aimTest.Controls.Remove(target);
            dead = true;

            target.Dispose();
            timer.Dispose();

            aimTest.ReloadStats();
            aimTest.MakeTarget();
        }
    }
}
