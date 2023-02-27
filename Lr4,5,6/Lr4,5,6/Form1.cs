using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr4_5_6
{
    public partial class Form1 : Form
    {
        int SumAll;
        int Index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxZakaz.Items.Add(listBoxMenu.Text);
            Index=listBoxMenu.SelectedIndex;
            SumAll += int.Parse(Convert.ToString(listBox1.Items[Index]));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBoxZakaz.Items.Remove(listBoxZakaz.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Приятного аппетита! \n Счёт:{SumAll}","Ресторан студент");
            
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBoxMenu.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBoxZakaz.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
