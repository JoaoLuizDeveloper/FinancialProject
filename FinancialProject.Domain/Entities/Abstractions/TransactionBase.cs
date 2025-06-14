namespace MyProject.Domain.Entities.Abstractions
{
    public abstract class TransactionBase
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTime Date { get; protected set; } = DateTime.UtcNow;
        public decimal Amount { get; protected set; }
        public string Description { get; protected set; }

        // Construtor base
        protected TransactionBase(decimal amount, string description)
        {
            Amount = amount;
            Description = description;
        }

        // Método abstrato ? obrigação de cada tipo implementar
        public abstract string GetTransactionType();

        // Método concreto ? lógica comum a todos os tipos
        public virtual bool IsValidAmount() => Amount > 0;
    }
}
