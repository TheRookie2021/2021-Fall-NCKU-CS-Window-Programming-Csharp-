using System;
using System.Linq;

namespace Crypto
{
    public class Password
    {
        //properties
        public const String Alphabet_generate="A B C D E F G H I J K L M N O P Q R S T U V W X Y Z a b c d e f g h i j k l m n o p q r s t u v w x y z";
        public const String Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public String Substitution;
        public String InputTxt_Encrypt, OutputTxt_Encrypt;
        public String InputTxt_Decrypt, OutputTxt_Decrypt;


        


        //methods
        //1. Table construct
        //1.1 Manual
        public void WriteIn(String txt_table)
        {
            Substitution = txt_table;

        }

        //1.2 Auto
        public void Generate()
        {//generate random table for crypto
            Substitution = String.Empty;
        
            Random rnd = new Random();
            
            string[] Split_AZ=Alphabet_generate.Split(' ');
            Split_AZ = Split_AZ.OrderBy(x => rnd.Next()).ToArray();
            foreach (var i in Split_AZ)
            {
                Substitution += i;
            }


        }


        /*public void PrintTable(String My_string)
        {
            MessageBox.Show(My_string);
        }*/

        public void PrintHistory()
        {
            //新的替換表 + substitude (空一行

            //加密: 明文 密文 (空一行

            //解密: 密文 明文 (空一行

        }
        public bool IsValid(String crypto)
        {//if the substitution table for cypto is valid
         //if not: 1. repeat  2. invalid( out of range)
            try
            {
                if (Substitution.Length != 52 || Substitution == null)
                    return false;

                for (int i = 0; i < 52; i++)
                {//檢查A~z是否各出現一次

                    if (Substitution.Equals(Alphabet.Substring(i)) == true)//出現範圍之外的字元
                        return false;

                    //向前搜索與往後搜索若出現不同的值 >> 兩個以上重複 
                    if (Substitution.IndexOf(Alphabet.Substring(i, 1)) != Substitution.LastIndexOf(Alphabet.Substring(i, 1)))
                        return false;

                }
            return true;
            }
            catch
            {
                return false;
            }
        }


        public void Encrypt(String text)
        {//加密 input string
         //store Input string
            InputTxt_Encrypt = text;
            OutputTxt_Encrypt = String.Empty;
            //Encrypt
            try
            {
                //1. length of input txt
                int length = InputTxt_Encrypt.Length;
                string[] temp = new string[length];
                for (int i = 0; i < length; i++)
                {
                    if (InputTxt_Encrypt.Substring(i, 1) != " ")
                    {
                        //2. for each char in input, find its indexof alphe
                        int indexofalphe = Alphabet.IndexOf(InputTxt_Encrypt.Substring(i, 1));
                        //3.                         then use the index, find char in substitude
                        //4.                         put the char into output[i]
                        temp[i] = Substitution.Substring(indexofalphe, 1);
                    }
                    else
                    {
                        temp[i] = " ";
                    }
                }

                //store Output Sting
                foreach (var i in temp)
                {
                    OutputTxt_Encrypt += i;
                }
            }
            catch
            {

            }
        }

        public void Decrypt(String text)
        {//解密 output string
            try
            {
                InputTxt_Decrypt = text;
                int length = InputTxt_Decrypt.Length;
                for (int i = 0; i < length; i++)
                {
                    if (InputTxt_Decrypt.Substring(i, 1) != " ")
                    {
                        //2. for each char in input, find its indexof Substitution
                        int indexofsubsti = Substitution.IndexOf(InputTxt_Decrypt.Substring(i, 1));
                        //3.                         then use the index, find char in Alphabet
                        //4.                         put the char into output[i]
                        OutputTxt_Decrypt += Alphabet.Substring(indexofsubsti, 1);
                    }
                    else
                    {
                        OutputTxt_Decrypt += " ";
                    }
                }

            }
            catch { 
}

        }


    }

    public class History
    {
        public string[] record = new String[20];
        public int[] type = new int[20];// 1 for table; 
                                        // 2 for Encrypt input 3 for Encrypt output
                                        // 4 for Decrypt input 5 for Decrypt output
        public string[] comb = new String[20];
        public int counter = 0;

        public void StoreRecord(string Round, int label)
        {
            try
            {
                record[counter] = Round;
                type[counter] = label;
                ++counter;
            }
            catch
            {
                Array.Resize(ref record, 20);
                Array.Resize(ref type, 20);
                Array.Resize(ref comb, 20);

            }
        }

        public string[] Combine()
        {

            for (int i = 0; i < counter; i++)
            {
                switch (type[i])// 1 for table; 
                                // 2 for Encrypt input 3 for Encrypt output
                                // 4 for Decrypt input 5 for Decrypt output
                {
                    case 1:
                        comb[i] = "\n新的替換表\n" + record[i]+"\n\n";
                        break;
                    case 2:
                        comb[i] = "加密 \r" + "\n明文: " + record[i] + "\r" + "\n密文:\r" + record[i + 1] + "\n";
                        break;
                    case 3:
                        break;
                    case 4:
                        comb[i] = "解密\r" + "\n密文: " + record[i] + "\r" + "\n明文:\r" + record[i + 1] + "\n";

                        break;
                    case 5:
                        break;
                    default: break;


                }

            }//for}
             return comb;
            }
        }
}
