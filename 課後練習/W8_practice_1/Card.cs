using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace W8_practice_1
{
    class Card : System.Windows.Forms.Button
    {
        public int number;
        public void hideNumber() {
            this.BackColor = Color.Gray;
            this.Text = null;
            this.Enabled = true;
        }
        public void showNumber() {
            this.BackColor = Color.AliceBlue;
            this.Text = number.ToString();
            this.Enabled = false;
        }
        
    }
}
