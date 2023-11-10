using Microsoft.AspNetCore.Components;
using MyBlazorBroker.Services;

namespace MyBlazorBroker.Shared
{
    public partial class MainLayout
    {
        [Inject]
        public IStocksService StocksService { get; set; }

        public void InvokeRefreshStocks()
        {
            StocksService.InvokeRefreshStocks();
        }
    }
}
