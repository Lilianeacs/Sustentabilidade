using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EMaterial> Materials { get; set; }
    }
}
