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
//
// // Declare ComboBox and TextBox for player input
//         private ComboBox cmbDifficulty;
//         private ComboBox cmbCategory;
//         private TextBox txtPlayerName;
//
//         public GameTitle()
//         {
//             InitializeComponent();
//             InitializeControls(); // Initialize controls
//             LoadCategories();
//             LoadDifficulties();
//         }
//
//         private void InitializeControls()
//         {
//             // Initialize and set properties for the player name TextBox
//             txtPlayerName = new TextBox
//             {
//                 Location = new Point(10, 10), // Set appropriate location
//                 Width = 200 // Set width
//             };
//             this.Controls.Add(txtPlayerName);
//
//             // Initialize and set properties for the difficulty ComboBox
//             cmbDifficulty = new ComboBox
//             {
//                 Location = new Point(10, 40), // Set appropriate location
//                 Width = 200 // Set width
//             };
//             this.Controls.Add(cmbDifficulty);
//
//             // Initialize and set properties for the category ComboBox
//             cmbCategory = new ComboBox
//             {
//                 Location = new Point(10, 70), // Set appropriate location
//                 Width = 200 // Set width
//             };
//             this.Controls.Add(cmbCategory);
//         }
//
//         private void LoadCategories()
//         {
//             // Load categories into the combo box
//             cmbCategory.Items.Add("Food");
//             cmbCategory.Items.Add("Dessert");
//             cmbCategory.Items.Add("Animals");
//             cmbCategory.Items.Add("Countries");
//             cmbCategory.Items.Add("Type of Vehicle");
//             cmbCategory.Items.Add("Colors");
//             cmbCategory.Items.Add("Sports");
//             cmbCategory.Items.Add("Instrument");
//         }
//
//         private void LoadDifficulties()
//         {
//             // Load difficulties into the combo box
//             cmbDifficulty.Items.Add("Easy");
//             cmbDifficulty.Items.Add("Medium");
//             cmbDifficulty.Items.Add("Hard");
//         }
//
//         private void btnStart_Click(object sender, EventArgs e)
//         {
//             string playerName = txtPlayerName.Text;
//             string selectedDifficulty = cmbDifficulty.SelectedItem?.ToString();
//             string selectedCategory = cmbCategory.SelectedItem?.ToString();
//
//             if (string.IsNullOrEmpty(playerName) || string.IsNullOrEmpty(selectedDifficulty) || string.IsNullOrEmpty(selectedCategory))
//             {
//                 MessageBox.Show("Please fill all fields before starting.");
//                 return;
//             }
//
//             // Start the game
//             MainForm mainForm = new MainForm(playerName, selectedDifficulty, selectedCategory);
//             mainForm.Show();
//             this.Hide();
//         }
//
//         private void btnExit_Click(object sender, EventArgs e)
//         {
//             Application.Exit();
//         }