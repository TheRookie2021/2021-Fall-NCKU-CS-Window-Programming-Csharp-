using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace W8_practice_2
{
    class Chessman: System.Windows.Forms.Button
    {

        private bool placing = false;
        public int row, col;
        public void showcolor(Color players_color)
        {
            this.BackColor = players_color;
            placing = true;

        }

        public void vanish()
        {
            this.BackColor = Color.White;
            placing = false;
        }



    }
}
