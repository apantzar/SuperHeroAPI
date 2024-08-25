# SuperHero API

This is a .NET 8 Core Web API project that uses Entity Framework Core for data access. 

## Project Overview

- **Framework**: .NET Core 8
- **Data Access**: Entity Framework Core
- **Database**: SQL Server Express

### Purpose

This project is intended for a workshop demonstration. To keep things simple and focused on the core concepts, the following elements are **not** used in this version:
- DTOs (Data Transfer Objects)
- Services
- Repository pattern
- Other advanced design patterns or architectural practices

The goal is to provide a straightforward example of building a .NET Core Web API with direct Entity Framework Core integration, making it easier for participants to grasp the basics without the overhead of additional layers or abstractions.

### Features

- Basic CRUD operations for managing superheroes.

### Future Enhancements

In a more advanced version of the project, the following could be introduced:
- Implementation of DTOs to manage data transfer.
- Service layers to handle business logic.
- Repository pattern and other best practices in ASP.NET Core development.

### Getting Started

To run this project locally:

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Update the connection string in `appsettings.json` to point to your SQL Server Express instance. Example connection string:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=SuperHeroDb;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
