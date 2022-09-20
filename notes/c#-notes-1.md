# História do C#

- Linguagem C
- Linguagem C++
- Linguagem (C#)

## Como as linguagens funcionam

Linguagem Compilada

```cpp
#include <iostream>

using namespace std;

int main() {
  cout << "Hello World!\n";
}
```

Linguagem Interpretada

```py
  print('hello world')
```

```py
  nome = 'joão'
  idade = 20

  print(f'Olá, eu sou o {nome}')
  print(f'Tenho {idade} anos')
```

## Linguagem Pré-Compilada

É uma linguagem que guarda um estado intermediário e consegue ser multi plataforma, sem perder performance.

```c#
namespace Base {
    public class Program {
        public static void Main() {

            Console.WriteLine("Hello World!");

        }
    }
}
```

## Variáveis

|nome|propósito|
|:-:|:-:|
|`int`|Inteiro|
|`long`|Inteiro maior|
|`float`|Número real, com ponto flutuante|
|`double`|Número real, com ponto flutuante|
|`bool`|Guarda verdadeiro ou falso|
|`char`|Um caracter|
|`string`|Sequência de caracteres|
