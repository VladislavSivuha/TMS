using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTracker.Domain.Dictionaries
{
    public static class Category
    {
        public static readonly Dictionary<string, int> category = new()
        {
            {"Продукты", 1 },
            {"Лекарства", 2 },
            {"Развлечения", 3 },
            {"Разное", 999 }
        };
    }
}
