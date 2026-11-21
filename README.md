# Aplicação Financeira com Entity Framework Core

Projeto individual de estudo em C# sobre persistência de dados. Uma aplicação de console usa o Entity Framework Core para inserir um registro de exemplo em um banco SQL Server LocalDB.

## O que o projeto implementa

- Uma entidade com identificador, nome, valor e estado de finalização.
- Um contexto do EF Core e uma migração inicial para criar a tabela.
- Uma rotina que adiciona um registro com `Add()` e faz a gravação com `SaveChanges()`.

O construtor usado no exemplo atribui os argumentos a campos privados. As propriedades mapeadas pelo EF Core não recebem esses valores. Ao consultar a tabela, leve em conta os valores padrão dessas propriedades.

## Tecnologias

C# · .NET 10 · Entity Framework Core 10 · SQL Server LocalDB

## Como executar

Use Windows com o SDK do .NET 10 e o SQL Server LocalDB instalados. A aplicação usa a instância LocalDB definida no contexto do EF Core. Confirme que essa instância está disponível na sua máquina.

Se ainda não tiver a ferramenta de linha de comando do EF Core, instale-a com:

```powershell
dotnet tool install --global dotnet-ef --version 10.0.13
```

Baixe ou clone este repositório. Na raiz do projeto, execute:

```powershell
dotnet restore ConsoleApp1/ConsoleApp1.csproj
dotnet ef database update --project ConsoleApp1/ConsoleApp1.csproj
dotnet run --project ConsoleApp1/ConsoleApp1.csproj
```

Depois de executar, abra o banco no SQL Server Management Studio ou em outro cliente compatível e consulte a tabela criada pela migração.

## O que aprendi

Este projeto me ajudou a entender como uma classe C# é mapeada para uma tabela, como uma migração cria o esquema do banco e como o EF Core grava um registro com `SaveChanges()`.
