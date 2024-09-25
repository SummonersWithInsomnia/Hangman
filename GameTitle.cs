using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Hangman
{
    public partial class GameTitle : Form
    {
        private int pbLogoOpacity = 0;
        private const int imgFadeSpeed = 50;

        private Timer pbLogoFadeTimer;

        public GameTitle()
        {
            InitializeComponent();

            pbLogoFadeTimer = new Timer { Interval = 300 };
            pbLogoFadeTimer.Tick += pbLogoFadeTimer_Tick;
            pbLogoFadeTimer.Start();
        }

        private void pbLogoFadeTimer_Tick(object sender, EventArgs e)
        {
            if (pbLogoOpacity < 255)
            {
                pbLogoOpacity += imgFadeSpeed;
                if (pbLogoOpacity > 255) pbLogoOpacity = 255;
                pb_logo.Image = applyOpacity(pb_logo.Image, pbLogoOpacity);
            }
            else
            {
                pbLogoFadeTimer.Stop();
                this.Controls.Add(this.lb_copyright);
                this.Controls.Add(this.lb_start_game);
            }
        }

        private Image applyOpacity(Image img, float opacity)
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

        private void startGame(object sender, EventArgs e)
        {
            Thread thread = new Thread(delegate() { new MainForm().ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}