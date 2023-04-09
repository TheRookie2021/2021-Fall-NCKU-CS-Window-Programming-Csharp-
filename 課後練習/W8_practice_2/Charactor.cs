using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace W8_practice_2
{
    class Charactor
    {
        private int career;//1 fighter 2 magicien 3 archer
        private Color color;
        public int A, B, C, D=0;
        private bool p2 = false;
        public bool set =false;
        public int who_on = 1;//1.A     2.B    3.C     4.D

        public bool P2//be set in constructor
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
                if (p2) D++;
            }
        }

        public Color Representation//be set in career
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Career//be set in constructor
        {
            set
            {
                career = value;

                if (career == 1)//Fighter
                {
                    A = -1;//-1 stand for infinite
                    B = 0;
                    C = 0;
                    D += 5;
                    //********************color*************************
                    if (p2==false)//if is P1 and is Fighter
                    {
                        Representation = Color.DeepSkyBlue;
                    }else if (p2 == true)//if is P2 and is Fighter
                    {
                        Representation = Color.Orange;
                    }

                }
                else if (career == 2)//Magicien
                {
                    A = -1;//-1 stand for infinite
                    B = 1;
                    C = 2;
                    D += 2;
                    //********************color*************************
                    if (p2 == false)//if is P1 and is Magicien
                    {
                        Representation = Color.DarkBlue;
                    }
                    else if (p2 == true)//if is P2 and is Magicien
                    {
                        Representation = Color.DarkOrange;
                    }
                }
                else if (career == 3)//Archer
                {
                    A = -1;//-1 stand for infinite
                    B = 1;
                    C = 1;
                    D += 3;
                    //********************color*************************
                    if (p2 == false)//if is P1 and is Archer
                    {
                        Representation = Color.BlueViolet;
                    }
                    else if (p2 == true)//if is P2 and is Archer
                    {
                        Representation = Color.OrangeRed;
                    }
                }

            }
        }


        public Charactor(int set_career, bool first)//directly set career and  first/second, indirectly set color
        {
            if (first == false) P2 = true; 
            Career = set_career;
            set = true;
        }
        

    }
}
