using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using MyBlazorBroker.Data;
using MyBlazorBroker.Services;

namespace MyBlazorBroker.Pages;

public partial class Index : IDisposable
{
    public List<Stock>? Stocks { get; set; } = new();

    [Inject]
    public IStocksDataService StocksDataService { get; set; } = default!;

    [Inject]
    public IStocksService StocksService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        await GetStocksAsync();
        StocksService.RefreshStocks += GetStocksAsync;
    }

    private async Task GetStocksAsync()
    {
        Stocks = await StocksDataService.GetStocksAsync();
        StateHasChanged();
    }

    //public string GetStockChangeColor(Stock stock)
    //{
    //    return stock.Change < 0 ? "red" : "green";
    //}

    public string GetStockChangeColor(Stock stock)
    {
        return new CssBuilder().AddClass("green", double.Parse(stock.Change) > 0)
            .AddClass("red", double.Parse(stock.Change) < 0)
            .Build();
    }

    public void Dispose()
    {
        StocksService.RefreshStocks -= GetStocksAsync;
    }
}