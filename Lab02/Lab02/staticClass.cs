using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    static class staticClass
    {
        public static int TotalPrice = 0;
        public static int TotalEnginePrice = 0;
        public static int EnginePrice = 0;
        public static int EnginePower = 0;
        public static int BrandPrice = 0;
        public static int EquipmentPrice = 0;
        public static int InsurancePrice = 0;
        public static int TotalBrandPrice = 0;

        public static void SetEnginePrice(int ePrice)
        {
            EnginePrice = ePrice;
        }

        public static void SetEnginePower(int ePower)
        {
            EnginePower = ePower;
        }

        public static int CountEnginePrice()
            {
                TotalEnginePrice = EnginePower + EnginePrice;
                return TotalEnginePrice;
            }

        public static void SetBrandPrice(int bPrice)
        {
            BrandPrice = bPrice;
        }

        public static void SetEquipmentPrice(int eqPrice)
        {
            EquipmentPrice += eqPrice;
        }

        public static void SetInsurancePrice(int iPrice)
        {
            InsurancePrice = iPrice;
        }

        public static int CountBrandPrice()
        {
            TotalBrandPrice = BrandPrice + EquipmentPrice + InsurancePrice;
            return TotalBrandPrice;
        }

        public static int CountTotalPrice()
        {
            TotalPrice = TotalEnginePrice + TotalBrandPrice;
            return TotalPrice;
        }

    }
}
