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

        // Timer tick event handler for fading the image
        private void pbLogoFadeTimer_Tick(object sender, EventArgs e)
        {
            if (pbLogoOpacity < 255)
            {
                pbLogoOpacity += imgFadeSpeed;
                if (pbLogoOpacity > 255) pbLogoOpacity = 255;

                pb_logo.Image = applyOpacity(pb_logo.Image, pbLogoOpacity / 255f); // Opacity should be in the range of 0.0 - 1.0
            }
            else
            {
                pbLogoFadeTimer.Stop();
                this.Controls.Add(this.lb_copyright);
                this.Controls.Add(this.lb_start_game);
            }
        }

        // Method to apply opacity using a ColorMatrix
        private Image applyOpacity(Image img, float opacity)
        {
            if (img == null) return null;

            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Set opacity

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);
            }

            return bmp;
        }

        // Method to start the game when a button or label is clicked
        private void startGame(object sender, EventArgs e)
        {
            // Pass initial values for lives, attempts, and wins
            int initialLives = 6;
            int initialAttempts = 0;
            int initialWins = 0;

            Thread thread = new Thread(delegate () { new MainForm(initialLives, initialAttempts, initialWins).ShowDialog(); });
            thread.Start();
            this.Close();
        }
    }
}
