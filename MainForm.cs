using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MainForm : Form
    {
        // Fields to store parameters
        private string playerName;
        private string selectedDifficulty;
        private string selectedCategory;

        // Labels for Lives, Attempts, and Wins
        private Label lblLives;
        private Label lblAttempts;
        private Label lblWins;

        // Variables to track the number of lives, attempts, and wins
        private int lives = 6; // Number of lives (same as number of hangman steps)
        private int attempts = 0; // Track the number of attempts
        private int wins = 0; // Track the number of wins

        private PictureBox pb_hanger; // Initialize the PictureBox
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
            lblLives = new Label
            {
                Text = $"Lives: {lives}",
                Location = new Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(lblLives);

            // Label for Attempts
            lblAttempts = new Label
            {
                Text = $"Attempts: {attempts}",
                Location = new Point(10, 30),
                AutoSize = true
            };
            this.Controls.Add(lblAttempts);

            // Label for Wins
            lblWins = new Label
            {
                Text = $"Wins: {wins}",
                Location = new Point(10, 50),
                AutoSize = true
            };
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

            // Example usage of the parameters
            MessageBox.Show($"Welcome, {playerName}! You are playing with {selectedDifficulty} difficulty in the {selectedCategory} category.");
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
        
        // This function would pick a randomWord from the Dictionary
        public randomWordPick()
        {
        // Create a Random instance
        Random random = new Random();

        // Pick a random category from the dictionary
        var randomCategoryKey = categoryWords.Keys.ElementAt(random.Next(categoryWords.Count));

        // Retrieve the words from the selected category
        var wordsInCategory = categoryWords[randomCategoryKey];

        // Pick a random word from that category
        var randomWord = wordsInCategory[random.Next(wordsInCategory.Count)];
        }

        // This function would convert the randomzed word to a char array
        public convertToLetterArray()
        {
        
        char guessingLetters[] = randomWord.ToCharArray();
        }

        // this function would get button input and and check if its in the guessed word else it runs guessCounter function 
        public void CheckIfGuessRight(char buttonValue)
        {
        // this is for loop through the letters
        int numOfLetters = guessingLetters.Length;
        // set if word has been found
        bool match = false;
        // checking if parameter is in the guessed letter array which should be true
        bool init = guessingLetters.Contains(buttonValue);

        
        if (init)
        {
            match = true;
        }
        else
        {
            GuessCounter();
        }
        }
        
        // this is to a function to use to keep track of score
        public void ScoreKeeper(char buttonValue)
        {
        // initialize score as 0
        int score = 0;
        // if guess is right then gives score based on difficulty
        if (CheckIfGuessRight(buttonValue))
        {
            score += WordPoint(randomWord);
        }
        // so the score, doesnt change when added 
        else
        {
            score += 0;
        }

        }
