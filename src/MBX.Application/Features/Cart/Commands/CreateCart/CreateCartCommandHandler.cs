using AutoMapper;

using MBX.Application.Contracts.Persistence.Common;
using MBX.Application.DTOs;

using MediatR;

namespace MBX.Application.Features.Cart.Commands.CreateCart;

public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, CartDto>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCartCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CartDto> Handle(CreateCartCommand request, CancellationToken cancellationToken)
    {
        var cart = _mapper.Map<Domain.Entities.Cart>(request.CreateCartDto);
        await _unitOfWork.Repository<Domain.Entities.Cart>().CreateAsync(cart);
        await _unitOfWork.CompleteAsync();
        return _mapper.Map<CartDto>(cart);
    }
}