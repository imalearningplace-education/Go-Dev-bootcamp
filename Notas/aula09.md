# Herança

Fazemos herança para ter uma boa divisão de responsabilidade no código e também para diminuir os pontos de alteração caso fossémos atualizar o sistema.

Geometria
```
FormaGeometrica
  > Circulo
  > Triangulo
  > Retangulo
```

```c#
public class FormaGeometrica {
  public double Espessura {get; set;}
  public Cor Cor {get; set;}  
}
```

```c#
public class Circulo : FormaGeometrica {
  public double raio {get; set;}
}
```

```c#
public class Quadrado : FormaGeometrica {
  public double altura {get; set;}
  public double comprimento {get; set;}
}
```

```
Pessoa
  > aluno
  > funcionário
    > funcionário instuticional
    > funcionário docente
    > funcionário serviço
```


            // upcasting
            FormaGeometrica circulo = new Circulo(2.3, Cor.CINZA, 9.0);
            FormaGeometrica forma1 = new Circulo(2.3, Cor.CINZA, 9.0);

            // downcasting
            Circulo derivadoC2 = (Circulo) forma1;