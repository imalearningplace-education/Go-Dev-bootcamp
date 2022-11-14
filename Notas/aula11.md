# Programação Funcional

A nossa motivação foi parar de usar sempre "o que" e começar a abordagem de "como fazer".

- Delegates: São os motivadores e o que faz os lambdas funcionarem por baixo dos panos.

# LINQ

**Language Integrated Query**

1. datasource (Fonte de dados)
2. query (Fila de operações)
3. terminal operation (Operação que encerra)

## Lazy loading (Carregamento Tardio)

Melhora algebricamente o custo de interação com um datasource.

- Predicate (T) => (bool)
- Action
- Func

```c#
List<int> numbers = new List<int> { 2, 3, 4, 5, 6 };

numbers
    .Where(n => n % 2 == 0)
    .Select(n => 10 * n)
    .ToList()
    .ForEach(Console.WriteLine);
```

# Entity Framework (Core)

Entity Framework é uma ORM(Object-Relational Mapping).

## DbContext

Cria uma sessão e lança os comandos para o banco de dados.


## DbSet<TEntity>

Dentro de um DbContext, carrega as informações das tabelas indo para o banco de dados e voltando do banco de dados.

## Sistemas Core

As tecnologias Core, como **.NET Core** e **EF Core** são tecnologias mais usadas pela flexibilidade entre diferentes plataformas e sistemas operacionais.

# Projeto MVC

**MVC** é um sigla para **Model Views and Controllers** no qual montamos uma aplicação C# sem uma divisão clara de tecnologias entre Back e Front end.

## Model

**Model** é uma das partes que mais praticamos no curso, nesta camada nós focamos em criar as classes/modelagens do nosso sistema, das entidades que irão interagir e trafegar pela aplicação.

Quanto temos bando de dados, essa parte conversa diretamente com algum modelo de persistência de dados em algum banco de dados ou em arquivos. 
## Controllers

**Controllers** são os "garçons" da nossa aplicação, no modelo MVC os controladores normalmente servem páginas web formadas, mas que em aplicações no geral também são capazes de retornar arquivos de informação. 

Este modelo não é sempre utilizado pois acaba exigindo uma responsabilidade do servidor de construir a página e enviá-la pronta para o cliente.

## Views

**Views** é a parte que construiremos a página usando uma tecnologia acoplada ao ao C#