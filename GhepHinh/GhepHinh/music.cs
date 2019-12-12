using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GhepHinh
{
    public class music
    {
        public music()
        {

        }
        public void PlayMusic()
        {
            string path_sound = (Assembly.GetEntryAssembly().Location + "");
            path_sound = path_sound.Replace("GhepHinh.exe", "S106.wav");
            SoundPlayer sound = new SoundPlayer(path_sound);
            sound.LoadAsync();
            sound.PlayLooping();
            sound.Play();
        }
        public void winner()
        {
            string path_sound = (Assembly.GetEntryAssembly().Location + "");
            path_sound = path_sound.Replace("GhepHinh.exe", "S104.wav");
            SoundPlayer sound = new SoundPlayer(path_sound);
            sound.Play();
        }
    }
}
