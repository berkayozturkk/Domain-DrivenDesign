using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Products;
using Domain_DrivenDesign.Domain.Shared;

namespace Domain_DrivenDesign.Domain.Categories;

public class Category : Entity
{
    public Category(Guid id,Name name) : base(id)
    {
        Name = name;
    }

    public Name Name { get; private set; }
    public ICollection<Product> Products { get; private set; }

    public void ChangeName(string name)
    {
        Name = new Name(name);
    }
}
