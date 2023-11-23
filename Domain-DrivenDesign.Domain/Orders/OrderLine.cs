﻿using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Products;

namespace Domain_DrivenDesign.Domain.Orders;

public class OrderLine : Entity
{
    public OrderLine(Guid id) : base(id) {}
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
}
