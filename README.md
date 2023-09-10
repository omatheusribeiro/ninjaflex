# Ninjaflex - Sistema de Vendas

Bem-vindo ao repositório do projeto Ninjaflex, um sistema de vendas desenvolvido com .NET Core 7 e Angular 12. Este projeto utiliza o SQL Server com Code First para gerenciar as migrações do banco de dados.

## Visão Geral

O Ninjaflex é um sistema de vendas robusto e flexível, projetado para atender às necessidades do seu negócio. Ele combina a poderosa capacidade de .NET Core 7 no lado do servidor com a rica experiência de usuário do Angular 12 no front-end.

## Estrutura do Repositório

Este repositório é organizado da seguinte forma:

- `ninjaflex.Back`: O código-fonte do servidor, desenvolvido com .NET Core 7, incluindo API, autenticação, gerenciamento de vendas e muito mais.

- `ninjaflex.Front`: O código-fonte do cliente, desenvolvido com Angular 12, contendo as telas de interface do usuário para gerenciar produtos, pedidos e clientes.

## Pré-requisitos

Antes de começar a usar o Ninjaflex, você precisará ter instalado o seguinte:

- [.NET Core 7](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Node.js](https://nodejs.org/) e [npm](https://www.npmjs.com/)
- [Angular CLI](https://angular.io/cli)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

Certifique-se de instalar todas as dependências antes de prosseguir.

## Configuração do Banco de Dados

O Ninjaflex utiliza o SQL Server com o Code First para gerenciar as migrações do banco de dados. Antes de iniciar o aplicativo, siga estas etapas:

1. Abra um terminal na pasta `ninjaflex.Back`.
2. Execute `dotnet ef database update` para aplicar as migrações e criar o banco de dados.

## Executando o Aplicativo

Agora que você configurou o banco de dados, siga estas etapas para executar o Ninjaflex:

1. Abra um terminal na pasta `ninjaflex.Back`.
2. Execute `dotnet run` para iniciar o servidor.
3. Abra outro terminal na pasta `ninjaflex.Front`.
4. Execute `npm install` para instalar as dependências do Angular.
5. Execute `ng serve` para iniciar o servidor de desenvolvimento do Angular.

Acesse o aplicativo em [http://localhost:4200](http://localhost:4200).

## Contribuição

Se você deseja contribuir para o Ninjaflex, fique à vontade para abrir um problema ou enviar uma solicitação de pull request. Agradecemos a sua colaboração!

## Licença

Este projeto é licenciado sob a [Licença MIT](LICENSE.md).

---

Sinta-se à vontade para personalizar este README conforme suas necessidades específicas e adicionar informações adicionais, como a documentação detalhada do projeto, instruções de implantação, e assim por diante. Boa sorte com o desenvolvimento do Ninjaflex!