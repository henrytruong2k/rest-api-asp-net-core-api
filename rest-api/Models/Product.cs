namespace rest_api.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }

        public double Price { get; set; }
    }

    public class ProductDto
    {
        public string Title { get; set; }

        public double Price { get; set; }
    }
}
