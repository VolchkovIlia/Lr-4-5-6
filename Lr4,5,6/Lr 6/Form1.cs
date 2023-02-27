using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(textBox2.Text);
            int tmp1=Int32.Parse(textBox1.Text);
            tmp += 1;
            if(tmp == 60)
            {
                tmp1 += 1;
                tmp = 0;
                textBox1.Text = tmp1.ToString();

            }
            textBox2.Text = tmp.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";    
            timer1.Enabled = false;
        }
    }
}
