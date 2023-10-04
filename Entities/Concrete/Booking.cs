using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Booking : IEntity
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RenDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Description { get; set; }

        public decimal DailyPrice { get; set; }

        public bool IsAvilable { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
