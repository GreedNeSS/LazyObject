using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObject.Models
{
    class AllTracks
    {
        private Song[] allSongs;
        public int Count { 
            get => allSongs.Length; 
        }

        public AllTracks(int countSong)
        {
            allSongs = new Song[countSong];

            Console.WriteLine($"Filling {countSong} songs!");
        }
    }
}
