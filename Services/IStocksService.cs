namespace MyBlazorBroker.Services;

public interface IStocksService
{
    event Func<Task> RefreshStocks;
    List<string> StockNames { get; set; }
    void InvokeRefreshStocks();
}