using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CustomerDetailDto
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerCity { get; set; }
    }
}
