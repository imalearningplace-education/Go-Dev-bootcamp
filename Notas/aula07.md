# Switch Case

Usamos o switch case em algumas situações de múltiplos *if's* e comparações únicas. Existem duas aplicações extremamente interessante dos usos de um switch case. Veja abaixo:

## Switch case em flags

```c#
public static bool IsVowel(char letra) {
    switch (letra) {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            return true;
        default:
            return false;
    }
}
```

## Switch case com enums

```c#
switch (ret1.Cor) {
  case Cor.VERDE:
  case Cor.AMARELO:
  case Cor.VERMELHO:
      Console.WriteLine("Colorido");
      break;
  default:
      Console.WriteLine("Não é Colorido");
      break;
}
```

```c#
string nome = "Hugo";
Console.WriteLine($"Hello, {nome}");
```