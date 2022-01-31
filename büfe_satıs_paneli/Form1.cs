using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace büfe_satıs_paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        double kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double top =0;
          

            int mısır = Convert.ToInt16(texmıs.Text);
            int su = Convert.ToInt16(texsu.Text);
            int cay = Convert.ToInt16(texcay.Text);
            int bilet = Convert.ToInt16(texbil.Text);
            


            top = mısır*4 + cay*2 + su*1 + bilet*8;
            lbltop.Text = top.ToString();

            kasa = kasa + top;
            lblkasa.Text = kasa.ToString();
     
          
         }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
