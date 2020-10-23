using System.Collections.Generic;
using Bridge.Entity;
using Bridge.Factory;
using Bridge.Interfaces;

namespace Bridge.Controller
{
    public class PriceCalcBasic : IPriceCalc
    {
        private IPriceCalcImpl _impl;
        public IPriceCalcImpl Implementor { get => _impl; set => _impl = value; }
 
        private readonly Dictionary<uint, ItemInCart> _cart
            = new Dictionary<uint,ItemInCart>();
    
        public PriceCalcBasic(DeliveryCompany company)
        {
            this._impl = PriceCalcImplFabric.GetPriceCalcImpl(company);
        }

        public virtual void AddItem(uint itemId, uint itemQuantity)
        {
            ItemInCart item = new ItemInCart { Id = itemId, Quantity = itemQuantity };
            this._cart.Add(itemId, item);
        }
    
        public virtual Money GetTotalPrice(Entity.Address shippingTo)
        {
            Money sum = new Money();
            var itemsList = this._cart.Values;
    
            foreach (ItemInCart item in itemsList) {
                Money itemPrice = this._impl.GetItemPrice(item.Id, item.Quantity);
                Money price = new Money();
                price.Value = itemPrice.Value * item.Quantity;
                item.Price = price;
    
                sum.Add(item.Price);
            }
    
            Money shippingPrice = this._impl.GetShippingPrice(
                itemsList.GetEnumerator(), shippingTo);
    
            sum.Add(shippingPrice);
    
            return sum;           
        }
    }
}