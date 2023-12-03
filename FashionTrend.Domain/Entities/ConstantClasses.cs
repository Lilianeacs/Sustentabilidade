namespace FashionTrend.Domain.Entities
{
    public static class ConstantClasses
    {
        public enum EContractStatus
        {
            Active =1,
            Inactive,
            Terminated
        }

        public enum EServiceType
        {
            REPAIR,
            MANUFACTORING
        }

        public enum EMaterial
        {
            Jeans,
            Silk,
            Leather,
            Lycra,
            Cotton,
            Velvet,
            Polyester,
            Linen
        }

        public enum ESewingMachine
        {
            Overloque,
            Galoneira,
            PontoCadeia,
            Travete,
            Reta,
            Caseadeira,
            Botoneira
        }

        public enum EServiceStatus
        {
            PENDING,
            APPROVED,
            REJECTED,
            COMPLETED
        }

        public enum EPaymentMethod
        {
            CreditCard,
            DebitCard,
            Pix
        }
    }
}
