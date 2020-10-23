using Bridge.Controller;
using Bridge.Interfaces;

namespace Bridge.Factory
{
    public enum DeliveryCompany { Self, CompanyA }
    public static class PriceCalcImplFabric
    {
        public static IPriceCalcImpl GetPriceCalcImpl(DeliveryCompany company)
        {
            switch (company) {
                case DeliveryCompany.CompanyA:
                    return new PriceCalcCompanyAImpl();
    
                default:
                    return new PriceCalcBaseImpl();
            }
        }
    }
}