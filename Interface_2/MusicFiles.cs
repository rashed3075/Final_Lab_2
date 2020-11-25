using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_2
{
    class MusicFiles
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private int yearOfRelease;

        public int YearOfReleas
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }
        private int durationInSec;

        public int Duration
        {
            get { return durationInSec; }
            set { durationInSec = value; }
        }
        public MusicFiles(string title , string artist , int yearOfRelease, int durationInSec)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSec = durationInSec; 
        }

    }
}
