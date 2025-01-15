using MBX.Application.DTOs;

using MediatR;

namespace MBX.Application.Features.Cart.Commands.CreateCart;

public class CreateCartCommand : IRequest<CartDto>
{
    public CreateCartCommand(CreateCartDto createCartDto)
    {
        CreateCartDto = createCartDto;
    }

    public CreateCartDto CreateCartDto { get; set; }
}