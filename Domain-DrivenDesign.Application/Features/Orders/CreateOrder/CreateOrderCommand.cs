using Domain_DrivenDesign.Domain.Orders;
using MediatR;

namespace Domain_DrivenDesign.Application.Features.Orders.CreateOrder;

public sealed record CreateOrderCommand(
    List<CreateOrderDto> CreateOrderDtos) : IRequest;
