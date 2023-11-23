using Domain_DrivenDesign.Domain.Abstraction;

namespace Domain_DrivenDesign.Domain.Orders;

public class Order : Entity
{
    public Order(Guid id) : base(id)
    {
    }
    public string OrderNumber { get; set; }
    public DateTime CreateDate { get; set; }
    public OrderStatusEnum Status { get; set; }
    public ICollection<OrderLine> OrderLines { get; set; }
}