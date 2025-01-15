using MBX.Application.DTOs;

using MediatR;

namespace MBX.Application.Features.Cart.Queries.GetAllCarts;

public class GetAllCartsQuery : IRequest<List<CartDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}