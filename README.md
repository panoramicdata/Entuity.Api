# Entuity.Api



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
