//namespace Hangman
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "Form1";
//        }

//        #endregion
//    }
//}
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button6;
            System.Windows.Forms.Button button7;
            System.Windows.Forms.Button button8;
            System.Windows.Forms.Button button9;
            System.Windows.Forms.Button button10;
            System.Windows.Forms.Button button12;
            System.Windows.Forms.Button button13;
            System.Windows.Forms.Button button14;
            System.Windows.Forms.Button button15;
            System.Windows.Forms.Button button16;
            System.Windows.Forms.Button button17;
            System.Windows.Forms.Button button18;
            System.Windows.Forms.Button button19;
            System.Windows.Forms.Button button20;
            System.Windows.Forms.Button button24;
            System.Windows.Forms.Button button25;
            System.Windows.Forms.Button button26;
            System.Windows.Forms.Button button27;
            System.Windows.Forms.Button button28;
            System.Windows.Forms.Button button29;
            System.Windows.Forms.Button button30;
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button15 = new System.Windows.Forms.Button();
            button16 = new System.Windows.Forms.Button();
            button17 = new System.Windows.Forms.Button();
            button18 = new System.Windows.Forms.Button();
            button19 = new System.Windows.Forms.Button();
            button20 = new System.Windows.Forms.Button();
            button24 = new System.Windows.Forms.Button();
            button25 = new System.Windows.Forms.Button();
            button26 = new System.Windows.Forms.Button();
            button27 = new System.Windows.Forms.Button();
            button28 = new System.Windows.Forms.Button();
            button29 = new System.Windows.Forms.Button();
            button30 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Lavender;
            button1.Location = new System.Drawing.Point(74, 319);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "Q";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Lavender;
            button2.Location = new System.Drawing.Point(130, 319);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(40, 40);
            button2.TabIndex = 1;
            button2.Text = "W";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Lavender;
            button3.Location = new System.Drawing.Point(186, 319);
            button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(40, 40);
            button3.TabIndex = 2;
            button3.Text = "E";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Lavender;
            button4.Location = new System.Drawing.Point(242, 319);
            button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(40, 40);
            button4.TabIndex = 3;
            button4.Text = "R";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Lavender;
            button5.Location = new System.Drawing.Point(298, 319);
            button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(40, 40);
            button5.TabIndex = 4;
            button5.Text = "T";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.Lavender;
            button6.Location = new System.Drawing.Point(354, 319);
            button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(40, 40);
            button6.TabIndex = 5;
            button6.Text = "Y";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.Color.Lavender;
            button7.Location = new System.Drawing.Point(410, 319);
            button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(40, 40);
            button7.TabIndex = 6;
            button7.Text = "U";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.Color.Lavender;
            button8.Location = new System.Drawing.Point(466, 319);
            button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(40, 40);
            button8.TabIndex = 7;
            button8.Text = "I";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.Lavender;
            button9.Location = new System.Drawing.Point(522, 319);
            button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(40, 40);
            button9.TabIndex = 8;
            button9.Text = "O";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.Color.Lavender;
            button10.Location = new System.Drawing.Point(578, 319);
            button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(40, 40);
            button10.TabIndex = 9;
            button10.Text = "P";
            button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = System.Drawing.Color.Lavender;
            button12.Location = new System.Drawing.Point(536, 364);
            button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(40, 40);
            button12.TabIndex = 18;
            button12.Text = "L";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = System.Drawing.Color.Lavender;
            button13.Location = new System.Drawing.Point(480, 364);
            button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(40, 40);
            button13.TabIndex = 17;
            button13.Text = "K";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = System.Drawing.Color.Lavender;
            button14.Location = new System.Drawing.Point(424, 364);
            button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(40, 40);
            button14.TabIndex = 16;
            button14.Text = "J";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = System.Drawing.Color.Lavender;
            button15.Location = new System.Drawing.Point(368, 364);
            button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(40, 40);
            button15.TabIndex = 15;
            button15.Text = "H";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = System.Drawing.Color.Lavender;
            button16.Location = new System.Drawing.Point(312, 364);
            button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(40, 40);
            button16.TabIndex = 14;
            button16.Text = "G";
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = System.Drawing.Color.Lavender;
            button17.Location = new System.Drawing.Point(256, 364);
            button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(40, 40);
            button17.TabIndex = 13;
            button17.Text = "F";
            button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = System.Drawing.Color.Lavender;
            button18.Location = new System.Drawing.Point(200, 364);
            button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button18.Name = "button18";
            button18.Size = new System.Drawing.Size(40, 40);
            button18.TabIndex = 12;
            button18.Text = "D";
            button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = System.Drawing.Color.Lavender;
            button19.Location = new System.Drawing.Point(144, 364);
            button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button19.Name = "button19";
            button19.Size = new System.Drawing.Size(40, 40);
            button19.TabIndex = 11;
            button19.Text = "S";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = System.Drawing.Color.Lavender;
            button20.Location = new System.Drawing.Point(88, 364);
            button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button20.Name = "button20";
            button20.Size = new System.Drawing.Size(40, 40);
            button20.TabIndex = 10;
            button20.Text = "A";
            button20.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = System.Drawing.Color.Lavender;
            button24.Location = new System.Drawing.Point(450, 409);
            button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button24.Name = "button24";
            button24.Size = new System.Drawing.Size(40, 40);
            button24.TabIndex = 26;
            button24.Text = "M";
            button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = System.Drawing.Color.Lavender;
            button25.Location = new System.Drawing.Point(394, 409);
            button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button25.Name = "button25";
            button25.Size = new System.Drawing.Size(40, 40);
            button25.TabIndex = 25;
            button25.Text = "N";
            button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            button26.BackColor = System.Drawing.Color.Lavender;
            button26.Location = new System.Drawing.Point(338, 409);
            button26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button26.Name = "button26";
            button26.Size = new System.Drawing.Size(40, 40);
            button26.TabIndex = 24;
            button26.Text = "B";
            button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            button27.BackColor = System.Drawing.Color.Lavender;
            button27.Location = new System.Drawing.Point(282, 409);
            button27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button27.Name = "button27";
            button27.Size = new System.Drawing.Size(40, 40);
            button27.TabIndex = 23;
            button27.Text = "V";
            button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = System.Drawing.Color.Lavender;
            button28.Location = new System.Drawing.Point(226, 409);
            button28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button28.Name = "button28";
            button28.Size = new System.Drawing.Size(40, 40);
            button28.TabIndex = 22;
            button28.Text = "C";
            button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = System.Drawing.Color.Lavender;
            button29.Location = new System.Drawing.Point(170, 409);
            button29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button29.Name = "button29";
            button29.Size = new System.Drawing.Size(40, 40);
            button29.TabIndex = 21;
            button29.Text = "X";
            button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            button30.BackColor = System.Drawing.Color.Lavender;
            button30.Location = new System.Drawing.Point(114, 409);
            button30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button30.Name = "button30";
            button30.Size = new System.Drawing.Size(40, 40);
            button30.TabIndex = 20;
            button30.Text = "Z";
            button30.UseVisualStyleBackColor = false;
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
            panel1.Location = new System.Drawing.Point(2, 489);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(690, 39);
            panel1.TabIndex = 43;
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
            this.Controls.Add(button24);
            this.Controls.Add(button25);
            this.Controls.Add(button26);
            this.Controls.Add(button27);
            this.Controls.Add(button28);
            this.Controls.Add(button29);
            this.Controls.Add(button30);
            this.Controls.Add(button12);
            this.Controls.Add(button13);
            this.Controls.Add(button14);
            this.Controls.Add(button15);
            this.Controls.Add(button16);
            this.Controls.Add(button17);
            this.Controls.Add(button18);
            this.Controls.Add(button19);
            this.Controls.Add(button20);
            this.Controls.Add(button10);
            this.Controls.Add(button9);
            this.Controls.Add(button8);
            this.Controls.Add(button7);
            this.Controls.Add(button6);
            this.Controls.Add(button5);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman [Created by Summoners With Insomnia]";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

