using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;
using FinanceTracker.Infrastructure.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace FinanceTracker.Application.Services
{
    public class FinanceService
    {
        private readonly InMemoryTransactionRepository _repository;
        public FinanceService()
        {
            _repository = new InMemoryTransactionRepository();
        }

        public void AddTransaction(decimal amount, TransactionType type, string category, string description)
        {
            _repository.Add(new Transaction { Amount = amount, Type = type, Category = category, Description = description });
        }
        public decimal GetTotalExpence()
        {
            return _repository.GetAll().Where(x => x.Type == TransactionType.Expense).Sum(x => x.Amount);
        }
        public decimal GetTotalIncome()
        {
            return _repository.GetAll().Where(x => x.Type == TransactionType.Income).Sum(x => x.Amount);
        }
    }
}
