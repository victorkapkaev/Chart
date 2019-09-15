using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Growth"].Points.AddXY("high than 185",int.Parse(textBox1.Text));
            this.chart1.Series["Growth"].Points.AddXY("175 - 185", int.Parse(textBox2.Text));
            this.chart1.Series["Growth"].Points.AddXY("165 - 175", int.Parse(textBox3.Text));
            this.chart1.Series["Growth"].Points.AddXY("155 - 165", int.Parse(textBox4.Text));
            this.chart1.Series["Growth"].Points.AddXY("less than 160", int.Parse(textBox5.Text));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            this.chart1.Series["Growth"].Points.Clear();


        }
    }
}
