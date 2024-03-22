using Application.Abstractions;

namespace DataAccess;

public class UnitOfWork : IUnitOfWork
{
    private readonly ShopDbContext _ctx;

    public UnitOfWork(ShopDbContext ctx)
    {
        _ctx = ctx;
    }
    
    public async Task StartTransactionAsync()
    {
        await _ctx.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        await _ctx.Database.CommitTransactionAsync();
    }
}