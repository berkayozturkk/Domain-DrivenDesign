using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Products;
using Domain_DrivenDesign.Domain.Shared;

namespace Domain_DrivenDesign.Domain.Orders;

public class Order : Entity
{
    public Order(Guid id, string orderNumber, DateTime createdDate, OrderStatusEnum status) : base(id)
    {
        OrderNumber = orderNumber;
        CreatedDate = createdDate;
        Status = status;
    }

    public string OrderNumber { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public ICollection<OrderLine> OrderLines { get; private set; }

    public void CreateOrder(List<CreateOrderDto> createOrders)
    {
        foreach (var item in createOrders)
        {
            if (item.Quantity < 1)
                throw new ArgumentException("Order must have at least one");

            //Business rules..

            OrderLine orderLine = new(
                Guid.NewGuid(),
                Id,
                item.ProductId,
                item.Quantity,
                new(item.Amount, Currency.FromCode(item.Currency)));

            OrderLines.Add(orderLine);
        }
    }

    public void RemoveOrderLine(Guid orderLineId)
    {
        var orderLine = OrderLines.FirstOrDefault(x => x.Id == orderLineId);

        if (orderLine is null)
            throw new ArgumentException("The order you want to delete could not be found");

        OrderLines.Remove(orderLine);
    }
}