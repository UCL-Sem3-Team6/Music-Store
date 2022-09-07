﻿namespace Music_Store.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }

        ICollection<Album>Albums { get; set; }
    }
}
