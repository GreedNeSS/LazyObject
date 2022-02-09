using System;
using LazyObject.Models;

namespace LazyObject
{
    

    class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new(30000);

            Console.WriteLine("Use Memory: " + GC.GetTotalMemory(false));

            mediaPlayer.Play();
            mediaPlayer.Pause();

            Console.WriteLine("Use Memory: " + GC.GetTotalMemory(false));

            AllTracks allTracks = mediaPlayer.GetAllTracks();

            Console.WriteLine("Use Memory: " + GC.GetTotalMemory(false));

            Console.WriteLine($"allTracks.Count: {allTracks.Count}");
        }
    }
}
