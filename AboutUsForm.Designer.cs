namespace Hangman
{
    partial class AboutUsForm
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
            this.lb_group_number = new System.Windows.Forms.Label();
            this.lb_member_list = new System.Windows.Forms.Label();
            this.lb_course_info = new System.Windows.Forms.Label();
            this.btn_back_to_game = new System.Windows.Forms.Button();
            this.pn_top = new System.Windows.Forms.Panel();
            this.pn_bottom = new System.Windows.Forms.Panel();
            this.lb_members = new System.Windows.Forms.Label();
            this.lb_group_name = new System.Windows.Forms.Label();
            this.pn_top.SuspendLayout();
            this.pn_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_group_number
            // 
            this.lb_group_number.AutoSize = true;
            this.lb_group_number.BackColor = System.Drawing.Color.Transparent;
            this.lb_group_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_group_number.Location = new System.Drawing.Point(148, 73);
            this.lb_group_number.Name = "lb_group_number";
            this.lb_group_number.Size = new System.Drawing.Size(106, 29);
            this.lb_group_number.TabIndex = 0;
            this.lb_group_number.Text = "Group 7";
            // 
            // lb_member_list
            // 
            this.lb_member_list.AutoSize = true;
            this.lb_member_list.BackColor = System.Drawing.Color.Transparent;
            this.lb_member_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_member_list.Location = new System.Drawing.Point(100, 226);
            this.lb_member_list.Name = "lb_member_list";
            this.lb_member_list.Size = new System.Drawing.Size(188, 120);
            this.lb_member_list.TabIndex = 1;
            this.lb_member_list.Text = "Xiangyu Hou\r\nCorazon Marie Palencia\r\nLovely Cunanan\r\nDan Lu\r\nGary Simwawa\r\nDaniel" + " Eno\r\n";
            this.lb_member_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_course_info
            // 
            this.lb_course_info.AutoSize = true;
            this.lb_course_info.BackColor = System.Drawing.Color.Transparent;
            this.lb_course_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_course_info.Location = new System.Drawing.Point(19, 41);
            this.lb_course_info.Name = "lb_course_info";
            this.lb_course_info.Size = new System.Drawing.Size(386, 17);
            this.lb_course_info.TabIndex = 2;
            this.lb_course_info.Text = "SODV2101: Rapid Application Development - 24SEPMNFS2";
            this.lb_course_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back_to_game
            // 
            this.btn_back_to_game.BackColor = System.Drawing.Color.Lavender;
            this.btn_back_to_game.Location = new System.Drawing.Point(129, 385);
            this.btn_back_to_game.Name = "btn_back_to_game";
            this.btn_back_to_game.Size = new System.Drawing.Size(159, 32);
            this.btn_back_to_game.TabIndex = 3;
            this.btn_back_to_game.Text = "Back to Game";
            this.btn_back_to_game.UseVisualStyleBackColor = false;
            this.btn_back_to_game.Click += new System.EventHandler(this.btn_back_to_game_Click);
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.Lavender;
            this.pn_top.BackgroundImage = global::Hangman.Properties.Resources.brick_panel;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(426, 21);
            this.pn_top.TabIndex = 4;
            // 
            // pn_bottom
            // 
            this.pn_bottom.BackColor = System.Drawing.Color.Lavender;
            this.pn_bottom.BackgroundImage = global::Hangman.Properties.Resources.brick_panel;
            this.pn_bottom.Location = new System.Drawing.Point(0, 437);
            this.pn_bottom.Name = "pn_bottom";
            this.pn_bottom.Size = new System.Drawing.Size(426, 21);
            this.pn_bottom.TabIndex = 5;
            // 
            // lb_members
            // 
            this.lb_members.AutoSize = true;
            this.lb_members.BackColor = System.Drawing.Color.Transparent;
            this.lb_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_members.Location = new System.Drawing.Point(138, 187);
            this.lb_members.Name = "lb_members";
            this.lb_members.Size = new System.Drawing.Size(122, 29);
            this.lb_members.TabIndex = 6;
            this.lb_members.Text = "Members";
            // 
            // lb_group_name
            // 
            this.lb_group_name.AutoSize = true;
            this.lb_group_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_group_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_group_name.Location = new System.Drawing.Point(34, 118);
            this.lb_group_name.Name = "lb_group_name";
            this.lb_group_name.Size = new System.Drawing.Size(322, 29);
            this.lb_group_name.TabIndex = 7;
            this.lb_group_name.Text = "Summoners With Insomnia";
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(423, 460);
            this.Controls.Add(this.lb_group_name);
            this.Controls.Add(this.lb_members);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pn_bottom);
            this.Controls.Add(this.btn_back_to_game);
            this.Controls.Add(this.lb_course_info);
            this.Controls.Add(this.lb_member_list);
            this.Controls.Add(this.lb_group_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 460);
            this.Name = "AboutUsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.pn_top.ResumeLayout(false);
            this.pn_bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lb_group_name;

        private System.Windows.Forms.Label lb_members;

        #endregion

        private System.Windows.Forms.Label lb_group_number;
        private System.Windows.Forms.Label lb_member_list;
        private System.Windows.Forms.Label lb_course_info;
        private System.Windows.Forms.Button btn_back_to_game;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Panel pn_bottom;
    }
}