using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObject.Models
{
    class MediaPlayer
    {
        public void Play() => Console.WriteLine("Play");
        public void Pause() => Console.WriteLine("Pause");
        public void Stop() => Console.WriteLine("Stop");

        private Lazy<AllTracks> allSongs;

        public MediaPlayer(int maxCountSongs = 10000)
        {
            allSongs = new Lazy<AllTracks>(() =>
             {
                 Console.WriteLine("Creating AllTracks object!");
                 return new AllTracks(10000);
             });
        }

        public AllTracks GetAllTracks() => allSongs.Value;
    }
}
