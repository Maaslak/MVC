﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public MusicDbContext() : base("DefaultConnection") { }
    }
}