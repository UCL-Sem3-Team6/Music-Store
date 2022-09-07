using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Music_Store.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Music_Store.Models.Album> Album { get; set; } = default!;

        public DbSet<Music_Store.Models.Artist>? Artist { get; set; }

        public DbSet<Music_Store.Models.Song>? Song { get; set; }

        public DbSet<Music_Store.Models.Genre>? Genre { get; set; }
    }
