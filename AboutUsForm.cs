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
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        
        private void btn_back_to_game_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
