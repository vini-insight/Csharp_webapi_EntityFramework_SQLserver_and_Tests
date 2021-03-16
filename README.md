# Csharp_webapi_EntityFramework_SQLserver_and_Tests
C# WebAPI Entity Framework SQL Server NUnit Fluent Assertions Bogus NLog ASP NET core C Sharp .NET core dotNET core EF core SQL Server

# para banco de dados funcionar:

na raíz do projeto Csharp_webapi_EntityFramework_SQLserver,

altere OU crie o arquivos appsettings.json para:

    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=IP-or-DNS\\SQLEXPRESS;Database=DB-NAME;Trusted_Connection=True;"
        },
        "Logging": {
            "LogLevel": {
                "Default": "Information",
                "Microsoft": "Warning",
                "Microsoft.Hosting.Lifetime": "Information"
            }
        },
        "AllowedHosts": "*"
    }


e também altere OU crie o arquivo appsettings.Development.json para:

    {
        "Logging": {
            "LogLevel": {
                "Default": "Information",
                "Microsoft": "Warning",
                "Microsoft.Hosting.Lifetime": "Information"
            }
        }
    }


Tutorial: https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-nunit

https://docs.microsoft.com/pt-br/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows
https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnectionstringbuilder?view=dotnet-plat-ext-5.0&viewFallbackFrom=netcore-3.1


https://buildingsteps.wordpress.com/2018/07/06/testing-entity-framework-core/
https://www.michalbialecki.com/2020/11/28/unit-tests-in-entity-framework-core-5/


Projeto de aprendizado para uma webapi com Entity Framework usando MySql, C#, .NET e NLog baseado nos seguintes tuturiais:

1º - criar dirtório chamado "Csharp_WebAPI_NUnit_EF_MySql_NLog".

2º - entrar na pasta:

    cd Csharp_WebAPI_NUnit_EF_MySql_NLog

3º - criar solution:

    dotnet new sln

4º - criar dirtório chamado "Csharp_WebAPI_NUnit_EF_MySql".

5º - entrar na pasta:

    cd Csharp_WebAPI_NUnit_EF_MySql

6º - criar novo projeto com mesmo nome da pasta:

    dotnet new webapi

7º - retorne para o diretório "Csharp_WebAPI_NUnit_EF_MySql":

    cd ..

8º - Execute o seguinte comando para adicionar o projeto de biblioteca de classes à solução:

    dotnet sln add Csharp_WebAPI_NUnit_EF_MySql/Csharp_WebAPI_NUnit_EF_MySql.csproj

9º - Criando o projeto de teste. Crie o diretório TestsCsharp_WebAPI_NUnit_EF_MySql_Tests

10º - entrar na pasta:

    cd Csharp_WebAPI_NUnit_EF_MySql_Tests

11º - criar novo projeto de Testes usando NUnit com mesmo nome da pasta:

    dotnet new nunit

12º -  Agora, adicione a biblioteca de classes PrimeService como outra dependência ao projeto de Testes. Use o comando:

    dotnet add reference ../Csharp_WebAPI_NUnit_EF_MySql/Csharp_WebAPI_NUnit_EF_MySql.csproj

13º - O seguinte esquema mostra o layout da solução final:

    /unit-testing-using-nunit
        unit-testing-using-nunit.sln
        /PrimeService
            Source Files
            PrimeService.csproj
        /PrimeServiceTests
            Test Source Files
            PrimeServiceTests.csproj

15º - Agora é necessário adicionar o projeto de testes na solution. Para isso, retorne ao diretório principal "unit-testing-using-nunit" e execute o seguinte comando:

    dotnet sln add ./Csharp_WebAPI_NUnit_EF_MySql_Tests/Csharp_WebAPI_NUnit_EF_MySql_Tests.csproj

16º - Criando o primeiro teste. Escreva um teste com falha, faça-o ser aprovado e, em seguida, repita o processo. No diretório PrimeServiceTests, renomeie o arquivo UnitTest1.cs para PrimeService_IsPrimeShould.cs e substitua todo o seu conteúdo pelo código a seguir:

17º - O atributo [TestFixture] indica uma classe que contém testes de unidade. O atributo [Test] indica um método que é um método de teste.
Salve esse arquivo e execute dotnet test para compilar os testes e a biblioteca de classes e, em seguida, execute os testes. O executor de teste do NUnit contém o ponto de entrada do programa para executar os testes. dotnet test inicia o executor de teste usando o projeto de teste de unidade que você criou.
O teste falha. Você ainda não criou a implementação.

OBS.: no CLI este comando funciona tanto na pasta da solution quanto na pasta do projeto de teste.

    dotnet test

18º - Faça esse teste ser aprovado escrevendo o código mais simples na classe PrimeService que funciona:

19º - Execute "dotnet test" novamente. Ele executa uma compilação para o projeto PrimeService e, depois, para o projeto PrimeServiceTests. Depois de compilar os dois projetos, ele executará esse teste único. Ele é aprovado.


DICAS CLI:

    dotnet tool install --global <PACKAGE_NAME>
    
    dotnet tool uninstall --global <PACKAGE_NAME>    

    dotnet remove package <PACKAGE_NAME>


DEPENDENCIAS:    

    dotnet tool install --global dotnet-ef --version 3.1.13 (migrations command CLI. sem isso comando não é reconhecido)

    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.1 (DbContext and DbSet classes. para padronizar com SQL server e funcionar com template igual do MySql)

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.1 (UseSqlServer())    

    dotnet add package NLog.Web.AspNetCore --version 4.11.0 (for NLog)

    dotnet add package NLog --version 4.7.8 (for NLog)

    dotnet add package FluentAssertions --version 5.10.3

    dotnet add package Bogus --version 33.0.2


parte 1: https://medium.com/@gedanmagalhaes/criando-uma-api-rest-com-asp-net-core-3-1-entity-framework-mysql-423c00e3b58e

parte 2: https://medium.com/@gedanmagalhaes/criando-uma-api-rest-com-asp-net-core-3-1-entity-framework-mysql-parte-2-e969e82e5d2f

HttpPost baseado neste código: https://github.com/GedanMagal/Api-Ef/blob/master/Controllers/ProductController.cs

EXEMPLO DELET E PUT: https://www.entityframeworktutorial.net/efcore/delete-data-in-entity-framework-core.aspx

Geração de Logs: https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-3

### PASSOS para ativar Entity Framework Core:

para puxar os registros do banco de dados: ainda não temos nenhuma tabela criada. abrir o terminal do vscode e gerar nossa primeira Migration rodando o comando:

(se já estiver com as migrations prontas basta pular esse passo)

    dotnet ef migrations add PrimeiraMigration

qualquer nome pode ser adicionado após o add. este comando gerara uma tabela no seu schema com o nome dado no DataContext, no caso a primeira tabela que criará será a de Pessoas pois foi a unica que mapeamos até o momento.

depois insira o comando para criar as tabelas e também o banco de dados:

    dotnet ef database update

caso queira ver o processo de execução, basta rodar com o -v no final do comando



# bugs para corrigir:

saltos de ID automático toda vez que ocorre uma exeção. na tabela de pessoas, a coluna cpf é UNIQUE no banco: 

    ALTER TABLE pessoas ADD UNIQUE (cpf);

toda vez que tenta inserir um cpf duplicado a lib retorna exeção "duplicate entry" e quando coloca cpf novo, cadastra, mas pula para o próximo ID. deveria ser o mesmo ID.



OUTROS TUTORIAIS:

    fluent assertions + Xunit
    https://www.youtube.com/watch?v=7roqteWLw4s
    https://gist.github.com/Elfocrash/101ffc29947832545cdaebcb259c2f44


    https://www.youtube.com/watch?v=9ZvDBSQa_so
    https://www.youtube.com/watch?v=YccmHAOfwEE
    https://github.com/okazakiandre/refatoringdi-mock
    https://www.youtube.com/watch?v=5GhPAM3mW-I


    https://www.youtube.com/watch?v=WWN-9ahbdIU
    


