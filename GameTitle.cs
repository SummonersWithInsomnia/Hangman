using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Hangman
{
    public partial class GameTitle : Form
    {
        // Values of Animation of Logo
        private int pbLogoOpacity = 0;
        private Timer pbLogoFadeTimer;
        private const int ImgFadeSpeed = 50;
        
        public GameTitle()
        {
            InitializeComponent();
            
            // Timer of Animation
            pbLogoFadeTimer = new Timer { Interval = 100 };
            pbLogoFadeTimer.Tick += pbLogoFadeTimer_Tick;
            pbLogoFadeTimer.Start();
        }
        
        // Tick of Timer
        private void pbLogoFadeTimer_Tick(object sender, EventArgs e)
        {
            if (pbLogoOpacity < 255)
            {
                pbLogoOpacity += ImgFadeSpeed;
                if (pbLogoOpacity > 255) pbLogoOpacity = 255;
                pb_logo.Image = ApplyOpacity(pb_logo.Image, pbLogoOpacity);
            }
            else
            {
                pbLogoFadeTimer.Stop();
                this.Controls.Add(this.lb_copyright);
                this.Controls.Add(this.lb_start_game);
            }
        }
        
        // Calculate the logo image to apply the opacity
        private Image ApplyOpacity(Image img, float opacity)
        {
            Bitmap bmp = new Bitmap(img);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        Color newColor = Color.FromArgb((int)(opacity), pixelColor);
                        bmp.SetPixel(x, y, newColor);
                    }
                }
            }
            return bmp;
        }

        private void StartGame(object sender, EventArgs e)
        {
            // Using a new thread for switching to the MainForm window
            Thread thread = new Thread(delegate() { new MainForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}