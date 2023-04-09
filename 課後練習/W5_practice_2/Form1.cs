using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassChicken.Chicken;
namespace W5_practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*        
        label_para_money
        label_para_health;
        label_para_weight;
        label_para_hunger;
        label_para_mood;
        label_para_event;

        textBox_name;
        textBox_display;

        button_feed;
        button_play;
        button_clean;
        button_doctor;
        button_end_day;
        button_name;

        */
        ClassChicken.Chicken chicken = new ClassChicken.Chicken();

        private void Form1_Load(object sender, EventArgs e)
        {
            button_feed.Enabled=false;
            button_play.Enabled = false;
            button_clean.Enabled = false;
            button_doctor.Enabled = false;
            button_end_day.Enabled = false;
            label_para_money.Text = 0 + " 元";
            label_para_health.Text = 0 + " %";
            label_para_weight.Text = 0 + " g";
            label_para_hunger.Text = 0 + " %";
            label_para_mood.Text = 0 + " %";
            label_para_event.Text = "請幫小雞命名";


        }

        private void button_name_Click(object sender, EventArgs e)
        {
            chicken.EnterName(textBox_name.Text);
            button_name.Enabled = false;
            textBox_name.Enabled = false;
            //-----------------------------
            button_feed.Enabled = true;
            button_play.Enabled = true;
            button_clean.Enabled = true;
            button_doctor.Enabled = true;
            button_end_day.Enabled = true;

            label_para_money.Text = chicken.money.ToString()+" 元";
            label_para_health.Text=chicken.health.ToString()+" %";
            label_para_weight.Text = chicken.weight.ToString() + " g";
            label_para_hunger.Text = chicken.hunger.ToString() + " %";
            label_para_mood.Text = chicken.mood.ToString() + " %";
            label_para_event.Text ="電子雞出生了!";
            textBox_display.Lines= chicken.Display();


        }

        private void button_feed_Click(object sender, EventArgs e)
        {

            chicken.Feed();
            label_para_money.Text = chicken.money.ToString() + " 元";
            label_para_health.Text = chicken.health.ToString() + " %";
            label_para_weight.Text = chicken.weight.ToString() + " g";
            label_para_hunger.Text = chicken.hunger.ToString() + " %";
            label_para_mood.Text = chicken.mood.ToString() + " %";
            //label_para_event.Text = chicken.Event();
            textBox_display.Lines = chicken.Display();

            label_para_event.Text = "";
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            chicken.Play();
            label_para_money.Text = chicken.money.ToString() + " 元";
            label_para_health.Text = chicken.health.ToString() + " %";
            label_para_weight.Text = chicken.weight.ToString() + " g";
            label_para_hunger.Text = chicken.hunger.ToString() + " %";
            label_para_mood.Text = chicken.mood.ToString() + " %";
            //label_para_event.Text = chicken.Event();
            textBox_display.Lines = chicken.Display();

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            chicken.Clean();
            label_para_money.Text = chicken.money.ToString() + " 元";
            label_para_health.Text = chicken.health.ToString() + " %";
            label_para_weight.Text = chicken.weight.ToString() + " g";
            label_para_hunger.Text = chicken.hunger.ToString() + " %";
            label_para_mood.Text = chicken.mood.ToString() + " %";
            //label_para_event.Text = chicken.Event();
            textBox_display.Lines = chicken.Display();

        }

        private void button_doctor_Click(object sender, EventArgs e)
        {
            chicken.Doctor();
            label_para_money.Text = chicken.money.ToString() + " 元";
            label_para_health.Text = chicken.health.ToString() + " %";
            label_para_weight.Text = chicken.weight.ToString() + " g";
            label_para_hunger.Text = chicken.hunger.ToString() + " %";
            label_para_mood.Text = chicken.mood.ToString() + " %";
            //label_para_event.Text = chicken.Event();
            textBox_display.Lines = chicken.Display();

        }

        private void button_end_day_Click(object sender, EventArgs e)
        {
            try {
                chicken.EndDay();
                label_para_money.Text = chicken.money.ToString() + " 元";
                label_para_health.Text = chicken.health.ToString() + " %";
                label_para_weight.Text = chicken.weight.ToString() + " g";
                label_para_hunger.Text = chicken.hunger.ToString() + " %";
                label_para_mood.Text = chicken.mood.ToString() + " %";
                label_para_event.Text = chicken.what_happened;
                textBox_display.Lines = chicken.Display();
                if (chicken.what_happened == "死亡")
                {
                    button_feed.Enabled = false;
                    button_play.Enabled = false;
                    button_clean.Enabled = false;
                    button_doctor.Enabled = false;
                    button_end_day.Enabled = false;
                }
            }
            catch
            {

            }
            }
    }
}
