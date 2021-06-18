namespace Lesson20___GenericsExample
{
    class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}