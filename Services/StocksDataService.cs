using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using MyBlazorBroker.Data;

namespace MyBlazorBroker.Services;

public class StocksDataService : IStocksDataService
{
    private readonly HttpClient _httpClient;
    private readonly IStocksService _stocksService;
    private readonly string _baseUrl;

    public StocksDataService(HttpClient httpClient, IStocksService stocksService, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _stocksService = stocksService;
        _baseUrl = configuration["StocksApi:BaseUrl"]
            ?? throw new InvalidOperationException("StocksApi:BaseUrl configuration is missing");
    }

    public async Task<List<Stock>?> GetStocksAsync()
    {
        if (_stocksService.StockNames.Count == 0)
        {
            return new List<Stock>();
        }

        return await _httpClient.GetFromJsonAsync<List<Stock>>($"{_baseUrl}/api/stocks/{string.Join('/', _stocksService.StockNames)}");
    }
}