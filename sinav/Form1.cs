using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y1 = Convert.ToDouble(txtYazili1.Text);
            double y2 = Convert.ToDouble(txtYazili2.Text);
            double y3= Convert.ToDouble(txtYazili3.Text);
            
            Ortalama ortalama=new Ortalama(y1,y2,y3);

            lblOrtalama.Text ="Ortalama: "+ ortalama.OrtalamaHesaplama().ToString();
        }
    }
}
