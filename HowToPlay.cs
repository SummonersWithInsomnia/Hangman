using System;
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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btn_return_to_game_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
