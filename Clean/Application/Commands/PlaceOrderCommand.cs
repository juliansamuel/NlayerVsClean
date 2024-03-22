using Domain.Models;
using MediatR;

namespace Application.Commands;

public class PlaceOrderCommand : IRequest
{
    public Order OrderToBePlaced { get; set; }
}