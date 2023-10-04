using Core.Entities;

namespace Entities.Dtos
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }

        public int CarId { get; set; }

        public int CustomerId { get; set; }

        public string RentalName  { get; set; }

        public string CarName { get; set; }

        public string CustomerName { get; set; }

        public DateTime RenDate { get; set; }

        public DateTime DeadlineTime { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

    }
}
