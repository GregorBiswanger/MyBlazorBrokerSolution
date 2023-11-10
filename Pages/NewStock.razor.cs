using Microsoft.AspNetCore.Components;
using MyBlazorBroker.Services;

namespace MyBlazorBroker.Pages;

public partial class NewStock
{
    public string StockName { get; set; } = string.Empty;

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IStocksService StocksService { get; set; }

    public void AddStock()
    {
        StocksService.StockNames.Add(StockName);

        NavigationManager.NavigateTo("/");
    }
}