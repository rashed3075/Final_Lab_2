using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_2
{
    class Ipod : IMusicPlayer
    {
        public void Play(bool on)
        {
            Console.WriteLine("Playing Music");
        }

        public void PlayNext()
        {
            Console.WriteLine("Playing Next Music");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Playing Previous Music");
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Sound : " + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Ipod ON....");
        }
    }
}
