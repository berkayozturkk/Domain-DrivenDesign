using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Products;
using Domain_DrivenDesign.Domain.Shared;

namespace Domain_DrivenDesign.Domain.Orders;

public class Order : Entity
{
    public Order(Guid id, string orderNumber, DateTime createdDate, OrderStatusEnum status,ICollection<OrderLine> orderLines) : base(id)
    {
        OrderNumber = orderNumber;
        CreatedDate = createdDate;
        Status = status;
        OrderLines = orderLines;
    }

    public string OrderNumber { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public ICollection<OrderLine> OrderLines { get; private set; }
}