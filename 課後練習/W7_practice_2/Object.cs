using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace W7_practice_2
{
    class Object
    {
        //property://player, bullet, enemy
        private Color _Status;
        private int _Speed;
        private int _Size;
        private int _Range_upper, _Range_lower;
        private int _PositionX, _PositionY; 
        public Color Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }
        public int Speed
        {
            get
            {
                return _Speed;
            }
            set
            {
                _Speed = value;
            }
        }//signed: (+)player, (+)Enemy, (-)Bullet
        public int Size
        {
            get
            {
                return _Size;
            }
            set
            {
                _Size = value;
            }
        }
        public int Range_upper
        {
            get
            {
                return _Range_upper;
            }
            set
            {
                _Range_upper = value;
            }
        }//set limitation of position x y
        public int Range_lower
        {
            get
            {
                return _Range_lower;
            }
            set
            {
                _Range_lower = value;
            }
        }//set limitation of position x y
        public int PositionX
        {
            get
            {
                return _PositionX;
            }
            set
            {
                 _PositionX = value;
            }
        }
        public int PositionY
        {
            get
            {
                return _PositionY;
            }
            set
            {
                
                 _PositionY = value;
            }
        }

        //----------------------METHOD----------------------
        public int MoveX(int L_Or_R)//1 for left, 3 for right
        {
            //sign needed!
            //player: left and right

            if(L_Or_R==1)//to left
                PositionX -= Speed;

            else if(L_Or_R == 3)//to right
                PositionX += Speed;

            return PositionX;
        }
        public int MoveY()
        {
            //sign needed!

            //bullet: bottom up (speed<0)
            //enemy: top down   (speed>0)

            PositionY += Speed;
            return PositionY;

        }
        
    }
}
