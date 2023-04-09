using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    class Program
    {
        static void Main(string[] args)
        {


            //輸入 1. 地圖大小(座標) 2. 地雷數量 3. 地雷座標位置
            //1. input and tryparse: space
            Console.Write("地圖大小(1~10): ");
            string input_space = Console.ReadLine();
            //errormessage: 超出範圍、請輸入範圍內的整數
            int space = 0;
            bool canConvert_space = int.TryParse(input_space, out space);//拒絕浮點數類型及非整數類型
            if (canConvert_space == false)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (space > 10 || space < 1)
            {
                Console.WriteLine("超出範圍");
                Console.ReadKey();
                Environment.Exit(0);
            }


            //2. input and tryparse: num of landmine
            Console.Write("地雷數量(1~10): ");
            //error message: 地雷數量超出範圍
            string input_landmine = Console.ReadLine();
            int landmine = 0;
            bool canConvert_landmine = int.TryParse(input_landmine, out landmine);
            if (canConvert_landmine == false)
            {
                Console.WriteLine("請輸入範圍內的整數");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (landmine > 10 || landmine <= 0)
            {
                Console.WriteLine("超出範圍");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if ((space * space) < landmine)
            {
                Console.WriteLine("地雷位置超出範圍");
                Console.ReadKey();
                Environment.Exit(0);
            }



            //3. input and tryparse: position
            int[,] matrix=new int[space, space] ;
            int row, col;
            int[] repetite=new int[space*space];//for repetition judgement
            //error message: 地雷位置超出範圍、請輸入兩個以空白區隔的整數
            for (int i = 0; i < landmine; i++)
            {
                Console.Write("第 {0} 個地雷的位置(以空白區隔): ",i);
                string input_position = Console.ReadLine();//then, 字串分割

                string[] words = input_position.Split(' ');

                //convert words[0] to int row
                if(int.TryParse(words[0],out row) == false)
                {
                    Console.WriteLine("請輸入兩個以空白區隔的整數");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (row > space-1 || row < 0)
                {
                    Console.WriteLine("地雷位置超出範圍");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                //convert word[1] to int col
                if (int.TryParse(words[1], out col) == false)
                {
                    Console.WriteLine("請輸入兩個以空白區隔的整數");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if ( col> space-1 || col <0)
                {
                    Console.WriteLine("地雷位置超出範圍");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                //repetition judgement
                int row_col_comb=row*10+col;
                if (repetite[row_col_comb] == 0)
                {
                    ++repetite[row_col_comb];

                }
                else
                {
                    Console.WriteLine("地雷位置重複");
                    --i;
                    continue;
                }

                    //Console.Write("{0} ", row);
                    //Console.WriteLine("{0} ", col);

                    //put the right input into matrix
                    matrix[row, col] = -10;
                if (space==1) goto Output;
                 
                //地雷周邊運算_邊界判斷: row+1>9, row-1<0, col+1>9, col-1<0
                if(row + 1 > space - 1)//row 出上界
                {
                    if(col + 1 > space - 1)//row 出上界且 col 出上界
                    {

                        matrix[row - 1, col] = matrix[row - 1, col] + 1;
                        matrix[row, col - 1] = matrix[row, col - 1] + 1;

                        matrix[row - 1, col - 1] = matrix[row - 1, col - 1] + 1;

                    }
                    else if (col - 1 < 0)//row 出上界 且 col 出下界
                    {

                        matrix[row - 1, col] = matrix[row - 1, col] + 1;
                        matrix[row, col + 1] = matrix[row, col + 1] + 1;

                        matrix[row - 1, col + 1] = matrix[row - 1, col + 1] + 1;

                    }
                    else//row 出上界 col 未出界
                    {
                        matrix[row - 1, col] = matrix[row - 1, col] + 1;
                        matrix[row, col - 1] = matrix[row, col - 1] + 1;
                        matrix[row, col + 1] = matrix[row, col + 1] + 1;

                        matrix[row - 1, col - 1] = matrix[row - 1, col - 1] + 1;
                        matrix[row - 1, col + 1] = matrix[row - 1, col + 1] + 1;

                    }
                }
                else if(row - 1 < 0)// row 出下界
                {
                    if (col + 1 > space-1)// row 出下界 且 col 出上界
                    {
                        matrix[row + 1, col] = matrix[row + 1, col] + 1;

                        matrix[row, col - 1] = matrix[row, col - 1] + 1;

                        matrix[row + 1, col - 1] = matrix[row + 1, col - 1] + 1;

                    }
                    else if (col - 1 < 0)// row 出下界 且 col 出下界
                    {
                        matrix[row + 1, col] = matrix[row + 1, col] + 1;

                        matrix[row, col + 1] = matrix[row, col + 1] + 1;

                        matrix[row + 1, col + 1] = matrix[row + 1, col + 1] + 1;

                    }
                    else// row 出下界 且 col 未出界
                    {

                        matrix[row + 1, col] = matrix[row + 1, col] + 1;

                        matrix[row, col - 1] = matrix[row, col - 1] + 1;
                        matrix[row, col + 1] = matrix[row, col + 1] + 1;

                        matrix[row + 1, col - 1] = matrix[row + 1, col - 1] + 1;
                        matrix[row + 1, col + 1] = matrix[row + 1, col + 1] + 1;
                        
                    }
                }
                else //row  未出界
                {
                    if (col + 1 > space - 1)// row 未出界 且 col 出上界
                    {

                        matrix[row + 1, col] = matrix[row + 1, col] + 1;
                        matrix[row - 1, col] = matrix[row - 1, col] + 1;
                        matrix[row, col - 1] = matrix[row, col - 1] + 1;
                        

                        matrix[row - 1, col - 1] = matrix[row - 1, col - 1] + 1;
                        matrix[row + 1, col - 1] = matrix[row + 1, col - 1] + 1;
                        
                    }
                    else if (col - 1 < 0)// row 未出界 且 col 出下界
                    {

                        matrix[row + 1, col] = matrix[row + 1, col] + 1;
                        matrix[row - 1, col] = matrix[row - 1, col] + 1;

                        matrix[row, col + 1] = matrix[row, col + 1] + 1;

                        
                        matrix[row + 1, col + 1] = matrix[row + 1, col + 1] + 1;
                        matrix[row - 1, col + 1] = matrix[row - 1, col + 1] + 1;


                    }
                    else// row 未出界 且 col 未出界
                    {

                        matrix[row + 1, col] = matrix[row + 1, col] + 1;
                        matrix[row - 1, col] = matrix[row - 1, col] + 1;
                        matrix[row, col - 1] = matrix[row, col - 1] + 1;
                        matrix[row, col + 1] = matrix[row, col + 1] + 1;

                        matrix[row - 1, col - 1] = matrix[row - 1, col - 1] + 1;
                        matrix[row + 1, col - 1] = matrix[row + 1, col - 1] + 1;
                        matrix[row + 1, col + 1] = matrix[row + 1, col + 1] + 1;
                        matrix[row - 1, col + 1] = matrix[row - 1, col + 1] + 1;
                    }
                }

                


                Array.Clear(words,0,1);
                
            }
            //輸出 分隔線---  地雷X 九宮格內的地雷數 
            Output:
            Console.WriteLine("---");
            for (int i = 0; i < space; i++)
            {
                for (int j = 0; j < space; j++)
                {
                    //轉置: x,y 座標剛好與 row,col 對稱
                    if (matrix[j, i] < 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(matrix[j, i]);
                    }
                }
             Console.WriteLine();
            }            

        
            Console.ReadKey();

        }
    }

}
