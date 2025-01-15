using MBX.Application.DTOs;

using MediatR;

namespace MBX.Application.Features.Cart.Commands.UpdateCart
{
    public class UpdateCartCommand : IRequest
    {
        public UpdateCartCommand(UpdateCartDto updateCartDto)
        {
            UpdateCartDto = updateCartDto;
        }

        public UpdateCartDto UpdateCartDto { get; set; }
    }
}
