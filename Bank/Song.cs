using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Song
    {
        public string SongTitle { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public float Duration { get; set; }
        public static List<Song> Songs = new List<Song>();

        public static void AddSong(Song song)
        {
            Songs.Add(song);
        }
        public List<Song> GetSongs() 
        { 
            return Songs; 
        }
    }
}
