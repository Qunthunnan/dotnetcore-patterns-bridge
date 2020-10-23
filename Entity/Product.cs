namespace Bridge.Entity
{
    /* Описание разновидности товара на складе */
    public class Product
    {
        // поле класса для хранения значения идентификатора,
        // присвоенного последнему созданному экземпляру
        private static uint lastId = 0;
        public Product () {
          this.Id = ++lastId;
        }
        public uint Id { get; }
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public Money Price { get; set; }
    }
}