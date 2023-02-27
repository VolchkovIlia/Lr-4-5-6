using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fromX=int.Parse(textBox1.Text);
            int toX=int.Parse(textBox2.Text);

            int fromY=int.Parse(textBox3.Text);
            int toY=int.Parse(textBox4.Text);

            if (fromX > toX)
            {
                MessageBox.Show("интервал должен быть от меньшего к большему");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (fromY > toY)
            {
                MessageBox.Show("интервал должен быть от меньшего к большему");
                textBox3.Text = "";
                textBox4.Text = "";
            }
            for (int x=fromX; x<=toX; x++)
            {
 
                for (int y=fromY; y<=toY; y++)
                {

                    listBox1.Items.Add($"z(x,y)={x}-{y}={x - y}");
                    
                }
            }
        }
    }
}
