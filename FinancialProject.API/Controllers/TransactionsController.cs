using Microsoft.AspNetCore.Mvc;
using FinancialProject.Domain.Entities;
using FinancialProject.Domain.Entities.Abstractions;

namespace FinancialProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        #region Polimorfism example with transactions
        /// <summary>
        /// Shows a polimorfism with a list of transactions
        /// </summary>
        [HttpGet("ListTransactions")]
        public IActionResult ListTransactions()
        {
            // Using the base class Transaction as a reference type
            // I can work with the derived classes TransactionPix and TransactionBill
            HashSet<Transaction> transactions = new()
            {
                new TransactionPix { Value = 150, Key = "joaoluizdeveloper@gmail.com", DescriptionPix= "Pix are a payment method exclusive from Brazil!" },
                new TransactionBill { Value = 250, Barcode = "237933812860008" }
            };

            var resultado = transactions.Select(t => new
            {
                type = t.GetType().Name,
                description = t.Description(),
                extraDescription = t is TransactionPix pix ? pix.DescriptionPix : "",
                resume = t.Resume()
            });

            return Ok(resultado);
        }
        #endregion
    }
}
