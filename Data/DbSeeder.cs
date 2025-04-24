using ExpenseTrackerAPI.Models;

namespace ExpenseTrackerAPI.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Expenses.Any())
            {
                var expenses = new List<Expense>
                {
                    new Expense { Description = "Groceries", Amount = 150.50m, Date = DateTime.Now.AddDays(-3) },
                    new Expense { Description = "Internet Bill", Amount = 60.00m, Date = DateTime.Now.AddDays(-10) },
                    new Expense { Description = "Electricity", Amount = 90.75m, Date = DateTime.Now.AddDays(-5) }
                };

                context.Expenses.AddRange(expenses);
                context.SaveChanges();
            }
        }
    }
}
