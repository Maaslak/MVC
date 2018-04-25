using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    [Table("songs")]
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
          public string Genre { get; set; }
    public string Artist { get; set; }

public Song(string name, string artist, string genre, int id)
        {
            Name = name;
            Artist = artist;
            Genre = genre;
            Id = id;
        }

        public Song()
        {
        }
    }
}