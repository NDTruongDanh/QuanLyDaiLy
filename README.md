# QuanLyDaiLy

QuanLyDaiLy is a C# school project application for managing agencies/distributors. It was created for educational purposes to practice building a small management system with a SQL Server backend.

## What’s in this project

- Core domains
  - Agents: store and maintain agent records
  - Products: manage basic product information and pricing
  - Orders & Invoices: record sales transactions to agents
  - Receipts & Payments: track incoming payments from agents
  - Debts: monitor outstanding balances and reconciliations
  - Reports: basic summaries (e.g., revenue and debt overviews)

- Technology overview
  - Application: C#
  - Database: T-SQL (SQL Server)

- Language composition (from repository stats)
  - C#: 93.4%
  - T-SQL: 6.6%

## Setup and Run

The instructions below cover a typical setup for a C# application with a SQL Server database. Adjust names and paths to match your environment.

1) Prerequisites
- Windows (recommended if the app uses WinForms/WPF)
- Visual Studio (Community or higher) with .NET tooling, or the .NET SDK with CLI
- SQL Server (Express or Developer) and optionally SQL Server Management Studio (SSMS)
- Git

2) Get the source
```bash
git clone https://github.com/NDTruongDanh/QuanLyDaiLy.git
cd QuanLyDaiLy
```

3) Set up the database
- If the repository includes SQL scripts (commonly under a folder like database/ or scripts/), run them in this order:
  1. Create database and schema objects (tables, views, stored procedures)
  2. Insert seed/sample data (optional)
- If there are no scripts, create a SQL Server database (e.g., QuanLyDaiLy) and prepare basic tables to match the application’s usage.

Using SSMS (example):
1. Open SSMS and connect to your SQL Server instance.
2. Create a new database, e.g., QuanLyDaiLy.
3. Open and execute the schema SQL scripts first, then any seed data scripts.

4) Configure the connection string
Depending on how the app is built, you will typically configure one of the following:

- App.config/Web.config (example):
```xml
<configuration>
  <connectionStrings>
    <add name="DefaultConnection"
         connectionString="Data Source=localhost;Initial Catalog=QuanLyDaiLy;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

- appsettings.json (example):
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=QuanLyDaiLy;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

Update:
- Server/instance name (e.g., .\\SQLEXPRESS or localhost)
- Authentication mode (Integrated Security or user/password)
- Database name (e.g., QuanLyDaiLy)

5) Build and run
- Visual Studio:
  1. Open the solution (.sln) file.
  2. Set the startup project (if there are multiple).
  3. Press F5 (Debug) or Ctrl+F5 (Run without debugging).

- .NET CLI (if applicable):
```bash
dotnet restore
dotnet build -c Release
dotnet run --project path/to/startup-project
```

6) First-time checks
- Verify the app can connect to SQL Server with your connection string.
- If the app expects initial data (agents, products), ensure the seed scripts were executed or add records via the UI.
- If Entity Framework migrations are used, apply them before first run (example):
```bash
dotnet ef database update
```

## Notes

- This is a student course (school) project intended for learning and demonstration.
- It focuses on core management workflows and a straightforward database-backed design.
