using Domain_DrivenDesign.Domain.Orders;
using MediatR;

namespace Domain_DrivenDesign.Application.Features.Orders.GetAllOrder;

public sealed record GetAllOrderQuery() : IRequest<List<Order>>;
