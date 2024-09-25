using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Button button11;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Button button21;
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            button11 = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            button21 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            panel1.SuspendLayout();
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(502, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 27);
            label1.TabIndex = 30;
            label1.Text = "Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(554, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(15, 20);
            label2.TabIndex = 31;
            label2.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 25F);
            label3.Location = new System.Drawing.Point(320, 230);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 57);
            label3.TabIndex = 32;
            label3.Text = "_";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI", 25F);
            label4.Location = new System.Drawing.Point(354, 230);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 57);
            label4.TabIndex = 33;
            label4.Text = "_";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Segoe UI", 25F);
            label5.Location = new System.Drawing.Point(385, 230);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 57);
            label5.TabIndex = 34;
            label5.Text = "_";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Segoe UI", 25F);
            label6.Location = new System.Drawing.Point(418, 230);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 57);
            label6.TabIndex = 35;
            label6.Text = "_";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Segoe UI", 25F);
            label7.Location = new System.Drawing.Point(449, 230);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 57);
            label7.TabIndex = 36;
            label7.Text = "_";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Segoe UI", 25F);
            label8.Location = new System.Drawing.Point(482, 230);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(42, 57);
            label8.TabIndex = 37;
            label8.Text = "_";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Segoe UI", 25F);
            label9.Location = new System.Drawing.Point(513, 230);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(42, 57);
            label9.TabIndex = 38;
            label9.Text = "_";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Segoe UI", 25F);
            label10.Location = new System.Drawing.Point(545, 230);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(42, 57);
            label10.TabIndex = 39;
            label10.Text = "_";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(290, 26);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(75, 27);
            label11.TabIndex = 40;
            label11.Text = "Level:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(339, 54);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(18, 20);
            label12.TabIndex = 41;
            label12.Text = "1";
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.Color.Khaki;
            button11.Location = new System.Drawing.Point(33, 494);
            button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(81, 30);
            button11.TabIndex = 42;
            button11.Text = "About Us";
            button11.UseVisualStyleBackColor = false;
            button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(329, 116);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(120, 27);
            label13.TabIndex = 44;
            label13.Text = "Category:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(444, 116);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(21, 27);
            label14.TabIndex = 45;
            label14.Text = "-";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = global::Hangman.Properties.Resources.Hangman0;
            pictureBox1.Location = new System.Drawing.Point(61, 26);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(208, 266);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = global::Hangman.Properties.Resources.brick_panel;
            panel1.Controls.Add(button21);
            panel1.Location = new System.Drawing.Point(2, 489);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(690, 39);
            panel1.TabIndex = 43;
            // 
            // button21
            // 
            button21.BackColor = System.Drawing.Color.Khaki;
            button21.Location = new System.Drawing.Point(546, 5);
            button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button21.Name = "button21";
            button21.Size = new System.Drawing.Size(107, 30);
            button21.TabIndex = 46;
            button21.Text = "How to Play";
            button21.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Hangman.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(692, 530);
            this.Controls.Add(label14);
            this.Controls.Add(label13);
            this.Controls.Add(button11);
            this.Controls.Add(label12);
            this.Controls.Add(label11);
            this.Controls.Add(label10);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(pictureBox1);
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
            this.Controls.Add(panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 577);
            this.MinimumSize = new System.Drawing.Size(710, 577);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman [Created by Summoners With Insomnia]";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}