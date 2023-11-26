﻿using MediatR;

namespace Domain_DrivenDesign.Domain.Users.Events;

public sealed class UserDomainEvent : INotification
{
    public User User { get; }
    public UserDomainEvent(User user)
    {
        User = user;
    }
}