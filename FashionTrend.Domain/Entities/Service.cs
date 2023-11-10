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
        public List<EServiceType> Type { get; set; }
        public List<ESewingMachine> SewingMachine { get; set; }
        public List<EMaterial> Material { get; set; }
        public bool Payment { get; set; }

    }
}
