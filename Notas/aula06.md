# Antes da POO

Fazendo o sistema receber uma pessoa composta pelos campos: nome, idade e altura.

```c#
string nome = "joao";
int idade = 20;
double altura = 1.8;
```

## Trocando duas variáveis


Tentando trocar duas variáveis:

```c#
int a = int.Parse(Console.ReadLine()); // 2
int b = int.Parse(Console.ReadLine()); // 3

a = b; // a = 3 , b = 3
b = a;
```

**Problema:** Não consigo lembrar o valor de ambas as variáveis durante a troca e acabo perdendo um dos valores

**Solução:** Criar uma variável *temporária/auxiliar* pra trocar esses valores.

troca:
```c#
int copy = a;
a = b;
b = copy;
```

## Voltando ao problema inicial...

Quero declarar 100 pessoas

```c#
string[] nomes = new string[100];
int[] idades = new int[100];
double[] alturas = new double[100];
```

**Por que não fizemos uma matriz?**

> Matriz é homogênea, isto é, guarda variáveis de um mesmo tipo.

## Problema motivador

Trocar os alunos das posições 0 e 5.

```c#
string nomeAux = nomes[0];
nomes[0] = nomes[5];
nomes[5] = nomeAux;

string idadeAux = idades[0];
idades[0] = idades[5];
idades[5] = idadeAux;

// ...
```

# Introdução POO

Classe: é uma classificação de um certo modelo.

> **Classe = Molde**

> **Objeto = fruto desse molde**

## O que contém uma classe?

Uma classe(molde) é composta por atributos(*tem*) e métodos(*faz*).

**Atributos:** São variáveis declaradas para cada objeto do tipo correspondente.

**Métodos:** São funções que pertencem a um determinado grupo ou a determinada classificação.

## Criando os atributos

```c#
class Pessoa {

    // atributos
    public string Nome;
    public int Idade;
    public double Altura;
}
```

## Criando métodos

```c#
class Pessoa {

    // atributos
    public string Nome;
    public int Idade;
    public double Altura;

    // métodos
    public void DizerOi() {
        Console.WriteLine("Hello World!");
    }

    public void FazerAniversario() {
        Idade++;
    }
}
```

## Instanciando objetos

```c#
public class Program {
    public static void Main() {

        Pessoa joao = new Pessoa();

        joao.Nome = "Joao da Silva";
        joao.Idade = 23;
        joao.Altura = 1.9;

        joao.DizerOi();
        joao.FazerAniversario();

        Console.WriteLine($"Idade = {joao.Idade}");
        
    }
}
```

## Gerenciando arquivos


Criamos por boa prática uma pasta com o nome `Model` ou `Entities` para guardar as entidades que modelam a nossa aplicação.

Por enquanto, usaremos apenas a privacidade do tipo `public`.

## Contrutores

Todas as classes já possuem dentro delas o construtor padrão.

```c#
 public class Conta {
    // atributos
    public string ID;
    public string Nome;
    public double Saldo = 0.0;

    public Conta() {

    }

}
```

## Construtores Personalizados

São formas de inicializar variáveis e garantir procedimentos durante a criação de um novo objeto.

Para que um objeto seja criado **todos** os parâmetros de seu(s) construtore(s) devem ser atendidos.

```c#
public Conta(string id, string nome) {
    ID = id;
    Nome = nome;
    Saldo = 0.0;
}
```

## Sobrecarga de Construtores

Podemos sobrecarregar um construtor mudando os argumentos que estarão contidos nele, isto é, podemos colocar mais uma *responsabilidade/processo* sobre o mesmo nome.

```c#
// construtor e sobrecargas
public Conta(string id, string nome, double saldo) {
    ID = id;
    Nome = nome;
    Saldo = saldo;
}

public Conta(string id, string nome) {
    ID = id;
    Nome = nome;
    Saldo = 0.0;
}
```