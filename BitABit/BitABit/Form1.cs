using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitABit
{
    public partial class Form1 : Form
    {
        private Bits bits;
        public Form1()
        {
            InitializeComponent();
            bits = this.bits = new Bits();

        }
        public void getevent() 
        {
            lbldecimal.Text = Convert.ToString(bits.getBits());
            lblbinario.Text = Convert.ToString(bits.getBits(), 2);
            lblhexa.Text = Convert.ToString(bits.getBits(), 16).ToUpper();
            lblBit1.Text = (bits.getBits(1)) ? "1" : "0";
            lblBit2.Text = (bits.getBits(2)) ? "1" : "0";
            lblBit3.Text = (bits.getBits(3)) ? "1" : "0";
            lblBit4.Text = (bits.getBits(4)) ? "1" : "0";
            lblBit5.Text = (bits.getBits(5)) ? "1" : "0";
            lblBit6.Text = (bits.getBits(6)) ? "1" : "0";
            lblBit7.Text = (bits.getBits(7)) ? "1" : "0";
            lblBit8.Text = (bits.getBits(8)) ? "1" : "0";
        }
 
        private void btnget_Click(object sender, EventArgs e)
        {
            bits.setBits(byte.Parse(txtvalor.Text));
            getevent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (chb1.Checked)
            {
                bits.setBit1(1);
            }
            else 
            {
                bits.setBit0(1);
            }

            if (chb2.Checked)
            {
                bits.setBit1(2);
            }
            else
            {
                bits.setBit0(2);
            }

            if (chb3.Checked)
            {
                bits.setBit1(3);
            }
            else
            {
                bits.setBit0(3);
            }

            if (chb4.Checked)
            {
                bits.setBit1(4);
            }
            else
            {
                bits.setBit0(4);
            }

            if (chb5.Checked)
            {
                bits.setBit1(5);
            }
            else
            {
                bits.setBit0(5);
            }

            if (chb6.Checked)
            {
                bits.setBit1(6);
            }
            else
            {
                bits.setBit0(6);
            }

            if (chb7.Checked)
            {
                bits.setBit1(7);
            }
            else
            {
                bits.setBit0(7);
            }

            if (chb8.Checked)
            {
                bits.setBit1(8);
            }
            else
            {
                bits.setBit0(8);
            }
            getevent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
