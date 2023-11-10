using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Domain.Entities
{
    public static class ConstantClasses
    {
        public enum EServiceType
        {
            REPAIR,
            MANUFACTORING
        }

        public enum EMaterial
        {
            JEANS,
            SILK,
            LEATHER,
            LYCRA
        }

        public enum ESewingMachine
        {
            OVERLOQUE,
            GALONEIRA,
            PONTO_CADEIA,
            TRAVETE,
            RETA,
            CASEADEIRA,
            BATANIEIRA
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
