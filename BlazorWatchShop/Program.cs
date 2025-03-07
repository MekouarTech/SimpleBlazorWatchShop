using BlazorWatchShop;
using BlazorWatchShop.Models;
using BlazorWatchShop.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddTransient<ProductService>();

builder.Services.AddSingleton<BlazorWatchShop.Tests.StateManagement._05StateContainer.StateContainer>();
builder.Services.AddSingleton<BlazorWatchShop.Tests.StateManagement._06StateContainerCustomProperties.StateContainer>();
builder.Services.AddSingleton<BlazorWatchShop.Tests.StateManagement._07StateContainerBaseComponent.StateContainer>();
builder.Services.AddSingleton<BlazorWatchShop.Tests.StateManagement._08StateContainerBaseComponentDontRenderParent.StateContainer>();

await builder.Build().RunAsync();
