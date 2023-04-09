using System;

namespace Crypto
{
    public class Password
    {
        //properties
        public String Alphabet;
        public String Substitution;
        private String InputTxt_Encrypt, OutputTxt_Encrypt;
        private String InputTxt_Decrypt, OutputTxt_Decrypt;


        public Password()
        {
            Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        }


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
            Random rnd = new Random();
            int rnd_seed = 51;

            for (int i = 0; i < 52; i++)
            {//random without repetition 1.2.
             //may use: IndexOf, Contains(), Insert(i,Alphabet.Substring(i));
                int Index_A = rnd.Next(rnd_seed);
                //1. if (Substitution.Contains(Alphabet.Substring(Index_A)) == true)//true: 新的目的地存在重複的字母 

                //2. Alphabet 用完即丟 以免重複
                Substitution.Insert(i, Alphabet.Substring(Index_A));
                Alphabet.Remove(Index_A, 1);
                --rnd_seed;//Alphabet 被移除掉一個

            }
        }

        public void PrintTable(String My_string)
        {
            MessageBox.Show(My_string);
        }
        public void PrintHistory()
        {
            //新的替換表 + substitude (空一行

            //加密: 明文 密文 (空一行

            //解密: 密文 明文 (空一行

        }
        public bool IsValid(String crypto)
        {//if the substitution table for cypto is valid
         //if not: 1. repeat  2. invalid( out of range)
            for (int i = 0; i < 52; i++)
            {//檢查A~z是否各出現一次
                if (Substitution.IndexOf(Alphabet.Substring(i, 1)) == -1)//出現範圍之外的字元
                {
                    return false;
                }

                if (Substitution.IndexOf(Alphabet.Substring(i, 1)) != Substitution.LastIndexOf(Alphabet.Substring(i, 1)))
                {//向前搜索與往後搜索若出現不同的值 >> 兩個以上重複 
                    return false;
                }
            }
            return true;
        }


        public void Encrypt(String text)
        {//加密 input string
         //store Input string
            InputTxt_Encrypt = text;
            //Encrypt
            //1. length of input txt
            int length = InputTxt_Encrypt.Length;

            for (int i = 0; i < length; i++)
            {
                if (InputTxt_Encrypt.Substring(i, 1) != " ")
                {
                    //2. for each char in input, find its indexof alphe
                    int indexofalphe = Alphabet.IndexOf(InputTxt_Encrypt.Substring(i, 1));
                    //3.                         then use the index, find char in substitude
                    //4.                         put the char into output[i]
                    OutputTxt_Encrypt.Insert(i, Substitution.Substring(indexofalphe, 1));
                }
                else
                {
                    OutputTxt_Encrypt.Insert(i, " ");
                }
            }
            //store Output Sting

        }

        public void Decrypt(String text)
        {//解密 output string
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
                    OutputTxt_Decrypt.Insert(i, Alphabet.Substring(indexofsubsti, 1));
                }
                else
                {
                    OutputTxt_Decrypt.Insert(i, " ");
                }
            }



        }


    }

}
