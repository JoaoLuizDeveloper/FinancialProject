# FInancialProject


✅ DDD (Domain-Driven Design)
Organiza o sistema com foco no design das regras de negócio, não na tecnologia.
<br />
✅ Serviço de Domínio
Centraliza lógicas importantes que não pertencem a uma entidade específica, mantendo o foco no negócio.
<br />
✅ Classes Abstratas
Não podem ser instanciadas. Servem como modelo base para outras classes.
<br />
✅ Métodos Abstratos
São declarações sem corpo. As classes filhas devem implementá-los.
<br />
✅ Métodos Concretos
Têm implementação. Classes filhas podem herdar ou sobrescrever.
<br />
✅ Herança
Classes filhas herdam estrutura e comportamento da classe abstrata.
<br />
✅ Base para Implementação
As filhas implementam os abstratos e podem personalizar os concretos.
<br />
✅ Compartilhamento de Comportamento
Garante que todas as filhas sigam um padrão comum e compartilhem lógica base.
<br />
✅ Polimorfismo
Permite usar a classe base para trabalhar com diferentes filhas de forma genérica.
<br />
✅ Principais Patterns no C#
1. Type Pattern – Verifica tipo + atribui
if (obj is string s)
{
    Console.WriteLine($"É uma string com valor: {s}");
}

2. Constant Pattern – Compara com valor constante
if (x is 0)
{
    Console.WriteLine("x é zero");
}

3. Relational Pattern – Comparações relacionais
if (idade is > 18 and < 60)
{
    Console.WriteLine("Adulto em idade ativa");
}

4. Logical Pattern – Combinação com and, or, not
if (valor is >= 10 and <= 20)
{
    Console.WriteLine("Dentro do intervalo");
}

5. Property Pattern – Avalia propriedades de objetos
if (pessoa is { Nome: "João", Idade: > 18 })
{
    Console.WriteLine("É João maior de idade");
}

6. Positional Pattern – Usado com deconstruct
record Ponto(int X, int Y);
var p = new Ponto(3, 4);
if (p is (0, 0)) // Desconstrói e compara
{
    Console.WriteLine("Origem");
}


7. Switch Expression Pattern – Expressivo e enxuto
string Categoria(int idade) => idade switch
{
    < 13 => "Criança",
    < 20 => "Adolescente",
    < 60 => "Adulto",
    _    => "Idoso"
};
