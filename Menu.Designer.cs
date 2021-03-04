
namespace HumanBenchmark
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbl_HumanBenchmark = new System.Windows.Forms.Label();
            this.lbl_SelectTest = new System.Windows.Forms.Label();
            this.lbl_Based = new System.Windows.Forms.Label();
            this.pb_AimTest = new System.Windows.Forms.PictureBox();
            this.pb_WordMemory = new System.Windows.Forms.PictureBox();
            this.pb_NumberOrder = new System.Windows.Forms.PictureBox();
            this.pb_ReactionTime = new System.Windows.Forms.PictureBox();
            this.pb_NumberMemory = new System.Windows.Forms.PictureBox();
            this.pb_TypingTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AimTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_WordMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NumberOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ReactionTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NumberMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TypingTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_HumanBenchmark
            // 
            this.lbl_HumanBenchmark.AutoSize = true;
            this.lbl_HumanBenchmark.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HumanBenchmark.Location = new System.Drawing.Point(143, 9);
            this.lbl_HumanBenchmark.Name = "lbl_HumanBenchmark";
            this.lbl_HumanBenchmark.Size = new System.Drawing.Size(496, 75);
            this.lbl_HumanBenchmark.TabIndex = 0;
            this.lbl_HumanBenchmark.Text = "Human Benchmark";
            // 
            // lbl_SelectTest
            // 
            this.lbl_SelectTest.AutoSize = true;
            this.lbl_SelectTest.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectTest.Location = new System.Drawing.Point(180, 93);
            this.lbl_SelectTest.Name = "lbl_SelectTest";
            this.lbl_SelectTest.Size = new System.Drawing.Size(422, 34);
            this.lbl_SelectTest.TabIndex = 1;
            this.lbl_SelectTest.Text = "Select the test you wanna take";
            // 
            // lbl_Based
            // 
            this.lbl_Based.AutoSize = true;
            this.lbl_Based.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Based.Location = new System.Drawing.Point(9, 527);
            this.lbl_Based.Name = "lbl_Based";
            this.lbl_Based.Size = new System.Drawing.Size(243, 17);
            this.lbl_Based.TabIndex = 8;
            this.lbl_Based.Text = "Based On Human Benchmark Website";
            // 
            // pb_AimTest
            // 
            this.pb_AimTest.BackColor = System.Drawing.Color.Transparent;
            this.pb_AimTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_AimTest.Image = global::HumanBenchmark.Properties.Resources.aim;
            this.pb_AimTest.Location = new System.Drawing.Point(600, 368);
            this.pb_AimTest.Name = "pb_AimTest";
            this.pb_AimTest.Size = new System.Drawing.Size(170, 130);
            this.pb_AimTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AimTest.TabIndex = 7;
            this.pb_AimTest.TabStop = false;
            this.pb_AimTest.Click += new System.EventHandler(this.Test_Click);
            // 
            // pb_WordMemory
            // 
            this.pb_WordMemory.BackColor = System.Drawing.Color.Transparent;
            this.pb_WordMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_WordMemory.Image = global::HumanBenchmark.Properties.Resources.word_memory;
            this.pb_WordMemory.Location = new System.Drawing.Point(306, 368);
            this.pb_WordMemory.Name = "pb_WordMemory";
            this.pb_WordMemory.Size = new System.Drawing.Size(170, 130);
            this.pb_WordMemory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_WordMemory.TabIndex = 6;
            this.pb_WordMemory.TabStop = false;
            this.pb_WordMemory.Click += new System.EventHandler(this.Test_Click);
            // 
            // pb_NumberOrder
            // 
            this.pb_NumberOrder.BackColor = System.Drawing.Color.Transparent;
            this.pb_NumberOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_NumberOrder.Image = global::HumanBenchmark.Properties.Resources.number_order;
            this.pb_NumberOrder.Location = new System.Drawing.Point(12, 368);
            this.pb_NumberOrder.Name = "pb_NumberOrder";
            this.pb_NumberOrder.Size = new System.Drawing.Size(170, 130);
            this.pb_NumberOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NumberOrder.TabIndex = 5;
            this.pb_NumberOrder.TabStop = false;
            this.pb_NumberOrder.Click += new System.EventHandler(this.Test_Click);
            // 
            // pb_ReactionTime
            // 
            this.pb_ReactionTime.BackColor = System.Drawing.Color.Transparent;
            this.pb_ReactionTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ReactionTime.Image = global::HumanBenchmark.Properties.Resources.reaction;
            this.pb_ReactionTime.Location = new System.Drawing.Point(600, 170);
            this.pb_ReactionTime.Name = "pb_ReactionTime";
            this.pb_ReactionTime.Size = new System.Drawing.Size(170, 130);
            this.pb_ReactionTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ReactionTime.TabIndex = 4;
            this.pb_ReactionTime.TabStop = false;
            this.pb_ReactionTime.Click += new System.EventHandler(this.Test_Click);
            // 
            // pb_NumberMemory
            // 
            this.pb_NumberMemory.BackColor = System.Drawing.Color.Transparent;
            this.pb_NumberMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_NumberMemory.Image = global::HumanBenchmark.Properties.Resources.number_memory;
            this.pb_NumberMemory.Location = new System.Drawing.Point(306, 170);
            this.pb_NumberMemory.Name = "pb_NumberMemory";
            this.pb_NumberMemory.Size = new System.Drawing.Size(170, 130);
            this.pb_NumberMemory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NumberMemory.TabIndex = 3;
            this.pb_NumberMemory.TabStop = false;
            this.pb_NumberMemory.Click += new System.EventHandler(this.Test_Click);
            // 
            // pb_TypingTest
            // 
            this.pb_TypingTest.BackColor = System.Drawing.Color.Transparent;
            this.pb_TypingTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_TypingTest.Image = global::HumanBenchmark.Properties.Resources.typing;
            this.pb_TypingTest.Location = new System.Drawing.Point(12, 170);
            this.pb_TypingTest.Name = "pb_TypingTest";
            this.pb_TypingTest.Size = new System.Drawing.Size(170, 130);
            this.pb_TypingTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_TypingTest.TabIndex = 2;
            this.pb_TypingTest.TabStop = false;
            this.pb_TypingTest.Click += new System.EventHandler(this.Test_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lbl_Based);
            this.Controls.Add(this.pb_AimTest);
            this.Controls.Add(this.pb_WordMemory);
            this.Controls.Add(this.pb_NumberOrder);
            this.Controls.Add(this.pb_ReactionTime);
            this.Controls.Add(this.pb_NumberMemory);
            this.Controls.Add(this.pb_TypingTest);
            this.Controls.Add(this.lbl_SelectTest);
            this.Controls.Add(this.lbl_HumanBenchmark);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pb_AimTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_WordMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NumberOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ReactionTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NumberMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TypingTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HumanBenchmark;
        private System.Windows.Forms.Label lbl_SelectTest;
        private System.Windows.Forms.PictureBox pb_TypingTest;
        private System.Windows.Forms.PictureBox pb_NumberMemory;
        private System.Windows.Forms.PictureBox pb_ReactionTime;
        private System.Windows.Forms.PictureBox pb_NumberOrder;
        private System.Windows.Forms.PictureBox pb_WordMemory;
        private System.Windows.Forms.PictureBox pb_AimTest;
        private System.Windows.Forms.Label lbl_Based;
    }
}