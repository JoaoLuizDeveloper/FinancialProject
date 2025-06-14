using Microsoft.AspNetCore.Mvc;
using MyProject.Domain.Entities;
using MyProject.Domain.Entities.Abstractions;

namespace MyProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        #region Exemplo de Polimorfismo com Transações
        [HttpGet("mocked-list")]
        public IActionResult GetMockedTransactions()
        {
            // Simula uma lista polimórfica com transações de receita e despesa
            var lista = new List<TransactionBase>
            {
                new IncomeTransaction(1000, "Salário"),
                new ExpenseTransaction(300, "Aluguel"),
                new IncomeTransaction(250, "Freelance"),
                new ExpenseTransaction(120, "Internet")
            };

            // Transforma em um resultado anônimo para retornar no JSON
            var result = lista.Select(t => new
            {
                Tipo = t.GetTransactionType(),
                Descricao = t.Description,
                Valor = t.Amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
            });

            return Ok(result);
        }
        #endregion

        [HttpPost("check-type")]
        public IActionResult CheckType([FromBody] object input)
        {
            // 1. Type Pattern
            if (input is string texto)
                return Ok($"É uma string: {texto}");

            return BadRequest("Não é uma string.");
        }

        [HttpGet("check-constant")]
        public IActionResult CheckConstant(int valor)
        {
            // 2. Constant Pattern
            if (valor is 0)
                return Ok("Valor é zero");

            return Ok("Valor não é zero");
        }

        [HttpGet("check-age")]
        public IActionResult CheckAge(int idade)
        {
            // 3. Relational Pattern
            if (idade is > 18 and < 60)
                return Ok("Adulto em idade ativa");

            return Ok("Fora da faixa ativa");
        }

        [HttpGet("check-value")]
        public IActionResult CheckValue(decimal valor)
        {
            // 4. Logical Pattern
            if (valor is >= 10 and <= 100)
                return Ok("Valor entre 10 e 100");

            return Ok("Valor fora do intervalo");
        }

        [HttpPost("check-pessoa")]
        public IActionResult CheckPessoa([FromBody] PessoaDto pessoa)
        {
            // 5. Property Pattern
            if (pessoa is { Nome: "João", Idade: > 18 })
                return Ok("É João maior de idade");

            return Ok("Outra pessoa");
        }

        [HttpPost("check-coordinates")]
        public IActionResult CheckCoordinates([FromBody] Ponto ponto)
        {
            // 6. Positional Pattern
            if (ponto is (0, 0))
                return Ok("Está na origem");

            return Ok($"Coordenadas: {ponto.X}, {ponto.Y}");
        }

        [HttpGet("categoria/{idade}")]
        public IActionResult GetCategoria(int idade)
        {
            // 7. Switch Expression Pattern
            string categoria = idade switch
            {
                < 13 => "Criança",
                < 20 => "Adolescente",
                < 60 => "Adulto",
                _ => "Idoso"
            };

            return Ok($"Categoria: {categoria}");
        }
    }

    // DTOs auxiliares
    public class PessoaDto
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public record Ponto(int X, int Y);
}
