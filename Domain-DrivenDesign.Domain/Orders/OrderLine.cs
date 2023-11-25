using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Products;
using Domain_DrivenDesign.Domain.Shared;

namespace Domain_DrivenDesign.Domain.Orders;

public class OrderLine : Entity
{
    public OrderLine(Guid id, Guid orderId, Guid productId, Product product,
       int quantity, Money price) : base(id)
    {
        ProductId = productId;
        Product = product;
        Quantity = quantity;
        Price = price;
    }

    public Guid OrderId { get; private set; }
    public Guid ProductId { get; private set; }
    public Product Product { get; private set; }
    public int Quantity { get; private set; }
    public Money Price { get; private set; }
}
