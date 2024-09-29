namespace Hangman
{
    partial class GameTitle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_start_game = new System.Windows.Forms.Label();
            this.lb_copyright = new System.Windows.Forms.Label();
            this.pb_hanging = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hanging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_start_game
            // 
            this.lb_start_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_start_game.Location = new System.Drawing.Point(249, 413);
            this.lb_start_game.Name = "lb_start_game";
            this.lb_start_game.Size = new System.Drawing.Size(227, 38);
            this.lb_start_game.TabIndex = 2;
            this.lb_start_game.Text = "Press to Start";
            this.lb_start_game.Click += new System.EventHandler(this.startGame);
            // 
            // lb_copyright
            // 
            this.lb_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_copyright.Location = new System.Drawing.Point(12, 497);
            this.lb_copyright.Name = "lb_copyright";
            this.lb_copyright.Size = new System.Drawing.Size(393, 24);
            this.lb_copyright.TabIndex = 3;
            this.lb_copyright.Text = "© 2024 Summoners with Insomnia. All right reserved.";
            this.lb_copyright.Click += new System.EventHandler(this.startGame);
            // 
            // pb_hanging
            // 
            this.pb_hanging.Image = global::Hangman.Properties.Resources.hanging;
            this.pb_hanging.Location = new System.Drawing.Point(286, 27);
            this.pb_hanging.Name = "pb_hanging";
            this.pb_hanging.Size = new System.Drawing.Size(134, 184);
            this.pb_hanging.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hanging.TabIndex = 2;
            this.pb_hanging.TabStop = false;
            this.pb_hanging.Click += new System.EventHandler(this.startGame);
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = global::Hangman.Properties.Resources.logo;
            this.pb_logo.Location = new System.Drawing.Point(136, 178);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(413, 125);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.startGame);
            // 
            // GameTitle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 530);
            this.Controls.Add(pb_logo);
            this.Controls.Add(this.pb_hanging);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 577);
            this.MinimumSize = new System.Drawing.Size(710, 577);
            this.Name = "GameTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Click += new System.EventHandler(this.startGame);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hanging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lb_copyright;
        private System.Windows.Forms.Label lb_start_game;
        private System.Windows.Forms.PictureBox pb_logo;
        #endregion

        private System.Windows.Forms.PictureBox pb_hanging;
    }
}