namespace ChainOfResponsibility
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(Expense expense);
        void RegisterNext(IExpenseHandler next);
    }
}
