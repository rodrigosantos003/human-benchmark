using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanBenchmark
{
    public partial class NumberOrder : Form
    {
        int numbers = 4;
        int currentNumber = 1;
        int level = 1;
        Random random = new Random();
        List<int> positions = new List<int> { };

        public NumberOrder()
        {
            InitializeComponent();
            ShowPanel(panel_Start);

            for (int i = 1; i <= 25; i++)
                positions.Add(i);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_Game);
            MakeNumbers();
        }

        private void MakeNumbers()
        {
            for (int i = 1; i <= numbers; i++)
            {
                int index = random.Next(positions.Count);
                foreach (Control x in gamePanel.Controls)
                {
                    if (x is Label && x.Name == "pos" + positions[index])
                    {
                        x.Text = i.ToString();
                    }
                }
                positions.RemoveAt(index);
            }
        }
        private void ShowPanel(Panel x)
        {
            foreach (Panel panel in this.Controls)
            {
                panel.Visible = false;
            }
            x.Visible = true;
        }

        private void CheckNumber(object sender, EventArgs e)
        {
            var label = (Label)sender;

            if (label.Text == "1")
            {
                foreach (Control x in gamePanel.Controls)
                    if (x is Label && x.Text != "")
                    {
                        x.ForeColor = Color.White;
                        x.BackColor = Color.White;
                    }
            }

            if (label.Text == currentNumber.ToString())
            {
                currentNumber++;
                label.ForeColor = SystemColors.ActiveBorder;
                label.BackColor = SystemColors.ActiveBorder;
            }
            else
            {
                EndGame();
            }

            if (currentNumber == numbers + 1)
            {
                NextLevel();
            }
        }

        private void EndGame()
        {
            ShowPanel(panel_Stats);
            lbl_Level.Text = "You lost on\nlevel " + level;
            lbl_Level.Left = (this.ClientSize.Width / 2) - (lbl_Level.Width / 2);
        }

        private void NextLevel()
        {
            currentNumber = 1;

            foreach (Control x in gamePanel.Controls)
            {
                if (x is Label)
                {
                    x.Text = "";
                    x.BackColor = SystemColors.ActiveBorder;
                    x.ForeColor = SystemColors.ControlText;
                }
            }

            if (numbers < 25) numbers++;

            positions.Clear();

            for (int i = 1; i <= 25; i++)
                positions.Add(i);

            ShowPanel(panel_nextLevel);
            lbl_currentLevel.Text = "You finished\nlevel " + level;
            lbl_currentLevel.Left = (this.ClientSize.Width / 2) - (lbl_currentLevel.Width / 2);
        }

        private void btn_tryAgain_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_Start);
            numbers = 4;
            currentNumber = 1;
            level = 1;

            foreach (Control x in gamePanel.Controls)
            {
                if (x is Label)
                {
                    x.Text = "";
                    x.BackColor = SystemColors.ActiveBorder;
                    x.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void btn_nextLevel_Click(object sender, EventArgs e)
        {
            level++;
            ShowPanel(panel_Game);
            MakeNumbers();
        }

        private void NumberOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Menu().Show();
        }
    }
}
