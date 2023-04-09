using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace W7_practice_2
{
    class Enemy : Object
    {
        Random rnd = new Random();
        public Color RandomColorChange()
        {
            
            if (rnd.Next(1,4) % 3 == 0)
            {
                Speed = 20;
                Status = Color.Red;

                return Color.Red;
            }
            else if (rnd.Next(1, 4) % 3 == 1)
            {
                Speed = 10;
                Status = Color.Blue;

                return Color.Blue;
            }
            else 
            {
                Speed = 30;
                Status = Color.Green;

                return Color.Green;
            }
        }
        public void Buttontext(ref Button Kevin)
        {
            if (Status == Color.Red)
            {
                Kevin.Text = "火";
                Kevin.ForeColor = Color.White;
            }

            if (Status == Color.Green)
            {

                Kevin.Text = "木";
                Kevin.ForeColor = Color.White;
            }

            if (Status == Color.Blue)
            {

                Kevin.Text = "水";
                Kevin.ForeColor = Color.White;
            }
        }

        public void Vanish(ref Button Kevin)
        {
            PositionY = 0;
        }
        public void Showout(ref Button Kevin)
        {
            Kevin.BackColor = RandomColorChange();
            Kevin.Visible = true;
        }


    }
}
