using System;

namespace ChainOfResponsibility
{
    public class Employee : IExpenseApprover
    {
        public string Name { get; set; }
        public decimal ApprovalLimit { get; set; }

        public Employee(string name, decimal approvalLimit)
        {
            Name = name;
            ApprovalLimit = approvalLimit;
        }

        public ApprovalResponse ApproveExpense(Expense expense)
        {
            Console.WriteLine($"{Name} - approval limit: ${ApprovalLimit} is performing approval check .....");
            return expense.ExpenseTotal > ApprovalLimit ? ApprovalResponse.BeyondApprovalLimit : ApprovalResponse.Approved;
        }
    }
}
