using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorBroker;
using MyBlazorBroker.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
Console.WriteLine($"Environment: {builder.HostEnvironment.Environment}");

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<IStocksService, StocksService>();
builder.Services.AddHttpClient<IStocksDataService, StocksDataService>();

await builder.Build().RunAsync();
