# Tipos anuláveis (*Nullables*)

```c#
// tipo não anulável
string nome;

// tipo anulável
Nullable<string> nome;

// sintaxe atual para nullables
string? nome;
```

## Coalescência Nula

```c#
  public Aluno(string? nome) {
      // checando se o argumento é nulo
      // se sim => Nome = "undefined"
      // senão => Nome = nome
      Nome = nome ?? "undefined";
  }

  public void FazerProva(int nota) {
      // Coalescência nula reflexiva
      // Nota = Nota ?? nota
      Nota ??= nota;
  }
```

# Foreach - Para cada

```C#
  int[] vetor = new int[20];
```

## Printando sem foreach

Interação pelo index.

```c#
for(int i =0; i < vetor.Length; i++) {
  Console.WriteLine(vetor[i]);
}
```

## Printando com o foreach

Interação pelos valores
```c#
int[] numeros = {2, 3, 4, 5, 6};

foreach(int numero in numeros) {
  Console.WriteLine(numero);
}
```

# Referências - `ret`/`out`

```c#
public void Troca(ref int a, ref int b) {
  int temp = a;
  a = b;
  b = temp;
}
```

```c#
int a, b;

Troca(a, b);
```

## **Ref**

Usado em casos que queremos manipular dados existentes e não trabalhar com cópias, mas sim com o mesmo conteúdo que o outro escopo trabalhava. 

## **Out**

Usado em casos que queremos atribuir ou configurar valores não necessariamente já existentes e manter ele no escopo principal.
