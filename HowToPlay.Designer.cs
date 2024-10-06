namespace Hangman
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.btn_return_to_game = new System.Windows.Forms.Button();
            this.lb_game_title = new System.Windows.Forms.Label();
            this.tb_how_to_play = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_return_to_game
            // 
            this.btn_return_to_game.BackColor = System.Drawing.Color.Lavender;
            this.btn_return_to_game.Location = new System.Drawing.Point(186, 322);
            this.btn_return_to_game.Margin = new System.Windows.Forms.Padding(2);
            this.btn_return_to_game.Name = "btn_return_to_game";
            this.btn_return_to_game.Size = new System.Drawing.Size(159, 32);
            this.btn_return_to_game.TabIndex = 0;
            this.btn_return_to_game.Text = "Return to Game";
            this.btn_return_to_game.UseVisualStyleBackColor = false;
            this.btn_return_to_game.Click += new System.EventHandler(this.btn_return_to_game_Click);
            // 
            // lb_game_title
            // 
            this.lb_game_title.AutoSize = true;
            this.lb_game_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_game_title.Font = new System.Drawing.Font("Segoe Print", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_game_title.Location = new System.Drawing.Point(168, 43);
            this.lb_game_title.Name = "lb_game_title";
            this.lb_game_title.Size = new System.Drawing.Size(191, 61);
            this.lb_game_title.TabIndex = 3;
            this.lb_game_title.Text = "Hangman";
            this.lb_game_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_how_to_play
            // 
            this.tb_how_to_play.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_how_to_play.Location = new System.Drawing.Point(27, 106);
            this.tb_how_to_play.Margin = new System.Windows.Forms.Padding(2);
            this.tb_how_to_play.Multiline = true;
            this.tb_how_to_play.Name = "tb_how_to_play";
            this.tb_how_to_play.Size = new System.Drawing.Size(483, 193);
            this.tb_how_to_play.TabIndex = 4;
            this.tb_how_to_play.Text = resources.GetString("tb_how_to_play.Text");
            this.tb_how_to_play.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(537, 383);
            this.Controls.Add(this.tb_how_to_play);
            this.Controls.Add(this.lb_game_title);
            this.Controls.Add(this.btn_return_to_game);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(555, 430);
            this.Name = "HowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to Play";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_return_to_game;
        private System.Windows.Forms.Label lb_game_title;
        private System.Windows.Forms.TextBox tb_how_to_play;
    }
}

