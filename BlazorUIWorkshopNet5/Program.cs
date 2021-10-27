using System;
using System.Net.Http;
using BlazorUIWorkshop.Exercises;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorUIWorkshopNet5;
using BlazorUIWorkshopNet5.Exercises._7_Refit;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://donatello-9hwr4.ondigitalocean.app/") });

builder.Services.AddRefitClient<IDonatelloApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://donatello-9hwr4.ondigitalocean.app/"));

builder.Services.AddScoped<Client>();
await builder.Build().RunAsync();
