using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Order
    {
        [Key]
        public int orderNumb { get; set; }
        public DateTime date { get; set; }
        public string payMethod  { get; set; }
        public double totalPay { get; set; }
        public int idClient { get; set; }
        public Client client { get; set; }
        public int idCart { get; set; }
        public Cart cart { get; set; }

        

    }
}
