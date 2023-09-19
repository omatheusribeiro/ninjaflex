# Ninjaflex - Sales System

Welcome to the Ninjaflex project repository, a sales system developed with .NET Core 7 and Angular 12. This project uses SQL Server with Code First to manage database migrations.

## Overview

Ninjaflex is a robust and flexible sales system designed to meet your business needs. It combines the powerful capabilities of .NET Core 7 on the server-side with the rich user experience of Angular 12 on the front-end.

## Repository Structure

This repository is organized as follows:

- `ninjaflex.API`: This layer is responsible for managing the application's API.

- `ninjaflex.Application`: This layer is responsible for managing all application services.

- `ninjaflex.Data`: This layer is responsible for managing the application's data.

- `ninjaflex.Domain`: This layer is responsible for managing the application's domains.

- `ninjaflex.Front`: This layer is responsible for managing the application's front-end.

- `ninjaflex.Infra`: This layer is responsible for managing the application's infrastructure.

## Prerequisites

Before you start using Ninjaflex, you'll need to have the following installed:

- [.NET Core 7](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Node.js](https://nodejs.org/) and [npm](https://www.npmjs.com/)
- [Angular CLI](https://angular.io/cli)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

Make sure to install all dependencies before proceeding.

## Database Configuration

Ninjaflex uses SQL Server with Code First to manage database migrations. Before running the application, follow these steps:

1. Open a terminal in the `ninjaflex.Data` folder.
2. Run `dotnet ef database update` to apply migrations and create the database.

## Running the Application

Now that you've configured the database, follow these steps to run Ninjaflex:

1. Open a terminal in the `ninjaflex.API` folder.
2. Run `dotnet run` to start the server.
3. Open another terminal in the `ninjaflex.Front` folder.
4. Run `npm install` to install Angular dependencies.
5. Run `ng serve` to start the Angular development server.

Access the application at [http://localhost:4200](http://localhost:4200).

## Contribution

If you'd like to contribute to Ninjaflex, feel free to open an issue or submit a pull request. We appreciate your collaboration!

## License

This project is licensed under the [Apache 2.0 License](LICENSE.md).
