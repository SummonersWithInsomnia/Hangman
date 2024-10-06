namespace howToPlay
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
            this.return_btn = new System.Windows.Forms.Button();
            this.hangman_title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Lavender;
            this.return_btn.Location = new System.Drawing.Point(279, 503);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(238, 50);
            this.return_btn.TabIndex = 0;
            this.return_btn.Text = "Return to Game";
            this.return_btn.UseVisualStyleBackColor = false;
            // 
            // hangman_title
            // 
            this.hangman_title.AutoSize = true;
            this.hangman_title.BackColor = System.Drawing.Color.Transparent;
            this.hangman_title.Font = new System.Drawing.Font("Segoe Print", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangman_title.Location = new System.Drawing.Point(235, 59);
            this.hangman_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hangman_title.Name = "hangman_title";
            this.hangman_title.Size = new System.Drawing.Size(298, 94);
            this.hangman_title.TabIndex = 3;
            this.hangman_title.Text = "Hangman";
            this.hangman_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(40, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(722, 299);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 599);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hangman_title);
            this.Controls.Add(this.return_btn);
            this.Name = "HowToPlay";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Label hangman_title;
        private System.Windows.Forms.TextBox textBox1;
    }
}

