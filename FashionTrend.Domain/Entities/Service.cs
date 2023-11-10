using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public EServiceType Type { get; set; }
        public ESewingMachine SewingMachine { get; set; }
        public EMaterial Material { get; set; }

    }
}
