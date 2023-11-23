using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Products;

namespace Domain_DrivenDesign.Domain.Categories;

public class Category : Entity
{
    public Category(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
    public ICollection<Product> Products { get; set;}
}
