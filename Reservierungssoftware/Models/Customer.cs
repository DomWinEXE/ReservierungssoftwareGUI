namespace Reservierungssoftware.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int Telefonnr {  get; set; }

        //Navigation Property
        public List<Order> Orders { get; set; }
        public int OrderId { get; set; }
    }
}
