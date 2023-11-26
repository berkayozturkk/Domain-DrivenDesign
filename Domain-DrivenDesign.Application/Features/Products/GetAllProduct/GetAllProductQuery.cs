using Domain_DrivenDesign.Domain.Products;
using MediatR;

namespace Domain_DrivenDesign.Application.Features.Products.GetAllProduct;

public sealed record GetAllProductQuery() : IRequest<List<Product>>;
