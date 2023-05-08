using System.ComponentModel.DataAnnotations;

namespace Assignment_2.Models
{
    public class CustomerInfo
    {
        [Key]
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string CustomerAddress { get; set; }
    }
}
