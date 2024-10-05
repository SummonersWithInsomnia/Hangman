using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    public partial class GameTitle : Form
    {
        public GameTitle()
        {
            InitializeComponent();
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