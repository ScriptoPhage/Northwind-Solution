# Overview

![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core%208-blue) 


An asp.net web app operating on the [Northwind Database](https://github.com/microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs). This solution was built after migrating the database from SQL Server to PostgreSQL using **DBeaver**. The SQL Server views and procedures were manually converted to PostgreSQL views and functions respectively.
## Features
- Fetching and showing data using **Tabulator.js** by invoking Northwind functions with parameters
- Image data Creation, Reading, Update and Deletion (**CRUD**) on the Categories table data.
- Is capable of detecting images with OLE headers and process accordingly
- Can execute raw SQL query through Entity Framework Core

## Tech Stack
| Component      | Technology             |
|----------------|-------------------------|
| Frontend       | Bootstrap, Tabulator.js |
| Backend        | Asp.net core 8, Entity Framework Core         |
| Database       | PostgreSQL             |

# Running the API Locally
To run this API locally, follow the steps below:
Clone the repository to your local machine:
## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/ScriptoPhage/Northwind-Solution.git
2. Navigate to the project directory:
   ```bash
   cd mvc
3. Restore the dependencies:
   ```bash
   dotnet Restore
4. Install PostgreSQL
5. Update the ```api/appsettings.json``` file and configure the ```ConnectionStrings```. Replace Username and Password with your resepctive database credentials 
   ```bash
   "ConnectionStrings": {
      "DefaultConnection": "Host=localhost;Port=5432;Database=Northwind;Username=myuser;Password=mypassword;"
    }
    ```
6. Install the dotnet-ef tool (if not installed already) to migrate the database.
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
This will create the necessary tables in your PostgreSQL database according to your models.
Or you may also use Nuget Package Manager Console (PMC)
```bash
Add-Migration InitialCreate
Update-Database
```
4. Run the application:
   ```bash
   dotnet run
By default, the API will be available at ```http://localhost:5130```.
