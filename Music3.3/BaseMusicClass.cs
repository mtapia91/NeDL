using System;

namespace Music
{
            //Four pieces of data for each obj from txt file
            //Artist, Song Title, Run Time, Album
    public class Music
    {
        string name {get; set;}
        string song {get; set;}
        double time {get; set;}
        string album {get; set;}

        public Music(string name, string song, double time, string album) //Constructor will have same name as class
        {
            this.name = name;
            this.song = song;
            this.time = time;
            this.album = album;
        }
        
        public override string ToString()
        {
            return "Artist: " + name + "\nSong Title: " + song + "\nRun Time: " + time + "\nAlbum Name: " + album;
        }

    }
}

