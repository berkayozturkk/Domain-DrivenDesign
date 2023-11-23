using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Categories;

namespace Domain_DrivenDesign.Domain.Products;

public class Product : Entity
{
    public Product(Guid id) : base(id) { }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Currency { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
