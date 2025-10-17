using Application.Interfaces.Repositories;
using CFinanceManager.Application.Dto;

namespace Infrastructure.Repositories;

public class TransactionRepository : ITransactionRepository
{
    public TransactionDto AddTransaction(TransactionDto transaction)
    {
        throw new NotImplementedException();
    }

    public TransactionDto UpdateTransaction(TransactionDto transaction)
    {
        throw new NotImplementedException();
    }

    public TransactionDto DeleteTransaction(int id)
    {
        throw new NotImplementedException();
    }

    public List<TransactionDto> GetTransactions(TransactionFilterDto filter)
    {
        throw new NotImplementedException();
    }
}