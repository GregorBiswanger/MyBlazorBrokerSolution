using Microsoft.AspNetCore.Components;
using MyBlazorBroker.Services;

namespace MyBlazorBroker.Pages;

public partial class NewStock
{
    public string StockName { get; set; } = string.Empty;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    public IStocksService StocksService { get; set; } = default!;

    public void AddStock()
    {
        StocksService.StockNames.Add(StockName);

        NavigationManager.NavigateTo("/");
    }
}