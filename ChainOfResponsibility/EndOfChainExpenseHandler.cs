using System;

namespace ChainOfResponsibility
{
    internal class EndOfChainExpenseHandler : IExpenseHandler
    {
        private EndOfChainExpenseHandler() { }
        private static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();

        public static EndOfChainExpenseHandler Instance
        {
            get { return _instance; }
        }

        public ApprovalResponse Approve(Expense expense)
        {
            return ApprovalResponse.Denied;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain for expense handler.");
        }
    }
}