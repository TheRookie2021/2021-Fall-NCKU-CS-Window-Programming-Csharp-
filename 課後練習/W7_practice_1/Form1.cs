using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7_practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] stackQ = new int[6];
        int[] stackW = new int[6];
        int[] stackE = new int[6];
        int[] stackR = new int[6];
            Button[] btQ = new Button[6];
            Button[] btW = new Button[6];
            Button[] btE = new Button[6];
            Button[] btR = new Button[6];
        int i_Q = -1, i_W = -1, i_E = -1, i_R = -1;
        public void push(ref int[] stack, ref int top, int num)
        {
            stack[++top] = num;
        }

        public int pop(ref int[] stack, ref int top)
        {
            return stack[top--];
        }
        public bool TopTwoEqual(int[] stack, int top)
        {
            if (top < 1) return false;

            else if (stack[top] == stack[top - 1])
                return true;
            else
                return false;
        }
        //-------------------------------stack------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

            label_cur_score.Visible = false;
            label_cur_num.Visible = false;
            for (int i = 0; i < 6; i++)
            {
                btQ[i] = new Button() ;
                btQ[i].SetBounds(50, 250 - i * 40, 40, 40);//(starting point X, starting point Y, width, heighth
                Controls.Add(btQ[i]);
                btW[i] = new Button();
                btW[i].SetBounds(90, 250 - i * 40, 40, 40);//(starting point X, starting point Y, width, heighth
                Controls.Add(btW[i]);

                btE[i] = new Button();
                btE[i].SetBounds(130, 250 - i * 40, 40, 40);//(starting point X, starting point Y, width, heighth
                Controls.Add(btE[i]);

                btR[i] = new Button();
                btR[i].SetBounds(170, 250 - i * 40, 40, 40);//(starting point X, starting point Y, width, heighth
                Controls.Add(btR[i]);

                btQ[i].Visible = false;
                btW[i].Visible = false;
                btE[i].Visible = false;
                btR[i].Visible = false;
                  
            }

        }
        //label_cur_score;
        //label_cur_num;

        int score = 0;
        int cur_num = 0;
        Random rnd = new Random();
        bool easy_mode = false;
        bool hard_mode = false;
        private void button_mode_easy_Click(object sender, EventArgs e)
        {
            easy_mode = true; hard_mode = false;
            button_mode_easy.Visible=false;
            button_mode_hard.Visible=false;
            /*for (int i = 0; i < 6; i++)
            {
                btQ[i].Visible = true;
                btW[i].Visible = true;
                btE[i].Visible = true;
                btR[i].Visible = true;
            }*/
            label_cur_score.Visible = true;
            label_cur_num.Visible = true;

            label_cur_score.Text = "你的分數:" + score;
            cur_num = 2;
            label_cur_num.Text = "當前的數字:" + cur_num;



        }
        private void button_mode_hard_Click(object sender, EventArgs e)
        {
            hard_mode = true; easy_mode = false;
            button_mode_easy.Visible = false;
            button_mode_hard.Visible = false;
            /*for (int i = 0; i < 6; i++)
            {
                btQ[i].Visible = true;
                btW[i].Visible = true;
                btE[i].Visible = true;
                btR[i].Visible = true;
            }*/
            label_cur_score.Visible = true;
            label_cur_num.Visible = true;
            label_timer.Visible = true;

            label_cur_score.Text = "你的分數:" + score;
            int temp = rnd.Next();
            if (temp % 3 == 0)
            {
                cur_num = 2;
                label_cur_num.Text = "當前的數字:" + cur_num;
            }
            else if (temp % 3 == 1)
            {
                cur_num = 4;
                label_cur_num.Text = "當前的數字:" + cur_num;
            }
            else if (temp % 3 == 2)
            {
                cur_num = 8;
                label_cur_num.Text = "當前的數字:" + cur_num;
            }
            timer1.Enabled = true;

        }

        double num = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num <= 0)
            {
                try
                {
                    int temp = rnd.Next();
                    push(ref stackQ, ref i_Q, cur_num); //top:1
                    while (i_Q > 0 && TopTwoEqual(stackQ, i_Q))
                    {
                        btQ[i_Q].Visible = false;
                        pop(ref stackQ, ref i_Q);//top:0
                        stackQ[i_Q] += stackQ[i_Q];
                    }

                    btQ[i_Q].Visible = true;//top:0
                    btQ[i_Q].Text = stackQ[i_Q].ToString();//top:0
                    //---------------------------------------------
                    if (temp % 3 == 0)
                    {
                        cur_num = 2;
                        label_cur_num.Text = "當前的數字:" + cur_num;
                    }
                    else if (temp % 3 == 1)
                    {
                        cur_num = 4;
                        label_cur_num.Text = "當前的數字:" + cur_num;
                    }
                    else if (temp % 3 == 2)
                    {
                        cur_num = 8;
                        label_cur_num.Text = "當前的數字:" + cur_num;
                    }

                    int[] arr_smallest = { i_Q, i_W, i_E, i_R };
                    int smallest_top = arr_smallest.Min();

                    for (int i = 0; i <= smallest_top;)// check row--------------------------------------------------------------------
                    {
                        if (stackQ[i] != 0 && stackQ[i] == stackR[i] &&
                                stackQ[i] == stackE[i] && stackQ[i] == stackW[i])

                        {
                            score += stackQ[i] * stackQ[i];

                            //Q
                            btQ[i_Q].Visible = false;
                            for (int j = i; j < i_Q; j++)
                            {
                                stackQ[j] = stackQ[j + 1];
                                btQ[j].Text = stackQ[j].ToString();
                            }
                            pop(ref stackQ, ref i_Q);

                            //W
                            btW[i_W].Visible = false;
                            for (int j = i; j < i_W; j++)
                            {
                                stackW[j] = stackW[j + 1];
                                btW[j].Text = stackW[j].ToString();
                            }
                            pop(ref stackW, ref i_W);

                            //E
                            btE[i_E].Visible = false;
                            for (int j = i; j < i_E; j++)
                            {
                                stackE[j] = stackE[j + 1];
                                btE[j].Text = stackE[j].ToString();
                            }
                            pop(ref stackE, ref i_E);

                            //R
                            btR[i_R].Visible = false;
                            for (int j = i; j < i_R; j++)
                            {
                                stackR[j] = stackR[j + 1];
                                btR[j].Text = stackR[j].ToString();
                            }
                            pop(ref stackR, ref i_R);
                            smallest_top--;
                            i = 0;
                        }
                        else i++;


                        if (i_Q > 0 || i_W > 0 || i_E > 0 || i_R > 0)//垂直相鄰的
                        {
                            //Q
                            while (i_Q > 0 && TopTwoEqual(stackQ, i_Q))
                            {
                                btQ[i_Q].Visible = false;
                                pop(ref stackQ, ref i_Q);//top:0
                                stackQ[i_Q] += stackQ[i_Q];
                            }
                            if (i_Q != -1)
                            {
                                btQ[i_Q].Visible = true;//top:0
                                btQ[i_Q].Text = stackQ[i_Q].ToString();//top:0
                            }
                            //W
                            while (i_W > 0 && TopTwoEqual(stackW, i_W))
                            {
                                btW[i_W].Visible = false;
                                pop(ref stackW, ref i_W);//top:0
                                stackW[i_W] += stackW[i_W];
                            }
                            if (i_W != -1)
                            {
                                btW[i_W].Visible = true;//top:0
                                btW[i_W].Text = stackW[i_W].ToString();//top:0
                            }
                            //E
                            while (i_E > 0 && TopTwoEqual(stackE, i_E))
                            {
                                btE[i_E].Visible = false;
                                pop(ref stackE, ref i_E);//top:0
                                stackE[i_E] += stackE[i_E];
                            }
                            if (i_E != -1)
                            {
                                btE[i_E].Visible = true;//top:0
                                btE[i_E].Text = stackE[i_E].ToString();//top:0
                            }

                            //R
                            while (i_R > 0 && TopTwoEqual(stackR, i_R))
                            {
                                btR[i_R].Visible = false;
                                pop(ref stackR, ref i_R);//top:0
                                stackR[i_R] += stackR[i_R];
                            }
                            if (i_R != -1)
                            {
                                btR[i_R].Visible = true;//top:0
                                btR[i_R].Text = stackR[i_R].ToString();//top:0
                            }
                        }
                    }//check btm row--------------------------------------------------------------------

                    if(btQ[5].Visible||btW[5].Visible|| btR[5].Visible|| btE[5].Visible)
                    {
                        timer1.Enabled = false;
                        DialogResult result;
                        result = MessageBox.Show("Game Over\n你的分數: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (result == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                    label_cur_score.Text = "你的分數:" + score;
                    num = 3;//reset limited time 
                }
                catch
                {
                    timer1.Enabled = false;
                    DialogResult result;
                    result = MessageBox.Show("Game Over\n你的分數: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }

                }//try catch

            }

            label_timer.Text = "時間: " + num.ToString("0.0");
            num-= 0.1;
        }
        //-------------------------------button----------------------------

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (easy_mode==true)
            {
                try
                {

                    switch (e.KeyCode)//switch : choose block---------------------
                    {

                        case Keys.A:
                            cur_num = 2;
                            label_cur_num.Text = "當前的數字:" + cur_num;
                            break;
                        case Keys.S:
                            cur_num = 4;
                            label_cur_num.Text = "當前的數字:" + cur_num;
                            break;
                        case Keys.D:
                            cur_num = 8;
                            label_cur_num.Text = "當前的數字:" + cur_num;
                            break;

                    }//switch : choose block---------------------------------------


                    switch (e.KeyCode)//switch : block down------------------------
                    {
                        case Keys.Q:

                            push(ref stackQ, ref i_Q, cur_num); //top:1
                            while (i_Q > 0 && TopTwoEqual(stackQ, i_Q))
                            {
                                btQ[i_Q].Visible = false;
                                pop(ref stackQ, ref i_Q);//top:0
                                stackQ[i_Q] += stackQ[i_Q];
                            }

                            btQ[i_Q].Visible = true;//top:0
                            btQ[i_Q].Text = stackQ[i_Q].ToString();//top:0
                            break;

                        case Keys.W:
                            push(ref stackW, ref i_W, cur_num); //top:1
                            while (i_W > 0 && TopTwoEqual(stackW, i_W))
                            {
                                btW[i_W].Visible = false;
                                pop(ref stackW, ref i_W);//top:0
                                stackW[i_W] += stackW[i_W];
                            }

                            btW[i_W].Visible = true;//top:0
                            btW[i_W].Text = stackW[i_W].ToString();//top:0
                            break;

                        case Keys.E:
                            push(ref stackE, ref i_E, cur_num); //top:1
                            while (i_E > 0 && TopTwoEqual(stackE, i_E))
                            {
                                btE[i_E].Visible = false;
                                pop(ref stackE, ref i_E);//top:0
                                stackE[i_E] += stackE[i_E];
                            }

                            btE[i_E].Visible = true;//top:0
                            btE[i_E].Text = stackE[i_E].ToString();//top:0
                            break;

                        case Keys.R:
                            push(ref stackR, ref i_R, cur_num); //top:1
                            while (i_R > 0 && TopTwoEqual(stackR, i_R))
                            {
                                btR[i_R].Visible = false;
                                pop(ref stackR, ref i_R);//top:0
                                stackR[i_R] += stackR[i_R];
                            }

                            btR[i_R].Visible = true;//top:0
                            btR[i_R].Text = stackR[i_R].ToString();//top:0
                            break;
                        default: break;
                    }//switch : block down-----------------------------------------

                        int[] arr_smallest = { i_Q, i_W, i_E, i_R };
                        int smallest_top = arr_smallest.Min();

                        for (int i = 0; i <= smallest_top;)// check row--------------------------------------------------------------------
                        {
                            if (stackQ[i] != 0 && stackQ[i] == stackR[i] &&
                                    stackQ[i] == stackE[i] && stackQ[i] == stackW[i])

                            {
                                score += stackQ[i] * stackQ[i];

                                //Q
                                btQ[i_Q].Visible = false;
                                for (int j = i; j < i_Q; j++)
                                {
                                    stackQ[j] = stackQ[j + 1];
                                    btQ[j].Text = stackQ[j].ToString();
                                }
                                pop(ref stackQ, ref i_Q);

                                //W
                                btW[i_W].Visible = false;
                                for (int j = i; j < i_W; j++)
                                {
                                    stackW[j] = stackW[j + 1];
                                    btW[j].Text = stackW[j].ToString();
                                }
                                pop(ref stackW, ref i_W);

                                //E
                                btE[i_E].Visible = false;
                                for (int j = i; j < i_E; j++)
                                {
                                    stackE[j] = stackE[j + 1];
                                    btE[j].Text = stackE[j].ToString();
                                }
                                pop(ref stackE, ref i_E);

                                //R
                                btR[i_R].Visible = false;
                                for (int j = i; j < i_R; j++)
                                {
                                    stackR[j] = stackR[j + 1];
                                    btR[j].Text = stackR[j].ToString();
                                }
                                pop(ref stackR, ref i_R);
                                smallest_top--;
                                i = 0;
                            }
                            else i++;


                        if (i_Q > 0 || i_W > 0 || i_E > 0 || i_R > 0)//垂直相鄰的
                        {
                            //Q
                            while (i_Q > 0 && TopTwoEqual(stackQ, i_Q))
                            {
                                btQ[i_Q].Visible = false;
                                pop(ref stackQ, ref i_Q);//top:0
                                stackQ[i_Q] += stackQ[i_Q];
                            }
                            if (i_Q != -1)
                            {
                                btQ[i_Q].Visible = true;//top:0
                                btQ[i_Q].Text = stackQ[i_Q].ToString();//top:0
                            }
                            //W
                            while (i_W > 0 && TopTwoEqual(stackW, i_W))
                            {
                                btW[i_W].Visible = false;
                                pop(ref stackW, ref i_W);//top:0
                                stackW[i_W] += stackW[i_W];
                            }
                            if (i_W != -1)
                            {
                                btW[i_W].Visible = true;//top:0
                                btW[i_W].Text = stackW[i_W].ToString();//top:0
                            }
                            //E
                            while (i_E > 0 && TopTwoEqual(stackE, i_E))
                            {
                                btE[i_E].Visible = false;
                                pop(ref stackE, ref i_E);//top:0
                                stackE[i_E] += stackE[i_E];
                            }
                            if (i_E != -1)
                            {
                                btE[i_E].Visible = true;//top:0
                                btE[i_E].Text = stackE[i_E].ToString();//top:0
                            }

                            //R
                            while (i_R > 0 && TopTwoEqual(stackR, i_R))
                            {
                                btR[i_R].Visible = false;
                                pop(ref stackR, ref i_R);//top:0
                                stackR[i_R] += stackR[i_R];
                            }
                            if (i_R != -1)
                            {
                                btR[i_R].Visible = true;//top:0
                                btR[i_R].Text = stackR[i_R].ToString();//top:0
                            }
                            }
                    }//check btm row--------------------------------------------------------------------
                    
                    label_cur_score.Text = "你的分數:" + score;
                    if (btQ[5].Visible || btW[5].Visible || btR[5].Visible || btE[5].Visible)
                    {
                        timer1.Enabled = false;
                        DialogResult result;
                        result = MessageBox.Show("Game Over\n你的分數: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (result == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }

                }//try catch
                catch
                {
                    DialogResult result;
                    result=MessageBox.Show("Game Over\n你的分數: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }//try catch
//*******************************************************-hard mode-*******************************************************************************
            } else if (hard_mode==true)
            {
                try
                {
                    int temp = rnd.Next();
                    switch (e.KeyCode)//switch : block down------------------------
                    {
                        case Keys.Q:
                            
                            push(ref stackQ, ref i_Q, cur_num); //top:1
                            while (i_Q > 0 && TopTwoEqual(stackQ, i_Q))
                            {
                                btQ[i_Q].Visible = false;
                                pop(ref stackQ, ref i_Q);//top:0
                                stackQ[i_Q] += stackQ[i_Q];
                            }

                            btQ[i_Q].Visible = true;//top:0
                            btQ[i_Q].Text = stackQ[i_Q].ToString();//top:0
                            //---------------------------------------------
                            if (temp % 3 == 0)
                            {
                                cur_num = 2;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 1)
                            {
                                cur_num = 4;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 2)
                            {
                                cur_num = 8;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            break;

                        case Keys.W:
                            push(ref stackW, ref i_W, cur_num); //top:1
                            while (i_W > 0 && TopTwoEqual(stackW, i_W))
                            {
                                btW[i_W].Visible = false;
                                pop(ref stackW, ref i_W);//top:0
                                stackW[i_W] += stackW[i_W];
                            }

                            btW[i_W].Visible = true;//top:0
                            btW[i_W].Text = stackW[i_W].ToString();//top:0
                            //-------------------------------------
                            if (temp % 3 == 0)
                            {
                                cur_num = 2;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 1)
                            {
                                cur_num = 4;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 2)
                            {
                                cur_num = 8;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            break;

                        case Keys.E:
                            push(ref stackE, ref i_E, cur_num); //top:1
                            while (i_E > 0 && TopTwoEqual(stackE, i_E))
                            {
                                btE[i_E].Visible = false;
                                pop(ref stackE, ref i_E);//top:0
                                stackE[i_E] += stackE[i_E];
                            }

                            btE[i_E].Visible = true;//top:0
                            btE[i_E].Text = stackE[i_E].ToString();//top:0
                            //--------------------------------------
                            if (temp % 3 == 0)
                            {
                                cur_num = 2;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 1)
                            {
                                cur_num = 4;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 2)
                            {
                                cur_num = 8;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            break;

                        case Keys.R:
                            push(ref stackR, ref i_R, cur_num); //top:1
                            while (i_R > 0 && TopTwoEqual(stackR, i_R))
                            {
                                btR[i_R].Visible = false;
                                pop(ref stackR, ref i_R);//top:0
                                stackR[i_R] += stackR[i_R];
                            }

                            btR[i_R].Visible = true;//top:0
                            btR[i_R].Text = stackR[i_R].ToString();//top:0
                            //-------------------------------------------
                            if (temp % 3 == 0)
                            {
                                cur_num = 2;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 1)
                            {
                                cur_num = 4;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            else if (temp % 3 == 2)
                            {
                                cur_num = 8;
                                label_cur_num.Text = "當前的數字:" + cur_num;
                            }
                            break;
                        default: break;
                    }//switch : block down-----------------------------------------


                    int[] arr_smallest = { i_Q, i_W, i_E, i_R };
                    int smallest_top = arr_smallest.Min();

                    for (int i = 0; i <= smallest_top;)// check row--------------------------------------------------------------------
                    {
                        if (stackQ[i] != 0 && stackQ[i] == stackR[i] &&
                                stackQ[i] == stackE[i] && stackQ[i] == stackW[i])

                        {
                            score += stackQ[i] * stackQ[i];

                            //Q
                            btQ[i_Q].Visible = false;
                            for (int j = i; j < i_Q; j++)
                            {
                                stackQ[j] = stackQ[j + 1];
                                btQ[j].Text = stackQ[j].ToString();
                            }
                            pop(ref stackQ, ref i_Q);

                            //W
                            btW[i_W].Visible = false;
                            for (int j = i; j < i_W; j++)
                            {
                                stackW[j] = stackW[j + 1];
                                btW[j].Text = stackW[j].ToString();
                            }
                            pop(ref stackW, ref i_W);

                            //E
                            btE[i_E].Visible = false;
                            for (int j = i; j < i_E; j++)
                            {
                                stackE[j] = stackE[j + 1];
                                btE[j].Text = stackE[j].ToString();
                            }
                            pop(ref stackE, ref i_E);

                            //R
                            btR[i_R].Visible = false;
                            for (int j = i; j < i_R; j++)
                            {
                                stackR[j] = stackR[j + 1];
                                btR[j].Text = stackR[j].ToString();
                            }
                            pop(ref stackR, ref i_R);
                            smallest_top--;
                            i = 0;
                        }
                        else i++;


                        if (i_Q > 0 || i_W > 0 || i_E > 0 || i_R > 0)//垂直相鄰的
                        {
                            //Q
                            while (i_Q > 0 && TopTwoEqual(stackQ, i_Q))
                            {
                                btQ[i_Q].Visible = false;
                                pop(ref stackQ, ref i_Q);//top:0
                                stackQ[i_Q] += stackQ[i_Q];
                            }
                            if (i_Q != -1)
                            {
                                btQ[i_Q].Visible = true;//top:0
                                btQ[i_Q].Text = stackQ[i_Q].ToString();//top:0
                            }
                            //W
                            while (i_W > 0 && TopTwoEqual(stackW, i_W))
                            {
                                btW[i_W].Visible = false;
                                pop(ref stackW, ref i_W);//top:0
                                stackW[i_W] += stackW[i_W];
                            }
                            if (i_W != -1)
                            {
                                btW[i_W].Visible = true;//top:0
                                btW[i_W].Text = stackW[i_W].ToString();//top:0
                            }
                            //E
                            while (i_E > 0 && TopTwoEqual(stackE, i_E))
                            {
                                btE[i_E].Visible = false;
                                pop(ref stackE, ref i_E);//top:0
                                stackE[i_E] += stackE[i_E];
                            }
                            if (i_E != -1)
                            {
                                btE[i_E].Visible = true;//top:0
                                btE[i_E].Text = stackE[i_E].ToString();//top:0
                            }

                            //R
                            while (i_R > 0 && TopTwoEqual(stackR, i_R))
                            {
                                btR[i_R].Visible = false;
                                pop(ref stackR, ref i_R);//top:0
                                stackR[i_R] += stackR[i_R];
                            }
                            if (i_R != -1)
                            {
                                btR[i_R].Visible = true;//top:0
                                btR[i_R].Text = stackR[i_R].ToString();//top:0
                            }
                        }
                    }//check btm row--------------------------------------------------------------------

                    label_cur_score.Text = "你的分數:" + score;
                    if (btQ[5].Visible || btW[5].Visible || btR[5].Visible || btE[5].Visible)
                    {
                        timer1.Enabled = false;
                        DialogResult result;
                        result = MessageBox.Show("Game Over\n你的分數: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (result == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                    num = 3;//reset limited time 
                    
                 


                }//try catch
                catch
                {
                    timer1.Enabled = false;
                    DialogResult result;
                    result = MessageBox.Show("Game Over\n你的分數: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }

                }//try catch
            }
        }

    }
}
