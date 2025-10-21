using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Practical_Example
{
    interface IMusicPlayer
    {
        void Play();
        void Pause();
        void Stop();
    }
    public class Spotify : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("click here to Play Music");
        }
        public void Pause()
        {
            Console.WriteLine("This button is for Pause the music");
        }
        public void Stop()
        {
            Console.WriteLine("This button is for Stop the Music");
        }

    }
    internal class IntercaeAndAbstartion
    {
        static void Main(string[] args)
        {
            Spotify s = new Spotify();
            s.Play();
            s.Pause();
            s.Stop();

        }
    }
}
