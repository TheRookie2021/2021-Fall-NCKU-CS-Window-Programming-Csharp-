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
        Form2 jump ;
        private void button_play_Click(object sender, EventArgs e)
        {
            try {

                my.Play();
                if (my.loop == true&& my.cur_music != null)
                {
                if (jump == null)
                {
                    jump = new Form2();
                    jump.Show();
                }
                    jump.Visible = true;
                }
            }
            catch{
                jump = new Form2();
                jump.Show();
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                my.Stop();
                jump.Visible = false;
            }
            catch{}
        }
        MusicPlayer my;
        Rdio_order[] list;
        int num;
        private void button_select_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "WAV(*.wav)|*.wav";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                checkBox_loop.Checked = false;
                if(jump!=null)
                    jump.Visible = false;
                if (list != null)
                {
                    my.Stop();
                    int l = list.Length;
                    for (int j = 0; j < l; j++)
                        groupBox1.Controls.Remove(list[j]);
                    my.playlist = null;
                }
                num = openFileDialog1.FileNames.Length;
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
                    list[i].SetBounds(30, 30 + 30 * i, 400, 30);
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
            try
            {
            jump.Visible = false;
            }
            catch { }


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

        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            if (my == null)
            {
                MessageBox.Show("請先建立撥放清單");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try {
                    my.SavePlaylist(saveFileDialog1.FileName);
                }
                catch {
                    MessageBox.Show("請先建立撥放清單");
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                num = my.num;
                for(int i = 0; i < num; i++)
                {
                    list[i].ForeColor = colorDialog1.Color;
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < num; i++)
                {
                    list[i].Font = fontDialog1.Font;
                }
            }
        }

        private void loadFromFileCtrLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (list != null &&my!=null)
                {
                    my.Stop();
                    int l = list.Length;
                    for (int j = 0; j < l; j++)
                        groupBox1.Controls.Remove(list[j]);
                    my = null;
                    list = null;
                }
                if(jump!=null)
                    jump.Visible = false;
                button_play.Enabled = true;
                button_stop.Enabled = true;
                checkBox_loop.Enabled = true;

                my = new MusicPlayer();
                my.LoadPlaylist(openFileDialog1.FileName);
                list = new Rdio_order[my.num];

                for(int i = 0; i < my.num; i++)
                {
                    list[i] = new Rdio_order();
                    list[i].num = i;
                    int max = my.playlist[i].Length;
                    if (max > 50) max = 50;

                    list[i].Text = my.playlist[i].Substring(0, max);
                    list[i].SetBounds(30, 30 + 30 * i, 400, 30);
                    groupBox1.Controls.Add(list[i]);
                    this.list[i].Click += new System.EventHandler(this.Radio_Click);
                }                                                                               
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
