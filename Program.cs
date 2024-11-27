using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

namespace HW_signalR;

/*internal class Program
{
    public static async Task Main(string[] args)
    {
        var connection = new HubConnectionBuilder().WithUrl("https://localhost:7012//currencyHub").Build();

        connection.On<string, decimal>("ReceiveCurrencyUpdate", (currencyPair, rate) =>
        {
            Console.WriteLine($"New rate for {currencyPair}: {rate}");


        });

        await connection.StartAsync();
        Console.WriteLine("Connect to server.");
        Console.ReadLine();
    }

    
}*/

