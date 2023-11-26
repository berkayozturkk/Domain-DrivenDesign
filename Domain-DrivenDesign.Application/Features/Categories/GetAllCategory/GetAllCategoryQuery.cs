using Domain_DrivenDesign.Domain.Categories;
using MediatR;

namespace Domain_DrivenDesign.Application.Features.Categories.GetAllCategory;

public sealed record GetAllCategoryQuery() : IRequest<List<Category>>;
