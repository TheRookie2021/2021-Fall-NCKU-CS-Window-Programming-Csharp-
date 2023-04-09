using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static W6_practice_2.TextFont;

namespace W6_practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        pictureBox_meme;
        button_last_page;
        button_next_page;

        groupBox_Font;
            radioButton_font_std;
            radioButton_font_ms;
            radioButton_font_new;

        groupBox_position;
            radioButton_position_DR;
            radioButton_position_DM;
            radioButton_position_UM;
            radioButton_position_DL;
            radioButton_position_UR;
            radioButton_position_UL;

        checkBox_bold;
        checkBox_italic;

        label_font_size;
        textBox_font_size;

        textBox_enter_text;
        label_enter_text;
        label_view;

        */
        private void Form1_Load(object sender, EventArgs e)
        {

            current = 1;
            pictureBox_meme.Image = Image.FromFile(@"..\..\meme\pic_0" + current + ".png");

            pictureBox_meme.SizeMode = PictureBoxSizeMode.Zoom;
            // 設定圖片方塊的大小
            title = new TextFont();
            radioButton_font_std.Checked = true;
            radioButton_position_UL.Checked = true;
            textBox_font_size.Text= "12";
            textBox_enter_text.Text = "文字呈現";
            title.ChangeFamily("標楷體");
            title.ChangeAlignment(1);
            title.Size = 12;
            title.ChangeLabel(ref label_view);
        }

        int current;
        TextFont title;

        private void Meme_Load()
        {
            pictureBox_meme.Image = Image.FromFile(@"..\..\meme\pic_0" + current + ".png");
        }

        private void button_last_page_Click(object sender, EventArgs e)
        {
            if (current - 1 == 0) current = 5;
            else --current;
            Meme_Load();
        }

        private void button_next_page_Click(object sender, EventArgs e)
        {
            if (current + 1 == 6) current = 1;
            else ++current;
            Meme_Load();
        }

        //------------------------------------------Rdo-Fonts-------------------------------------------

        private void radioButton_font_std_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeFamily("標楷體");//標楷體、新細明體、微軟正黑體
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void radioButton_font_new_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeFamily("新細明體");//標楷體、新細明體、微軟正黑體
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void radioButton_font_ms_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeFamily("微軟正黑體");//標楷體、新細明體、微軟正黑體
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }
        //----------------------------------------Rdo-Position-------------------------------------------

        private void radioButton_position_UL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeAlignment(1);
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void radioButton_position_UM_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeAlignment(2);
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void radioButton_position_UR_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeAlignment(3);
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void radioButton_position_DL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeAlignment(7);
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void radioButton_position_DM_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeAlignment(8);
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void radioButton_position_DR_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeAlignment(9);
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        //------------------------------------------TEXTBOX-------------------------------------------
        private void textBox_enter_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label_view.Text = string.Empty;
                label_view.Text = textBox_enter_text.Text;
                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void textBox_font_size_TextChanged(object sender, EventArgs e)
        {
            try
            {   if (int.Parse(textBox_font_size.Text) > 32|| int.Parse(textBox_font_size.Text) < 1)
                    title.Size = 12;
                else title.Size = int.Parse(textBox_font_size.Text);

                title.ChangeLabel(ref label_view);
                label_view.Visible = true;
            }
            catch { }
        }

        private void checkBox_bold_CheckedChanged(object sender, EventArgs e)
        {
            try {
                title.ChangeStyle(checkBox_bold.Checked, checkBox_italic.Checked);
                title.ChangeLabel(ref label_view);
            }
            catch { }
            
        }

        private void checkBox_italic_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                title.ChangeStyle(checkBox_bold.Checked, checkBox_italic.Checked);
                title.ChangeLabel(ref label_view);
            }
            catch { }

        }
    }//scope end
}
