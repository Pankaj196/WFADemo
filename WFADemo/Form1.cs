using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACls;
namespace WFADemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WFA w = new WFA();

        private void button1_Click(object sender, EventArgs e)
        {
            float x=Convert.ToInt32(textBox1.Text);
            float y=Convert.ToInt32(textBox2.Text);
            textBox3.Text=Convert.ToString(w.Add(x,y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float x=Convert.ToInt32(textBox1.Text);
            float y=Convert.ToInt32(textBox2.Text);
            textBox3.Text=Convert.ToString(w.Sub(x,y));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float x = Convert.ToInt32(textBox1.Text);
            float y=Convert.ToInt32(textBox2.Text);
            textBox3.Text=Convert.ToString((w.Mul(x,y)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float x=Convert.ToInt32((textBox1.Text));
            float y=Convert.ToInt32((textBox2.Text));
            textBox3.Text = Convert.ToString((w.Div(x, y)));
        }
    }
}
