using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class CADRE : Form
    {
        public CADRE()
        {
            InitializeComponent();
        }

        private void CADRE_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClickMe_Click(object sender, EventArgs e)
        {
            ClickMe.Text = "coucou";
        }

        bool Clicked = false;

        private void LeButton_Click(object sender, EventArgs e)
        {
            if (Clicked == true) this.Text = "oiqeanfmoivwjmgpoeqk";
            else this.Text = "Caption";

            Clicked = !Clicked;

        }

        int count = 0;

        private void ButtonBGcolor_Click(object sender, EventArgs e)
        {
            count++;
            switch (count)
            {
                case 1 :
                    this.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    this.BackColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    this.BackColor = System.Drawing.Color.Blue;
                    break;


                default:
                    this.BackColor = System.Drawing.Color.DarkOrange;
                    break;
            }

            if (count >= 3) count = 0;
        }
    }
}
