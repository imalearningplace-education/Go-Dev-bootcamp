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