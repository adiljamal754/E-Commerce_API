using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? description { get; set; }
        public string picUrl { get; set; }
        public bool inPromotion { get; set; }
        public bool inStock { get; set; }
        public int quantityStock { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, double price, string? description, string picUrl, bool inPromotion, bool inStock, int quantityStock)
        {
            Id = id;
            Name = name;
            Price = price;
            this.description = description;
            this.picUrl = picUrl;
            this.inPromotion = inPromotion;
            this.inStock = inStock;
            this.quantityStock = quantityStock;
        }
        public Product( string name, double price, string? description, string picUrl, bool inPromotion, bool inStock, int quantityStock)
        {
  
            Name = name;
            Price = price;
            this.description = description;
            this.picUrl = picUrl;
            this.inPromotion = inPromotion;
            this.inStock = inStock;
            this.quantityStock = quantityStock;
        }

    }
}
