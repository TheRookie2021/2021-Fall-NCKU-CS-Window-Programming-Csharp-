using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7_practice_2
{
    class Player:Object
    {
        private int _Score;
        public int Score
        {
            get
            {
                return _Score;
            }
            set
            {
                _Score = value;
            }
        }


        //當碰到克制屬性的敵人時(水屬性的玩家碰到火屬性的敵人):分數+5，被碰到的敵人消失，玩家轉為該敵人屬性
        public void Attack(Enemy Kevin)
        {
            Score += 5;
            Status = Kevin.Status;

        }
        //當碰到被克屬性的敵人時: 分數-5,被碰到的敵人消失。
        public void Injured()
        {
            Score -= 5;
        }

        //碰到同屬敵人:不會發生任何事，重合時玩家要顯示在敵人上方。
        public void PassThrough()
        {

        }

    }
}
