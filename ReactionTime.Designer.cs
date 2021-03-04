
namespace HumanBenchmark
{
    partial class ReactionTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReactionTime));
            this.label1 = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.txt_amountTests = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_testAmount = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_testAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click to start!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // delay
            // 
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // txt_amountTests
            // 
            this.txt_amountTests.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_amountTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amountTests.Location = new System.Drawing.Point(113, 0);
            this.txt_amountTests.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amountTests.Name = "txt_amountTests";
            this.txt_amountTests.Size = new System.Drawing.Size(68, 15);
            this.txt_amountTests.TabIndex = 1;
            this.txt_amountTests.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount of Tests:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(113, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 1);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel_testAmount
            // 
            this.panel_testAmount.AutoSize = true;
            this.panel_testAmount.Controls.Add(this.label2);
            this.panel_testAmount.Controls.Add(this.pictureBox1);
            this.panel_testAmount.Controls.Add(this.txt_amountTests);
            this.panel_testAmount.Location = new System.Drawing.Point(224, 222);
            this.panel_testAmount.Margin = new System.Windows.Forms.Padding(4);
            this.panel_testAmount.Name = "panel_testAmount";
            this.panel_testAmount.Size = new System.Drawing.Size(185, 21);
            this.panel_testAmount.TabIndex = 4;
            // 
            // ReactionTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(633, 385);
            this.Controls.Add(this.panel_testAmount);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReactionTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReactionTime";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReactionTime_FormClosed);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReactionTime_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_testAmount.ResumeLayout(false);
            this.panel_testAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.TextBox txt_amountTests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_testAmount;
    }
}