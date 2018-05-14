using ChainOfResponsibility;
using System;

namespace ChainOfResponsibilityClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpenseHandler william = new ExpenseHandler(new Employee("William Worker", Decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("Mary Managerr", 1000));
            ExpenseHandler victor = new ExpenseHandler(new Employee("Victor VP", 5000));
            ExpenseHandler paula = new ExpenseHandler(new Employee("Paula President", 20000));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            Decimal expenseAmount;
            Decimal.TryParse(Console.ReadLine(), out expenseAmount);

            var expense = new Expense(expenseAmount);
            ApprovalResponse response = william.Approve(expense);
            Console.WriteLine($"The expense was {response}");

            Console.ReadKey();
        }
    }
}
