using System.ComponentModel.DataAnnotations;

namespace Music_Store.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Uri AlbumArtUrl { get; set; }


        public Artist Artist { get; set; }
        public Genre Genre { get; set; }

    }
}
