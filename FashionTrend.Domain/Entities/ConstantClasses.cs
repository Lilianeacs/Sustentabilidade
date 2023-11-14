namespace FashionTrend.Domain.Entities
{
    public static class ConstantClasses
    {
        public enum EServiceType
        {
            REPAIR,
            MANUFACTORING
        }

        public enum EServiceStatus
        {
            PENDING,
            APPROVED,
            REJECTED,
            COMPLETED
        }
    }
}
