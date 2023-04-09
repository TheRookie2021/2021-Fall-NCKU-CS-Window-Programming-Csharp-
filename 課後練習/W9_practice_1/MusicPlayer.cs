using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace W9_practice_2
{
    class MusicPlayer : SoundPlayer
    {
        public bool loop = false;
        public string[] playlist;
        private SoundPlayer cur_music;
        public MusicPlayer(int num)
        {
            playlist = new string[num];
        }
        public void Play()
        {

            if (loop == true)
            {
                cur_music.Load();
                cur_music.PlayLooping();

            }
            else {
                cur_music.Load();
                cur_music.Play();
            }
        }
        public void Loop()
        {
            cur_music.Load();
            cur_music.PlayLooping();
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
        /*
                public void SetMusicLocation(String path)
                {

                }
                //------------------------------------------
                public SavePlaylist()
                {


                }
                public string[] LoadPlaylist()
                {




                }

         */
    }
}
