using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8_practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------properties--------------------------------------------------------------------
        Chessman[,] chessboard;
        Charactor P1, P2;
        bool[,] check_P1_board, check_P2_board;
        bool take_turn = true; //P1's turn for true, P2 for false
        /*
        button_start

        label_P1
            button_fight_1
            button_magic_1
            button_arch_1
        
                groupBox1
            radioButton_chessA_P1
            radioButton_chessB_P1
            radioButton_chessD_P1
            radioButton_chessC_P1
        
        label_P2
            button_fight_2
            button_magic_2
            button_arch_2

                groupBox2
            radioButton_chessD_P2
            radioButton_chessC_P2
            radioButton_chessB_P2
            radioButton_chessA_P2

         */

        //------------------------------------------------------------properties--------------------------------------------------------------------
        //------------------------------------------------------------start--------------------------------------------------------------------
        int row, col;
        private void Form1_Load(object sender, EventArgs e)
        {

            check_P1_board = new bool[19, 19];
            check_P2_board = new bool[19, 19];
            //set check board
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {

                    check_P1_board[i, j] = false;
                    check_P2_board[i, j] = false;
                }
            }
        }
        private void chess_Click(object sender, EventArgs e)
        {
            Chessman chessRef = (Chessman)sender;
            if (take_turn == true)
            {//P1's turn now
                switch (P1.who_on)
                {
                    case 1://普通棋子
                        if (check_P1_board[chessRef.row, chessRef.col] == false
                             && check_P2_board[chessRef.row, chessRef.col] == false
                             )
                        {
                            chessRef.BackColor = P1.Representation;
                            check_P1_board[chessRef.row, chessRef.col] = true;
                        }
                        else return;
                        break;
                        //---------------------------------------------------------------
                    case 2://橫向棋子(右加一)
                        if (P1.B > 0) P1.B--;
                        else return;
                        if (check_P1_board[chessRef.row, chessRef.col] == false
                            && check_P2_board[chessRef.row, chessRef.col] == false
                                 )
                        {
                            chessRef.BackColor = P1.Representation;
                            check_P1_board[chessRef.row, chessRef.col] = true;
                        }
                        else return;
                        if (chessRef.col + 1 < 19)
                        if (check_P1_board[chessRef.row, chessRef.col + 1] == false
                            && check_P2_board[chessRef.row, chessRef.col + 1] == false
                            )
                        {
                            chessboard[chessRef.row, chessRef.col+1].BackColor= P1.Representation;
                            check_P1_board[chessRef.row, chessRef.col + 1] = true;
                        }

                        break;
                        //---------------------------------------------------------------
                    case 3://縱向棋子(下加一
                        if (P1.C > 0) P1.C--;
                        else return;
                        if (check_P1_board[chessRef.row, chessRef.col] == false
                            && check_P2_board[chessRef.row, chessRef.col] == false
                            )
                        {
                            chessRef.BackColor = P1.Representation;
                            check_P1_board[chessRef.row, chessRef.col] = true;
                        }
                        else return;
                        /*
                         */
                        if (chessRef.row + 1 < 19)
                        if (check_P1_board[chessRef.row+1, chessRef.col ] == false
                            && check_P2_board[chessRef.row+1, chessRef.col ] == false
                            )
                        {
                            chessboard[chessRef.row + 1, chessRef.col].BackColor = P1.Representation;
                            check_P1_board[chessRef.row + 1, chessRef.col] = true;
                        }

                        break;
                        //---------------------------------------------------------------
                    case 4://覆蓋棋子
                        if (P1.D > 0) P1.D--;
                        else return;
                        chessRef.BackColor = P1.Representation;
                        check_P1_board[chessRef.row, chessRef.col] = true;

                        if(check_P2_board[chessRef.row, chessRef.col] == true)
                        {
                            check_P2_board[chessRef.row, chessRef.col] = false;
                        }
                        break;
                    default:
                        radioButton_chessA_P1.Checked = true; P1.who_on = 1;//rdb: default selection
                        goto case 1;
                }//swich P1 who_on

                
            if (check(check_P1_board, chessRef.row, chessRef.col))
                {
                    string msg = "P1獲勝";

                    DialogResult result;
                    result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                 
                radioButton_chessA_P1.Checked = true; P1.who_on = 1;//rdb: default selection
                turn(ref take_turn); groupBox2.Enabled = true; groupBox1.Enabled = false;
            }
            else
            {//P2's turn now
                switch (P2.who_on)
                {
                    case 1://普通棋子
                        if (check_P2_board[chessRef.row, chessRef.col] == false
                             && check_P1_board[chessRef.row, chessRef.col] == false
                             )
                        {
                            chessRef.BackColor = P2.Representation;
                            check_P2_board[chessRef.row, chessRef.col] = true;
                        }
                        else return;
                        break;
                    //---------------------------------------------------------------
                    case 2://橫向棋子(右加一)
                        if (P2.B > 0) P2.B--;
                        else return;
                        if (check_P2_board[chessRef.row, chessRef.col] == false
                                 && check_P1_board[chessRef.row, chessRef.col] == false
                                 )
                        {
                            chessRef.BackColor = P2.Representation;
                            check_P2_board[chessRef.row, chessRef.col] = true;
                        }
                        else return;
                        if (chessRef.col + 1 < 19)
                            if (check_P2_board[chessRef.row, chessRef.col + 1] == false
                                && check_P1_board[chessRef.row, chessRef.col + 1] == false
                                )
                            {
                                chessboard[chessRef.row, chessRef.col + 1].BackColor = P2.Representation;
                                check_P2_board[chessRef.row, chessRef.col + 1] = true;
                            }

                        break;
                    //---------------------------------------------------------------
                    case 3://縱向棋子(上加一
                        if (P2.C > 0) P2.C--;
                        else return;
                        if (check_P2_board[chessRef.row, chessRef.col] == false
                            && check_P1_board[chessRef.row, chessRef.col] == false
                            )
                        {
                            chessRef.BackColor = P2.Representation;
                            check_P2_board[chessRef.row, chessRef.col] = true;
                        }
                        else return;
                        if (chessRef.row + 1 < 19)
                            if (check_P1_board[chessRef.row + 1, chessRef.col] == false
                                && check_P1_board[chessRef.row + 1, chessRef.col] == false
                                )
                            {
                                chessboard[chessRef.row + 1, chessRef.col].BackColor = P2.Representation;
                                check_P2_board[chessRef.row + 1, chessRef.col] = true;
                            }

                        break;
                    //---------------------------------------------------------------
                    case 4://覆蓋棋子
                        if (P2.D > 0) P2.D--;
                        else return;
                        chessRef.BackColor = P2.Representation;
                        check_P2_board[chessRef.row, chessRef.col] = true;

                        if (check_P1_board[chessRef.row, chessRef.col] == true)
                        {
                            check_P1_board[chessRef.row, chessRef.col] = false;
                        }
                        break;
                    default:
                        radioButton_chessA_P2.Checked = true; P2.who_on = 1;//rdb: default selection
                        goto case 1;
                }//swich P2 who_on
                if (check(check_P2_board, chessRef.row, chessRef.col))
                {
                    string msg = "P2獲勝";
                    
                    DialogResult result;
                    result = MessageBox.Show(msg, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                radioButton_chessA_P2.Checked = true; P2.who_on = 1;//rdb: default selection
                turn(ref take_turn); groupBox1.Enabled = true; groupBox2.Enabled = false;
            }

        }
        private void turn (ref bool now)
        {
            if (now == true)//P1's turn
                now = false;//change to P2's turn
            else now = true;//P2 to P1
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            try
            {
                if (P1.set && P2.set)
                {
                    button_start.Visible = false;
                    groupBox2.Visible = true;
                    groupBox1.Visible = true;
                    button_fight_1.Visible = false;
                    button_magic_1.Visible = false;
                    button_arch_1.Visible = false;
                    button_fight_2.Visible = false;
                    button_magic_2.Visible = false;
                    button_arch_2.Visible = false;

                    //label


                    //set career

                    //show button matrix
                    //set button matrix
                    chessboard = new Chessman[19, 19];
                    for (int i = 0; i < 19; i++)
                    {
                        for (int j = 0; j < 19; j++)
                        {
                            chessboard[i, j] = new Chessman();
                            chessboard[i, j].row = i;
                            chessboard[i, j].col= j;
                            chessboard[i, j].SetBounds(150 + 21 * j, 50 + 21 * i, 21, 21);
                            Controls.Add(chessboard[i, j]);
                            this.chessboard[i, j].Click += new System.EventHandler(this.chess_Click);//button event
                        }
                    }
                }
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("請設定雙方職業");
                return;
            }



         

        }//btn start clk
        //------------------------------------------------------------start--------------------------------------------------------------------
        //------------------------------------------------------------P1-career--------------------------------------------------------------------

        private void button_fight_1_Click(object sender, EventArgs e)
        {
            P1 = new Charactor(1, true);
            label_P1.Text = "P1: 戰士";
            button_fight_1.Enabled = false;
            button_magic_1.Enabled = false;
            button_arch_1.Enabled = false;
           

        }

        private void button_magic_1_Click(object sender, EventArgs e)
        {
            P1 = new Charactor(2, true);
            label_P1.Text = "P1: 法師";
            button_fight_1.Enabled = false;
            button_magic_1.Enabled = false;
            button_arch_1.Enabled = false;
        }

        private void button_arch_1_Click(object sender, EventArgs e)
        {
            P1 = new Charactor(3, true);
            label_P1.Text = "P1: 弓箭手";
            button_fight_1.Enabled = false;
            button_magic_1.Enabled = false;
            button_arch_1.Enabled = false;
        }
        private void radioButton_chessA_P1_CheckedChanged(object sender, EventArgs e)
        {
            P1.who_on = 1;
           
        }

        private void radioButton_chessB_P1_CheckedChanged(object sender, EventArgs e)
        {
            P1.who_on = 2;
        }

        private void radioButton_chessC_P1_CheckedChanged(object sender, EventArgs e)
        {
            P1.who_on = 3;
        }

        private void radioButton_chessD_P1_CheckedChanged(object sender, EventArgs e)
        {
            P1.who_on = 4;
        }

//------------------------------------------------------------P1-career--------------------------------------------------------------------
//------------------------------------------------------------P2-career--------------------------------------------------------------------

        private void button_fight_2_Click(object sender, EventArgs e)
        {
            P2 = new Charactor(1, false);
            label_P2.Text = "P2: 戰士";
            button_fight_2.Enabled = false;
            button_magic_2.Enabled = false;
            button_arch_2.Enabled = false;
        }

        private void button_magic_2_Click(object sender, EventArgs e)
        {
            P2 = new Charactor(2, false);
            label_P2.Text = "P2: 法師";
            button_fight_2.Enabled = false;
            button_magic_2.Enabled = false;
            button_arch_2.Enabled = false;
        }

        private void button_arch_2_Click(object sender, EventArgs e)
        {
            P2 = new Charactor(3, false);
            label_P2.Text = "P2: 弓箭手";
            button_fight_2.Enabled = false;
            button_magic_2.Enabled = false;
            button_arch_2.Enabled = false;
        }


        private void radioButton_chessA_P2_CheckedChanged(object sender, EventArgs e)
        {
            P2.who_on = 1;
        }

        private void radioButton_chessB_P2_CheckedChanged(object sender, EventArgs e)
        {
            P2.who_on = 2;
        }


        private void radioButton_chessC_P2_CheckedChanged(object sender, EventArgs e)
        {
            P2.who_on = 3;
        }

        private void radioButton_chessD_P2_CheckedChanged(object sender, EventArgs e)
        {
            P2.who_on = 4;
        }
//------------------------------------------------------------P2-career--------------------------------------------------------------------
        private bool check(bool [,] board,int row,int col)
        {
            int cur_r = row, cur_c = col;
            int verti = 1, heriz = 1, deg45 = 1, deg135 = 1;

            //0
           
            for(int i = 1; i < 5; i++)
            {
                //right
                if (cur_c + i < 19)
                {
                    if (board[cur_r, cur_c + i] == true)
                    {
                        ++heriz;
                    }
                    else
                    {
                        cur_r = row;
                        cur_c = col;
                        break;
                    }
                }
                else break;

            }

                for (int i = 1; i < 5; i++)
            {
                //left
                if (cur_c - i > -1)
                {
                    if (board[cur_r, cur_c - i] == true)
                    {
                        ++heriz;
                    }
                    else
                        break;
                }
                else break;

            }
            
            //45
            for (int i = 1; i < 5; i++)
            {
                //right up
                if (cur_r - i > -1 && cur_c + i < 19)
                {
                    if (board[cur_r - i, cur_c + i] == true)
                    {
                        ++deg45;
                    }
                    else
                    {
                        cur_r = row;
                        cur_c = col;
                        break;
                    }
                }
                else break;
            }
            for (int i = 1; i < 5; i++)
            {
                //left down
                if (cur_r + i < 19 && cur_c - i > -1)
                {
                    if (board[cur_r + i, cur_c - i] == true)
                    {
                        ++deg45;
                    }

                    else break;
                }
                else break;

            }
            //90
            for (int i = 1; i < 5; i++)
            {
                //up
                if (cur_r - i > -1)
                {
                    if (board[cur_r - i, cur_c] == true)
                    {
                        ++verti;
                    }
                    else
                    {
                        cur_r = row;
                        cur_c = col;
                        break;
                    }
                }
                else break;
            }
            for (int i = 1; i < 5; i++)
            {
                //down
                if (cur_r + i < 19)
                {
                    if (board[cur_r + i, cur_c] == true)
                    {
                        ++verti;
                    }

                    else break;
                }
                else break;
                
            }
            

            //135
            for (int i = 1; i < 5; i++)
            {
                //left up
                if (cur_r - i > -1 && cur_c - 1 > -1)
                {
                    if (board[cur_r - i, cur_c - i] == true)
                    {
                        ++deg135;
                    }
                    else
                    {
                        cur_r = row;
                        cur_c = col;
                        break;
                    }
                }
                else break;
            }
            for (int i = 1; i < 5; i++)
            {
                //left up
                if (cur_r + i < 19 && cur_c + 1 < 19)
                {
                    if (board[cur_r + i, cur_c + i] == true)
                    {
                        ++deg135;
                    }

                    else break;
                }
                else break;
            }

            if (heriz >= 5) return true;
            if (verti >= 5) return true;
            if (deg45 >= 5) return true;
            if (deg135 >= 5) return true;
        
            return false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            radioButton_chessA_P1.Text = "普通棋子";
            radioButton_chessB_P1.Text = "橫向棋子" + P1.B;
            radioButton_chessC_P1.Text = "縱向棋子" + P1.C;
            radioButton_chessD_P1.Text = "覆蓋棋子" + P1.D;

            radioButton_chessA_P2.Text = "普通棋子";
            radioButton_chessB_P2.Text = "橫向棋子" + P2.B;
            radioButton_chessC_P2.Text = "縱向棋子" + P2.C;
            radioButton_chessD_P2.Text = "覆蓋棋子" + P2.D;
        }


    }//form end
}