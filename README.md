# DIO - Trilha .NET - Programação orientada a objetos

Desafio de projeto da trilha .NET da [DIO](https://www.dio.me/), baseado no repositório
[digitalinnovationone/trilha-net-poo-desafio](https://github.com/digitalinnovationone/trilha-net-poo-desafio).

## O desafio

Modelar um sistema que trabalha com celulares, criando uma abstração de um celular para que diferentes
marcas e modelos tenham seu próprio comportamento, aproveitando ao máximo o reuso de código.

### Regras

1. A classe `Smartphone` é **abstrata**: não pode ser instanciada, serve apenas como modelo.
2. As classes `Nokia` e `Iphone` são **subclasses** de `Smartphone`.
3. O método `InstalarAplicativo` é **sobrescrito** em `Nokia` e em `Iphone`, pois cada marca instala aplicativos de um jeito.

## Diagrama de classes

```
             Smartphone <<abstract>>
             + Numero: string
             - Modelo: string
             - IMEI: string
             - Memoria: int
             + Ligar()
             + ReceberLigacao()
             + InstalarAplicativo(string nome) <<abstract>>
                   /              \
                Nokia            Iphone
   + InstalarAplicativo()    + InstalarAplicativo()
```

## Estrutura

```
DesafioPOO.csproj
Program.cs           # testes com Nokia e Iphone
Models/
  Smartphone.cs      # classe abstrata base
  Nokia.cs
  Iphone.cs
```

## Conceitos de POO aplicados

- **Abstração:** `Smartphone` reúne o que todo celular tem (número, modelo, IMEI, memória, ligar e receber ligação).
- **Encapsulamento:** `Modelo`, `IMEI` e `Memoria` são privados, como no diagrama.
- **Herança:** `Nokia` e `Iphone` herdam de `Smartphone` e repassam os dados ao construtor base com `base(...)`.
- **Polimorfismo:** cada classe sobrescreve `InstalarAplicativo` com `override`, e o `Program.cs` usa variáveis do tipo `Smartphone`.

## Como executar

Pré-requisito: [.NET SDK 10](https://dotnet.microsoft.com/download) (para usar outra versão, altere o
`TargetFramework` no `.csproj`, por exemplo para `net8.0`).

```bash
dotnet run
```

Saída esperada:

```
Smartphone Nokia:
Ligando...
Recebendo ligação...
Instalando o aplicativo WhatsApp no Nokia...

Smartphone iPhone:
Ligando...
Recebendo ligação...
Instalando o aplicativo Telegram no iPhone pela App Store...
```
