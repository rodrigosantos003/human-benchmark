
namespace HumanBenchmark
{
    partial class WordMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordMemory));
            this.panel_Start = new System.Windows.Forms.Panel();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Game = new System.Windows.Forms.Panel();
            this.btn_seenWord = new System.Windows.Forms.Button();
            this.btn_newWord = new System.Windows.Forms.Button();
            this.lbl_word = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_lives = new System.Windows.Forms.Label();
            this.panel_Start.SuspendLayout();
            this.panel_Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Start
            // 
            this.panel_Start.Controls.Add(this.btn_Start);
            this.panel_Start.Controls.Add(this.label2);
            this.panel_Start.Controls.Add(this.label1);
            this.panel_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Start.Location = new System.Drawing.Point(0, 0);
            this.panel_Start.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Start.Name = "panel_Start";
            this.panel_Start.Size = new System.Drawing.Size(551, 524);
            this.panel_Start.TabIndex = 0;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(141, 331);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(267, 74);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click the buttons depending if you \r\nsaw the word already";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word Memory";
            // 
            // panel_Game
            // 
            this.panel_Game.Controls.Add(this.btn_seenWord);
            this.panel_Game.Controls.Add(this.btn_newWord);
            this.panel_Game.Controls.Add(this.lbl_word);
            this.panel_Game.Controls.Add(this.lbl_score);
            this.panel_Game.Controls.Add(this.lbl_lives);
            this.panel_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Game.Location = new System.Drawing.Point(0, 0);
            this.panel_Game.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Game.Name = "panel_Game";
            this.panel_Game.Size = new System.Drawing.Size(551, 524);
            this.panel_Game.TabIndex = 3;
            // 
            // btn_seenWord
            // 
            this.btn_seenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seenWord.Location = new System.Drawing.Point(324, 288);
            this.btn_seenWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seenWord.Name = "btn_seenWord";
            this.btn_seenWord.Size = new System.Drawing.Size(133, 49);
            this.btn_seenWord.TabIndex = 4;
            this.btn_seenWord.Text = "Seen";
            this.btn_seenWord.UseVisualStyleBackColor = true;
            this.btn_seenWord.Click += new System.EventHandler(this.btn_seenWord_Click);
            // 
            // btn_newWord
            // 
            this.btn_newWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newWord.Location = new System.Drawing.Point(92, 288);
            this.btn_newWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_newWord.Name = "btn_newWord";
            this.btn_newWord.Size = new System.Drawing.Size(133, 49);
            this.btn_newWord.TabIndex = 3;
            this.btn_newWord.Text = "New";
            this.btn_newWord.UseVisualStyleBackColor = true;
            this.btn_newWord.Click += new System.EventHandler(this.btn_newWord_Click);
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_word.Location = new System.Drawing.Point(185, 197);
            this.lbl_word.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(171, 52);
            this.lbl_word.TabIndex = 2;
            this.lbl_word.Text = "Palavra";
            // 
            // lbl_score
            // 
            this.lbl_score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(444, 11);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(86, 25);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "Score: 0";
            // 
            // lbl_lives
            // 
            this.lbl_lives.AutoSize = true;
            this.lbl_lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lives.Location = new System.Drawing.Point(16, 11);
            this.lbl_lives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lives.Name = "lbl_lives";
            this.lbl_lives.Size = new System.Drawing.Size(80, 25);
            this.lbl_lives.TabIndex = 0;
            this.lbl_lives.Text = "Lives: 3";
            // 
            // WordMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(551, 524);
            this.Controls.Add(this.panel_Game);
            this.Controls.Add(this.panel_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WordMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordMemory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordMemory_FormClosed);
            this.panel_Start.ResumeLayout(false);
            this.panel_Start.PerformLayout();
            this.panel_Game.ResumeLayout(false);
            this.panel_Game.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Start;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Game;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_lives;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Button btn_seenWord;
        private System.Windows.Forms.Button btn_newWord;
    }
}