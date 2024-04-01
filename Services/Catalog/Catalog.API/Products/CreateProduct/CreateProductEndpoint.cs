namespace Catalog.API.Products.CreateProduct;


public record CreateProductRequesty(string Name, List<string> Category, string Description, string ImageFile, decimal Price);

public record CreateProductResponse(Guid ID);

public class CreateProductEndpoint
{
}
