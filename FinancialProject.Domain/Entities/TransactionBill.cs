using FinancialProject.Domain.Entities.Abstractions;

namespace FinancialProject.Domain.Entities
{
    // The TransactionBill class inherits from the abstract class Transaction
    // As if it belongs to the Transaction class
    public class TransactionBill : Transaction
    {
        public string Barcode { get; set; } = string.Empty;

        // Generating the description for the bill payment transaction
        public override string Description()
        {
            return $"Payment of Bill: {Barcode}, Value: {Value:C}";
        }
    }
}