using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorUIWorkshop;
using BlazorUIWorkshop.Exercises;
using BlazorUIWorkshop.Exercises._7_Refit;
using BlazorUIWorkshop.Exercises._8_Nswag;
using Microsoft.Extensions.DependencyInjection;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<BlazorUIWorkshop.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://donatello-9hwr4.ondigitalocean.app/") });

builder.Services.AddRefitClient<IDonatelloApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://donatello-9hwr4.ondigitalocean.app/"));

builder.Services.AddScoped<Client>();

await builder.Build().RunAsync();