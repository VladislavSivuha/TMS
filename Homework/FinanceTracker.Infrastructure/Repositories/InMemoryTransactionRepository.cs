using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace FinanceTracker.Infrastructure.Repositories
{
    public class InMemoryTransactionRepository
    {
        private readonly List<Transaction> _transactions = new()
        {
            new Transaction{
                Amount = 1000,
                Type = TransactionType.Expense,
                Category = "Развлечения",
                Description = "Торговый центр Ультра" },
            new Transaction{
                Amount = 100500,
                Type = TransactionType.Income,
                Category = "Зарплата",
                Description = "Аванс" }
        };

        public void Add(Transaction transaction)
        {
            _transactions.Add(transaction);
        }
        public List<Transaction> GetAll()
        { 
            return _transactions;
        }
        public Transaction GetByID(Guid id)
        {
            return _transactions.Where(x => x.ID == id).FirstOrDefault();
        }

    }
}
