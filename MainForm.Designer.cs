using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Diagnostics.Eventing.Reader;

namespace Hangman
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// 

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btn_q;
            System.Windows.Forms.Button btn_w;
            System.Windows.Forms.Button btn_e;
            System.Windows.Forms.Button btn_r;
            System.Windows.Forms.Button btn_t;
            System.Windows.Forms.Button btn_y;
            System.Windows.Forms.Button btn_u;
            System.Windows.Forms.Button btn_i;
            System.Windows.Forms.Button btn_o;
            System.Windows.Forms.Button btn_p;
            System.Windows.Forms.Button btn_l;
            System.Windows.Forms.Button btn_k;
            System.Windows.Forms.Button btn_j;
            System.Windows.Forms.Button btn_h;
            System.Windows.Forms.Button btn_g;
            System.Windows.Forms.Button btn_f;
            System.Windows.Forms.Button btn_d;
            System.Windows.Forms.Button btn_s;
            System.Windows.Forms.Button btn_a;
            System.Windows.Forms.Button btn_m;
            System.Windows.Forms.Button btn_n;
            System.Windows.Forms.Button btn_b;
            System.Windows.Forms.Button btn_v;
            System.Windows.Forms.Button btn_c;
            System.Windows.Forms.Button btn_x;
            System.Windows.Forms.Button btn_z;
            System.Windows.Forms.Label lb_score;
            System.Windows.Forms.Label lb_score_value;
            System.Windows.Forms.Label lb_input0;
            System.Windows.Forms.Label lb_input1;
            System.Windows.Forms.Label lb_input2;
            System.Windows.Forms.Label lb_input3;
            System.Windows.Forms.Label lb_input4;
            System.Windows.Forms.Label lb_input5;
            System.Windows.Forms.Label lb_input6;
            System.Windows.Forms.Label lb_input7;
            System.Windows.Forms.Label lb_level;
            System.Windows.Forms.Label lb_level_value;
            System.Windows.Forms.Button btn_about_us;
            System.Windows.Forms.Label lb_category;
            System.Windows.Forms.Label lb_category_value;
            System.Windows.Forms.PictureBox pb_hanger;
            System.Windows.Forms.Panel pn_bar;
            System.Windows.Forms.Button btn_back_to_menu;
            btn_q = new System.Windows.Forms.Button();
            btn_w = new System.Windows.Forms.Button();
            btn_e = new System.Windows.Forms.Button();
            btn_r = new System.Windows.Forms.Button();
            btn_t = new System.Windows.Forms.Button();
            btn_y = new System.Windows.Forms.Button();
            btn_u = new System.Windows.Forms.Button();
            btn_i = new System.Windows.Forms.Button();
            btn_o = new System.Windows.Forms.Button();
            btn_p = new System.Windows.Forms.Button();
            btn_l = new System.Windows.Forms.Button();
            btn_k = new System.Windows.Forms.Button();
            btn_j = new System.Windows.Forms.Button();
            btn_h = new System.Windows.Forms.Button();
            btn_g = new System.Windows.Forms.Button();
            btn_f = new System.Windows.Forms.Button();
            btn_d = new System.Windows.Forms.Button();
            btn_s = new System.Windows.Forms.Button();
            btn_a = new System.Windows.Forms.Button();
            btn_m = new System.Windows.Forms.Button();
            btn_n = new System.Windows.Forms.Button();
            btn_b = new System.Windows.Forms.Button();
            btn_v = new System.Windows.Forms.Button();
            btn_c = new System.Windows.Forms.Button();
            btn_x = new System.Windows.Forms.Button();
            btn_z = new System.Windows.Forms.Button();
            lb_score = new System.Windows.Forms.Label();
            lb_score_value = new System.Windows.Forms.Label();
            lb_input0 = new System.Windows.Forms.Label();
            lb_input1 = new System.Windows.Forms.Label();
            lb_input2 = new System.Windows.Forms.Label();
            lb_input3 = new System.Windows.Forms.Label();
            lb_input4 = new System.Windows.Forms.Label();
            lb_input5 = new System.Windows.Forms.Label();
            lb_input6 = new System.Windows.Forms.Label();
            lb_input7 = new System.Windows.Forms.Label();
            lb_level = new System.Windows.Forms.Label();
            lb_level_value = new System.Windows.Forms.Label();
            btn_about_us = new System.Windows.Forms.Button();
            lb_category = new System.Windows.Forms.Label();
            lb_category_value = new System.Windows.Forms.Label();
            pb_hanger = new System.Windows.Forms.PictureBox();
            pn_bar = new System.Windows.Forms.Panel();
            btn_back_to_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(pb_hanger)).BeginInit();
            pn_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_q
            // 
            btn_q.BackColor = System.Drawing.Color.Lavender;
            btn_q.Location = new System.Drawing.Point(74, 319);
            btn_q.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_q.Name = "btn_q";
            btn_q.Size = new System.Drawing.Size(40, 40);
            btn_q.TabIndex = 0;
            btn_q.Text = "Q";
            btn_q.UseVisualStyleBackColor = false;
            btn_q.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_w
            // 
            btn_w.BackColor = System.Drawing.Color.Lavender;
            btn_w.Location = new System.Drawing.Point(130, 319);
            btn_w.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_w.Name = "btn_w";
            btn_w.Size = new System.Drawing.Size(40, 40);
            btn_w.TabIndex = 1;
            btn_w.Text = "W";
            btn_w.UseVisualStyleBackColor = false;
            btn_w.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_e
            // 
            btn_e.BackColor = System.Drawing.Color.Lavender;
            btn_e.Location = new System.Drawing.Point(186, 319);
            btn_e.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_e.Name = "btn_e";
            btn_e.Size = new System.Drawing.Size(40, 40);
            btn_e.TabIndex = 2;
            btn_e.Text = "E";
            btn_e.UseVisualStyleBackColor = false;
            btn_e.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_r
            // 
            btn_r.BackColor = System.Drawing.Color.Lavender;
            btn_r.Location = new System.Drawing.Point(242, 319);
            btn_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_r.Name = "btn_r";
            btn_r.Size = new System.Drawing.Size(40, 40);
            btn_r.TabIndex = 3;
            btn_r.Text = "R";
            btn_r.UseVisualStyleBackColor = false;
            btn_r.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_t
            // 
            btn_t.BackColor = System.Drawing.Color.Lavender;
            btn_t.Location = new System.Drawing.Point(298, 319);
            btn_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_t.Name = "btn_t";
            btn_t.Size = new System.Drawing.Size(40, 40);
            btn_t.TabIndex = 4;
            btn_t.Text = "T";
            btn_t.UseVisualStyleBackColor = false;
            btn_t.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_y
            // 
            btn_y.BackColor = System.Drawing.Color.Lavender;
            btn_y.Location = new System.Drawing.Point(354, 319);
            btn_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_y.Name = "btn_y";
            btn_y.Size = new System.Drawing.Size(40, 40);
            btn_y.TabIndex = 5;
            btn_y.Text = "Y";
            btn_y.UseVisualStyleBackColor = false;
            btn_y.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_u
            // 
            btn_u.BackColor = System.Drawing.Color.Lavender;
            btn_u.Location = new System.Drawing.Point(410, 319);
            btn_u.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_u.Name = "btn_u";
            btn_u.Size = new System.Drawing.Size(40, 40);
            btn_u.TabIndex = 6;
            btn_u.Text = "U";
            btn_u.UseVisualStyleBackColor = false;
            btn_u.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_i
            // 
            btn_i.BackColor = System.Drawing.Color.Lavender;
            btn_i.Location = new System.Drawing.Point(466, 319);
            btn_i.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_i.Name = "btn_i";
            btn_i.Size = new System.Drawing.Size(40, 40);
            btn_i.TabIndex = 7;
            btn_i.Text = "I";
            btn_i.UseVisualStyleBackColor = false;
            btn_i.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_o
            // 
            btn_o.BackColor = System.Drawing.Color.Lavender;
            btn_o.Location = new System.Drawing.Point(522, 319);
            btn_o.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_o.Name = "btn_o";
            btn_o.Size = new System.Drawing.Size(40, 40);
            btn_o.TabIndex = 8;
            btn_o.Text = "O";
            btn_o.UseVisualStyleBackColor = false;
            btn_o.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_p
            // 
            btn_p.BackColor = System.Drawing.Color.Lavender;
            btn_p.Location = new System.Drawing.Point(578, 319);
            btn_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_p.Name = "btn_p";
            btn_p.Size = new System.Drawing.Size(40, 40);
            btn_p.TabIndex = 9;
            btn_p.Text = "P";
            btn_p.UseVisualStyleBackColor = false;
            btn_p.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_l
            // 
            btn_l.BackColor = System.Drawing.Color.Lavender;
            btn_l.Location = new System.Drawing.Point(536, 364);
            btn_l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_l.Name = "btn_l";
            btn_l.Size = new System.Drawing.Size(40, 40);
            btn_l.TabIndex = 18;
            btn_l.Text = "L";
            btn_l.UseVisualStyleBackColor = false;
            btn_l.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_k
            // 
            btn_k.BackColor = System.Drawing.Color.Lavender;
            btn_k.Location = new System.Drawing.Point(480, 364);
            btn_k.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_k.Name = "btn_k";
            btn_k.Size = new System.Drawing.Size(40, 40);
            btn_k.TabIndex = 17;
            btn_k.Text = "K";
            btn_k.UseVisualStyleBackColor = false;
            btn_k.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_j
            // 
            btn_j.BackColor = System.Drawing.Color.Lavender;
            btn_j.Location = new System.Drawing.Point(424, 364);
            btn_j.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_j.Name = "btn_j";
            btn_j.Size = new System.Drawing.Size(40, 40);
            btn_j.TabIndex = 16;
            btn_j.Text = "J";
            btn_j.UseVisualStyleBackColor = false;
            btn_j.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_h
            // 
            btn_h.BackColor = System.Drawing.Color.Lavender;
            btn_h.Location = new System.Drawing.Point(368, 364);
            btn_h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_h.Name = "btn_h";
            btn_h.Size = new System.Drawing.Size(40, 40);
            btn_h.TabIndex = 15;
            btn_h.Text = "H";
            btn_h.UseVisualStyleBackColor = false;
            btn_h.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_g
            // 
            btn_g.BackColor = System.Drawing.Color.Lavender;
            btn_g.Location = new System.Drawing.Point(312, 364);
            btn_g.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_g.Name = "btn_g";
            btn_g.Size = new System.Drawing.Size(40, 40);
            btn_g.TabIndex = 14;
            btn_g.Text = "G";
            btn_g.UseVisualStyleBackColor = false;
            btn_g.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_f
            // 
            btn_f.BackColor = System.Drawing.Color.Lavender;
            btn_f.Location = new System.Drawing.Point(256, 364);
            btn_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_f.Name = "btn_f";
            btn_f.Size = new System.Drawing.Size(40, 40);
            btn_f.TabIndex = 13;
            btn_f.Text = "F";
            btn_f.UseVisualStyleBackColor = false;
            btn_f.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_d
            // 
            btn_d.BackColor = System.Drawing.Color.Lavender;
            btn_d.Location = new System.Drawing.Point(200, 364);
            btn_d.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_d.Name = "btn_d";
            btn_d.Size = new System.Drawing.Size(40, 40);
            btn_d.TabIndex = 12;
            btn_d.Text = "D";
            btn_d.UseVisualStyleBackColor = false;
            btn_d.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_s
            // 
            btn_s.BackColor = System.Drawing.Color.Lavender;
            btn_s.Location = new System.Drawing.Point(144, 364);
            btn_s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_s.Name = "btn_s";
            btn_s.Size = new System.Drawing.Size(40, 40);
            btn_s.TabIndex = 11;
            btn_s.Text = "S";
            btn_s.UseVisualStyleBackColor = false;
            btn_s.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_a
            // 
            btn_a.BackColor = System.Drawing.Color.Lavender;
            btn_a.Location = new System.Drawing.Point(88, 364);
            btn_a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_a.Name = "btn_a";
            btn_a.Size = new System.Drawing.Size(40, 40);
            btn_a.TabIndex = 10;
            btn_a.Text = "A";
            btn_a.UseVisualStyleBackColor = false;
            btn_a.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_m
            // 
            btn_m.BackColor = System.Drawing.Color.Lavender;
            btn_m.Location = new System.Drawing.Point(450, 409);
            btn_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_m.Name = "btn_m";
            btn_m.Size = new System.Drawing.Size(40, 40);
            btn_m.TabIndex = 26;
            btn_m.Text = "M";
            btn_m.UseVisualStyleBackColor = false;
            btn_m.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_n
            // 
            btn_n.BackColor = System.Drawing.Color.Lavender;
            btn_n.Location = new System.Drawing.Point(394, 409);
            btn_n.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_n.Name = "btn_n";
            btn_n.Size = new System.Drawing.Size(40, 40);
            btn_n.TabIndex = 25;
            btn_n.Text = "N";
            btn_n.UseVisualStyleBackColor = false;
            btn_n.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_b
            // 
            btn_b.BackColor = System.Drawing.Color.Lavender;
            btn_b.Location = new System.Drawing.Point(338, 409);
            btn_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_b.Name = "btn_b";
            btn_b.Size = new System.Drawing.Size(40, 40);
            btn_b.TabIndex = 24;
            btn_b.Text = "B";
            btn_b.UseVisualStyleBackColor = false;
            btn_b.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_v
            // 
            btn_v.BackColor = System.Drawing.Color.Lavender;
            btn_v.Location = new System.Drawing.Point(282, 409);
            btn_v.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_v.Name = "btn_v";
            btn_v.Size = new System.Drawing.Size(40, 40);
            btn_v.TabIndex = 23;
            btn_v.Text = "V";
            btn_v.UseVisualStyleBackColor = false;
            btn_v.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_c
            // 
            btn_c.BackColor = System.Drawing.Color.Lavender;
            btn_c.Location = new System.Drawing.Point(226, 409);
            btn_c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_c.Name = "btn_c";
            btn_c.Size = new System.Drawing.Size(40, 40);
            btn_c.TabIndex = 22;
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = false;
            btn_c.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_x
            // 
            btn_x.BackColor = System.Drawing.Color.Lavender;
            btn_x.Location = new System.Drawing.Point(170, 409);
            btn_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_x.Name = "btn_x";
            btn_x.Size = new System.Drawing.Size(40, 40);
            btn_x.TabIndex = 21;
            btn_x.Text = "X";
            btn_x.UseVisualStyleBackColor = false;
            btn_x.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // btn_z
            // 
            btn_z.BackColor = System.Drawing.Color.Lavender;
            btn_z.Location = new System.Drawing.Point(114, 409);
            btn_z.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_z.Name = "btn_z";
            btn_z.Size = new System.Drawing.Size(40, 40);
            btn_z.TabIndex = 20;
            btn_z.Text = "Z";
            btn_z.UseVisualStyleBackColor = false;
            btn_z.Click += new System.EventHandler(this.inputFromKeyBoard);
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.BackColor = System.Drawing.Color.Transparent;
            lb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_score.Location = new System.Drawing.Point(502, 26);
            lb_score.Name = "lb_score";
            lb_score.Size = new System.Drawing.Size(89, 29);
            lb_score.TabIndex = 30;
            lb_score.Text = "Score:";
            // 
            // lb_score_value
            // 
            lb_score_value.AutoSize = true;
            lb_score_value.BackColor = System.Drawing.Color.Transparent;
            lb_score_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_score_value.Location = new System.Drawing.Point(554, 54);
            lb_score_value.Name = "lb_score_value";
            lb_score_value.Size = new System.Drawing.Size(15, 20);
            lb_score_value.TabIndex = 31;
            lb_score_value.Text = "-";
            // 
            // lb_input0
            // 
            lb_input0.AutoSize = true;
            lb_input0.BackColor = System.Drawing.Color.Transparent;
            lb_input0.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input0.Location = new System.Drawing.Point(320, 230);
            lb_input0.Name = "lb_input0";
            lb_input0.Size = new System.Drawing.Size(42, 57);
            lb_input0.TabIndex = 32;
            lb_input0.Text = "_";
            // 
            // lb_input1
            // 
            lb_input1.AutoSize = true;
            lb_input1.BackColor = System.Drawing.Color.Transparent;
            lb_input1.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input1.Location = new System.Drawing.Point(354, 230);
            lb_input1.Name = "lb_input1";
            lb_input1.Size = new System.Drawing.Size(42, 57);
            lb_input1.TabIndex = 33;
            lb_input1.Text = "_";
            // 
            // lb_input2
            // 
            lb_input2.AutoSize = true;
            lb_input2.BackColor = System.Drawing.Color.Transparent;
            lb_input2.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input2.Location = new System.Drawing.Point(385, 230);
            lb_input2.Name = "lb_input2";
            lb_input2.Size = new System.Drawing.Size(42, 57);
            lb_input2.TabIndex = 34;
            lb_input2.Text = "_";
            // 
            // lb_input3
            // 
            lb_input3.AutoSize = true;
            lb_input3.BackColor = System.Drawing.Color.Transparent;
            lb_input3.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input3.Location = new System.Drawing.Point(418, 230);
            lb_input3.Name = "lb_input3";
            lb_input3.Size = new System.Drawing.Size(42, 57);
            lb_input3.TabIndex = 35;
            lb_input3.Text = "_";
            // 
            // lb_input4
            // 
            lb_input4.AutoSize = true;
            lb_input4.BackColor = System.Drawing.Color.Transparent;
            lb_input4.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input4.Location = new System.Drawing.Point(449, 230);
            lb_input4.Name = "lb_input4";
            lb_input4.Size = new System.Drawing.Size(42, 57);
            lb_input4.TabIndex = 36;
            lb_input4.Text = "_";
            // 
            // lb_input5
            // 
            lb_input5.AutoSize = true;
            lb_input5.BackColor = System.Drawing.Color.Transparent;
            lb_input5.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input5.Location = new System.Drawing.Point(482, 230);
            lb_input5.Name = "lb_input5";
            lb_input5.Size = new System.Drawing.Size(42, 57);
            lb_input5.TabIndex = 37;
            lb_input5.Text = "_";
            // 
            // lb_input6
            // 
            lb_input6.AutoSize = true;
            lb_input6.BackColor = System.Drawing.Color.Transparent;
            lb_input6.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input6.Location = new System.Drawing.Point(513, 230);
            lb_input6.Name = "lb_input6";
            lb_input6.Size = new System.Drawing.Size(42, 57);
            lb_input6.TabIndex = 38;
            lb_input6.Text = "_";
            // 
            // lb_input7
            // 
            lb_input7.AutoSize = true;
            lb_input7.BackColor = System.Drawing.Color.Transparent;
            lb_input7.Font = new System.Drawing.Font("Segoe UI", 25F);
            lb_input7.Location = new System.Drawing.Point(545, 230);
            lb_input7.Name = "lb_input7";
            lb_input7.Size = new System.Drawing.Size(42, 57);
            lb_input7.TabIndex = 39;
            lb_input7.Text = "_";
            // 
            // lb_level
            // 
            lb_level.AutoSize = true;
            lb_level.BackColor = System.Drawing.Color.Transparent;
            lb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_level.Location = new System.Drawing.Point(290, 26);
            lb_level.Name = "lb_level";
            lb_level.Size = new System.Drawing.Size(83, 29);
            lb_level.TabIndex = 40;
            lb_level.Text = "Level:";
            // 
            // lb_level_value
            // 
            lb_level_value.AutoSize = true;
            lb_level_value.BackColor = System.Drawing.Color.Transparent;
            lb_level_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_level_value.Location = new System.Drawing.Point(339, 54);
            lb_level_value.Name = "lb_level_value";
            lb_level_value.Size = new System.Drawing.Size(18, 20);
            lb_level_value.TabIndex = 41;
            lb_level_value.Text = "1";
            // 
            // btn_about_us
            // 
            btn_about_us.BackColor = System.Drawing.Color.Khaki;
            btn_about_us.Location = new System.Drawing.Point(33, 494);
            btn_about_us.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_about_us.Name = "btn_about_us";
            btn_about_us.Size = new System.Drawing.Size(81, 30);
            btn_about_us.TabIndex = 42;
            btn_about_us.Text = "About Us";
            btn_about_us.UseVisualStyleBackColor = false;
            btn_about_us.Click += new System.EventHandler(this.btn_about_us_Click);
            // 
            // lb_category
            // 
            lb_category.AutoSize = true;
            lb_category.BackColor = System.Drawing.Color.Transparent;
            lb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_category.Location = new System.Drawing.Point(329, 116);
            lb_category.Name = "lb_category";
            lb_category.Size = new System.Drawing.Size(125, 29);
            lb_category.TabIndex = 44;
            lb_category.Text = "Category:";
            // 
            // lb_category_value
            // 
            lb_category_value.AutoSize = true;
            lb_category_value.BackColor = System.Drawing.Color.Transparent;
            lb_category_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_category_value.Location = new System.Drawing.Point(444, 116);
            lb_category_value.Name = "lb_category_value";
            lb_category_value.Size = new System.Drawing.Size(22, 29);
            lb_category_value.TabIndex = 45;
            lb_category_value.Text = "-";
            // 
            // pb_hanger
            // 
            pb_hanger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pb_hanger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pb_hanger.ErrorImage = null;
            pb_hanger.Image = global::Hangman.Properties.Resources.hangman0;
            pb_hanger.Location = new System.Drawing.Point(61, 26);
            pb_hanger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb_hanger.Name = "pb_hanger";
            pb_hanger.Size = new System.Drawing.Size(208, 266);
            pb_hanger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_hanger.TabIndex = 29;
            pb_hanger.TabStop = false;
            // 
            // pn_bar
            // 
            pn_bar.BackgroundImage = global::Hangman.Properties.Resources.brick_panel;
            pn_bar.Controls.Add(btn_back_to_menu);
            pn_bar.Location = new System.Drawing.Point(2, 489);
            pn_bar.Name = "pn_bar";
            pn_bar.Size = new System.Drawing.Size(690, 39);
            pn_bar.TabIndex = 43;
            // 
            // btn_back_to_menu
            // 
            btn_back_to_menu.BackColor = System.Drawing.Color.Khaki;
            btn_back_to_menu.Location = new System.Drawing.Point(551, 5);
            btn_back_to_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_back_to_menu.Name = "btn_back_to_menu";
            btn_back_to_menu.Size = new System.Drawing.Size(107, 30);
            btn_back_to_menu.TabIndex = 46;
            btn_back_to_menu.Text = "Back to Menu";
            btn_back_to_menu.UseVisualStyleBackColor = false;
            btn_back_to_menu.Click += new System.EventHandler(this.btn_back_to_menu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Hangman.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(692, 530);
            this.Controls.Add(lb_category_value);
            this.Controls.Add(lb_category);
            this.Controls.Add(btn_about_us);
            this.Controls.Add(lb_level_value);
            this.Controls.Add(lb_level);
            this.Controls.Add(lb_input7);
            this.Controls.Add(lb_input6);
            this.Controls.Add(lb_input5);
            this.Controls.Add(lb_input4);
            this.Controls.Add(lb_input3);
            this.Controls.Add(lb_input2);
            this.Controls.Add(lb_input1);
            this.Controls.Add(lb_input0);
            this.Controls.Add(lb_score_value);
            this.Controls.Add(lb_score);
            this.Controls.Add(pb_hanger);
            this.Controls.Add(btn_m);
            this.Controls.Add(btn_n);
            this.Controls.Add(btn_b);
            this.Controls.Add(btn_v);
            this.Controls.Add(btn_c);
            this.Controls.Add(btn_x);
            this.Controls.Add(btn_z);
            this.Controls.Add(btn_l);
            this.Controls.Add(btn_k);
            this.Controls.Add(btn_j);
            this.Controls.Add(btn_h);
            this.Controls.Add(btn_g);
            this.Controls.Add(btn_f);
            this.Controls.Add(btn_d);
            this.Controls.Add(btn_s);
            this.Controls.Add(btn_a);
            this.Controls.Add(btn_p);
            this.Controls.Add(btn_o);
            this.Controls.Add(btn_i);
            this.Controls.Add(btn_u);
            this.Controls.Add(btn_y);
            this.Controls.Add(btn_t);
            this.Controls.Add(btn_r);
            this.Controls.Add(btn_e);
            this.Controls.Add(btn_w);
            this.Controls.Add(btn_q);
            this.Controls.Add(pn_bar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 577);
            this.MinimumSize = new System.Drawing.Size(710, 577);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(pb_hanger)).EndInit();
            pn_bar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}