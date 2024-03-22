namespace Application.Abstractions;

public interface IUnitOfWork
{
    Task StartTransactionAsync();
    Task CommitTransactionAsync();
}