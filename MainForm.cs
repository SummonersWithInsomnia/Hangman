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
            InitializeGameLabels();
        }

        // Labels for Lives, Attempts, and Wins
        private Label lblLives;
        private Label lblAttempts;
        private Label lblWins;

        // Variables to track the number of lives, attempts, and wins
        private int lives = 6; // Number of lives (same as number of hangman steps)
        private int attempts = 0; // Track the number of attempts
        private int wins = 0; // Track the number of wins

        private System.Windows.Forms.PictureBox pb_hanger;
        // Array to hold hangman drawings
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

        // Track incorrect guesses through keyboard clicks
        private int wrongLetter = 0;

        // Initialize labels for lives, attempts, and wins
        private void InitializeGameLabels()
        {
            // Label for Lives
            lblLives = new Label();
            lblLives.Text = $"Lives: {lives}";
            lblLives.Location = new Point(10, 10); // Adjust position as necessary
            lblLives.AutoSize = true;
            this.Controls.Add(lblLives);

            // Label for Attempts
            lblAttempts = new Label();
            lblAttempts.Text = $"Attempts: {attempts}";
            lblAttempts.Location = new Point(10, 30); // Adjust position as necessary
            lblAttempts.AutoSize = true;
            this.Controls.Add(lblAttempts);

            // Label for Wins
            lblWins = new Label();
            lblWins.Text = $"Wins: {wins}";
            lblWins.Location = new Point(10, 50); // Adjust position as necessary
            lblWins.AutoSize = true;
            this.Controls.Add(lblWins);
        }

        // Function to handle wrong letter guesses
        private void guessCounter()
        {
            wrongLetter++;
            attempts++;
            UpdateGameLabels(); // Update labels on each guess

            if (wrongLetter < hangmanPhotos.Length)
            {
                pb_hanger.Image = hangmanPhotos[wrongLetter];
            }
            else
            {
                // If max guesses are reached, show game over message
                MessageBox.Show("Game Over!");
                // Reset game or show menu
                ResetGame();
            }
        }

        // Method to update labels for lives, attempts, and wins
        private void UpdateGameLabels()
        {
            lblLives.Text = $"Lives: {lives - wrongLetter}";
            lblAttempts.Text = $"Attempts: {attempts}";
        }

        // Function to reset the game
        private void ResetGame()
        {
            wrongLetter = 0;
            attempts = 0;
            lives = 6;
            pb_hanger.Image = hangmanPhotos[0];
            UpdateGameLabels();
        }

        // Call this function when the player wins the game
        private void PlayerWins()
        {
            wins++;
            MessageBox.Show("You Win!");
            UpdateGameLabels();
            ResetGame();
        }

        // Dictionary to hold the Categories and words
        private Dictionary<string, List<string>> categoryWords = new Dictionary<string, List<string>>()
        {
            { "Food", new List<string> { "Barbeque", "Pancakes", "Meatballs", "Casserole", "Tortilla", "Coleslaw", "Dumpling", "Sandwich", "Macaroni", "Crabcake", "Bread", "Pizza", "Toast", "Tacos", "Sushi", "Bagel", "Steak", "Quiche", "Ramen", "Paella", "Rice", "Soup", "Beef", "Tuna", "Spam", "Eggs" } },
            { "Dessert", new List<string> { "Brownies", "Cupcakes", "Macarons", "Doughnut", "Tiramisu", "Pavlova", "Profiterole", "Fudge", "Crepe", "Trifle", "Cookie", "Pastry", "Mousse", "Parfait", "Gelato", "Sorbet", "Tart", "Pies", "Cake", "Flan" } },
            { "Animals", new List<string> { "Giraffes", "Elephant", "Flamingo", "Kangaroo", "Hedgehog", "Otter", "Horse", "Sheep", "Zebra", "Geese", "Rabbit", "Koala", "Tiger", "Lynx", "Elk", "Wolf", "Bear", "Frog", "Mole", "Cow" } },
            { "Countries", new List<string> { "Portugal", "Thailand", "Colombia", "Malaysia", "Nepal", "Chile", "Spain", "Egypt", "Italy", "Brazil", "China", "Kenya", "France", "Peru", "Cuba", "Laos", "Chad", "Mali", "Fiji", "Iraq", "Iran", "Oman" } },
            { "Type of Vehicle", new List<string> { "Tractor", "Ambulance", "Airplane", "Truck", "Train", "Yacht", "Scooter", "Sedan", "Trolley", "Boat", "Bike", "Jeep", "Tram", "Car", "Van", "Bus" } },
            { "Colors", new List<string> { "Lavender", "Amber", "Ivory", "Indigo", "Olive", "Peach", "Coral", "Mauve", "Blue", "Gold", "Pink", "Gray", "Aqua", "Lime", "Teal", "Plum" } },
            { "Sports", new List<string> { "Baseball", "Swimming", "Football", "Handball", "Softball", "Rugby", "Soccer", "Hockey", "Boxing", "Fencing", "Rowing", "Squash", "Judo", "Polo", "Dart", "Surf", "Yoga", "Dive", "Gold", "Ski" } },
            { "Instrument", new List<string> { "Saxophone", "Trombone", "Accordion", "Clarinet", "Mandolin", "Marimba", "Harmonica", "Violin", "Trumpet", "Flute", "Cello", "Banjo", "Piano", "Tuba", "Drums", "Conga", "Harp", "Oboe", "Bong", "Lyre", "Uke", "Bass" } }
        };

        // Difficulty point system
        private const int Easy = 5;
        private const int Medium = 10;
        private const int Hard = 15;

        // Method to determine word points by length
        private int wordPoints(string word)
        {
            if (word.Length >= 8)
            {
                return Easy;
            }
            else if (word.Length == 5 || word.Length == 6)
            {
                return Medium;
            }
            else
            {
                return Hard;
            }
        }

        private void inputFromKeyboard(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Console.WriteLine("Input from Keyboard: " + b.Text);
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
