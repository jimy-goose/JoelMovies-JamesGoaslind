using System.ComponentModel.DataAnnotations;

namespace JoelMovies_JamesGoaslind.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
