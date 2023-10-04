using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Entities.Dtos
{
    public class CarDetailDto : IDto
    {
        public string CarName { get; set; }
        public string CarDescription { get; set; }

        public string BrandName { get; set; }

        public string ColorName { get; set; }

        public List<CarImage> CarImages { get; set; } = new List<CarImage>();

        
    }
}
