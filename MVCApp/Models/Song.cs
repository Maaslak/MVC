using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Song
    {
        public string Name;
        string Artist, Genre;
        int Id;

        public Song(string name, string artist, string genre, int id)
        {
            Name = name;
            Artist = artist;
            Genre = genre;
            Id = id;
        }

        
    }
}