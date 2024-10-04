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



        // Using Dictionary to hold the Categories and words
        // We will have three word difficulty levels chosen at random, and each difficulty will have different points assigned

        private Dictionary<string, List<string>> categoryWords = new Dictionary<string, List<string>>() {

            { "Food", new List<string>
        {
            // Easy
            "Barbeque", "Pancakes", "Meatballs", "Casserole",
            "Tortilla", "Coleslaw", "Dumpling", "Sandwich",
            "Macaroni", "Crabcake",

            //Medium
            "Bread", "Pizza", "Toast", "Tacos", "Sushi", "Bagel", "Steak",
            "Quiche", "Ramen", "Paella",

            // Hard
            "Rice", "Soup", "Beef", "Tuna", "Spam", "Eggs"
            }
        },

            { "Dessert", new List<string>
        {
            // Easy
            "Brownies", "Cupcakes", "Macarons", "Doughnut", "Tiramisu",
            "Pavlova", "Profiterole",

            //Medium
            "Fudge", "Crepe", "Trifle", "Cookie", "Pastry", "Mousse",
            "Parfait", "Gelato", "Sorbet",

            // Hard
            "Tart", "Pies", "Cake", "Flan"
            }
        },
       

            { "Animals", new List<string>
        {
            // Easy
            "Giraffes", "Elephant", "Flamingo",
            "Kangaroo", "Hedgehog",

            //Medium
            "Otter", "Horse", "Sheep", "Zebra", "Geese", "Rabbit",
            "Koala", "Tiger",

            // Hard
            "Lynx", "Elk",  "Wolf", "Bear", "Frog", "Mole", "Cow"

            }
        },

            { "Countries", new List<string>
        {
            // Easy
            "Portugal", "Thailand", "Colombia", "Malaysia",

            //Medium
            "Nepal", "Chile", "Spain", "Egypt", "Italy", "Brazil",
            "China", "Kenya", "France",

            // Hard
            "Peru", "Cuba", "Laos", "Chad",  "Mali", "Fiji", "Iraq", "Iran", "Oman",
            }
        },

            { "Type of Vehicle", new List<string>
        {
            // Easy
            "Tractor", "Ambulance", "Airplane",

            //Medium
            "Truck", "Train", "Yacht", "Scooter", "Sedan",
            "Trolley", 
            // Hard
            "Boat", "Bike", "Jeep", "Tram", "Car" , "Van", "Bus",
            }
        },

            { "Colors", new List<string>
        {
            // Easy
            "Lavender",

            //Medium
            "Amber", "Ivory", "Indigo", "Olive",  "Peach",
            "Coral", "Mauve",

            // Hard
            "Blue", "Gold", "Pink", "Gray", "Aqua", "Lime", "Teal","Plum"
            }
        },


            { "Sports", new List<string>
        {
            // Easy
            "Baseball","Swimming", "Football",
            "Handball", "Softball",

            //Medium
            "Rugby", "Soccer", "Hockey", "Boxing", "Fencing",
            "Rowing", "Squash",

            // Hard
            "Judo", "Polo", "Dart", "Surf", "Yoga", "Dive", "Gold", "Ski"
            }
        },

            { "Instrument", new List<string>
        {
            // Easy
            "Saxophone", "Trombone", "Accordion", "Clarinet", "Mandolin",
            "Marimba", "Harmonica",

            //Medium
            "Violin", "Trumpet", "Flute", "Cello", "Banjo", "Piano",
            "Tuba", "Drums", "Conga",

            // Hard
            "Harp", "Oboe", "Bong", "Lyre", "Uke", "Bass"
            }
        }
    };


        // Difficulty point system
        private const int Easy = 5;
        private const int Medium = 10;
        private const int Hard = 15;

        // This method determines the word points by length
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
    }
}
