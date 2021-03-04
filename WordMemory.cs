using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanBenchmark
{
    public partial class WordMemory : Form
    {
        int lives = 3;
        int score = 0;
        StreamReader rdr = new StreamReader(Path.GetFullPath(@"..\..\words.txt"));
        ArrayList palavras = new ArrayList();
        ArrayList palavrasUsadas = new ArrayList();
        Random random = new Random();
        string linha;
        public WordMemory()
        {
            InitializeComponent();
            while ((linha = rdr.ReadLine()) != null)
            {
                palavras.Add(linha);
            }
            rdr.Close();

            ShowPanel(panel_Start);
        }

        private void ShowPanel(Panel x)
        {
            foreach (Panel panel in this.Controls)
            {
                panel.Visible = false;
            }
            x.Visible = true;
        }

        private void UpdateInfo()
        {
            lbl_score.Text = "Score: " + score;
            lbl_score.Left = this.ClientSize.Width - lbl_score.Width - 12;

            lbl_lives.Text = "Lives: " + lives;

            if(lives == 0)
            {
                MessageBox.Show("You reached a score of: " + score);
                ShowPanel(panel_Start);
                palavrasUsadas.Clear();
                lives = 3;
                score = 0;
            }
        }

        private void WriteWord()
        {
            lbl_word.Text = palavras[random.Next(palavras.Count)].ToString();

            lbl_word.Left = (this.ClientSize.Width / 2) - (lbl_word.Width / 2);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_Game);
            WriteWord();
        }

        private void btn_newWord_Click(object sender, EventArgs e)
        {
            if (palavrasUsadas.Contains(lbl_word.Text))
                lives--;
            else
            {
                score++;
                palavrasUsadas.Add(lbl_word.Text);
            }
            UpdateInfo();
            WriteWord();
        }

        private void btn_seenWord_Click(object sender, EventArgs e)
        {
            if (palavrasUsadas.Contains(lbl_word.Text))
                score++;
            else
                lives--;
            UpdateInfo();
            WriteWord();
        }

        private void WordMemory_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Menu().Show();
        }
    }
}