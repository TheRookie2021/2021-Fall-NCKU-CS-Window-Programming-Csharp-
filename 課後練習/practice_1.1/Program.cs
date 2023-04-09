using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 
            //1 月 1 號星期幾
            string input_weekday;
            int weekday;
            int[] space=new int[12];
            Console.Write("1 月 1 號星期幾 (1~7): ");

            input_weekday =Console.ReadLine();
            if (int.TryParse(input_weekday,out weekday)==false)
            {
                Console.WriteLine(" \n ... 請輸入範圍內的整數 ....\n");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (weekday<1 || weekday > 7 ) //範圍1~7
            {
                Console.WriteLine(" \n ... 輸入值超出範圍 ....\n");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //計算每個月一開始的space數
            space[0] = weekday - 1;
            for(int i = 1; i< 12; i++)
            {
                if (i == 7)//i=7, 八月時不規律
                {
                    space[i] = (space[i - 1] + 31) % 7;
                }
                else if (i == 1)
                {
                    space[i] = (space[i - 1] + 28) % 7;
                }
                else if (i % 2 == 1)//偶數月時候(30天) (i=3, 4月)
                {
                    space[i] = (space[i - 1] + 30) % 7;
                }
                else
                {
                    space[i] = (space[i - 1] + 31) % 7;
                };
            }

            //從幾月開始印
            string month;
            Console.Write("從幾月開始印(1~12): ");
            month= Console.ReadLine();
            int temp=0;
            if (int.TryParse(month, out temp) == false)
            {

                Console.WriteLine(" \n ... 請輸入範圍內的整數 ....\n");
                Console.ReadKey();
                Environment.Exit(0);
            }
            //output: 月份的英文、輸入月份到 12 月的月曆
            switch (month)
            {
                case "1":
                    //January
                    Console.WriteLine("January"); 
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    
                    for (int i = 0,day = 1; i < 31+space[0]; i++)
                    {
                      
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[0] )
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ",day);
                            day++;
                        }

                        
                    
                    }

                    Console.WriteLine();
                    goto case "2";
                case "2":
                    //February
                    Console.WriteLine(); 
                    Console.WriteLine("February");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 28 +space[1]; i++)
                    {

                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[1])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }


                    Console.WriteLine();
                    goto case "3";
                case "3":
                    //March
                    Console.WriteLine();
                    Console.WriteLine("March");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 31 + space[2]; i++)
                    {
                        
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[2])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }



                    Console.WriteLine();
                    goto case "4";
                case "4":
                    //April
                    Console.WriteLine();
                    Console.WriteLine("April");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 30 + space[3]; i++)
                    {
                        
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[3])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }
                    Console.WriteLine();
                    goto case "5";
                case "5":
                    //May
                    Console.WriteLine();
                    Console.WriteLine("May");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 31 + space[4]; i++)
                    {
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[4])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }

                    Console.WriteLine();
                    goto case "6";
                case "6":
                    //June
                    Console.WriteLine();
                    Console.WriteLine("June");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 30 + space[5]; i++)
                    {
                        
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[5])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }
                    Console.WriteLine();
                    goto case "7";
                case "7":
                    //July
                    Console.WriteLine();
                    Console.WriteLine("July");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 31 + space[6]; i++)
                    {
                        
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[6])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }

                    Console.WriteLine();
                    goto case "8";
                case "8":
                    //August 
                    Console.WriteLine();
                    Console.WriteLine("August");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 31 + space[7]; i++)
                    {

                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[7])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }

                    Console.WriteLine();
                    goto case "9";
                case "9":
                    //September 
                    Console.WriteLine();
                    Console.WriteLine("September ");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 30 + space[8]; i++)
                    {
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[8])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }

                    Console.WriteLine();
                    goto case "10";
                case "10":
                    //October
                    Console.WriteLine();
                    Console.WriteLine("October");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 31 + space[9]; i++)
                    {
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[9])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }

                    Console.WriteLine();
                    goto case "11";
                case "11" :
                    //November
                    Console.WriteLine();
                    Console.WriteLine("November");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 30 + space[10]; i++)
                    {
                        
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[10])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }
                    Console.WriteLine();
                    goto case "12";
                case "12":
                    //December
                    Console.WriteLine();
                    Console.WriteLine("December");
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");
                    for (int i = 0, day = 1; i < 31 + space[11]; i++)
                    {
                        if (i % 7 == 0 && i != 0) Console.WriteLine();
                        if (i < space[11])
                        {
                            Console.Write("    ");
                        }
                        else
                        {
                            Console.Write("{0,3} ", day);
                            day++;
                        }
                    }
                    break;

                default:
                    Console.WriteLine(" \n ... 輸入值超出範圍 ....");
                    break;

            }




            //結束程式
            Console.ReadKey();
        }
    }
}
