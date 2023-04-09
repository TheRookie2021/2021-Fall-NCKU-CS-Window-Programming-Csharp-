using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            Button[] b = new Button[10];
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                b[i] = new Button();
                b[i].SetBounds(40*i, 40, 35, 34);//(starting point X, starting point Y, width, heighth)
                b[i].Text = "" + i;
                Controls.Add(b[i]);
            }
            Console.WriteLine();
        //    Array.Resize(ref b, b.Length + 10);//button volume turns to 20
       //     for (int i = 0; i < 20; i++)
       //     {
       //         b[i] = new Button();
       //         b[i].SetBounds(40 * i, 40, 35, 34);//(starting point X, starting point Y, width, heighth)
       //         b[i].Text = "" + i;
       //         Controls.Add(b[i]);
      //      }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Remove(b[2]);
        }
    }
}
