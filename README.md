[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![NuGet version](https://img.shields.io/nuget/v/Entuity.Api.svg)](https://www.nuget.org/packages/Entuity.Api/)

[![Codacy Badge](https://app.codacy.com/project/badge/grade/Entuity.Api)](https://app.codacy.com/gh/panoramicdata/Entuity.Api/dashboard)

# Entuity.Api

Support for the REST API as documented here:
https://support.entuity.com/hc/en-us/sections/360004560094-Entuity-RESTful-API

## Example Usage
``` C#
var entuityClient = new EntuityClient(new EntuityClientOptions
{
  Url = "https://entuity.example.com/",
  Username = "username",
  Password = "xxxxxxxx",
  UserAgent = "MyApp",
  Logger = s.GetRequiredService<ILogger<EntuityClient>>()
});

var result = await client
  .Inventory
  .GetAllAsync(default);
```
