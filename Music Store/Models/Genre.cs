using System.ComponentModel.DataAnnotations;

namespace Music_Store.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        ICollection<Album> Albums { get; set; }

    }
}
