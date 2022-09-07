using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Music_Store.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string GenreId { get; set; }
        public int ArtistId { get; set; }
        
        
        [Required(ErrorMessage = "Feltet er ikke udfyldt")]
        [DisplayName("Titel")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Feltet er ikke udfyldt")]
        [DisplayName("Artist")]
        public Artist Artist { get; set; }

        [Required(ErrorMessage = "Feltet er ikke udfyldt")]
        [DisplayName("Genre")]
        public Genre Genre { get; set; }
       
        
        [Required(ErrorMessage = "Feltet er ikke udfyldt")]
        [DisplayName("Prise")]
        public decimal Price { get; set; }


        [Column(TypeName = "nvarchar (100)")]
        [DisplayName("Billede navn")]
        public string AlbumImage { get; set; }

        [NotMapped]
        [DisplayName("Tilføj billede")]
        public IFormFile AlbumArtUrl { get; set; }




    }
}
