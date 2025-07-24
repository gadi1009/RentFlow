# RealEstateManagementSystem

> Early-stage real-estate management system built with .NET/WinForms.  
> This repo was auto-organized by a script: folders, namespaces, and boilerplate files were normalized.

## Structure

```
RealEstateManagementSystem/
├── Enums/
├── Models/
├── DTOs/
├── Interfaces/
│   ├── Repositories/
│   └── Services/
├── Services/
├── Repositories/
│   ├── File/
│   └── EFCore/
├── Data/
│   ├── Seed/
│   ├── Migrations/
│   └── Storage/
├── Forms/
├── Mappers/
├── Utilities/
├── Config/
└── Program.cs
```

## How to run

```bash
dotnet restore
dotnet run
```

## To-Do / Roadmap

- Secure passwords (hash + salt)
- Replace file-based persistence with a DB (EF Core)
- Add unit & integration tests
- CI (GitHub Actions)
