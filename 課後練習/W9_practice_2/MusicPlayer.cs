using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;
namespace W9_practice_2
{
    class MusicPlayer : SoundPlayer
    {
        public bool loop = false;
        public string[] playlist;
        public SoundPlayer cur_music;
        public int num;
        public MusicPlayer(int number)
        {
            playlist = new string[number];
            num = number;
        }
        public MusicPlayer(){ }
           
        public void Play()
        {

            if (loop == true)
            {
                if (cur_music != null)
                {
                    cur_music.Load();
                    cur_music.PlayLooping();
                }
            }
            else {
                if (cur_music != null)
                {
                cur_music.Load();
                cur_music.Play();
                }

            }
        }
        public void Loop()
        {
            if (cur_music != null)
            {
                cur_music.Load();
                cur_music.PlayLooping();
            }
        }
        public void Stop()
        {   
            if(cur_music!=null)
                cur_music.Stop();

        }

        public void SelectWaveFiles(int num)//select which is ready to play
        {
            cur_music = new SoundPlayer();
            cur_music.SoundLocation = playlist[num];
        }
      

        //------------------------------------------
        public void SavePlaylist(string filename)
        {
            FileInfo finfo = new FileInfo(filename);
            StreamWriter sw = finfo.CreateText();
            for (int i = 0; i < num; i++)
            {
                sw.WriteLine(playlist[i]);
            }
            sw.Flush();
            sw.Close();

        }
        public void LoadPlaylist(string filename)//input address of file
        {
            FileInfo finfo = new FileInfo(filename);
            StreamReader sr = new StreamReader(filename);
            string str;
            playlist = new string[4];
            int i = 0;
            do
            {
                str = sr.ReadLine(); //MessageBox.Show(str + "\r\n");
                if (str == null) break;
                playlist[i++] = str;

            } while (true);
            sr.Close();
            num = i ;
            //MessageBox.Show(playlist[0] +"\r\n"+num);
            Array.Resize(ref playlist, num);

        }

      
    }
}
