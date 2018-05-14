namespace ChainOfResponsibility
{
    public class ExpenseHandler : IExpenseHandler
    {
        private IExpenseApprover _approver;
        private IExpenseHandler _next;

        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(Expense expense)
        {
            var response = _approver.ApproveExpense(expense);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expense);
            }

            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
    }
}
