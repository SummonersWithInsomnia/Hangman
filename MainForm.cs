using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MainForm : Form
    {
        // Dictionary of the Word List
        // <word, category>
        private Dictionary<string, string> wordList;

        private List<string> words;

        private string currentWord;
        
        // Score
        private int score = 0;
        
        // Level
        private int level = 1;
        
        // Wrong count
        private int wrongCount = 0;

        // Log the used buttons
        private HashSet<Button> usedButtons = new HashSet<Button>();
        
        // Resources of Hangman Photos
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
        
        public MainForm()
        {
            InitializeComponent();
            importWords();
            setupGame();
        }

        private string getWord()
        {
            Random random = new Random();
            int rIndex = random.Next(words.Count);
            return words[rIndex];
        }

        private void setupGame()
        {
            // Reset the wrong counter every level
            wrongCount = 0;
            pb_hanger.Image = hangmanPhotos[wrongCount];
            
            // Reset the buttons
            foreach (var button in usedButtons)
            {
                button.Visible = true;
            }

            currentWord = getWord();
            lb_category_value.Text = upperCaseFirstLetter(wordList[currentWord]);
            Console.WriteLine("Current word: " + currentWord);

            lb_input.Text = generateStars(currentWord);
        }

        private string upperCaseFirstLetter(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
        }

        private string generateStars(string word)
        {
            string stars = "";
            for (int i = 0; i < word.Length; i++)
            {
                stars += "*";
            }
            return stars;
        }

        private void resetGame()
        {
            score = 0;
            level = 1;
        }

        // To read words from file
        private void importWords()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            
            wordList = new Dictionary<string, string>();
            words = new List<string>();

            Stream stream = assembly.GetManifestResourceStream("Hangman.Resources.wordlist.txt");
            StreamReader reader = new StreamReader(stream);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                wordList.Add(values[0], values[1]);
                words.Add(values[0]);
            }
        }

        // To get the input from the buttons of the keyboard
        private void inputFromKeyBoard(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Console.WriteLine("Input form Keyboard: " + b.Text);

            if (checkLetter(b.Text))
            {
                b.Visible = false;
                
                // for reset the buttons
                usedButtons.Add(b);
            }
            
        }

        // To check the letter
        private bool checkLetter(string letter)
        {
            return false;
        }

        private void btn_back_to_menu_Click(object sender, EventArgs e)
        {
            // Using a new thread for switching to the GameTitle window
            Thread thread = new Thread(delegate() { new GameTitle().ShowDialog(); });
            thread.Start();
            this.Close();
        }

        private void btn_about_us_Click(object sender, EventArgs e)
        {
            // To pop up AboutUsForm
            using (AboutUsForm aboutUsForm = new AboutUsForm())
            {
                aboutUsForm.ShowDialog();
            }
        }
        
    }
}