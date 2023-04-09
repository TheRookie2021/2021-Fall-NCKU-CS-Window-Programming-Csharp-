using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace W7_practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Player A = new Player();
            Enemy[] K = new Enemy[4];
            Bullet B = new Bullet();
            Button Amy = new Button();
            Button[] Kevin = new Button[4];
            Button bullet = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            label_status.Visible=false;
            label_score.Visible = false;
            label_time.Visible = false;

            A.Range_lower = 100;
            A.Range_upper = 300;
            A.PositionX = 100;
            A.PositionY = 300;
            A.Size = 40;
            A.Speed = 50;

            B.Range_lower = 100;
            B.Range_upper = 300;
            B.PositionX = A.PositionX;
            B.PositionY = A.PositionY;
            B.Size = 20;
            

            for (int i = 0; i < 4; i++)
            {
                K[i] = new Enemy();
                K[i].Range_lower = 0;
                K[i].Range_upper = 400;
                K[i].PositionX = 100 + 50 * i;
                K[i].PositionY = 0;
                K[i].Size = 40;
            }

        }
        private void button_start_Click(object sender, EventArgs e)
        {
            
            radioButton_water.Visible=false;
            radioButton_fire.Visible = false;
            radioButton_gress.Visible = false;
            label1.Visible = false;
            button_start.Visible = false;

            
            label_status.Visible = true;
            label_score.Visible = true;
            label_time.Visible = true;

            //set bound
            Controls.Add(Amy);
            Amy.SetBounds(A.PositionX, A.PositionY, A.Size, A.Size);
            Amy.Text = "你";
            Amy.ForeColor = Color.White;
            Controls.Add(bullet);
            bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);
            B.Vanish(ref bullet);

            for(int i = 0; i < 4; i++)
            {
                Kevin[i] = new Button();
                Controls.Add(Kevin[i]);
                Kevin[i].SetBounds(K[i].PositionX, K[i].PositionY, K[i].Size, K[i].Size);
            }
            //set color
            Amy.BackColor = A.Status;
            {
                Random rnd = new Random();
                for (int j = 0; j < rnd.Next(10); j++)
                {
                    K[1].RandomColorChange();
                }
                for (int j = 0; j < rnd.Next(10); j++)
                {
                    K[0].RandomColorChange();
                }
                for (int j = 0; j < rnd.Next(10); j++)
                {
                    K[3].RandomColorChange();
                }
                for (int j = 0; j < rnd.Next(10); j++)
                {
                    K[2].RandomColorChange();
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Kevin[i].BackColor= K[i].RandomColorChange();
                K[i].Buttontext(ref Kevin[i]);
            }

            timer1.Enabled = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (A.PositionX <= A.Range_upper && A.PositionX >= A.Range_lower)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        A.MoveX(1);
                        break;
                    case Keys.D:
                        A.MoveX(3);
                        break;
                    case Keys.W:
                        if (B.cooldown == true )
                        {
                            B.BulletStatus(A);
                            bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);
                            bullet.BackColor = B.Status;
                            B.Shoot(ref bullet);
                        }
                        break;
                }
            }
            if (A.PositionX >= 250) { A.PositionX = 250; }
            if (A.PositionX <= 100) { A.PositionX = 100; }
            Amy.SetBounds(A.PositionX, A.PositionY, A.Size, A.Size);
            
        }

        private void radioButton_water_CheckedChanged(object sender, EventArgs e)
        {
            A.Status = Color.Blue;
            B.Status = A.Status;
        }

        private void radioButton_fire_CheckedChanged(object sender, EventArgs e)
        {
            A.Status = Color.Red;
            B.Status = A.Status;
        }

        private void radioButton_gress_CheckedChanged(object sender, EventArgs e)
        {
            A.Status = Color.Green;
            B.Status = A.Status;
        }

        int time_limite = 600;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (A.Score < 0)
            {
                timer1.Enabled = false;
                DialogResult result;
                label_score.Text = "目前分數:" + 0;
                if (A.Status == Color.Red)
                {
                    result = MessageBox.Show("你被熄滅了\n" + "你的分數:" + 0, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                if (A.Status == Color.Blue)
                {
                    result = MessageBox.Show("你枯竭了\n" + "你的分數:" + 0, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                if (A.Status == Color.Green)
                {
                    result = MessageBox.Show("你燒起來了\n" + "你的分數:" + 0, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }

            }
            if (time_limite<=0)
            {
                timer1.Enabled = false;
                DialogResult result;
                label_score.Text = "目前分數:" + A.Score;
                result = MessageBox.Show("遊戲結束\n" + "你的分數:" + A.Score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
            }
            time_limite--;
            //detect bullet
            if (B.shooting == true)
            {
                B.MoveY();
                bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);
            }
            B.CoolDown();

            //collide : Kevin and Amy
            for (int i = 0; i < 4; i++)
            {
                if(K[i].PositionX==A.PositionX && K[i].PositionY == A.PositionY)
                {
                    //Amy attack
                    if(A.Status==Color.Red && K[i].Status == Color.Green)
                    {
                        A.Attack(K[i]);
                        Amy.BackColor = A.Status;
                        K[i].Vanish(ref Kevin[i]);
                        Kevin[i].BackColor = K[i].RandomColorChange();
                        K[i].Buttontext(ref Kevin[i]);
                    }
                    else if(A.Status == Color.Green && K[i].Status == Color.Blue)
                    {
                        A.Attack(K[i]);
                        Amy.BackColor = A.Status;
                        K[i].Vanish(ref Kevin[i]);
                        Kevin[i].BackColor = K[i].RandomColorChange();
                        K[i].Buttontext(ref Kevin[i]);
                    }
                    else if (A.Status == Color.Blue && K[i].Status == Color.Red)
                    {
                        A.Attack(K[i]);
                        Amy.BackColor = A.Status;
                        K[i].Vanish(ref Kevin[i]);
                        Kevin[i].BackColor = K[i].RandomColorChange();
                        K[i].Buttontext(ref Kevin[i]);
                    }
                    //Amy injured
                    if (A.Status == Color.Green && K[i].Status == Color.Red)
                    {
                        A.Injured();
                        K[i].Vanish(ref Kevin[i]);
                        Kevin[i].BackColor = K[i].RandomColorChange();
                        K[i].Buttontext(ref Kevin[i]);
                    }
                    else if (A.Status == Color.Blue && K[i].Status == Color.Green)
                    {
                        A.Injured();
                        K[i].Vanish(ref Kevin[i]);
                        Kevin[i].BackColor = K[i].RandomColorChange();
                        K[i].Buttontext(ref Kevin[i]);

                    }
                    else if (A.Status == Color.Red && K[i].Status == Color.Blue)
                    {
                        A.Injured();
                        K[i].Vanish(ref Kevin[i]);
                        Kevin[i].BackColor = K[i].RandomColorChange();
                        K[i].Buttontext(ref Kevin[i]);
                    }
                    

                }
            }//for loop (kevin)

            //collide : Kevin and Bullet
            for (int i = 0; i < 4; i++)
            {
                if (K[i].PositionX == B.PositionX && K[i].PositionY >= B.PositionY &&B.shooting==true)
                {
                    //Bullet attack
                    if (B.Status == Color.Red && K[i].Status == Color.Green)
                    {
                        B.Attack(ref A); B.Vanish(ref bullet);
                        B.BulletStatus(A);
                        bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);
                    }
                    else if (B.Status == Color.Green && K[i].Status == Color.Blue)
                    {
                        B.Attack(ref A); B.Vanish(ref bullet);
                        B.BulletStatus(A);
                        bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);
                    }
                    else if (B.Status == Color.Blue && K[i].Status == Color.Red)
                    {
                        B.Attack(ref A); B.Vanish(ref bullet);
                        B.BulletStatus(A);
                        bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);
                    }

                    //Bullet injured
                    if (B.Status == Color.Green && K[i].Status == Color.Red)
                    {
                        B.Injured(ref A); B.Vanish(ref bullet);
                        B.BulletStatus(A);
                        bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);

                    }
                    else if (B.Status == Color.Blue && K[i].Status == Color.Green)
                    {
                        B.Injured(ref A); B.Vanish(ref bullet);
                        B.BulletStatus(A);
                        bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);

                    }
                    else if (B.Status == Color.Red && K[i].Status == Color.Blue)
                    {
                        B.Injured(ref A); B.Vanish(ref bullet);
                        B.BulletStatus(A);
                        bullet.SetBounds(B.PositionX, B.PositionY, B.Size, B.Size);
                    }
                    if (K[i].Status == B.Status) break;
                    else K[i].Vanish(ref Kevin[i]); K[i].Buttontext(ref Kevin[i]);

                }
            }//for loop (kevin)

            
            //Kevin out of range
            for (int i = 0; i < 4; i++)
            {
                if (K[i].PositionY >= K[i].Range_upper)
                {

                    Kevin[i].BackColor=K[i].RandomColorChange();
                    K[i].Buttontext(ref Kevin[i]);

                    K[i].PositionY = K[i].Range_lower;
                }
                K[i].MoveY();
                Kevin[i].SetBounds(K[i].PositionX, K[i].PositionY, K[i].Size, K[i].Size);
            }
            label_score.Text = "目前分數:" + A.Score;
            if (A.Status == Color.Red) label_status.Text = "目前屬性: 火";
            if (A.Status == Color.Blue) label_status.Text = "目前屬性: 水";
            if (A.Status == Color.Green) label_status.Text = "目前屬性: 木";
            label_time.Text = "倒數時間:" + time_limite/10;

        }//timer1
    }
}
