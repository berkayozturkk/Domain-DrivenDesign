using MediatR;

namespace Domain_DrivenDesign.Domain.Orders.Events;

public sealed class SendOrderEmailEvent : INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //Send Mail
        return Task.CompletedTask;
    }
}
