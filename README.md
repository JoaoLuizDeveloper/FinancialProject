# FinancialProject


✅ DDD (Domain-Driven Design)
Organiza o sistema com foco no design das regras de negócio, não na tecnologia.
<br />
<br />
✅ Serviço de Domínio
Centraliza lógicas importantes que não pertencem a uma entidade específica, mantendo o foco no negócio.
<br />
<br />
✅ Classes Abstratas
Não podem ser instanciadas. Servem como modelo base para outras classes.
<br />
<br />
✅ Métodos Abstratos
São declarações sem corpo. As classes filhas devem implementá-los.
<br />
<br />
✅ Métodos Concretos
Têm implementação. Classes filhas podem herdar ou sobrescrever.
<br />
<br />
✅ Herança
Classes filhas herdam estrutura e comportamento da classe abstrata.
<br />
<br />
✅ Base para Implementação
As filhas implementam os abstratos e podem personalizar os concretos.
<br />
<br />
✅ Compartilhamento de Comportamento
Garante que todas as filhas sigam um padrão comum e compartilhem lógica base.
<br />
<br />
✅ Polimorfismo
Permite usar a classe base para trabalhar com diferentes filhas de forma genérica.
<br />
<br />

✅ Design Patterns (Padrões de Projeto)
<br />
1_ Singleton - Apenas uma instância de uma classe em todo o sistema.

2_ Factory/Abstract Factory - 
Factory → Cria objetos com base em lógica
Abstract Factory → Cria famílias de objetos relacionados

3_ Strategy - Troca ações em tempo de execução.

4_ Observer - Notificação de objetos quando algo muda.

5_ Decorator - Adiciona funcionalidades a um objeto sem mudar sua estrutura.

6_ Builder - Constrói objetos passo a passo.

✅ Architectural Patterns
<br />
1_ Clean Architecture - Divide o sistema em camadas com dependência invertida:

2_ CQRS - Separa leitura (Query) de escrita (Command)
