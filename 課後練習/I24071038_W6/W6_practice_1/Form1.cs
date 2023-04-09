using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W6_practice_1
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int height, temp_h;
        int width, temp_w;
        String left, right;
        Button[,] bt_left;
        Button[,] bt_right;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_enter_num.Enabled=false;
            height = 0;      temp_h = 0;
            width = 0;       temp_w = 0;

        }
        /* 
         textBox_height;
         textBox_width;
         textBox_enter_num;

         label_height;
         label_width;
         label_enter_num;
         button_ok;
         */


        /* 7 <= 高 <= 15,  5 <= 寬 <= 10 */
        /* “高”要是奇數 */

        private void textBox_height_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_width_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_enter_num_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bt_left[i, j].BackColor = Color.White;
                    bt_right[i, j].BackColor = Color.White;
                }
            } 
            left = string.Empty;
                right = string.Empty;
            if (textBox_enter_num.Text.Length == 1 && textBox_enter_num.Text.Equals("-") == false)
            {
                left = "0";
                right = textBox_enter_num.Text.Substring(0, 1);
            }
            if (textBox_enter_num.Text.Length == 2)
            {
                left = textBox_enter_num.Text.Substring(0, 1);
                right = textBox_enter_num.Text.Substring(1, 1);
            }
            
            switch (left)
            {
                case "-":
                    for(int i = 1; i < width-1; i++)
                    {
                        bt_left[height / 2, i].BackColor = Color.Blue;
                    }
                    break;
                case "0":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 )//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "1":
                    for(int i = 1; i < height-1; i++)
                    {
                        if (i == height / 2) continue;
                        bt_left[i,width-1 ].BackColor = Color.Blue;
                    }
                    break;
                case "2":
                    for (int i = 0; i < height ; i++)
                    {
                        for(int j = 0; j < width ; j++)
                        {
                            if (i == 0 || i == height-1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == 0 && (i > height / 2 && i < height - 1))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == width - 1 && (i < height / 2 && i > 0))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }

                        }
                    }
                    break;
                case "3":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if ( j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "4":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if ( i == height /2 )//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "5":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "6":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 )
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "7":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 )//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "8":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 )
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "9":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
            }
            switch (right)
            {
                case "0":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 )//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "1":
                    for (int i = 1; i < height - 1; i++)
                    {
                        if (i == height / 2) continue;
                        bt_right[i, width - 1].BackColor = Color.Blue;
                    }
                    break;
                case "2":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == 0 && (i > height / 2 && i < height - 1))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == width - 1 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }

                        }
                    }
                    break;
                case "3":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "4":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == height/2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "5":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "6":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "7":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "8":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "9":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        /* 7 <= 高 <= 15,  5 <= 寬 <= 10 */
        /* “高”要是奇數 */

        bool second = false;
        private void button_ok_Click(object sender, EventArgs e)
        { //建立顯示方格群

            int temp;
            bool fine = false;
            try
            {

                if (int.TryParse(textBox_height.Text, out temp) == false)
                {
                    MessageBox.Show("請輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fine = false;
                }
                else
                if (int.Parse(textBox_height.Text) % 2 == 0)
                {
                    MessageBox.Show("高不能為偶數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fine = false;
                }
                else
                if ((int.Parse(textBox_height.Text) > 15 || int.Parse(textBox_height.Text) < 7))
                {
                    MessageBox.Show("請輸入範圍內數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fine = false;
                }
                else
                {
                    height = int.Parse(textBox_height.Text);
                    fine = true;
                }
            }
            catch { }

            try
            {
                if (int.TryParse(textBox_width.Text, out temp) == false)
                {
                    MessageBox.Show("請輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fine = false;
                }
                else
                if ((int.Parse(textBox_width.Text) > 10 || int.Parse(textBox_width.Text) < 5))
                {
                    MessageBox.Show("請輸入範圍內數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fine = false;
                }
                else
                {
                    width = int.Parse(textBox_width.Text);
                    fine = true;
                }
            }
            catch { }

            if (fine)
                textBox_enter_num.Enabled = true;
            if (second==true)
            {
                for (int i = 0; i <temp_h ; i++)
                    for (int j = 0; j < temp_w; j++)
                    {
                        Controls.Remove(bt_left[i, j]);
                        Controls.Remove(bt_right[i, j]);
                    }
            }

            second = true;
            bt_left =  new Button[height,width];
            bt_right = new Button[height,width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bt_left[i,j] = new Button();
                    bt_left[i, j].SetBounds(200+20 + (100 / width) * j, 50 + (200 / height) * i, (100 / width), (200 / height));//(starting point X, starting point Y, width, heighth
                    bt_left[i, j].BackColor = Color.White;
                    Controls.Add(bt_left[i, j]);
                }
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bt_right[i, j] = new Button();
                    bt_right[i, j].SetBounds(340 + (100/width)*j, 50 + (200/height)*i, (100 / width), (200 / height));//(starting point X, starting point Y, width, heighth
                    bt_right[i, j].BackColor = Color.White;
                    Controls.Add(bt_right[i, j]);
                }
            }
            switch (left)
            {
                case "-":
                    for (int i = 1; i < width - 1; i++)
                    {
                        bt_left[height / 2, i].BackColor = Color.Blue;
                    }
                    break;
                case "0":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "1":
                    for (int i = 1; i < height - 1; i++)
                    {
                        if (i == height / 2) continue;
                        bt_left[i, width - 1].BackColor = Color.Blue;
                    }
                    break;
                case "2":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == 0 && (i > height / 2 && i < height - 1))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == width - 1 && (i < height / 2 && i > 0))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }

                        }
                    }
                    break;
                case "3":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "4":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "5":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "6":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "7":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "8":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "9":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_left[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_left[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
            }
            switch (right)
            {

                case "0":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "1":
                    for (int i = 1; i < height - 1; i++)
                    {
                        if (i == height / 2) continue;
                        bt_right[i, width - 1].BackColor = Color.Blue;
                    }
                    break;
                case "2":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == 0 && (i > height / 2 && i < height - 1))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == width - 1 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }

                        }
                    }
                    break;
                case "3":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "4":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "5":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "6":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1 && (i > height / 2 && i < height - 1))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "7":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == width - 1)//左右垂直線
                            {
                                if (i != 0 && i != height - 1 && i != height / 2)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "8":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
                case "9":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || i == height / 2)//上中下橫線
                            {
                                if (j != 0 && j != width - 1)
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                            if (j == 0 || j == width - 1)//左右垂直線
                            {
                                if (j == width - 1)
                                {
                                    if (i != 0 && i != height - 1 && i != height / 2)
                                        bt_right[i, j].BackColor = Color.Blue;
                                }
                                if (j == 0 && (i < height / 2 && i > 0))
                                {
                                    bt_right[i, j].BackColor = Color.Blue;
                                }
                            }
                        }
                    }
                    break;
            }
            temp_w = width; temp_h = height;
        }
    }





}
