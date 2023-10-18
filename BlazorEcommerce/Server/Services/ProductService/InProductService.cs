namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface InProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

    }
}
