using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_2
{
    class Phone : IMusicPlayer, IRadioPlayer
    {
        public void ChangeChannel()
        {
            Console.WriteLine("Changing Channel");
        }

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

        public void Retune(double frequency)
        {
            Console.WriteLine("Frequency : "+frequency);
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Sound : " + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Phone Turning ON...");
        }
    }
}
