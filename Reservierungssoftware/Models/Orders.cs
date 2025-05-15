namespace Reservierungssoftware.Models
{

    // ORM Object Relational Mapper -> C# -> SQL DB
    public class Order
    {

        public int Id { get; set; }
        public DateOnly Anreise { get; set; }
        public DateOnly Abreise { get; set; }
        public string? ZTyp { get; set; }


        //Foreign Key
        public int CustomerId { get; set; }        
        public Customer Customer { get; set; }

    }
}
