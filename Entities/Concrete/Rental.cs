using Core.Entities;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}