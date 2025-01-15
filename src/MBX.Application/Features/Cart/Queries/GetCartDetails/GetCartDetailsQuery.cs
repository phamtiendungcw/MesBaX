using MBX.Application.DTOs;

using MediatR;

namespace MBX.Application.Features.Cart.Queries.GetCartDetails;

public class GetCartDetailsQuery : IRequest<CartDto?>
{
    public GetCartDetailsQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}