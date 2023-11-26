﻿using MediatR;

namespace Domain_DrivenDesign.Application.Features.Users.CreateUser;

public sealed record CreateUserCommand(
    string Name,
    string Email,
    string Password,
    string Country,
    string City,
    string Street,
    string PostalCode,
    string FullAddress) : IRequest;
