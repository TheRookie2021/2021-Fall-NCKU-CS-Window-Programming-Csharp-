using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace W5_practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /* 
        Label_Title_Table;
        Label_Alpha;
        Label_Legal;
        Txt_Table;
        --
        Label_Title_Crypto;
        Label_String_Enter;
        Label_Encryp_result;
        Txt_Enter;
        Txt_Encrypt;
        --
        Label_Title_Decrypt;
        Label_String_Enter;
        Label_Decrype_Result;
        Txt_Enter;
        Txt_Decrypt;

        */
        Crypto.Password User = new Crypto.Password();
        Crypto.History Recording = new Crypto.History();
        private void Form1_Load(object sender, EventArgs e)
        {


            //替換表page
            Label_Title_Table.Visible = true;
            Label_Alpha.Visible = true;
            Label_Legal.Visible = true;
            Label_Illegal.Visible = false;

            Txt_Table.Visible = true;

            btm_generate.Visible = true;
            btm_ok.Visible = true;
            Label_Legal.Visible = false;//"合法替換"


            //加密page
            Label_Title_Crypto.Visible = false;
            Label_String_Enter.Visible = false;
            Label_Encryp_result.Visible = false;
            Txt_Enter_Crypto.Visible = false;
            Txt_Encrypt.Visible = false;

            //解密page
            Label_Title_Decrypt.Visible = false;
            Label_String_Decrypt.Visible = false;
            Label_Decrype_Result.Visible = false;
            Txt_Enter.Visible = false;
            Txt_Decrypt.Visible = false;

            //歷史紀錄page
            Label_Title_History.Visible = false;
            Txt_History.Visible = false;

        }
        //Bottoms:
        private void btm_change_Click(object sender, EventArgs e)
        {
            //替換表page
            Label_Title_Table.Visible = true;
            Label_Alpha.Visible = true;
            Label_Legal.Visible = false;
            Label_Illegal.Visible = false;

            Txt_Table.Visible = true;

            btm_generate.Visible = true;
            btm_ok.Visible = true;
            Label_Legal.Visible = false;//"合法替換"


            //加密page
            Label_Title_Crypto.Visible = false;
            Label_String_Enter.Visible = false;
            Label_Encryp_result.Visible = false;
            Txt_Enter_Crypto.Visible = false;
            Txt_Encrypt.Visible = false;

            //解密page
            Label_Title_Decrypt.Visible = false;
            Label_String_Decrypt.Visible = false;
            Label_Decrype_Result.Visible = false;
            Txt_Enter.Visible = false;
            Txt_Decrypt.Visible = false;

            //歷史紀錄page
            Label_Title_History.Visible = false;
            Txt_History.Visible = false;

        }

        private void btm_cypto_Click(object sender, EventArgs e)
        {

            //turn off 替換表 page
            Label_Title_Table.Visible = false;
            Label_Alpha.Visible = false;
            Txt_Table.Visible = false;
            Label_Legal.Visible = false;
            Label_Illegal.Visible = false;

            btm_generate.Visible = false;
            btm_ok.Visible = true;

            //turn on 加密 page
            Label_Title_Crypto.Visible = true;
            Label_String_Enter.Visible = true;
            Label_Encryp_result.Visible = true;
            Txt_Enter_Crypto.Visible = true;
            Txt_Encrypt.Visible = true;

            //turn of 解密 page
            Label_Title_Decrypt.Visible = false;
            Label_String_Decrypt.Visible = false;
            Label_Decrype_Result.Visible = false;
            Txt_Enter.Visible = false;
            Txt_Decrypt.Visible = false;

            //turn of 歷史紀錄 page
            Label_Title_History.Visible = false;
            Txt_History.Visible = false;

        }

        private void btm_decode_Click(object sender, EventArgs e)
        {
            //turn off 替換表 page
            Label_Title_Table.Visible = false;
            Label_Alpha.Visible = false;
            Txt_Table.Visible = false;
            Label_Legal.Visible = false;
            Label_Illegal.Visible = false;

            btm_generate.Visible = false;

            btm_ok.Visible = true;
            //加密page
            Label_Title_Crypto.Visible = false;
            Label_String_Enter.Visible = false;
            Label_Encryp_result.Visible = false;
            Txt_Enter_Crypto.Visible = false;
            Txt_Encrypt.Visible = false;

            //turn of 解密 page
            Label_Title_Decrypt.Visible = true;
            Label_String_Decrypt.Visible = true;
            Label_Decrype_Result.Visible = true;
            Txt_Enter.Visible = true;
            Txt_Decrypt.Visible = true;

            //turn of 歷史紀錄 page
            Label_Title_History.Visible = false;
            Txt_History.Visible = false;
        }

        private void btm_history_Click(object sender, EventArgs e)
        {
            //turn off 替換表 page
            Label_Title_Table.Visible = false;
            Label_Alpha.Visible = false;
            Txt_Table.Visible = false;
            Label_Legal.Visible = false;
            Label_Illegal.Visible = false;

            btm_generate.Visible = false;
            btm_ok.Visible = false;
            //加密page
            Label_Title_Crypto.Visible = false;
            Label_String_Enter.Visible = false;
            Label_Encryp_result.Visible = false;
            Txt_Enter_Crypto.Visible = false;
            Txt_Encrypt.Visible = false;

            //turn of 解密 page
            Label_Title_Decrypt.Visible = false;
            Label_String_Decrypt.Visible = false;
            Label_Decrype_Result.Visible = false;
            Txt_Enter.Visible = false;
            Txt_Decrypt.Visible = false;

            //turn of 歷史紀錄 page
            Label_Title_History.Visible = true;
            Txt_History.Visible = true;

            //display history
            Txt_History.Lines = Recording.Combine();


        }
     

        private void btm_ok_Click(object sender, EventArgs e)
        {
            if (Label_Title_Table.Visible == true)
            {
                User.Substitution = Txt_Table.Text;
                if (Label_Title_Table.Visible == true)
                {
                    if (User.IsValid(Txt_Table.Text) == true)
                    {
                        Label_Legal.Visible = true;
                        Label_Illegal.Visible = false;
                        User.Substitution = Txt_Table.Text;
                        //history
                        Recording.StoreRecord(User.Substitution,1);
                    }
                    else
                    {
                        Label_Legal.Visible = false;
                        Label_Illegal.Visible = true;

                    }
                }
            }else if(Label_Title_Crypto.Visible == true)
            {
                Txt_Encrypt.Text = String.Empty; 

                User.Encrypt(Txt_Enter_Crypto.Text);
                //history
                Recording.StoreRecord(Txt_Enter_Crypto.Text, 2);

                Txt_Encrypt.Text = User.OutputTxt_Encrypt;
                //history
                Recording.StoreRecord(User.OutputTxt_Encrypt, 3);

            }
            else if (Label_Title_Decrypt.Visible == true)
            {
                Txt_Decrypt.Text = string.Empty;

                User.Decrypt(Txt_Enter.Text);
                //history
                Recording.StoreRecord(Txt_Enter.Text, 4);

                Txt_Decrypt.Text = User.OutputTxt_Decrypt;
                //history
                Recording.StoreRecord(User.OutputTxt_Decrypt, 5);

            }
            

        }

        private void btm_generate_Click(object sender, EventArgs e)
        {
            User.Generate();
            Txt_Table.Text = User.Substitution;

        }

        private void Txt_Decrypt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Txt_Encrypt_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
