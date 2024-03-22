using Core.Models;
using MediatR;

namespace Core.Commands;

public class PlaceOrderCommand : IRequest
{
    public Order OrderToBePlaced { get; set; }
}