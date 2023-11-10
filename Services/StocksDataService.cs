using System.Net.Http.Json;
using MyBlazorBroker.Data;

namespace MyBlazorBroker.Services;

public class StocksDataService : IStocksDataService
{
    private readonly HttpClient _httpClient;
    private readonly IStocksService _stocksService;

    public StocksDataService(HttpClient httpClient, IStocksService stocksService)
    {
        _httpClient = httpClient;
        _stocksService = stocksService;
    }

    public async Task<List<Stock>?> GetStocksAsync()
    {
        if (_stocksService.StockNames.Count == 0)
        {
            return new List<Stock>();
        }

        return await _httpClient.GetFromJsonAsync<List<Stock>>("https://stockplaceholder.herokuapp.com/api/stocks/" + string.Join('/', _stocksService.StockNames));
    }
}