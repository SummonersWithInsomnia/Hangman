﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btn_how_to_play_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
