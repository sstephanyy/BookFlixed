namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface InProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

    }
}
