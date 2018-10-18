using System;
using System.Collections.Generic;

namespace ShortConsoleApplications
{
    /*A playlist is considered a repeating playlist if any of the songs contain
     * a reference to a previous song in the playlist. Otherwise, the playlist 
     * will end with the last song which points to null.

    Implement a function IsRepeatingPlaylist that returns true if a playlist is 
    repeating or false if it is not.
    */
    public class Song
    {
        private string name;
        public Song NextSong { get; set; }
        readonly List<string> check;

        public Song(string name)
        {
            this.name = name;
            check = new List<string> { name };
        }

        public bool IsRepeatingPlaylist()
        {
            if (check.Contains(NextSong.name)) return true;

            if (NextSong != null){
                check.Add(NextSong.name);
                return NextSong.IsRepeatingPlaylist();
            }
            return false;
        }
    }
}
