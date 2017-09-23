using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YeezyMinigame
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int buty = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            koszyk.Top = playground.Bottom - (playground.Bottom / 10);

            przegrales_lbl.Left = (playground.Width / 2) - (przegrales_lbl.Width / 2);
            przegrales_lbl.Top = (playground.Height / 2) - (przegrales_lbl.Height / 2);
            przegrales_lbl.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            koszyk.Left = Cursor.Position.X - (koszyk.Width / 2);

            but.Left += speed_left;
            but.Top += speed_top;

            if (but.Bottom >= koszyk.Top && but.Bottom <= koszyk.Bottom && but.Left >= koszyk.Left && but.Right <= koszyk.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                buty += 1;
                buty_lbl.Text = buty.ToString();

            }

            if (but.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (but.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (but.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (but.Bottom >= playground.Bottom)
            {
                timer1.Enabled = true;
                przegrales_lbl.Visible = true;
            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.F1)
            {
                but.Top = 50;
                but.Left = 50;
                speed_left = 4;
                speed_top = 4;
                buty = 0;
                buty_lbl.Text = "0";
                timer1.Enabled = true;
                przegrales_lbl.Visible = false;
            }

        }




    }
}
