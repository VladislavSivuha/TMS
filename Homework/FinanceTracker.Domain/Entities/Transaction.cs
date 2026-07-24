using FinanceTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker.Domain.Entities
{
    public class Transaction
    {
        // Почему в этом классе не используется класс Рекорд
        public  Guid ID { get; set; } = Guid.NewGuid();
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public string Category { get; set; } = "Разное";
        public string Description { get; set; } =string.Empty;
        public DateTime Date {  get; set; } = DateTime.Now;

    }
}
