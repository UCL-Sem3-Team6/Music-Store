using System.ComponentModel.DataAnnotations;

namespace Music_Store.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; } 
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        ICollection<Album> Albums { get; set; } 

           
    }
}
