using Domain_DrivenDesign.Domain.Users;
using MediatR;

namespace Domain_DrivenDesign.Application.Features.Users.GetAllUser;

public sealed record GetAllUserQuery() : IRequest<List<User>>;
