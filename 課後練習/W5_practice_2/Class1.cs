using System;

namespace ClassChicken
{
    public class Chicken
    {
        public string name, what_happened, money_status;
        private string[] message = new string[100];
        private int message_counter = 1;
        public int day = 1, money = 100, health = 70, weight = 700, hunger = 70, mood = 50;
        private bool poop = false, sick = false, dead = false;
        public long tick = DateTime.Now.Ticks; //避免偽隨機
        public Chicken()
        {
        }
        /*
            - 健康: 70 %  (0 ~ 100)
            - 體重: 700 g (600g ~ 4000g)
            - 飽足感:70 %  (0 ~ 100)
            - 心情: 50 %  (0 ~ 100)
        */
    

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool EnterName(string Text)
        {/*程式一開始禁用所有互動按鈕
            金錢為 0
            所有寵物狀態為 0
            事件提示請幫寵物取名
            輸入名稱後生成寵物
            如果 textbox 為空，預設名稱為”電子雞”
*/          if (Text == "")
                name = "電子雞";
            else
                name = Text;
            
            return true;
        }

        private void Bound()
        {
            if (health < 0) health = 0;
            if (health > 100) health = 100;

            if (weight < 0) weight= 0;

            if (hunger < 0) hunger = 0;
            if (hunger > 100) hunger = 100;

            if (mood < 0) mood = 0;
            if (mood > 100) mood = 100;

        }
        public string[] Display()
        {
            message[0] = "第 " + 1 + " 天\n";
            return message;
        }

        public bool IsBankrupt(int cost)
        {/*
            當金錢為 0 時，在按下互動按鈕時請根據
            按的按鈕顯示訊息。
            金額不足無法餵食
            金額不足無法玩耍
            金額不足無法打掃
            金額不足無法看醫生
*/
            if (money - cost < 0) return true;
            else return false;
        }


        public void Feed()
        {/*  
            - 每次 10 塊
          - 飽足感隨機增加(0~20)
          - 體重隨機增加(50~100)
          - 當存在排泄物，餵食後健康減少 10
*/
            System.Threading.Thread.Sleep(2);// 以免偽隨機出現
            if (IsBankrupt(10) == true)
            {
                money_status = "金額不足無法餵食";
                message[message_counter] = money_status;
                ++message_counter;
                return;
            }
            money -= 10;

            message[message_counter] = "餵"+ name+"吃飯了";
            ++message_counter;
            //-------------
            Random rnd = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            hunger += rnd.Next(20);
            weight += rnd.Next(50, 100);
            Bound();
            if (poop == true)
                health -= 10;
            


        }

        public void Play()
        {/*  
            - 每次 5 塊
          - 健康隨機增加(0~20)
          - 心情隨機增加(0~20)
          - 飽足感隨機減少(0~20)
*/
            System.Threading.Thread.Sleep(2);// 以免偽隨機出現
            if (IsBankrupt(5) == true)
            {
                money_status = "金額不足無法玩耍";
                message[message_counter] = money_status;
                ++message_counter;
                return;
            }
            money -= 5;

            message[message_counter] = "和"+ name+"玩耍";
            ++message_counter;
            //-------------
            Random rnd = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            health += rnd.Next(20);
            mood   += rnd.Next(20);
            hunger -= rnd.Next(20);
            Bound();
        }
        public void Clean()
        {/*-
            - 每次花費 5 塊
            - 清除排泄物
*/
            if (IsBankrupt(5) == true)
            {
                money_status = "金額不足無法打掃";
                message[message_counter] = money_status;
                ++message_counter;
                return;
            }
            money -= 5;
            message[message_counter] = "打掃了" + name + "的家";
            ++message_counter;
            //-------------
            poop = false;
            what_happened = "大便清乾淨了";
        }
        public void Doctor()
        {/*  
              - 每次花費20 塊
              - 健康加 30
              - 心情減 20
              - 移除生病狀態
*/
            System.Threading.Thread.Sleep(2);// 以免偽隨機出現

            if (IsBankrupt(20) == true)
            {
                money_status = "金額不足無法看醫生";
                message[message_counter] = money_status;
                ++message_counter;
                return;
            }
            money -= 20;

            message[message_counter] = "帶" + name + "去看醫生";
            ++message_counter;
            //-------------
            health += 30;
            mood -= 20;
            Bound();
            if (sick == true)
                what_happened = name+"康復了";
            sick = false;


        }
        public void EndDay()
        {/* 
            - 飽足感減少 20 
            - 飽足感歸零後每天體重減少 200
            - 養 10 天後健康每天減少 10
            - 計算隔天的事件

            - 如果是生病的狀態體重減150，心情減 20。
            - 如果是存在排泄物的狀態健康減 30 。
*/

            
            hunger -= 20;
            if(hunger  <= 0)
                weight -= 200;


            if (day >= 10)
                health -= 10;

            ++day;
            message[message_counter] = "\r\n第 " + day + " 天\n";
            ++message_counter;
            Bound();
            
            Event();

            if (what_happened == "平安的一天過去了")
            {
                message[message_counter] = "平安的一天過去了";
                ++message_counter;
            }

            if (sick == true) {
                weight -= 150;
                mood -= 20;
            }


            if (poop == true)
            {
                health -= 30;
            }

            Bound();
        }


        public string Event()
        {/*
        - 排泄poop
              - 當飽足感大於等於 50
        - 下蛋egg 
              - 體重大於 1000
              - 健康大於 60
              - 下蛋後健康減少 5
              - 以心情(%)為機率下蛋
              - 賣出隨機獲得 15 ~ 25 塊錢
        - 生病sick
              - 健康少等於 50
              - 心情少於等於 50
              - 以(100 - 健康)(%)機率產生生病狀態
        - 死亡dead
              - 健康小於 10
              - 體重小於 1000g
              - 以(100 - 心情)(%)機率死亡

*/
            Random rnd = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
            what_happened = string.Empty;

            if (hunger >= 50)
            {
                what_happened = "大便";
                poop = true;
                message[message_counter] = name+ "大便" + "了";
                ++message_counter;
            }

            System.Threading.Thread.Sleep(100);// 以免偽隨機出現

            if(weight>1000 && health > 60)
            {
                
                if (rnd.Next(100) <= mood)//假設mood=70%: 1~100 中 抽到小於等於 70 的機率為70;
                {
                    what_happened += "下蛋";
                    health -= 5;
                    int sell = 0;
                    sell += rnd.Next(15, 25);
                    money += sell;
                    message[message_counter] = name + "下蛋" + "了, 獲得"+sell+"元";
                    ++message_counter;
                }
            }
            System.Threading.Thread.Sleep(300);// 以免偽隨機出現

            if (health <= 50 && mood <= 50)
            {
                
                if (rnd.Next(100) <= (100 - health))
                {
                    what_happened += "生病";
                    sick = true;
                    message[message_counter] = name + "生病" + "了";
                    ++message_counter;
                }
            }
            System.Threading.Thread.Sleep(2);// 以免偽隨機出現


            if (health < 10 && weight < 1000)
            {
                
                if (rnd.Next(100) <= (100 - mood))
                {
                    what_happened = "死亡";
                    message[message_counter] = name + what_happened +"了";
                    ++message_counter;
                }
            }
            if(what_happened==string.Empty)
                what_happened = "平安的一天過去了";
            return what_happened;

        }

        
    }
}
