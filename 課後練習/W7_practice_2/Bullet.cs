using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace W7_practice_2
{
    class Bullet : Object
    {
        private int cool_down = 0;
        public bool shooting = false;
        //only use positionY
        public void BulletStatus(Player Amy)
        {
            Status = Amy.Status;
            PositionX = Amy.PositionX;
            PositionY = Amy.PositionY;
            if (Status == Color.Blue)
            {
                Speed = -10;
            }else if(Status == Color.Red)
            {
                Speed = -20;
            }
            else if (Status == Color.Green)
            {
                Speed = -30;
            }

        }
        public bool cooldown = true;
        public void CoolDown()
        {
            if (cool_down > 0)
            {
                --cool_down;
                cooldown = false;
            }
            else //ready to shoot
            {
                cooldown = true;
            }
        }
        public void Shoot(ref Button Bullet)
        {
            if (cooldown== true)
            {
                Bullet.Visible = true;
                shooting = true;
                cool_down = 10;//shoot and reset cool down
            }
        }
       
        public void Attack(ref Player Amy)
        {
            Amy.Score += 2;
        }
        public void Vanish(ref Button Bullet)
        {
            shooting = false;
            Bullet.Visible = false;
        }
        public void Injured(ref Player Amy)
        {
            Amy.Score -= 2;
        }
    }
}
