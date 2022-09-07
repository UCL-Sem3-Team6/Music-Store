using System.ComponentModel.DataAnnotations;

namespace Music_Store.Models
{
    public class Group:Artist
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

    }

}
