using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phi
{
    public partial class CADRE : Form
    {

        decimal Phi = 1.61803M;

        public CADRE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ResultRGB.BackColor = Color.FromArgb(Convert.ToInt32(NumericRed.Value), Convert.ToInt32(NumericGreen.Value), Convert.ToInt32(NumericBlue.Value));

            ResultPhiRGB.BackColor = Color.FromArgb(Convert.ToInt32(NumericRed.Value * Phi), Convert.ToInt32(NumericGreen.Value * Phi), Convert.ToInt32(NumericBlue.Value * Phi));
        }

        private void NumericBlue_ValueChanged(object sender, EventArgs e)
        {
            ResultRGB.BackColor = Color.FromArgb(Convert.ToInt32(NumericRed.Value), Convert.ToInt32(NumericGreen.Value), Convert.ToInt32(NumericBlue.Value));

            ResultPhiRGB.BackColor = Color.FromArgb(Convert.ToInt32(NumericRed.Value * Phi), Convert.ToInt32(NumericGreen.Value * Phi), Convert.ToInt32(NumericBlue.Value * Phi));
        }

        private void NumericRed_ValueChanged(object sender, EventArgs e)
        {
            ResultRGB.BackColor = Color.FromArgb(Convert.ToInt32(NumericRed.Value), Convert.ToInt32(NumericGreen.Value), Convert.ToInt32(NumericBlue.Value));

            ResultPhiRGB.BackColor = Color.FromArgb(Convert.ToInt32(NumericRed.Value * Phi), Convert.ToInt32(NumericGreen.Value * Phi), Convert.ToInt32(NumericBlue.Value * Phi));

        }

        private void PhiResultRGB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ResultPhiRGB_Click(object sender, EventArgs e)
        {      
     
        }

    }
}
