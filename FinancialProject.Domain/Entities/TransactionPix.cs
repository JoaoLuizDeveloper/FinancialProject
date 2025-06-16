using FinancialProject.Domain.Entities.Abstractions;

namespace FinancialProject.Domain.Entities
{
    // The TransactionPIX class inherits from the abstract class Transaction
    // As if it belongs to the Transaction class
    public class TransactionPix : Transaction
    {
        public string Key { get; set; } = string.Empty;

        public string? DescriptionPix { get; set; }

        // Generating the description for the PIX transaction
        public override string Description()
        {
            return $"PIX Sended to key: {Key}, Value: {Value:C}";
        }
    }
}