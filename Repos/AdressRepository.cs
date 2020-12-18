using System.Collections.Generic;

namespace Bridge.Entity
{
    public class AdressRepository
    {
        public static List<Address> addressesPriceList =
  new List<Address>(){
            new Address() {
                Country = Address.countryOptions.Ukraine,
                City = Address.cityOptions.Kyiv,
                Street = Address.stritsOptions.KhreschatykSt,
                Price=new Money(){Currency=Money.CurrencyType.GRN, Value=20}
              },
            new Address() {
                Country = Address.countryOptions.Ukraine,
                City = Address.cityOptions.Lviv,
                Street = Address.stritsOptions.SvobodyAve,
                Price=new Money(){Currency=Money.CurrencyType.GRN, Value=40}
              },
            new Address() {
                Country = Address.countryOptions.Ukraine,
                City = Address.cityOptions.Mariupol,
                Street = Address.stritsOptions.MyruAve,
                Price=new Money(){Currency=Money.CurrencyType.GRN, Value=60}
              },
            new Address() {
                Country = Address.countryOptions.Russia,
                City = Address.cityOptions.Moscov,
                Street = Address.stritsOptions.TverskayaSt,
                Price=new Money(){Currency=Money.CurrencyType.RUB, Value=700}
              },
            new Address() {
                Country = Address.countryOptions.Russia,
                City = Address.cityOptions.SaintPetersburg,
                Street = Address.stritsOptions.NevskyAve,
                Price=new Money(){Currency=Money.CurrencyType.RUB, Value=800}
              },
            new Address() {
                Country = Address.countryOptions.Russia,
                City = Address.cityOptions.RostovOnDon,
                Street = Address.stritsOptions.BudonnovskiyAve,
                Price=new Money(){Currency=Money.CurrencyType.RUB, Value=500}
              },
            new Address() {
                Country = Address.countryOptions.Belarus,
                City = Address.cityOptions.Minsk,
                Street = Address.stritsOptions.BarykinSt,
                Price=new Money(){Currency=Money.CurrencyType.BYN, Value=24}
              },
            new Address() {
                Country = Address.countryOptions.Belarus,
                City = Address.cityOptions.Mogilev,
                Street = Address.stritsOptions.vulycaLienina,
                Price=new Money(){Currency=Money.CurrencyType.BYN, Value=27}
              },
            new Address() {
                Country = Address.countryOptions.Belarus,
                City = Address.cityOptions.Gomel,
                Street = Address.stritsOptions.PiershamajskayaSt,
                Price=new Money(){Currency=Money.CurrencyType.BYN, Value=17}
              }
  };
    }
}