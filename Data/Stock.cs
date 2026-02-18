namespace MyBlazorBroker.Data;

public class Stock
{
    public string Symbol { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Change { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string LastTradeDate { get; set; } = string.Empty;
    public string LastTradePriceOnly { get; set; } = string.Empty;
    public string ChangeinPercent { get; set; } = string.Empty;
    public string LastTradeTime { get; set; } = string.Empty;
}