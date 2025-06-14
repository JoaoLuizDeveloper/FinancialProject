using MyProject.Domain.Entities.Abstractions;

namespace MyProject.Domain.Entities
{
    public class IncomeTransaction : TransactionBase
    {
        public IncomeTransaction(decimal amount, string description)
            : base(amount, description) { }

        public override string GetTransactionType() => "Receita";

        public override bool IsValidAmount() => Amount >= 1; // Personalização da lógica concreta
    }
}