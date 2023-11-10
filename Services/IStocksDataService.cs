using MyBlazorBroker.Data;

namespace MyBlazorBroker.Services;

public interface IStocksDataService
{
    Task<List<Stock>?> GetStocksAsync();
}