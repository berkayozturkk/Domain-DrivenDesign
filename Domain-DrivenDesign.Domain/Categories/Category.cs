using Domain_DrivenDesign.Domain.Products;

namespace Domain_DrivenDesign.Domain.Categories;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Products { get; set;}
}
