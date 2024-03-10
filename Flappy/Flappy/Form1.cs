namespace Flappy
{
    public partial class Form1 : Form
    {
        bool jump;
        int gravity = 15;
        int initialgspeed = 20;
        int gamespeed = 20;
        int score = 0;
        int highest;
        Random random = new Random();
        PictureBox tpipes = new PictureBox();
        PictureBox bpipes = new PictureBox();
        public Form1()
        {
            tpipes.Left = 200;
            bpipes.Left = 200;
            InitializeComponent();
            StartUp();
            PipeTop();
            PipeBottom();
        }
        private void PipeTop()
        {
            tpipes.Tag = "pipes";
            tpipes.BackgroundImage = Image.FromFile("C:/Users/Windows/source/repos/Flappy/Flappy/bin/Debug/net8.0-windows/FlappyAssets/toppipe.png");
            tpipes.BackgroundImageLayout = ImageLayout.Stretch;
            tpipes.BackColor = Color.Transparent;
            tpipes.Width = 85;
            tpipes.BringToFront();

            tpipes.Top = 0;
            tpipes.Left = 500;
            tpipes.Height = random.Next(140, 200);

            this.Controls.Add(tpipes);
        }
        private void PipeBottom()
        {
            bpipes.Tag = "pipes";
            bpipes.BackgroundImage = Image.FromFile("C:/Users/Windows/source/repos/Flappy/Flappy/bin/Debug/net8.0-windows/FlappyAssets/bottompipe.png");
            bpipes.BackgroundImageLayout = ImageLayout.Stretch;
            bpipes.BackColor = Color.Transparent;
            bpipes.Width = 85;
            bpipes.BringToFront();


            bpipes.Top = random.Next(300, 350);
            bpipes.Left = 500;
            bpipes.Height = 250;

            this.Controls.Add(bpipes);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Score.SendToBack();
            Highest.SendToBack();
            foreach (Control p in this.Controls)
            {
                if (p is PictureBox && (string)p.Tag == "pipes")
                {
                    p.Left -= gamespeed;
                }
            }

            //++ Scores and thingy
            if (bpipes.Left < -100)
            {
                score++;
                Score.Text = score.ToString();

                if (score % 5 == 0)
                {
                    gamespeed += 3;
                }

                if (score > highest)
                {
                    highest = score;
                    Highest.Text = highest.ToString();
                }
                PipeBottom();
                PipeTop();
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "pipes" && Flappy.Bounds.IntersectsWith(x.Bounds))
                {
                    Timer.Stop();
                    Dead.Visible = true;
                    DeadI.Visible = true;
                }
                else if (Flappy.Top > 380)
                {
                    Timer.Stop();
                    Dead.Visible = true;
                    DeadI.Visible = true;
                }
            }

            Flappy.Top += gravity;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jump)
            {
                Flappy.BackgroundImage = Image.FromFile("C:/Users/Windows/source/repos/Flappy/Flappy/bin/Debug/net8.0-windows/FlappyAssets/FlappyUp.png");
                gravity = -20;
            }
            if (e.KeyCode == Keys.Enter)
            {
                StartUp();
                Dead.Visible = false;
                DeadI.Visible = false;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jump)
            {
                Flappy.BackgroundImage = Image.FromFile("C:/Users/Windows/source/repos/Flappy/Flappy/bin/Debug/net8.0-windows/FlappyAssets/Flappy.png");
                gravity = 20;
            }
        }
        private void StartUp()
        {
            this.Text = "Flappy Bird - @rinn";
            Icon = new Icon(@"C:/Users/Windows/source/repos/Flappy/Flappy/bin/Debug/net8.0-windows/FlappyAssets/Flappy Bird.ico");
            this.BackgroundImage = Image.FromFile("C:/Users/Windows/source/repos/Flappy/Flappy/bin/Debug/net8.0-windows/FlappyAssets/flappybg.png");
            Flappy.BackgroundImageLayout = ImageLayout.Stretch;
            Flappy.BackColor = Color.Transparent;
            Flappy.BackgroundImage = Image.FromFile("C:/Users/Windows/source/repos/Flappy/Flappy/bin/Debug/net8.0-windows/FlappyAssets/Flappy.png");
            //Reset score,gamespeed and player position when dead
            score = 0;
            Score.Text = score.ToString();
            gamespeed = initialgspeed;
            Flappy.Top = 186;

            //Bring pipes to right outside the screen when dead
            tpipes.Left = 500;
            bpipes.Left = 500;
            this.DoubleBuffered = true;
            Timer.Start();
            Dead.Visible = false;
            DeadI.Visible = false;
        }


    }
}
