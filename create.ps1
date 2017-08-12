#Create entity library
dotnet new classlib --name Core.Entity --language C# --framework netcoreapp1.0
cd Core.Entity
dotnet add package Microsoft.EntityFrameworkCore --version 1.1.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 1.1.2
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 1.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 1.1.2
dotnet restore
cd ..

#Create app
dotnet new webapi --name Core.Api --language C# --framework netcoreapp1.0
cd Core.App
dotnet add package Microsoft.AspNetCore.Cors --version 1.1.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 1.1.2
dotnet add reference ..\Core.Entity\Core.Entity.csproj
dotnet restore
cd ..

#Create solution
dotnet new sln --name spa
dotnet sln add Core.Entity\Core.Entity.csproj Core.App\Core.Api.csproj

