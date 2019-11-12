using System;
using System.Collections.Generic;
using System.Text;

namespace MusicAnalyzer
{
    class Song
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string artist;
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private string album;
        private string Album
        {
            get { return album; }
            set { album = value; }
        }

        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        private int time;
        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1000 || value > 2020) throw new ArgumentOutOfRangeException();

                year = value;
            }
        }

        public Song(string name, string artist, string album, string genre, int size, int time, int year)
        {
            Name = name;
            Artist = artist;
            Album = album;
            Genre = genre;
            Size = size;
            Time = time;
            Year = year;
        }
    }
}
