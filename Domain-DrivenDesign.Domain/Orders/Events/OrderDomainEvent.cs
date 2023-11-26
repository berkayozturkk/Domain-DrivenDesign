using MediatR;

namespace Domain_DrivenDesign.Domain.Orders.Events;

public sealed class OrderDomainEvent : INotification
{
    public Order Order { get; }
    public OrderDomainEvent(Order order)
    {
        Order = order;
    }
}