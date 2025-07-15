using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Select2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
}
