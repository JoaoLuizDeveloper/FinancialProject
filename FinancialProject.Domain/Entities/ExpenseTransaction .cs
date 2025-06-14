using MyProject.Domain.Entities.Abstractions;

namespace MyProject.Domain.Entities
{
    public class ExpenseTransaction : TransactionBase
    {
        public ExpenseTransaction(decimal amount, string description)
            : base(amount, description) { }

        public override string GetTransactionType() => "Despesa";
    }
}