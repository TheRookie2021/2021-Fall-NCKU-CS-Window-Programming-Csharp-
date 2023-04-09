using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W9_practice_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Button[,] arr = new Button[10, 4];
        int max=10;
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = new Button();
                    arr[i, j].SetBounds(100 + 100 * j, 250 - 25 * i, 80, 20);
                    arr[i, j].BackColor = Color.Blue;
                    arr[i, j].ForeColor = Color.Black;
                    arr[i, j].Text = j + "," + (9 - i);
                    //arr[i, j].Enabled = false;
                    arr[i, j].TextAlign = ContentAlignment.TopLeft;
                    Controls.Add(arr[i, j]);
                }
            }
            
            
           

                

            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            max = trackBar1.Value;
        }
        int interval = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (interval < 0)
            {
                Random rnd = new Random();
                for (int i = 0; i < 4; i++)
                {
                    int cur = rnd.Next(max + 1);
                    for (int j = 0; j < 10; j++)
                    {
                        if (j < cur)
                        {
                            arr[j, i].BackColor = Color.Blue;
                        }
                        else
                        {
                            arr[j, i].BackColor = Color.Transparent;
                        }

                    }

                }
                interval = 5;
            }
            else interval--;
        }
    }
}
