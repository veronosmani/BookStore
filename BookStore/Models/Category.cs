using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int CID { get; set; }
        
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
