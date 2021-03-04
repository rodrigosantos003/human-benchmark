
namespace HumanBenchmark
{
    partial class NumberMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberMemory));
            this.lbl_numero = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.timer_TempoRestante = new System.Windows.Forms.Timer(this.components);
            this.pbar_tempoRestante = new System.Windows.Forms.ProgressBar();
            this.panel_startGame = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_inGame = new System.Windows.Forms.Panel();
            this.panel_guessNumber = new System.Windows.Forms.Panel();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_guessNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Stats = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_guess = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_startGame.SuspendLayout();
            this.panel_inGame.SuspendLayout();
            this.panel_guessNumber.SuspendLayout();
            this.panel_Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(332, 122);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(47, 52);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "0";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.White;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(256, 238);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(200, 62);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer_TempoRestante
            // 
            this.timer_TempoRestante.Interval = 10;
            this.timer_TempoRestante.Tick += new System.EventHandler(this.timer_TempoRestante_Tick);
            // 
            // pbar_tempoRestante
            // 
            this.pbar_tempoRestante.Location = new System.Drawing.Point(223, 185);
            this.pbar_tempoRestante.Margin = new System.Windows.Forms.Padding(4);
            this.pbar_tempoRestante.Maximum = 400;
            this.pbar_tempoRestante.Name = "pbar_tempoRestante";
            this.pbar_tempoRestante.Size = new System.Drawing.Size(267, 18);
            this.pbar_tempoRestante.TabIndex = 2;
            this.pbar_tempoRestante.Value = 400;
            // 
            // panel_startGame
            // 
            this.panel_startGame.Controls.Add(this.label2);
            this.panel_startGame.Controls.Add(this.label1);
            this.panel_startGame.Controls.Add(this.btn_Start);
            this.panel_startGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_startGame.Location = new System.Drawing.Point(0, 0);
            this.panel_startGame.Margin = new System.Windows.Forms.Padding(4);
            this.panel_startGame.Name = "panel_startGame";
            this.panel_startGame.Size = new System.Drawing.Size(712, 506);
            this.panel_startGame.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Try to remember as much numbers as you can!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Memory";
            // 
            // panel_inGame
            // 
            this.panel_inGame.Controls.Add(this.pbar_tempoRestante);
            this.panel_inGame.Controls.Add(this.lbl_numero);
            this.panel_inGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_inGame.Location = new System.Drawing.Point(0, 0);
            this.panel_inGame.Margin = new System.Windows.Forms.Padding(4);
            this.panel_inGame.Name = "panel_inGame";
            this.panel_inGame.Size = new System.Drawing.Size(712, 506);
            this.panel_inGame.TabIndex = 8;
            // 
            // panel_guessNumber
            // 
            this.panel_guessNumber.Controls.Add(this.btn_Submit);
            this.panel_guessNumber.Controls.Add(this.txt_guessNumber);
            this.panel_guessNumber.Controls.Add(this.label4);
            this.panel_guessNumber.Controls.Add(this.label3);
            this.panel_guessNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_guessNumber.Location = new System.Drawing.Point(0, 0);
            this.panel_guessNumber.Margin = new System.Windows.Forms.Padding(4);
            this.panel_guessNumber.Name = "panel_guessNumber";
            this.panel_guessNumber.Size = new System.Drawing.Size(712, 506);
            this.panel_guessNumber.TabIndex = 6;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.White;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(276, 310);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(160, 49);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_guessNumber
            // 
            this.txt_guessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guessNumber.Location = new System.Drawing.Point(95, 238);
            this.txt_guessNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guessNumber.Name = "txt_guessNumber";
            this.txt_guessNumber.Size = new System.Drawing.Size(521, 46);
            this.txt_guessNumber.TabIndex = 2;
            this.txt_guessNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_guessNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Write the number inside the textbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Do you remember the number?";
            // 
            // panel_Stats
            // 
            this.panel_Stats.Controls.Add(this.btn_next);
            this.panel_Stats.Controls.Add(this.lbl_level);
            this.panel_Stats.Controls.Add(this.lbl_guess);
            this.panel_Stats.Controls.Add(this.label7);
            this.panel_Stats.Controls.Add(this.lbl_number);
            this.panel_Stats.Controls.Add(this.label5);
            this.panel_Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Stats.Location = new System.Drawing.Point(0, 0);
            this.panel_Stats.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Stats.Name = "panel_Stats";
            this.panel_Stats.Size = new System.Drawing.Size(712, 506);
            this.panel_Stats.TabIndex = 7;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.White;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(264, 414);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(184, 55);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.Location = new System.Drawing.Point(259, 308);
            this.lbl_level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(180, 54);
            this.lbl_level.TabIndex = 4;
            this.lbl_level.Text = "Level 1";
            // 
            // lbl_guess
            // 
            this.lbl_guess.AutoSize = true;
            this.lbl_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guess.Location = new System.Drawing.Point(339, 215);
            this.lbl_guess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_guess.Name = "lbl_guess";
            this.lbl_guess.Size = new System.Drawing.Size(33, 36);
            this.lbl_guess.TabIndex = 3;
            this.lbl_guess.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Your Guess";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(339, 92);
            this.lbl_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(33, 36);
            this.lbl_number.TabIndex = 1;
            this.lbl_number.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number";
            // 
            // NumberMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(712, 506);
            this.Controls.Add(this.panel_Stats);
            this.Controls.Add(this.panel_guessNumber);
            this.Controls.Add(this.panel_startGame);
            this.Controls.Add(this.panel_inGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NumberMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumberMemory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NumberMemory_FormClosed);
            this.panel_startGame.ResumeLayout(false);
            this.panel_startGame.PerformLayout();
            this.panel_inGame.ResumeLayout(false);
            this.panel_inGame.PerformLayout();
            this.panel_guessNumber.ResumeLayout(false);
            this.panel_guessNumber.PerformLayout();
            this.panel_Stats.ResumeLayout(false);
            this.panel_Stats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer timer_TempoRestante;
        private System.Windows.Forms.ProgressBar pbar_tempoRestante;
        private System.Windows.Forms.Panel panel_startGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_inGame;
        private System.Windows.Forms.Panel panel_guessNumber;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_guessNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Stats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_guess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Button btn_next;
    }
}