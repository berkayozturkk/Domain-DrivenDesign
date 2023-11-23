using Domain_DrivenDesign.Domain.Categories;

namespace Domain_DrivenDesign.Domain.Products;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Currency { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
