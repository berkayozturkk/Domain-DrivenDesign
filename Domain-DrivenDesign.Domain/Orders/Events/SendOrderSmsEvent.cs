using MediatR;

namespace Domain_DrivenDesign.Domain.Orders.Events;

public sealed class SendOrderSmsEvent : INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //Send SMS
        return Task.CompletedTask;
    }
}
