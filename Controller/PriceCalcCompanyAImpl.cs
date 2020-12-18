using System.Collections;
using Bridge.Entity;
using Bridge.Interfaces;

namespace Bridge.Controller
{
    public class PriceCalcCompanyAImpl : PriceCalcBaseImpl
    {
        public override Money GetShippingPrice(IEnumerator cart, Entity.Address shippingTo)
        {
            //TODO
            return shippingTo.Price;
        }

        //public virtual void SetDeliveryCompany(DeliveryCompany company)
        //{
        //    this._impl = PriceCalcImplFabric.GetPriceCalcImpl(company);
        //}
    }
}