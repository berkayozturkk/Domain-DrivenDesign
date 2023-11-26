using MediatR;

namespace Domain_DrivenDesign.Domain.Users.Events;

public sealed class SendRegisterEmailEvent : INotificationHandler<UserDomainEvent>
{
    public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
    {
        //User register send email
        return Task.CompletedTask;
    }
}
