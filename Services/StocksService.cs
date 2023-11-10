namespace MyBlazorBroker.Services
{
    public class StocksService : IStocksService
    {
        public event Func<Task>? RefreshStocks;

        public List<string> StockNames { get; set; } = new();

        public void InvokeRefreshStocks()
        {
            RefreshStocks?.Invoke();
        }
    }
}
