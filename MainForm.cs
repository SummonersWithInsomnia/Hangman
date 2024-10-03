using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.PictureBox pb_hanger;
        //Array to hold hangman drawings
        private Bitmap[] hangmanPhotos =
        {
            Hangman.Properties.Resources.hangman0,
            Hangman.Properties.Resources.hangman1,
            Hangman.Properties.Resources.hangman2,
            Hangman.Properties.Resources.hangman3,
            Hangman.Properties.Resources.hangman4,
            Hangman.Properties.Resources.hangman5,
            Hangman.Properties.Resources.hangman6,
        };

        //Track incorrect guesses though keyboard clicks
        private int wrongLetter = 0;

        //Function to handle wrong letter guesses
        private void guessCounter()
        {
            wrongLetter++;

            if (wrongLetter < hangmanPhotos.Length)
            {
                pb_hanger.Image = hangmanPhotos[wrongLetter];
            }

            else
            {
                // If max guesses are reached, show game over message
                MessageBox.Show("Game Over!");

                // or we add a button to reset the game and/or back to main menu
                //ResetGame();
            }
        }

        private void inputFromKeyboard(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Console.WriteLine("Input form Keyboard: " + b.Text);
        }
        
        private void btn_about_us_Click(object sender, EventArgs e)
        {
            using (AboutUsForm aboutUsForm = new AboutUsForm())
            {
                aboutUsForm.ShowDialog();
            }
        }

        private void btn_back_to_menu_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(delegate () { new GameTitle().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void pb_hanger_Click(object sender, EventArgs e)
        {

        }
    }
}
