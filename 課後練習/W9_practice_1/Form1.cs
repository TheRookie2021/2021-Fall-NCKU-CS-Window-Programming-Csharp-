using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace W9_practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            try {

                my.Play();
            }
            catch{}
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                my.Stop();
            }
            catch{}
        }
        MusicPlayer my;
        Rdio_order[] list;
        private void button_select_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "WAV(*.wav)|*.wav";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (list != null)
                {
                    my.Stop();
                    int l = list.Length;
                    for (int j = 0; j < l; j++)
                        groupBox1.Controls.Remove(list[j]);
                    my.playlist = null;
                }
                int num = openFileDialog1.FileNames.Length;
                if (num > 4) num = 4;
                my = new MusicPlayer(num);
                foreach (String files in openFileDialog1.FileNames.Take(num))
                {
                    my.playlist[i++] = files;
                }
                list = new Rdio_order[num];
                for(i=0;i<num;i++)
                {
                    string file = my.playlist[i];
                    list[i] = new Rdio_order();
                    list[i].num = i;
                    int max = my.playlist[i].Length;
                    if (max > 50) max = 50;
                    
                    list[i].Text = my.playlist[i].Substring(0,max);
                    list[i].SetBounds(30, 40 + 30 * i, 400, 20);
                    groupBox1.Controls.Add(list[i]);
                    this.list[i].Click+= new System.EventHandler(this.Radio_Click);
                }

                button_play.Enabled = true;
                button_stop.Enabled = true;
                checkBox_loop.Enabled = true;
            }
            

        }
        private void Radio_Click(object sender, EventArgs e)
        {
            Rdio_order refrdo = (Rdio_order)sender;
            my.SelectWaveFiles(refrdo.num);
            my.Stop();

        }

        private void checkBox_loop_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_loop.Checked == true) my.loop = true;
            else my.loop = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_play.Enabled = false;
            button_stop.Enabled = false;
            checkBox_loop.Enabled = false;
        }
    }
}
