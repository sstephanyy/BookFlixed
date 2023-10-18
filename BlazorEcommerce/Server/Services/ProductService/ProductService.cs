namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : InProductService //When a class inherits (herda) from another class, it means that the new class (ProductService) inherits the properties and methods of the base class (InProductService). 
    {
        private readonly DataContext _context; //readonly significa que o valor dessa variável não pode ser alterado após a sua inicialização
        public ProductService(DataContext context)
        {
            _context = context; //is used to access the data source (e.g., a database) to retrieve products.
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync() // _context para obter uma lista de produtos do database
            };

            return response;
        }
    }
}
