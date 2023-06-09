[![NuGet](https://img.shields.io/nuget/v/CrunkA3.ViessmannClient)](https://www.nuget.org/packages/CrunkA3.ViessmannClient)
[![.NET](https://github.com/CrunkA3/ViessmannClient/actions/workflows/dotnet.yml/badge.svg)](https://github.com/CrunkA3/ViessmannClient/actions/workflows/dotnet.yml)
[![CodeQL](https://github.com/CrunkA3/ViessmannClient/actions/workflows/codeql.yml/badge.svg)](https://github.com/CrunkA3/ViessmannClient/actions/workflows/codeql.yml)

# ViessmannClient

Based on [PhilipDaubmeier.ViessmannClient](https://github.com/philipdaubmeier/GraphIoT/blob/master/src/ViessmannClient/ViessmannClient.nuspec)

This class library provides a way to call the Viessmann Developer Portal API. It encapsulates all authentication, retry and parsing logic and provides a strongly typed method interface for reading all details, settings and sensor values of an installation as well as execute commands.

## NuGet

```powershell
PM> Install-Package CrunkA3.ViessmannClient
```

## Usage

For getting access to Viessmann APIs, first register on the [Viessmann Developer Portal](https://developer.viessmann.com/) and create a client via ["API Keys"](https://developer.viessmann.com/de/clients), which will generate a client id for you and lets you set one or more redirect URIs.

To then use this library, you have to implement the interfaces `IViessmannAuth` and `IViessmannConnectionProvider<T>` to provide the Viessmann webservice clients with all information necessary to authenticate and establish a connection.

The minimal viable example for playing around with the client would be to create a connection provider and generate the login form uri as shown here:

```csharp
var auth = new ViessmannAuth();
var viessmannConnProvider = new ViessmannConnectionProvider<ViessmannPlatformClient>(auth)
{
    ClientId = "<clientId>",
    RedirectUri = "http://localhost:4000"
};

var client = new ViessmannPlatformClient(viessmannConnProvider);
var uri = client.GetLoginUri();

Console.WriteLine($"Login here: {uri.AbsoluteUri}");
```

For playing around you can now copy the uri that was written to the console into a browser and log in there. The browser will then redirect to a page that does not exist and will show a _"page not found"_ message. Just use the part after `?code=` in the browser address bar and input it into the program, which is shown in the following.

```csharp
Console.WriteLine("After logging in you should be redirected to a non-existent page.");
Console.WriteLine("Enter the code you see in the browsers address bar behind '?code=':");
var code = Console.ReadLine();
await client.TryCompleteLogin(code);
```

After this step, the `auth` object will contain a valid access token and also a refresh token. The refresh token can be permanently persisted and loaded after each startup and will automatically be used for refreshing the access token if expired.

> **Note:** in a productive use you will want to launch the login uri in an embedded browser view or redirect to this uri in case of a web application. After sucessful login either capture the resulting uri from the embedded browser or use a productive callback API on your server side.

With being logged in sucessfully and having a valid refresh token in the `auth` object, you can now go ahead and use the library to actually traverse through installations, gateways and devices and finally query for data on the Viessmann API:

```csharp
// Get the first installation, gateway and device id of the logged in user
var installationId = (await client.GetInstallations()).First().LongId;
var gatewayId = (await client.GetGateways(installationId)).First().LongId;
var deviceId = (await client.GetDevices(installationId, gatewayId)).First().LongId;

// Get sensor values
var features = await client.GetDeviceFeatures(installationId, gatewayId, deviceId);
var outsideTemp = features.GetHeatingSensorsTemperatureOutside();
var boilerTemp = features.GetHeatingBoilerTemperature();
Console.WriteLine($"Outside temp: {outsideTemp} °C, boiler temp: {boilerTemp} °C");

// Execute command
var commandContent = new Commands.CommandContent<double> { CommandName = "SetTemperature", CommandBody = 52 });
bool result = await viessmannClient
    .ExecuteDeviceFeatureCommand(installationId, gatewayId, deviceId, featureName, commandContent);
```

For more usage examples you can also have a look at the [unit tests](../../test/ViessmannClient.Tests).

A full list of status and sensor values of devices can be found in the [`DeviceFeatureList`](Model/Devices/DeviceFeatureList.cs) class and in the Viessmann Developer Portal, _"IoT Features"_, chapter [_"List of features"_](https://developer.viessmann.com/en/doc/iot).

## Platform Support

ViessmannClient is targeted for .NET 6.0 or higher.
