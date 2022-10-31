using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int contact { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string adress { get; set; }
        public byte cep { get; set; }

    }
}
