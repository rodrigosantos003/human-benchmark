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
    public partial class NumberMemory : Form
    {
        int level = 1;
        string number;
        Random random = new Random();
        public NumberMemory()
        {
            InitializeComponent();
            mostrarPanel(panel_startGame);
        }

        private void mostrarPanel(Panel x)
        {
            foreach (Panel panel in this.Controls)
            {
                panel.Visible = false;
            }
            x.Visible = true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            mostrarPanel(panel_inGame);
            timer_TempoRestante.Enabled = true;
            makeNumber();
        }

        private void timer_TempoRestante_Tick(object sender, EventArgs e)
        {
            if (pbar_tempoRestante.Value > 0)
            {
                pbar_tempoRestante.Value -= 2;
            }
            else
            {
                mostrarPanel(panel_guessNumber);
                timer_TempoRestante.Enabled = false;
                txt_guessNumber.Focus();
            }
        }

        private void makeNumber()
        {
            number = "";
            for (int x = 0; x < level; x++)
            {
                number += random.Next(0, 9);
            }
            lbl_numero.Text = number;
            lbl_numero.Left = (this.ClientSize.Width / 2) - (lbl_numero.Width / 2);
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (number == txt_guessNumber.Text) showStats(true);
            else showStats(false);
        }

        private void showStats(bool rightNumber)
        {
            mostrarPanel(panel_Stats);
            btn_next.Focus();

            if (rightNumber)
            {
                lbl_guess.ForeColor = Color.Green;
                lbl_level.Text = "Level " + level;
                level++;
                btn_next.Text = "Next Level";
            }
            else
            {
                lbl_guess.ForeColor = Color.Red;
                lbl_level.Text = "You reached Level " + level;
                level = 1;
                btn_next.Text = "Try Again";
            }

            lbl_number.Text = number;
            lbl_guess.Text = txt_guessNumber.Text;
            txt_guessNumber.Text = "";
            lbl_level.Left = (this.ClientSize.Width / 2) - (lbl_level.Width / 2);
            lbl_number.Left = (this.ClientSize.Width / 2) - (lbl_number.Width / 2);
            lbl_guess.Left = (this.ClientSize.Width / 2) - (lbl_guess.Width / 2);
        }

        private void txt_guessNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) btn_Submit.PerformClick();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(btn_next.Text == "Next Level")
            {
                mostrarPanel(panel_inGame);
                pbar_tempoRestante.Value = 400;
                timer_TempoRestante.Enabled = true;
                makeNumber();
            }
            else
            {
                pbar_tempoRestante.Value = 400;
                number = "";
                mostrarPanel(panel_startGame);
            }
        }

        private void NumberMemory_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Menu().Show();
        }
    }
}
