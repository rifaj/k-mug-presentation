
namespace K_Mug.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public int Amount { get; set; }
        public int CreatedDate { get; set; }
    }
}