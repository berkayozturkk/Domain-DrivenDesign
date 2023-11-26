using MediatR;

namespace Domain_DrivenDesign.Application.Features.Categories.CreateCategory;

public sealed record CreateCategoryCommand(
    string Name) : IRequest;
