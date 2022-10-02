# Conectivos / Operarados lógicos

## Conectivo E/AND - `&&`
```c#
bool agua = true;
bool cafe = false;

if( agua ) {
  if ( cafe ) {
    // ...
  }
}
```

melhorando:

```c#
if( agua && cafe ) {
 // ...
}
```

## Conectivo Ou/Or - `||`

```c#
bool agua = true;
bool suco = false;

if (agua) {
  // ...
}

if(suco) {
  // ...
}
```

```c#
if ( agua || suco ) {
  // ...
}
```

# Casting (Ativo)

É um aviso em frente a variável que avisa sobre a compatibilidade entre os tipos.

Exemplo:

```c#
int a = (int)3.2;
```

# Bônus: Estrutura do...while

```c#
while( 2 > 3) {
  Console.WriteLine("run");
}
```

Saída: 
```
```

```c#
do {
  Console.WriteLine("run");
}while(2 > 3);
```

Saída: 
```
  run
```

# Função 

- conjunto de regras
- entradas/argumento/parametro
- saída/retorna

somar(x, y, z, ...) = x + y + z + 
  
f(x) = x + 2
f(3.2) = 3.2 + 2 = 5.2

```c#
double f(double x) {
  return x + 2;
}
```

# Funções Recursivas

```
1. casos base
2. estrategia recursiva
```

```
somar(inicio, fim) {

  Se inicio == fim {
    retorne inicio
  }

  return fim + somar(inicio, fim-1)
}
```
