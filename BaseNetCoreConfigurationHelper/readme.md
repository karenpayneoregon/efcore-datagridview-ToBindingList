# About



Contains help methods to configure a SqlClient connection or a  [DbContext](https://docs.microsoft.com/en-us/ef/core/dbcontext-configuration/) connection, environment and logging read from appsettings.json in a project.



![img](assets/Versions.png)

![img](assets/core_csharp_shield.png)



|Scope|Method/property   |Definition   |
| :---         |  :---  | :--- |
|private|ConfigurationFileName :small_blue_diamond:   |Configuration file in frontend project   |
|public|Environment :small_blue_diamond:   |Configuration file in frontend project   |
|public|ConnectionString :small_orange_diamond:   | Used to get one connection string (no environent)   |
|public|GetConnectionString :small_orange_diamond:   | Used to get one connection string (environent)   |
|public|UseLogging :small_orange_diamond:   |true to use logging, false no logging for EF Core  |
|public|GetConnectionString :small_orange_diamond:   |Get prod or dev connection string insecure   |
|private|InitMainConfiguration :small_orange_diamond:  |Initialize ConfigurationBuilder for appsettings.json   |
|private|InitMainConfiguration :small_orange_diamond:   |Configuration building   |
|public|InitOptions :small_orange_diamond:  |Generic method to read section in configuration file   |

<br/>

:small_orange_diamond: method

:small_blue_diamond: property

<br/>



# NuGet packages 

[microsoft.extensions.configuration](https://www.nuget.org/packages/Microsoft.Extensions.Configuration/) <br/>
[microsoft.extensions.configuration.binder](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Binder/)<br/>
[microsoft.extensions.configuration.FileExensions](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.FileExtensions/)<br/>
[microsoft.extensions.configuration.Json](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Json/)

# Sample configurations

appsettings.json

```json
{
  "database": {
    "DatabaseServer": ".\\SQLEXPRESS",
    "Catalog": "NorthWind2020",
    "IntegratedSecurity": "true",
    "UsingLogging": "true"
  },
  "ConnectionStrings": {
    "DevelopmentConnection": "Server=.\\SQLEXPRESS;Database=NorthWind2020;Integrated Security=true",
    "ProductionConnection": "Server=.\\SQLEXPRESS;Database=NorthWind2020;Integrated Security=true"
  },
  "Environment": {
    "Production": false
  }
}
```