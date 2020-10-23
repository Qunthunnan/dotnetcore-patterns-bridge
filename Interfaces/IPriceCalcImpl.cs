using System.Collections;
using Bridge.Entity;

namespace Bridge.Interfaces
{
    public interface IPriceCalcImpl
    {
        Money GetItemPrice(uint itemId, uint itemQuantity);
        Money GetShippingPrice(IEnumerator cart, Address shippingTo);
    }
}