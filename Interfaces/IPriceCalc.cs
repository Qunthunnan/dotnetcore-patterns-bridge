using Bridge.Entity;

namespace Bridge.Interfaces
{
    public interface IPriceCalc
    {
        IPriceCalcImpl Implementor {get; set;}
        void AddItem(uint itemId, uint itemQuantity);
        Money GetTotalPrice(Address shippingTo);
        //void SetDeliveryCompany(DeliveryCompany company);
    }
}