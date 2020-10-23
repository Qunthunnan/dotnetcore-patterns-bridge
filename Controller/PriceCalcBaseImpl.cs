using System.Collections;
using Bridge.Entity;
using Bridge.Interfaces;

namespace Bridge.Controller
{
    public class PriceCalcBaseImpl : IPriceCalcImpl
    {
        public virtual Money GetItemPrice(uint itemId, uint itemQuantity) 
        {
            return new Money() {
                Value = ProductRepository.products[itemId].Price.Value,
                Currency = Money.CurrencyType.RUB
            };
        }
        public virtual Money GetShippingPrice(IEnumerator cart, Entity.Address shippingTo)
        {
            return new Money() {
                Value = 20,
                Currency = Money.CurrencyType.RUB
            };
        }
    }
}