class HomeController
{
    private readonly IProductRepository _productRepository;

    public HomeController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public ActionResult Index()
    {
        var products = _productRepository.GetProducts();
        return View(products);
    }
}

interface IProductRepository
{
    IEnumerable<Product> GetProducts();
}

class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Name = "Laptop" },
            new Product { Name = "Mouse" }
        };
    }
}

class SecondHandRepository : IProductRepository
{
    public IEnumerable<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Name = "Second Hand Laptop" },
            new Product { Name = "Second Hand Mouse" }
        };
    }
}