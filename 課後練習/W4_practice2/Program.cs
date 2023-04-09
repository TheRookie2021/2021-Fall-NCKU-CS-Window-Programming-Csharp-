using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_practice2
{

    
    class Program
    {

        //DFS
        public static void FindWay_DFS(ref char[,] map,int start_row,int start_col, ref  int end_row, ref int end_col, ref int steps,ref bool ans) {
          //Console.WriteLine(start_row+","+ start_col);
           //Console.WriteLine(end_row + "," + end_col);

            /*
                “0”代表起點
                “X”代表終點
                “1”代表牆壁，不能通過
                “ Space”代表路徑，你只能走這裡
            */

            //計算目前位置與終點的相對距離、方向 (p.s. 右下 數值越大)
            bool relative_row = start_row > end_row;//true: 終點位於目前位置的上方
                bool relative_col = start_col > end_col;//true: 終點位於目前位置的左方
                int vector_row = end_row - start_row;//為了比較row col 之相對遠近
                int vector_col = end_col - start_col;
            //Console.WriteLine(relative_row + "," + relative_col);
            //Console.WriteLine(vector_row + "," + vector_col);

            //end condition: 1. 遇到X, output adjusted map ; 2. 無解(回到原點且無法再走任何一步) 
            if (    map[start_row + 1, start_col] == 'X' ||
                    map[start_row - 1, start_col] == 'X' ||
                    map[start_row, start_col + 1] == 'X' ||
                    map[start_row, start_col - 1] == 'X')
            {
                //PrintMap(ref map);
                //Console.WriteLine(steps);
                ans = true;
                return;

            }
            else 
            {

                //目前位置與終點同行或同列該怎麼辦: 同row 先試試左右  同col 先試試上下
                if (start_row == end_row)//同row
                {
                    // 先試左右比較好
                    
                        if (relative_col == true)//終點位於目前位置的左方 先試左
                        {
                            goto L_first;
                        }
                        else if (relative_col == false)//終點位於目前位置的右方 先試右
                        {
                            goto R_first;
                        }
                    
                } else if(start_col == end_col)//同col
                {
                    //先試上下比較好
                    
                        if (relative_row == true)//終點位於目前位置的上方 先試上
                        {
                            goto U_first;
                        }
                        else if (relative_row == false)//終點位於目前位置的下方 先試下
                        {
                            goto D_first;
                        }
                    
                }
                else//不同行且不同列 (p.s. 不會出現同行同列 因為在那之前函示已經return了)
                {
                    if (vector_row <0 && vector_col>0 )// 終點在第一象限，先試右上比較好
                    {
                        if (map[start_row, start_col + 1] == ' ')
                        {
                            goto R_first;
                        }
                        else if (map[start_row-1 , start_col ] == ' ')
                        {
                            goto U_first;
                        }
                    }
                    else if (vector_row < 0 && vector_col <0 )// 終點在第二象限，先試左上比較好
                    {
                        if (map[start_row, start_col -1] == ' ')
                        {
                            goto L_first;
                        }
                        else if (map[start_row - 1, start_col] == ' ')
                        {
                            goto U_first;
                        }
                    }
                    else if(vector_row>0 && vector_col<0 )/// 終點在第三象限，先試左下比較好
                    {
                        if (map[start_row, start_col - 1] == ' ')
                        {
                            goto L_first;
                        }
                        else if (map[start_row+1 , start_col] == ' ')
                        {
                            goto D_first;
                        }
                    }
                    else if (vector_row > 0 && vector_col > 0)// 終點在第四象限，先試右下比較好
                    {
                        if (map[start_row, start_col + 1] == ' ')
                        {
                            goto R_first;
                        }
                        else if (map[start_row+1, start_col ] == ' ')
                        {
                            goto D_first;
                        }
                    }
                }
            }

        //------------------------------------------------------------------------------------------
        //檢查有沒有路 右上為先 VS 上右為先

        R_first:
            if (map[start_row, start_col + 1] == ' ')
            {
                //Console.WriteLine("R");
                map[start_row, start_col + 1] = '*';
                ++steps;
                FindWay_DFS(ref map, start_row, start_col + 1, ref end_row, ref end_col, ref steps, ref ans);
                return;

            }
            
          //++++++++++++++++++++++++++++++++++++++++++++
           


        L_first:
            if (map[start_row, start_col - 1] == ' ')
            {

                //Console.WriteLine("L");
                map[start_row, start_col - 1] = '*';
                ++steps;
                FindWay_DFS(ref map, start_row, start_col - 1, ref end_row, ref end_col, ref steps, ref ans);
                return;

            }//不會有L走不了緊接R

        //++++++++++++++++++++++++++++++++++++++++++++

        U_first:
            if (map[start_row - 1, start_col] == ' ')
            {
                //Console.WriteLine("U");
                map[start_row - 1, start_col] = '*';
                ++steps;
                FindWay_DFS(ref map, start_row - 1, start_col, ref end_row, ref end_col, ref steps, ref ans);
                return;
            }
            
            //++++++++++++++++++++++++++++++++++++++++++++

            D_first:
            if (map[start_row + 1, start_col] == ' ')
            {

                //Console.WriteLine("D");
                map[start_row + 1, start_col] = '*';
                ++steps;
                FindWay_DFS(ref map, start_row + 1, start_col, ref end_row, ref end_col, ref steps, ref ans);

                return;

            }else if(   
                        map[start_row - 1, start_col] == ' ' ||
                        map[start_row, start_col + 1] == ' ' ||
                        map[start_row, start_col - 1] == ' '    )
            {
                goto R_first;
                
            }
           


            //-----------------------------------------------------------
            //若都沒有路了，代表是死路: 回頭並標記現在的位置為 d 並回頭
            if (map[start_row + 1, start_col] == '*')
            {
                map[start_row, start_col] = 'd';
                --steps;
                FindWay_DFS(ref map, start_row + 1, start_col, ref end_row, ref end_col, ref steps, ref ans);
                return;

            }

            if (map[start_row - 1, start_col] == '*')
            {
                map[start_row, start_col] = 'd';
                --steps;
                FindWay_DFS(ref map, start_row - 1, start_col, ref end_row, ref end_col, ref steps, ref ans);
                return;

            }

            if (map[start_row, start_col + 1] == '*')
            {
                map[start_row, start_col] = 'd';
                --steps;
                FindWay_DFS(ref map, start_row, start_col + 1, ref end_row, ref end_col, ref steps, ref  ans);
                return;

            }

            if (map[start_row, start_col - 1] == '*')
            {
                map[start_row, start_col] = 'd';
                --steps;
                FindWay_DFS(ref map, start_row, start_col - 1, ref end_row, ref end_col, ref steps,ref  ans);
                return;

            }




            //-----------------------------------------------------------
            //如果無解 無反應

            ans = false;
                
        }


        public static void PrintMap(ref char[,] map)
        {
            //1. output map with way
           
            //2. output num of steps
            //將FindWay紀錄標記d轉為space
            int row = map.GetLength(0);
            int col = map.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (map[i, j] == 'd')
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(map[i, j]);
                    }

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //input
            int row = 0, col = 0;
            //輸入迷宮大小(底, 高) , 輸入底與高，中間用 ”, ”分隔
            Console.Write("輸入迷宮大小(底, 高):");//底 col 高 row
            string input_space=Console.ReadLine();
            string[] words = input_space.Split(',');

            //格式檢查
            if (int.TryParse(words[0], out col) == false)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                Environment.Exit(0);
            }
            //格式檢查
            if (int.TryParse(words[1], out row) == false)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            //根據上面的迷宮大小，輸入迷宮地圖 空一行
            char[,] map_original = new char[row,col];
            char[,] map_detect_s = new char[row+2, col+2];
            char[,] map_detect_e = new char[row + 2, col + 2];


            Console.WriteLine("輸入迷宮地圖:");
            for (int i=0;i<row;i++)
            {for(int j=0; j < col; j++)
                {
                    map_original[i, j] = Console.ReadKey().KeyChar;
                    if (map_original[i, j] == '\n'|| map_original[i, j] == '\r')
                    {
                        j-=1;
                    }
                }
                Console.ReadKey();
            Console.WriteLine();    
            }

            Console.WriteLine();

            /*
            //test original
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(map_original[i, j]);
                }
                Console.WriteLine();  
            }
            */

            //擴大邊界 避免邊界判定的bug
            for (int i = 0; i < row + 2; i++)
            {
                for (int j = 0; j < col + 2; j++) {

                    if (    i == 0 || j==0  ||
                            i ==row+2-1     ||
                            j ==col+2-1         )
                    {
                        map_detect_s[i, j] = '1';
                        map_detect_e[i, j] = '1';

                    }
                    else
                    {
                        map_detect_s[i, j] = map_original[i - 1, j - 1];
                        map_detect_e[i, j] = map_original[i - 1, j - 1];

                    }


                }
            }
            /*
            //test detect
            for (int i = 0; i < row+2; i++)
            {
                for (int j = 0; j < col+2; j++)
                {
                    Console.Write(map_detect[i, j]);
                }
                Console.WriteLine();
            }
            */

            //找起點 終點 反向map修正
            int start_row = 0, start_col = 0;
            int end_row = 0, end_col = 0;
            for (int i = 0; i < row+2; i++)
            {
                for (int j = 0; j < col+2; j++)
                {
                    if (map_detect_s[i, j] == '0')
                    {
                        start_row = i;
                        start_col = j;
                        map_detect_e[i, j] = 'X';
                    }else if(map_detect_e[i, j] == 'X')
                    {
                        end_row = i;
                        end_col = j;
                        map_detect_e[i, j] = '0';
                    }
                }                   
            }
            //Console.WriteLine(start_row + "," + start_col);

            //--------------------------------------------------------------------------------------------------
            //output
            //空一行規劃一條起點到終點的路線，並空一行計算路徑長


            /*  “0”代表起點
                “X”代表終點
                “1”代表牆壁，不能通過
                “ Space”代表路徑，你只能走這裡
            */
            int steps_start_to_end = 0;
            int steps_end_to_start = 0;
            //Console.WriteLine(end_row + "," + end_col);
            bool ans_s =false;
            bool ans_e = false;

            //比較哪個路徑最短

            FindWay_DFS(ref map_detect_s, start_row, start_col,ref end_row,ref end_col, ref steps_start_to_end,ref ans_s);

          
            FindWay_DFS(ref map_detect_e, end_row, end_col, ref start_row, ref start_col, ref steps_end_to_start,ref ans_e);

            Console.WriteLine("Output:");

            //將 map detect 還原

            if (ans_s == true && ans_e==true)
            {
                if (steps_start_to_end <= steps_end_to_start)
                {
                    //將 map detect 還原
                    for (int i = 0; i < row + 2; i++)
                    {
                        for (int j = 0; j < col + 2; j++)
                        {

                            if (  !(i == 0 || j == 0 ||
                                    i == row + 2 - 1 ||
                                    j == col + 2 - 1    ))
                            {
                                map_original[i - 1, j - 1]= map_detect_s[i, j]  ;
                                //map_original[i - 1, j - 1]= map_detect_e[i, j]  ;
                            }
                        }
                    }
                    PrintMap(ref map_original);
                    Console.WriteLine(steps_start_to_end);

                }
                else
                {
                    //將 map detect 還原
                    for (int i = 0; i < row + 2; i++)
                    {
                        for (int j = 0; j < col + 2; j++)
                        {
                            if(map_detect_e[i, j] == 'X')
                            {
                                map_detect_e[i, j] = '0';
                            }else if(map_detect_e[i, j] == '0')
                            {
                                map_detect_e[i, j] = 'X';
                            }

                            if (!(i == 0 || j == 0 ||
                                    i == row + 2 - 1 ||
                                    j == col + 2 - 1))
                            {
                               // map_original[i - 1, j - 1] = map_detect_s[i, j];
                                map_original[i - 1, j - 1] = map_detect_e[i, j];
                            }
                        }
                    }
                    PrintMap(ref map_original);
                    Console.WriteLine(steps_end_to_start);

                }
            }else if (ans_e==true &&ans_s==false)
            {        //將 map detect 還原
                for (int i = 0; i < row + 2; i++)
                {
                    for (int j = 0; j < col + 2; j++)
                    {
                        if (map_detect_e[i, j] == 'X')
                        {
                            map_detect_e[i, j] = '0';
                        }
                        else if (map_detect_e[i, j] == '0')
                        {
                            map_detect_e[i, j] = 'X';
                        }

                        if (!(i == 0 || j == 0 ||
                                i == row + 2 - 1 ||
                                j == col + 2 - 1))
                        {
                            // map_original[i - 1, j - 1] = map_detect_s[i, j];
                            map_original[i - 1, j - 1] = map_detect_e[i, j];
                        }
                    }
                }
                PrintMap(ref map_original);
                Console.WriteLine(steps_end_to_start);

            }
            else if(ans_e==false && ans_s == true)
            {
                //將 map detect 還原
                for (int i = 0; i < row + 2; i++)
                {
                    for (int j = 0; j < col + 2; j++)
                    {

                        if (!(i == 0 || j == 0 ||
                                i == row + 2 - 1 ||
                                j == col + 2 - 1))
                        {
                            map_original[i - 1, j - 1] = map_detect_s[i, j];
                            //map_original[i - 1, j - 1]= map_detect_e[i, j]  ;
                        }
                    }
                }
                PrintMap(ref map_original);
                Console.WriteLine(steps_start_to_end);

            }
            else 
            {
                PrintMap(ref map_original);
                Console.WriteLine("沒有路徑");

            }







            Console.ReadKey();
        }
    }
}
