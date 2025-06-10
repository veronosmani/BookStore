using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bookstore_Razor.Models
{
    public class Category {
        [Key]
        public int CID { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30, ErrorMessage = "Category Name can't be longer than 30 characters.")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100.")]
        public int? DisplayOrder { get; set; }

    }
}
