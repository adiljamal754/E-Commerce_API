using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class User
    {
        [Key]
        public string email { get; set; }
        public string password { get; set; }
    }
}
