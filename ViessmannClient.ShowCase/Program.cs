// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net;
using ViessmannClient;
using ViessmannClient.Model.Installations;
using ViessmannClient.Network;

Console.WriteLine("Hello, World!");

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var auth = new ViessmannAuth();
var viessmannConnectionProvider = new ViessmannConnectionProvider<ViessmannPlatformClient>(auth)
{
    ClientId = config["viessmannClientId"],
    RedirectUri = "http://localhost:59926/ViessmannLogin"
};

using var client = new ViessmannPlatformClient(viessmannConnectionProvider);


app.MapGet("", () => Results.Redirect(client.GetLoginUri().ToString(), false));

app.MapGet("/ViessmannLogin", async (string code) =>
{
    var loginResult = await client.TryCompleteLogin(code);
    if (!loginResult) return Results.Problem("Login nicht erfolgreich");

    var installations = await client.GetInstallations();

    return Results.Ok(installations);
})
    .Produces<IEnumerable<Installation>>();


app.Run();
