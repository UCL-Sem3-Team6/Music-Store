using System.ComponentModel.DataAnnotations;

namespace Music_Store.Models
{
    public class Soloartist:Artist
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
    }
}
