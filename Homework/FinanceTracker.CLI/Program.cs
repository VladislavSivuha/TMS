using FinanceTracker.Application.Services;

namespace FinanceTracker.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinanceService service = new FinanceService();
            Console.WriteLine("Мой финансовый трекер");
            Console.WriteLine($"Мой баланс: {service.GetTotalIncome() - service.GetTotalExpence()}");
        }
    }
}
