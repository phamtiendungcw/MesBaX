using MediatR;

namespace MBX.Application.Features.Cart.Commands.DeleteCart;

public class DeleteCartCommand : IRequest
{
    public DeleteCartCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}