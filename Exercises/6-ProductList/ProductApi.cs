namespace BlazorUIWorkshop.Exercises._6_ProductList
{
    public class ProductApi
    {
        public List<Product> ListAll()
        {
            return new List<Product>()
            {
                new Product
                {
                    Name = "Men's large vest", 
                    Price = 12.39m, 
                },
                new Product
                {
                    Name = "Men's Polo Shirt", 
                    Price = 49.79m
                },
                new Product
                {
                    Name = "Women's blue T-shirt",
                    Price = 29.79m
                }
            };
        }
        
        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; } = "https://via.placeholder.com/180x200/";
            public decimal Price { get; set; }

        }
    }
}
