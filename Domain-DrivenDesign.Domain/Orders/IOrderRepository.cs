namespace Domain_DrivenDesign.Domain.Orders;

public interface IOrderRepository
{
    Task<Order> CreateAsync(List<CreateOrderDto> createOrders, CancellationToken cancellationToken = default);
    Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
}