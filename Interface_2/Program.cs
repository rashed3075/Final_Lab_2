using System;

namespace Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipod ip1 = new Ipod();
            Console.WriteLine("*******************");
            ip1.Play(true);
            ip1.PlayNext();
            ip1.PlayPrevious();
            ip1.SetVolume(51);
            ip1.Switch(true);
            Console.WriteLine("*******************");
            Phone p1 = new Phone();
           
            p1.ChangeChannel();
            p1.Play(true);
            p1.PlayNext();
            p1.PlayPrevious();
            p1.Retune(98.4);
            p1.SetVolume(100);
            p1.Switch(true);
            Console.WriteLine("*******************");
        }
    }
}
