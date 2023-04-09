using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

      

 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double money = double.Parse(txtCapi.Text);   //本金
            double years = double.Parse(txtYear.Text);   //年期
            double yrate = double.Parse(txtRate.Text);   //年利率
            double total;     //本利和
            total = money * Math.Pow((1 + yrate / 100), years);
            label4.Text = "本利和 = NT$ " + total.ToString("#,#.0") + " 元";
            label4.Text += "\n總利息 = NT$ " + (total - money).ToString("#,#.0") + " 元";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
