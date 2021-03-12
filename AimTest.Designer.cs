
namespace HumanBenchmark
{
    partial class AimTest
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
            this.lbl_Score = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Misses = new System.Windows.Forms.Label();
            this.lbl_Restart = new System.Windows.Forms.Label();
            this.lbl_Quit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(12, 9);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(99, 25);
            this.lbl_Score.TabIndex = 1;
            this.lbl_Score.Text = "Score - 0";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 10;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(12, 34);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(132, 25);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "Time - 00:00";
            // 
            // lbl_Misses
            // 
            this.lbl_Misses.AutoSize = true;
            this.lbl_Misses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Misses.Location = new System.Drawing.Point(12, 59);
            this.lbl_Misses.Name = "lbl_Misses";
            this.lbl_Misses.Size = new System.Drawing.Size(111, 25);
            this.lbl_Misses.TabIndex = 3;
            this.lbl_Misses.Text = "Misses - 0";
            // 
            // lbl_Restart
            // 
            this.lbl_Restart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Restart.AutoSize = true;
            this.lbl_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Restart.Location = new System.Drawing.Point(194, 189);
            this.lbl_Restart.Name = "lbl_Restart";
            this.lbl_Restart.Size = new System.Drawing.Size(412, 73);
            this.lbl_Restart.TabIndex = 4;
            this.lbl_Restart.Text = "Click to Start!";
            // 
            // lbl_Quit
            // 
            this.lbl_Quit.AutoSize = true;
            this.lbl_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quit.Location = new System.Drawing.Point(285, 262);
            this.lbl_Quit.Name = "lbl_Quit";
            this.lbl_Quit.Size = new System.Drawing.Size(231, 25);
            this.lbl_Quit.TabIndex = 5;
            this.lbl_Quit.Text = "Press Escape to Exit";
            // 
            // AimTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Quit);
            this.Controls.Add(this.lbl_Restart);
            this.Controls.Add(this.lbl_Misses);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Score);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AimTest";
            this.Text = "AimTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AimTest_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AimTest_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AimTest_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Misses;
        private System.Windows.Forms.Label lbl_Restart;
        private System.Windows.Forms.Label lbl_Quit;
    }
}