using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace W8_practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = @"..\Debug\card.map";
        Card[,] card_arr;
        int row, col;
        int[,] matrix;
        int p1_score = 0, p2_score = 0;
        int round = 1;
        bool turn = true;
        private bool Next_turn(ref bool turn)
        {
            if (turn == true) return false;
            else return true;

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label_p1.Visible = false;
            label_p2.Visible = false;
            label_round.Visible = false;

        }

        int show_time = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (show_time <= 0)
            {
                timer1.Enabled = false;
                for (int j = 0; j < row; j++)
                {
                    for (int k = 0; k < col; k++) {
                        card_arr[j, k].hideNumber();
                    }
                }
            }
            show_time--;

        }

        private void card_Click(object sender, EventArgs e)
        {
    
            Card cardRef = (Card)sender;
            cardRef.showNumber();
            if (round % 2 == 1)
            {
                check_P1_first(ref cardRef);
            }
            else
            {
                check_P2_first(ref cardRef);
            }
            label_p1.Text = "P1:" + p1_score + "分";
            label_p2.Text = "P2:" + p2_score + "分";
           

        }
        int num1=-1, num2=-1;

        Card ref1, ref2;
        private void check_P1_first(ref Card flip)
        {
            if (num1 == -1)
            {
                num1 = flip.number;
                ref1 = flip;
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P2";
                return;
            }
            else if(num2==-1)
            {
                num2 = flip.number;
                ref2 = flip;
                Thread.Sleep(2000);
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P2";
            }

            if(num2 != -1 && num1 > num2 )//P1 win
            {
                ref1.hideNumber();
                ref2.hideNumber();

                num1 = -1; num2 = -1;
                ref1 = null;
                ref2 = null;
                round++;
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P2";
                return;
            }
            else if(num1 != -1 && num1 < num2)//P2 win count scores
            {
                ref1.Visible = false;
                ref2.Visible = false;
                p2_score += (num2-num1);
                num1 = -1; num2 = -1;
                ref1 = null;
                ref2 = null;
                round++;
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P2";
                count -= 2;
                if (count == 0)
                {
                    string msg;
                    if (p1_score > p2_score) msg = "P1獲勝";
                    else if (p1_score < p2_score) msg = "P2獲勝";
                    else msg = "平手";

                    DialogResult result;
                    result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                return;
            }


        }
        private void check_P2_first(ref Card flip)
        {


            if (num1 == -1)
            {
                num1 = flip.number;
                ref1 = flip;
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P1";
                return;
            }
            else if (num2 == -1)
            {
                num2 = flip.number;
                ref2 = flip;
                Thread.Sleep(2000);
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P1";
            }

            if (num2 != -1 && num1 > num2)//P2 win
            {

                ref1.hideNumber();
                ref2.hideNumber();

                num1 = -1; num2 = -1;
                ref1 = null;
                ref2 = null;
                round++;
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P1";
                return;
            }
            else if (num1 != -1 && num1 < num2)//P1 win count scores
            {
                ref1.Visible = false;
                ref2.Visible = false;
                p1_score += (num2 - num1); 
                num1 = -1; num2 = -1;
                ref1 = null;
                ref2 = null;
                round++;
                label_round.Text = string.Empty;
                label_round.Text = "第" + round + "回合" + "輪到P1";
                count -= 2;
                if (count == 0)
                {
                    string msg;
                    if (p1_score > p2_score) msg = "P1獲勝";
                    else if (p1_score < p2_score) msg = "P2獲勝";
                    else msg = "平手";

                    DialogResult result;
                    result = MessageBox.Show( msg , "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                return;
            }


        }
        int count;
        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button_start.Visible = false;
            label_p1.Visible = true;
            label_p2.Visible = true;
            label_round.Visible = true;

            label_p1.Text = "P1:"+p1_score+"分";
            label_p2.Text = "P2:" + p2_score + "分"; ;
            label_round.Text = "第"+round +"回合"+"輪到P1";
            StreamReader sr = new StreamReader(filename);
            string L1,data;
            string[] temp=new string[2];
            
            //讀第一行 row col
            L1  = sr.ReadLine();
            temp= L1.Split(' ');
            row = int.Parse(temp[0]);
            col = int.Parse(temp[1]);
            matrix = new int[row, col];
            card_arr=new Card[row, col];
            count = row * col;
            
            //讀matrix
            string[] rows = new string[row];
            int i = 0;
            do
            {
                data = sr.ReadLine();            // 讀取一行文字資料
                if (data == null) break;         // 若資料讀取完畢，跳離迴圈
                rows[i++] = data;
            } while (true);
            sr.Close();

            string[] num=new string[col];
            string temp_s=string.Empty;

            for (int j=0;j < row;j++)
            {
                temp_s = string.Empty;
                temp_s = rows[j];
                num=temp_s.Split(' ');
                for(int k = 0; k < col; k++)
                {
                    matrix[j,k] = int.Parse(num[k]);
                    num[k] = string.Empty;
                }
            }
            //設定大小與邊界
            int Xstart = 160,Ystart=60;
            int distance = 200;
            int Xsize =distance/row,Ysize=distance/col ;

            //顯示卡牌
            for(int j = 0; j < row; j++)
            {
                for(int k = 0; k < col; k++)
                {
                    card_arr[j, k] = new Card();
                    card_arr[j, k].number = matrix[j, k];
                    card_arr[j, k].SetBounds(Xstart + distance/row * j, Ystart+ distance/col * k, Xsize, Ysize);
                    card_arr[j, k].showNumber();
                    Controls.Add(card_arr[j, k]);
                    this.card_arr[j, k].Click += new System.EventHandler(this.card_Click);//button event
                }
            }
        }

    
    }
}
