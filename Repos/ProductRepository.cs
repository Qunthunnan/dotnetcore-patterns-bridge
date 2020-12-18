using System.Collections.Generic;

namespace Bridge.Entity
{
    /* Описание разновидности товара на складе */
    public class ProductRepository
    {
        // поле класса для хранения сриска
        // демонстрационных описаний товаров
        private static List<Product> productList =
          new List<Product>(){
            new Product() {
              Name="iPhone",
              Price=new Money(){Currency=Money.CurrencyType.GRN, Value=30000}
              },
            new Product() {
              Name="PC",
              Price=new Money(){Currency=Money.CurrencyType.GRN, Value=35000}
              },
            new Product() {
              Name="Tablet",
              Price=new Money(){Currency=Money.CurrencyType.GRN, Value=5000}
              }
          };

        public static Dictionary<uint, Product> products =
          new Dictionary<uint, Product>();

        static ProductRepository(){
          foreach (Product p in productList)
          {
              products.Add(p.Id, p);
          }
        }
    }
}