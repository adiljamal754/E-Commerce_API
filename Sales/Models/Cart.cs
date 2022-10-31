using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public double  Totalprice { get; set; }
        public List<OrderedItem> orderedItems { get; set; }

        public double CalcTotal()
        {
            foreach (OrderedItem item in orderedItems)
            {
                this.Totalprice = item.product.Price * item.quantity;
            }
            
            return this.Totalprice;
        }

    }
}
