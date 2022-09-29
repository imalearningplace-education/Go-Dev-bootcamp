# Keywords em repetição

## 1. break

> Laço de repetição: Fala sobre as interações individuais do nosso loop.

Interrompe forçadamente o laço de repetição no ponto em que foi lido.

## 2. continue

Pula o resto do laço de que falta ser executado, porém não interrompe o loop.


# Vetores

Vetores são conjuntos de um dado tipo que podem armazenar sequencias contiguas de dados.

> Vetores são referência para blocos de memória

## Criação e uso

```c#
// criando com valores 
// tamanho calculador automaticamente
double[] precos = {1.99, 3.99, 7.99}

//  criando por alocação
int[] idades = new int[5];

// colocando valores
idades[0] = 20;
idades[1] = 24;
idades[2] = 29;
idades[3] = 22;
idades[4] = 23;

// criando por alocação
// colocando os primeiros valores
double[] alturas = new double[10]{1.7, 1.8, 2.1};
```

## Bônus: Valos vs. Referência

Quando falamos de tipo valor é tudo que estudamos até agora, quando atribuímos um valor a uma variável, este número é copiado para aquele espaço de memória.

Quando falamos de tipo referência, estamos olhando para variáveis como por exemplo os vetores. Vetores não são *caixinhas* simples de memória, eles na verdade são uma referência (um apontador) para outro endereço na memória.

Fazemos este tipo de relação quando precisamos reservar grandes espaços, pois existem regiões que permitem grandes alocações e outras não. Comunicamos estas regiões através da referência: **um comunicador de endereços**

> Esta é uma discussão que percorre durante todo o nosso estudo da programação, o conceito é simples, porém podemos avançar para casos complexos e usar isto ao nosso favor.

# Entradas em uma linha

Usaremos um comando associado as `string`'s para resolver esse tipo de caso, no qual pegaremos a linha completa e usaremos o comando `.Split()`.

O comando `.Split()` deve receber como entrada um caracter ou uma sequência de caracteres a serem buscados e usados como critério de separação.

```c#
// realizar leitura
string[] linha = Console.ReadLine().Split(" ");

// atribuir as variaveis
string nome = linha[0];
int idade = int.Parse(linha[1]);
double altura = double.Parse(linha[2]);
```

# Bônus: Operador Ternário

Este operador é algo que gostamos de usar para compactar e **melhorar a expressividade** do nosso código.

O seguinte código:

```c#
int a = 2, b = 3;
int maior;

if( a > b ) {
  maior = a;
} else {
  maior = b;
}
```

poderia ser reduzido para:

```c#
maior = (a > b) ? a : b;
```

Em resumo, o operador ternário tem três regiões

```
( 1 ) ? ( 2 ) : ( 3 )
```

1. condição a ser testada
2. valor que retorna se for verdadeiro
3. valor que retorna se for falso
