using System;

namespace ChainOfResponsibility
{
    public class Expense
    {
        private decimal _expenseTotal;

        public Expense(Decimal total)
        {
            _expenseTotal = total;
        }

        public decimal ExpenseTotal => _expenseTotal;
    }
}
