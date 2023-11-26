using Domain_DrivenDesign.Domain.Abstraction;
using Domain_DrivenDesign.Domain.Users.Events;
using Domain_DrivenDesign.Domain.Users;
using MediatR;

namespace Domain_DrivenDesign.Application.Features.Users.CreateUser;

internal sealed class CreateUserCommandHander : IRequestHandler<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;

    public CreateUserCommandHander(IUserRepository userRepository, IUnitOfWork unitOfWork, IMediator mediator)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.CreateAsync(
            request.Name,
            request.Email,
            request.Password,
            request.Country,
            request.City,
            request.Street,
            request.PostalCode,
            request.FullAddress,
            cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await _mediator.Publish(new UserDomainEvent(user));
    }
}