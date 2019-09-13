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
            this.chart1.Series["Groth"].Points.AddXY("от 175",int.Parse(textBox1.Text));
            this.chart1.Series["Groth"].Points.AddXY("от 170 до 175", int.Parse(textBox2.Text));
            this.chart1.Series["Groth"].Points.AddXY("от 165 до 170", int.Parse(textBox3.Text));
            this.chart1.Series["Groth"].Points.AddXY("от 160 до 165", int.Parse(textBox4.Text));
            this.chart1.Series["Groth"].Points.AddXY("до 160", int.Parse(textBox5.Text));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            this.chart1.Series["Groth"].Points.Clear();


        }
    }
}
