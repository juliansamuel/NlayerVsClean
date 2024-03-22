using Application.Abstractions;
using Application.Commands;
using MediatR;

namespace Application.CommandHandlers;

public class PlaceOrderCommandHandler : IRequestHandler<PlaceOrderCommand>
{
    private readonly IOrderRepository _orderRepo;
    private readonly IProductRepository _productRepo;
    private readonly IUnitOfWork _uow;

    public PlaceOrderCommandHandler(IOrderRepository orderRepo, IProductRepository productRepo,
        IUnitOfWork uow)
    {
        _orderRepo = orderRepo;
        _productRepo = productRepo;
        _uow = uow;
    }
    public async Task<Unit> Handle(PlaceOrderCommand request, CancellationToken cancellationToken)
    {
        await _uow.StartTransactionAsync();
        await _orderRepo.PlaceOrderAsync(request.OrderToBePlaced);
        await _productRepo.DecreaseProductsQuantity(request.OrderToBePlaced.OrderedProducts);
        await _uow.CommitTransactionAsync();
        return new Unit();
    }
}