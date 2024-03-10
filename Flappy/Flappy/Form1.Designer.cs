namespace Flappy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Timer = new System.Windows.Forms.Timer(components);
            Flappy = new PictureBox();
            Score = new Label();
            Highest = new Label();
            Dead = new Label();
            DeadI = new Label();
            ((System.ComponentModel.ISupportInitialize)Flappy).BeginInit();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Tick += Timer_Tick;
            // 
            // Flappy
            // 
            Flappy.BackColor = Color.Blue;
            Flappy.Location = new Point(225, 186);
            Flappy.Name = "Flappy";
            Flappy.Size = new Size(55, 45);
            Flappy.TabIndex = 0;
            Flappy.TabStop = false;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Bahnschrift", 40F, FontStyle.Bold);
            Score.ForeColor = Color.White;
            Score.Location = new Point(223, 3);
            Score.Name = "Score";
            Score.Size = new Size(58, 65);
            Score.TabIndex = 1;
            Score.Text = "0";
            Score.TextAlign = ContentAlignment.TopCenter;
            // 
            // Highest
            // 
            Highest.AutoSize = true;
            Highest.BackColor = Color.Transparent;
            Highest.Font = new Font("Bahnschrift", 40F, FontStyle.Bold);
            Highest.ForeColor = Color.White;
            Highest.Location = new Point(223, 380);
            Highest.Name = "Highest";
            Highest.Size = new Size(58, 65);
            Highest.TabIndex = 2;
            Highest.Text = "0";
            Highest.TextAlign = ContentAlignment.TopCenter;
            // 
            // Dead
            // 
            Dead.AutoSize = true;
            Dead.BackColor = Color.Transparent;
            Dead.Font = new Font("Bahnschrift", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dead.ForeColor = Color.White;
            Dead.Location = new Point(150, 153);
            Dead.Name = "Dead";
            Dead.Size = new Size(205, 81);
            Dead.TabIndex = 3;
            Dead.Text = "DEAD";
            Dead.TextAlign = ContentAlignment.TopCenter;
            // 
            // DeadI
            // 
            DeadI.AutoSize = true;
            DeadI.BackColor = Color.Transparent;
            DeadI.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold);
            DeadI.ForeColor = Color.White;
            DeadI.Location = new Point(110, 234);
            DeadI.Name = "DeadI";
            DeadI.Size = new Size(285, 33);
            DeadI.TabIndex = 4;
            DeadI.Text = "Press Enter to Restart";
            DeadI.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 450);
            Controls.Add(DeadI);
            Controls.Add(Dead);
            Controls.Add(Flappy);
            Controls.Add(Score);
            Controls.Add(Highest);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = " ";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Flappy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private PictureBox Flappy;
        private Label Score;
        private Label Highest;
        private Label Dead;
        private Label DeadI;
    }
}
