# Modelos de saída

Sem quebra de linha:
```c#
Console.Write("Hello World!\n");
```

**`\n`** :  é um caracter especial para indicar que queremos pular linha

Optamos mais pelo uso do:

```c#
Console.WriteLine("Hello World!");
```

## 1. Concatenação

```c#
int idade = 20;

Console.WriteLine("A idade é " + idade);
```

## 2. Interpolação (placeholder)

```c#
int idade = 20;

Console.WriteLine($"A idade é {idade}");
```

## 3. Interpolação (por Referência)

Colocamos um valor numérico para ser uma referência e depois passamos as variáveis como parâmetros.

```c#
string nome = "Hugo"
int idade = 20;

Console.WriteLine("{0} tem uma idade de {1} anos", nome, idade);
```

# Leitura de dados

## Comando de leitura

Lê o que for digitado no console até a tecla enter ser pressionada e retorna em modelo de `string` (frase)

```c#
  Console.ReadLine();
```

Para casos que eu queira ler algo diferente de `string`, devemos usar o método `.Parse` em cima do tipo desejado.

```c#
  string nome;
  int idade;
  double altura;
  bool estaNaSala;

  nome = Console.ReadLine();
  idade = int.Parse(Console.ReadLine());
  altura = double.Parse(Console.ReadLine());
```

# Estrutura de Seleção (`if-else`)

## Operadores Aritméticos

- (+, -, *, /) : Operações fundamentais

- % : Operação módulo

> O módulo retorna o resto entre dois números, ou seja, a%b retorna o resto de a na divisão por b.

## Operadores Comparativos

`a = b` : "A recebe B"
`a == b` : Compara A e B e retorna `true` ou `false`
`a >= b` : Compara se A é maior ou igual a B

> `!` é um sinal que indica a negação de alguma expressão ou termo

`a != b` : Compara se A é diferente de B
`!(a == b)` : Nega a resposta de "A é igual a B?"

## Operadore Reflexivos

`numero = numero + 2`: numero recebe o valor de numero somado com 2
`numero += 2`: numero recebe o valor de numero somado com 2

`numero = numero*2`
`numero *= 2`

`numero %= 2` : `numero = numero%2`

`numero++` : Acrescento 1 ao valor de numero
`numero--` : Retiro 1 do valor de numero

## Estrutura `if`

```
Se ( Condição ) {
  Código se for verdadeiro
}
```

```c#
if ( /*condição*/ ) {
  // código
}
```

Em casos de apenas um único comando, também podemos usar a sintaxe:

```c#
if( /*condição*/ )
  // código de uma linha
```

```c#
if ( /*condição*/ ) {
  // código se for verdade 
} else {
  // código se for falso
}
```

```c#
if ( /*condição*/ ) {
  // código se for verdade 
} else if (/*condição 2*/ ) {
 // código se a 2 for verdade
} else if (/*condição 3*/ ) {
 // código se a 3 for verdade
} ...
else {
  // código se for falso
}
```

# Estruras de Repetição

```
1. Inicialização
2. Verificação
3. Atualização
```

## Estruta `while` - Enquanto

```c#
while ( /*condição*/ ) {

} 
```

## Estrutura `for` - Para

```c#
for ( /*incialização*/ ; /*verificação*/ ; /*atualização*/ ){
  
}
```