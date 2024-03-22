using Core.Commands;
using Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> PlaceOrder([FromBody] Order order)
    {
        var command = new PlaceOrderCommand {OrderToBePlaced = order};
        await _mediator.Send(command);
        return NoContent();
    }
}