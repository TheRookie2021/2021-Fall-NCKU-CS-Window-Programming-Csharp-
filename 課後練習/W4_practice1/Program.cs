using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_p1_template
{
    class Program
    {
        public class PokerCard
        {
            //initialize poker pool
            private string[,] Pool = new string[52, 2];//col: 0 存放花色與數值 col:1 記錄張數
            private string[] Deck1 = new string[15];
            private string[] Deck2 = new string[15];

            public PokerCard()
            {
                //卡牌限制: 52張  有花色  同一個數字花色不重複 同一個花色數字不重複
                //想法1. 先建立一個52+2空間的arr 再隨機 不重複的抽取
                //初始化pool
                string[] color = new string[4];
                color[0] = "Spade";
                color[1] = "Heart";
                color[2] = "Diamond";
                color[3] = "Club";
                //設定pool的第0 col 花色與數值
                int order = 0;
                for (int i = 0; i < 4; i++)
                {
                    string temp_color = color[i];
                    for (int j = 1; j < 14; j++)
                    {
                        Pool[order, 0] = temp_color + " " + j;
                        order++;
                    }
                }
                //設定pool的第1 col=張數
                for (int i = 0; i < 52; i++)
                {
                    Pool[i, 1] = "1";
                }
            }

            public void Draw1(int times)
            //method: draw a card without putting it back (put them in a deck for drawn card) 
            {
                //抽到重覆的花色 重抽
                if (Deck1[9] != null)
                {
                    Console.WriteLine("Deck is Full!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }else if (times > 9 || times <= 0)
                {
                    Console.WriteLine("invalid draw!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }

                for (int j = 0; j < times; j++)
                {
                    long tick = DateTime.Now.Ticks; //避免偽隨機
                    Random rand_draw = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                again:
                    int RandNum = rand_draw.Next(51);
                    int CardNum = int.Parse(Pool[RandNum, 1]);
                    bool check_card = (CardNum == 0);
                    switch (check_card)
                    {
                        case true: //==0, 已抽過 再抽一次
                            goto again;

                        case false: //未抽過 抽出來放進Deck

                            for (int i = 0; i < 10; i++)
                            {
                                if (Deck1[i] == null)//Deck[i]的位置沒有東西
                                {
                                    Deck1[i] = Pool[RandNum, 0];
                                    Pool[RandNum, 1] = "0";
                                    break;
                                }

                            }

                            break;

                    }
                }
                System.Threading.Thread.Sleep(2);// 以免偽隨機出現
            }

            public void PrintTopDeck1()
            //method: return(print) the card on the top of the deck
            {
                if (Deck1[9] != null)
                {
                    Console.WriteLine("Deck is Full!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (Deck1[0] == null)
                {
                    Console.WriteLine("Deck is Empty!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                for(int i = 9; i >= 0; i--)
                {
                    if (Deck1[i] != null)
                    {
                        Console.Write($"{Deck1[i]}");
                        break;
                    }
                }


            }

            public void PrintAllDeck1()
            {
                if (Deck1[9] != null)
                {
                    Console.WriteLine("Deck is Full!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (Deck1[0] == null)
                {
                    Console.WriteLine("Deck is Empty!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                for (int i = 0; i<10 && Deck1[i]!=null ; i++)
                {
                    if (Deck1[i] != null)
                    {
                        Console.Write($"{Deck1[i]}");
                        if(Deck1[i+1] != null)
                        {

                            Console.Write($", ");
                        }
                        
                    }


                }
            }
            public int PokerValue1(int Num)
            //method: return the int value in the specific order of a deck
            {
                if (Num >= 0 || Num < 10)
                {
                    string[] word = Deck1[Num].Split(' ');
                    
                    int num = int.Parse(word[1]);
                    
                    Array.Clear(word, 0, 1);
                    if (num <= 10)
                    {
                        return num;
                    }else
                    {
                        return 10;
                    }
                }
                else
                {
                    Console.WriteLine("Out of Deck!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                return 0;
            }

            public int Counter1()
                // count the present total value
            {
                int total = 0;
                int Num_of_Ace = 0;
                int i = 0;
                for (; Deck1[i] != null; ++i) ;//to the top of deck
                //計算非Ace
                for (int j = 0; j < i; j++)
                {
                    if (PokerValue1(j) != 1)// value of # j
                    {
                        total += PokerValue1(j);
                    }else if (PokerValue1(j) == 1)
                    {
                        ++Num_of_Ace;
                    }
                }
                //then, 計算Ace
                if (Num_of_Ace != 0 && total<=21)
                {
                    switch (Num_of_Ace)//最多把一個Ace 當成11
                    {
                        case 1:
                            if (total + 11<= 21)
                            {
                                return total + 11;
                            }else
                            {
                                return total + 1;
                            }
                            
                        case 2: // 1=11; 1,1 = 1+11; 1,1,1=11+1+1; 1,1,1,1=11+1+1+1;
                                // 1,1,12= 10+1+1; 1,13= 10+11; 1,1,2= 2+11+1
                            if (total + 11 + 1 <= 21)
                            {
                                total += 12;
                                return total;
                            }
                            else
                            {
                                total += 2;
                                return total;
                            }

                        case 3:
                            if(total + 11 + 1 +1<= 21)
                            {
                                total += 13;
                                return total;
                            }
                            else
                            {
                                total += 3;
                                return total;
                            }

                        case 4:
                            if(total + 11 + 1+1+1 <= 21)
                            {
                                total += 14;
                                return total;
                            }
                            else
                            {
                                total += 4;
                                return total;
                            }

                        default: break;
                    }
                }
                


                return total;//沒有Ace 的情況會到這
            }
            public bool IsExplode1()
            {
                bool explode = (Counter1()> 21);
                return explode;//true: 爆掉 false: 未爆
            }

            public void Draw2(int times)
            //method: draw a card without putting it back (put them in a deck for drawn card) 
            {
                //抽到重覆的花色 重抽
                if (Deck2[9] != null)
                {
                    Console.WriteLine("Deck is Full!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (times > 9 || times <= 0)
                {
                    Console.WriteLine("invalid draw!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }

                for (int j = 0; j < times; j++)
                {
                    long tick = DateTime.Now.Ticks; //避免偽隨機
                    Random rand_draw = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
                again:
                    int RandNum = rand_draw.Next(51);
                    int CardNum = int.Parse(Pool[RandNum, 1]);
                    bool check_card = (CardNum == 0);
                    switch (check_card)
                    {
                        case true: //==0, 已抽過 再抽一次
                            goto again;

                        case false: //未抽過 抽出來放進Deck

                            for (int i = 0; i < 10; i++)
                            {
                                if (Deck2[i] == null)//Deck[i]的位置沒有東西
                                {
                                    Deck2[i] = Pool[RandNum, 0];
                                    Pool[RandNum, 1] = "0";
                                    break;
                                }

                            }

                            break;

                    }
                }
                System.Threading.Thread.Sleep(2);// 以免偽隨機出現
            }

            public void PrintTopDeck2()
            //method: return(print) the card on the top of the deck
            {
                if (Deck2[9] != null)
                {
                    Console.WriteLine("Deck is Full!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (Deck2[0] == null)
                {
                    Console.WriteLine("Deck is Empty!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                for (int i = 9; i >= 0; i--)
                {
                    if (Deck2[i] != null)
                    {
                        Console.Write($"{Deck2[i]}");
                        break;
                    }
                }

            }

            public void PrintAllDeck2()
            {
                if (Deck2[9] != null)
                {
                    Console.WriteLine("Deck is Full!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (Deck2[0] == null)
                {
                    Console.WriteLine("Deck is Empty!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                for (int i = 0; i < 10 && Deck2[i] != null; i++)
                {
                    if (Deck2[i] != null)
                    {
                        Console.Write($"{Deck2[i]}");
                        if (Deck2[i + 1] != null)
                        {

                            Console.Write($", ");
                        }

                    }


                }
            }
            public int PokerValue2(int Num)
            //method: return the int value in the specific order of a deck
            {
                if (Num >= 0 || Num < 10)
                {
                    string[] word = Deck2[Num].Split(' ');

                    int num = int.Parse(word[1]);

                    Array.Clear(word, 0, 1);
                    if (num <= 10)
                    {
                        return num;
                    }
                    else
                    {
                        return 10;
                    }
                }
                else
                {
                    Console.WriteLine("Out of Deck!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                return 0;
            }

            public int Counter2()
            // count the present total value
            {
                int total = 0;
                int Num_of_Ace = 0;
                int i = 0;
                for (; Deck2[i] != null; ++i) ;//to the top of deck
                //計算非Ace
                for (int j = 0; j < i; j++)
                {
                    if (PokerValue2(j) != 1)// value of # j
                    {
                        total += PokerValue2(j);
                    }
                    else if (PokerValue2(j) == 1)
                    {
                        ++Num_of_Ace;
                    }
                }
                //then, 計算Ace
                if (Num_of_Ace != 0 && total <= 21)
                {
                    switch (Num_of_Ace)//最多把一個Ace 當成11
                    {
                        case 1:
                            if (total + 11 <= 21)
                            {
                                return total + 11;
                            }
                            else
                            {
                                return total + 1;
                            }

                        case 2: // 1=11; 1,1 = 1+11; 1,1,1=11+1+1; 1,1,1,1=11+1+1+1;
                                // 1,1,12= 10+1+1; 1,13= 10+11; 1,1,2= 2+11+1
                            if (total + 11 + 1 <= 21)
                            {
                                total += 12;
                                return total;
                            }
                            else
                            {
                                total += 2;
                                return total;
                            }

                        case 3:
                            if (total + 11 + 1 + 1 <= 21)
                            {
                                total += 13;
                                return total;
                            }
                            else
                            {
                                total += 3;
                                return total;
                            }

                        case 4:
                            if (total + 11 + 1 + 1 + 1 <= 21)
                            {
                                total += 14;
                                return total;
                            }
                            else
                            {
                                total += 4;
                                return total;
                            }

                        default: break;
                    }
                }



                return total;//沒有Ace 的情況會到這
            }
            public bool IsExplode2()
            {
                bool explode = (Counter2() > 21);
                return explode;//true: 爆掉 false: 未爆
            }


        }

        static void Main(string[] args)
        {
            try
            {
                // 程式流程
                // 1. 輸入玩家1、玩家2初始金錢(需要格式檢查)
                
                Console.Write("玩家1初始金錢: ");
                string input_money_player1=Console.ReadLine();
                int money_player1 ;
                if (int.TryParse(input_money_player1, out money_player1) == false)
                {
                    Console.WriteLine("請輸入正確格式");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                Console.Write("玩家2初始金錢: ");
                string input_money_player2 = Console.ReadLine();
                int money_player2;
                if (int.TryParse(input_money_player2, out money_player2) == false)
                {
                    Console.WriteLine("請輸入正確格式");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                Console.WriteLine("--------------------------------------------------------");

            // 2. 顯示玩家1初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
            //    手牌花色：Spade, Heart, Diamond, Club
            //    手牌點數：1~13
            //    手牌顯示格式: "花色 點數"
            //-----------------------------------------------------------------------------------------
            new_round:
                // 2.1 顯示抽牌(初始) 
                PokerCard card_player = new PokerCard();
                card_player.Draw1(2);
                card_player.Draw2(2);

                int score_player1 = 0;
                int score_player2 = 0;
             
                //P1狀態顯示
                Console.Write("玩家1手牌: ");
                card_player.PrintAllDeck1();
                score_player1 = card_player.Counter1();
                Console.WriteLine($"\n玩家1目前點數: {score_player1}");
                Console.WriteLine($"玩家1目前金錢: {money_player1}");
                //P1下注
            P1_betting:
                    Console.Write("輸入下注金額:");
                    string input_bet_player1 = Console.ReadLine();
                    int bet_player1;
                    if (int.TryParse(input_bet_player1, out bet_player1) == false)
                    {
                        Console.WriteLine("請輸入正確格式");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if ((money_player1 - bet_player1) < 0)
                    {
                        Console.WriteLine("金錢不足，請重新輸入!");
                        goto P1_betting;
                    }else if (bet_player1 == 0)
                    {
                        Console.WriteLine("金錢不能為零，請重新輸入!");
                        goto P1_betting;
                    }

                //P2狀態顯示
                Console.Write("\n玩家2手牌: ");
                card_player.PrintAllDeck2();
                score_player2 = card_player.Counter2();
                Console.WriteLine($"\n玩家2目前點數: {score_player2}");
                Console.WriteLine($"玩家2目前金錢: {money_player2}");

            P2_betting:
                Console.Write("輸入下注金額:");
                string input_bet_player2 = Console.ReadLine();
                int bet_player2;
                if (int.TryParse(input_bet_player2, out bet_player2) == false)
                {
                    Console.WriteLine("請輸入正確格式");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if ((money_player2 - bet_player2) < 0)
                {
                    Console.WriteLine("金錢不足，請重新輸入!");
                    goto P2_betting;
                }
                else if (bet_player2 == 0)
                {
                    Console.WriteLine("金錢不能為零，請重新輸入!");
                    goto P2_betting;
                }
                goto round_player1;

            //-----------------------------------------------------------------------------------------

            //玩家1行動
            round_player1:
                Console.WriteLine();

                Console.WriteLine("玩家1行動");
                while (true)
                {
                    //P1狀態
                    Console.Write("\n玩家1手牌: ");
                    card_player.PrintAllDeck1();
                    score_player1 = card_player.Counter1();
                    Console.WriteLine($"\n玩家1目前點數: {score_player1}");
                    Console.WriteLine($"玩家1目前金錢: {money_player1}");
                    //是否繼續抽牌? 1.還有錢:是 loop 否 outof loop and print status  (即使爆掉也可以繼續)
                    Console.Write("是否繼續抽牌? (Yes:1/No:P) ");
                    string enter = Console.ReadLine();
                    switch (enter)
                    {
                        case "1":
                            //P1選擇繼續抽牌
                            card_player.Draw1(1);

                             break;
                        case "P":
                            Console.Write("\n玩家1手牌: ");
                            card_player.PrintAllDeck1();
                            score_player1 = card_player.Counter1();
                            Console.WriteLine($"\n玩家1目前點數: {score_player1}");
                            Console.WriteLine($"玩家1目前金錢: {money_player1}");

                            Console.WriteLine();
                            if (score_player1 > 21) goto judging;
                            goto round_player2;
                        default:
                            Console.WriteLine("請輸入正確格式");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }

                    //判定P1 點數是否爆掉: 是 結束; 否 while 繼續
                    if (card_player.IsExplode1())
                    {
                        Console.Write("\n玩家1手牌: ");
                        card_player.PrintAllDeck1();
                        score_player1 = card_player.Counter1();
                        Console.WriteLine($"\n玩家1目前點數: {score_player1}");
                        Console.WriteLine($"玩家1目前金錢: {money_player1}");
                        Console.Write("\n玩家1爆了!\n");
                        goto judging;
                      
                    }


                    // 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)
                    //    注意1：抽牌完要顯示玩家手牌與點數V
                    //    注意2：選擇停止抽牌，需印出當前點數

                }//while P1

            round_player2:
                if (score_player1 > 21)
                {
                    goto judging;
                }
                Console.WriteLine("玩家2行動");
                while (true)
                {
                    //P2狀態
                    Console.Write("\n玩家2手牌: ");
                    card_player.PrintAllDeck2();
                    score_player2 = card_player.Counter2();
                    Console.WriteLine($"\n玩家2目前點數: {score_player2}");
                    Console.WriteLine($"玩家2目前金錢: {money_player2}");
                    //是否繼續抽牌? 1.還有錢:是 loop 否 outof loop and print status  (即使爆掉也可以繼續)
                    Console.Write("是否繼續抽牌? (Yes:1/No:P) ");
                    string enter = Console.ReadLine();
                    switch (enter)
                    {
                        case "1":
                            //P1選擇繼續抽牌
                            card_player.Draw2(1);

                            break;
                        case "P":
                            Console.Write("\n玩家2手牌: ");
                            card_player.PrintAllDeck2();
                            score_player2 = card_player.Counter2();
                            Console.WriteLine($"\n玩家2目前點數: {score_player2}");
                            Console.WriteLine($"玩家2目前金錢: {money_player2}");

                            Console.WriteLine();

                            goto judging;
                        default:
                            Console.WriteLine("請輸入正確格式");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }

                    //判定P1 點數是否爆掉: 是 結束; 否 while 繼續
                    if (card_player.IsExplode2())
                    {
                        Console.Write("\n玩家2手牌: ");
                        card_player.PrintAllDeck2();
                        score_player2 = card_player.Counter2();
                        Console.WriteLine($"\n玩家2目前點數: {score_player2}");
                        Console.WriteLine($"玩家2目前金錢: {money_player2}");
                        Console.Write("\n玩家2爆了!\n");
                        goto judging;

                    }


                    // 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)
                    //    注意1：抽牌完要顯示玩家手牌與點數V
                    //    注意2：選擇停止抽牌，需印出當前點數

                }//while P2


            //結算: 有人破產 遊戲結束 沒人破產 回到上一步驟
            judging:
                //比大小
                if (score_player1 > 21|| card_player.IsExplode1())
                {
                    Console.WriteLine("此局玩家2獲勝!");
                    Console.WriteLine("玩家2獲得" + bet_player1 + "金錢");

                    money_player1 -= bet_player1;
                    money_player2 += bet_player1;
                    Console.WriteLine("--------------------------------------------------------");

                }
                else if (score_player2>21|| card_player.IsExplode2())
                {
                    Console.WriteLine("此局玩家1獲勝!");
                    Console.WriteLine("玩家1獲得" + bet_player2 + "金錢");

                    money_player2 -= bet_player2;
                    money_player1 += bet_player2;
                    Console.WriteLine("--------------------------------------------------------");

                }
                else if (score_player1 > score_player2)
                {
                    Console.WriteLine("此局玩家1獲勝!");
                    Console.WriteLine("玩家1獲得" + bet_player2 + "金錢");

                    Console.WriteLine("--------------------------------------------------------");

                    //P2失去賭金 直接給player1
                    money_player2 -= bet_player2;
                    money_player1 += bet_player2;
                }
                else if(score_player1< score_player2)
                {
                    Console.WriteLine("此局玩家2獲勝!");
                    Console.WriteLine("玩家2獲得" + bet_player1 + "金錢");

                    Console.WriteLine("--------------------------------------------------------");

                    //P1失去賭金 直接給player2
                    money_player1 -= bet_player1;
                    money_player2 += bet_player1;
                }
                else
                {
                    Console.WriteLine("平手!拿回各自的錢");
                    Console.WriteLine("--------------------------------------------------------");

                    goto new_round;
                }

                // 5. 結果判定
                //    case1 : 玩家1在抽牌時超過21點，直接判定玩家2獲勝(跳過玩家2行動)
                //            Console.WriteLine("玩家1爆了，玩家2獲勝!");
                //    case2 : 玩家2在抽牌時超過21點，直接判定玩家1獲勝
                //            Console.WriteLine("玩家2爆了，玩家1獲勝!");
                //    case3 : 若雙方都沒超過21點，比較點數大小並判斷勝敗平手
                //
                //    玩家1/2獲勝：Console.WriteLine("玩家1/2獲勝，獲得" + [玩家2/1下注金錢] + "金錢");
                //    平手：Console.WriteLine("平手!拿回各自的錢");V
                //
                //破產判定
                if (money_player2 == 0)
                {
                    Console.Write("玩家2破產了!\n玩家1勝利!\n");
                    Console.Write("|GAME OVER|\n");
                    Console.ReadKey();
                    Environment.Exit(0);
                }else if (money_player1 == 0)
                {
                    Console.Write("玩家1破產了!\n玩家2勝利!\n");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    goto new_round;
                }


                //    Console.WriteLine("玩家1手牌: " + [手牌1] + ", " + [手牌2]);
                //    Console.WriteLine("玩家1目前點數: " + [玩家1總點數]);
                //    Console.WriteLine("玩家1目前金錢: " + [玩家1金錢]);
                //    Console.Write("請輸入下注金額: ");V
                //    金錢不足：Console.WriteLine("金錢不足，請重新輸入!");、並重新輸入V
                //    下注金額0：Console.WriteLine("金錢不能為零，請重新輸入!");、並重新輸入 V



                // 6. 如果雙方都還有錢就回到步驟2，否則結束程式



                // 3. 顯示玩家2初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查

                // 3.1 顯示抽牌(初始)
                // 3.2 輸入下注金額 並檢查範圍


                //    Console.WriteLine("玩家2手牌: " + [手牌1] + ", " + [手牌2]);
                //    Console.WriteLine("玩家2目前點數: " + [玩家2總點數]);
                //    Console.WriteLine("玩家2目前金錢: " + [玩家2金錢]);




                // 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)
                //    注意1：抽牌完要顯示玩家手牌與點數
                //    注意2：選擇停止抽牌，需印出當前點數


                //    while (true) 
                //        Console.WriteLine("玩家1/2行動(輸入1抽1張排、輸入P停止抽牌):");
                //        if 輸入 1:
                //            Console.WriteLine("玩家1/2手牌: " + [手牌1] + ", " + [手牌2] + ", " + ....);
                //            Console.WriteLine("玩家1/2目前點數: " + [玩家1/2總點數]);
                //            if 超過21點:
                //                break
                //            else
                //                continue
                //        else if 輸入 P:
                //            停止抽牌：Console.WriteLine("玩家1/2跳過，目前點數: " + [玩家總點數]);
                //            break
                //
                // 6. 如果雙方都還有錢就回到步驟2，否則結束程式
                //
                // 格式檢查錯誤：、並直接結束程式
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
