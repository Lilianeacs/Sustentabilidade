using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string Description { get; set; }
        public bool Delivery { get; set; }
        public List<EServiceType> Type { get; set; }
        public string SewingMachine { get; set; }
        public string Material { get; set; }
        public bool Payment { get; set; }

    }
}
