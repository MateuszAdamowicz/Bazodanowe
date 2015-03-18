namespace Product.Domain.Model.Category
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PropertyValue Value { get; set; }
        public Category Category { get; set; }
    }
}