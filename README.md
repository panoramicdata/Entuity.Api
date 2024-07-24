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
