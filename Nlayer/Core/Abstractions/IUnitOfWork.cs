namespace Core.Abstractions;

public interface IUnitOfWork
{
    Task StartTransactionAsync();
    Task CommitTransactionAsync();
    
}