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
    public partial class TypingTest : Form
    {
        #region Variaveis
        StreamReader rdr = new StreamReader(Path.GetFullPath(@"..\..\words.txt"));
        ArrayList palavras = new ArrayList();
        string linha;
        Random random = new Random();
        int letraAtual = 0;
        string palavraAtual;
        int letrasCertas = 0;
        int score = 0;
        int totalLetras = 0;
        int totalLetrasCertas = 0;
        float accuracy = 0;
        #endregion

        public TypingTest()
        {
            InitializeComponent();

            while ((linha = rdr.ReadLine()) != null)
            {
                palavras.Add(linha);
            }
            rdr.Close();
        }

        private void verificarTamanho()
        {
            float tamanho;

            panel_Word.AutoSize = false;
            panel_Word.Size = new Size(0, 0);

            foreach (Control x in panel_Word.Controls)
            {
                if (x is Label)
                {
                    tamanho = x.Font.SizeInPoints;
                    tamanho--;
                    x.Font = new Font(x.Font.Name, tamanho, x.Font.Style);
                }
            }

            panel_Word.AutoSize = true;
            panel_Word.Left = (this.ClientSize.Width - panel_Word.Width) / 2;

            if (panel_Word.Width > this.ClientSize.Width)
                verificarTamanho();
        }

        private void writeWord()
        {
            panel_Word.Controls.Clear();
            string palavraAntiga = palavraAtual;

            do { palavraAtual = palavras[random.Next(0, palavras.Count)].ToString(); }
            while (palavraAntiga == palavraAtual);


            panel_Word.Size = new Size(0, 0);

            for (int i = 0; i < palavraAtual.Length; i++)
            {
                Label label = new Label();
                label.Text = palavraAtual.Substring(i, 1).ToUpper();
                label.Font = new Font("Verdana", 16F, FontStyle.Bold);
                label.Margin = new Padding(0, 0, 0, 0);
                label.Padding = new Padding(0, 0, 0, 0);
                label.UseCompatibleTextRendering = true;
                label.AutoSize = true;
                label.Tag = i;
                panel_Word.Controls.Add(label);
            }

            panel_Word.AutoSize = true;
            panel_Word.Left = (this.ClientSize.Width - panel_Word.Width) / 2;

            if (panel_Word.Width > this.ClientSize.Width)
                verificarTamanho();

            totalLetras += palavraAtual.Length;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_Palavra.Text.Length < letraAtual)
            {
                foreach (Control x in panel_Word.Controls)
                {
                    if (x is Label && Convert.ToInt32(x.Tag) == letraAtual - 1)
                    {
                        x.ForeColor = Color.Black;
                        letrasCertas--;
                        letraAtual--;
                        break;
                    }
                }
                return;
            }

            foreach (Control x in panel_Word.Controls)
            {
                if (x is Label && Convert.ToInt32(x.Tag) == letraAtual)
                {
                    if (x.Text.ToUpper() == txt_Palavra.Text.Substring(txt_Palavra.Text.Length - 1, 1).ToUpper())
                    {
                        x.ForeColor = Color.Green;
                        letrasCertas++;
                        totalLetrasCertas++;
                        letraAtual++;
                    }
                    else
                    {
                        x.ForeColor = Color.Red;
                        letraAtual++;
                    }
                    break;
                }
            }

            if (txt_Palavra.Text.Length == palavraAtual.Length)
            {
                if (letrasCertas == palavraAtual.Length)
                    score++;
                lbl_palavras.Text = "Palavras Certas:" + score;
                writeWord();
                txt_Palavra.Text = "";
                letraAtual = 0;
                letrasCertas = 0;

            }
        }

        private void TypingTest_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_Start.Visible = false;
                txt_Palavra.Visible = true;
                txt_Palavra.Focus();
                writeWord();

                time.Enabled = true;
            }
        }

        private void resetTest()
        {
            time.Enabled = false;
            letraAtual = 0;
            letrasCertas = 0;
            score = 0;
            totalLetras = 0;
            totalLetrasCertas = 0;
            accuracy = 0;
            lbl_palavras.Text = "Palavras Certas: " + score;
            lbl_Start.Visible = true;
            txt_Palavra.Visible = false;
            panel_Word.Controls.Clear();
            this.Focus();
        }

        private void stats()
        {
            accuracy = (totalLetrasCertas * 100) / totalLetras;

            string WPM = "\nWPM: " + score;
            string nletras = "\nNumber of Letters; " + totalLetras;
            string totalCertas = "\nRight Letters: " + totalLetrasCertas;
            string per = "\nAccuracy: " + accuracy + "%";

            MessageBox.Show("Time's Over!\n" + WPM + nletras + totalCertas + per, "Stats");
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            time.Stop();
            stats();
            resetTest();
        }

        private void TypingTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Menu().Show();
        }
    }
}