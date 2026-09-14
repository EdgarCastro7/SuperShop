using System.ComponentModel.DataAnnotations;

namespace SuperShop.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "City")]
        [MaxLength(50, ErrorMessage = "The field {0} can contain {1} caracthers.")]
        public string Name { get; set; }
    }
}
