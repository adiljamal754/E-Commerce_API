using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class OrderedItem
    {
        [Key]
        public int Id { get; set; }
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}
