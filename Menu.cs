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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            var test = (PictureBox)sender;

            switch (test.Name)
            {
                case "pb_TypingTest":
                    new TypingTest().Show();
                    Hide();
                    break;

                case "pb_NumberMemory":
                    new NumberMemory().Show();
                    Hide();
                    break;

                case "pb_ReactionTime":
                    new ReactionTime().Show();
                    Hide();
                    break;

                case "pb_NumberOrder":
                    new NumberOrder().Show();
                    Hide();
                    break;

                case "pb_WordMemory":
                    new WordMemory().Show();
                    Hide();
                    break;

                case "pb_AimTest":
                    new AimTest().Show();
                    Hide();
                    break;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
