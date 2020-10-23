using System;
using System.Collections;
using System.Collections.Generic;
using Bridge.Controller;
using Bridge.Entity;
using Bridge.Factory;
using Bridge.Interfaces;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IPriceCalc calc1 = new PriceCalcBasic(DeliveryCompany.Self);
            Money price1 = GetCartTotal(calc1);
            Console.WriteLine(price1.Value);
            
            IPriceCalc calc2 = new PriceCalcDiscount(DeliveryCompany.CompanyA);
            Money price2 = GetCartTotal(calc2);
            Console.WriteLine(price2.Value);

            /*IPriceCalc calc = new PriceCalcBasic(DeliveryCompany.Self);
            calc1.AddItem(itemId, itemQuantity);
            Money price3 = GetCartTotal(calc1);
            
            calc1.SetDeliveryCompany(DeliveryCompany.CompanyA);
            Money price4 = calc1.GetTotalPrice(userData.shippingAddr);*/
        }

        private static Money GetCartTotal(IPriceCalc calc)
        {
            List<Tuple<uint,uint>> itemsList = new List<Tuple<uint,uint>>();
            itemsList.Add(new Tuple<uint,uint>(1, 2)); // товар с идентификатором 1, количество - 2
            itemsList.Add(new Tuple<uint,uint>(2, 15));
            itemsList.Add(new Tuple<uint,uint>(3, 1));
        
            foreach (Tuple<uint,uint> item in itemsList) {
                calc.AddItem(item.Item1, item.Item2);
            }
        
            return calc.GetTotalPrice(new Address());
        }
    }
}
