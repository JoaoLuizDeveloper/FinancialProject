namespace FinancialProject.Domain.Entities.Abstractions
{
    public abstract class Transaction
    {
        public decimal Value { get; set; }

        // Declaring an abstract method that must be implemented in the derived classes
        public abstract string Description();

        // Creating a virtual method to return a summary of the transaction
        public virtual string Resume()
        {
            return $"Value of Transaction: {Value:C}";
        }
    }
}