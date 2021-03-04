
namespace HumanBenchmark
{
    partial class TypingTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingTest));
            this.lbl_palavras = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.panel_Word = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Palavra = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_palavras
            // 
            this.lbl_palavras.AutoSize = true;
            this.lbl_palavras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_palavras.Location = new System.Drawing.Point(16, 11);
            this.lbl_palavras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_palavras.Name = "lbl_palavras";
            this.lbl_palavras.Size = new System.Drawing.Size(148, 20);
            this.lbl_palavras.TabIndex = 17;
            this.lbl_palavras.Text = "Palavras Certas: 0";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Start.ForeColor = System.Drawing.Color.Black;
            this.lbl_Start.Location = new System.Drawing.Point(29, 194);
            this.lbl_Start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(403, 59);
            this.lbl_Start.TabIndex = 16;
            this.lbl_Start.Text = "Press Enter to Start!";
            // 
            // panel_Word
            // 
            this.panel_Word.Location = new System.Drawing.Point(20, 160);
            this.panel_Word.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Word.Name = "panel_Word";
            this.panel_Word.Size = new System.Drawing.Size(440, 123);
            this.panel_Word.TabIndex = 14;
            // 
            // txt_Palavra
            // 
            this.txt_Palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Palavra.Location = new System.Drawing.Point(233, 181);
            this.txt_Palavra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Palavra.Name = "txt_Palavra";
            this.txt_Palavra.Size = new System.Drawing.Size(12, 9);
            this.txt_Palavra.TabIndex = 15;
            this.txt_Palavra.Visible = false;
            this.txt_Palavra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // time
            // 
            this.time.Interval = 60000;
            this.time.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // TypingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(472, 444);
            this.Controls.Add(this.lbl_palavras);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.panel_Word);
            this.Controls.Add(this.txt_Palavra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TypingTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypingTest_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TypingTest_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_palavras;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.FlowLayoutPanel panel_Word;
        private System.Windows.Forms.TextBox txt_Palavra;
        private System.Windows.Forms.Timer time;
    }
}