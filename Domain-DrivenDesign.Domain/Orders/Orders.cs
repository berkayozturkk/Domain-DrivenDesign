namespace Domain_DrivenDesign.Domain.Orders;

public class Orders
{
    public Guid Id { get; set; }
    public string OrderNumber { get; set; }
    public DateTime CreateDate { get; set; }
    public OrderStatusEnum Status { get; set; }
    public ICollection<OrderLine> OrderLines { get; set; }
}