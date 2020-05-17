dotnet ef dbcontext scaffold "Data Source={server};Database={database-name};Persist Security Info=True;User ID={username};Password={password};" Microsoft.EntityFrameworkCore.SqlServer -o Models\Northwind -c NorthwindEntities
 
 
 This is cli command to scaffold an existing sqlserver db table classes into an asp.net core mvc project. See Medhat Elmasry youtube video https://www.youtube.com/watch?v=jHDhwAzskmo&list=PLvI8AHFvoYT3jhNpT8Tb_6HDzi16rxpcd&index=8  read https://docs.microsoft.com/tr-tr/ef/core/miscellaneous/cli/dotnet for complete information of packages to be installed and cli commands to be executed for new asp.net core version 3.x
 -----------------------------------------------------------
 
