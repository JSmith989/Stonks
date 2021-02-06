using System;
using System.Collections.Generic;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GE", "General Electric");
            stocks.Add("HD", "Home Depot");
            stocks.Add("SIRI", "Sirius XM");
            stocks.Add("KO", "Coca-Cola");
            stocks.Add("NFLX", "Netflix");
            stocks.Add("GOOG", "Google");
            stocks.Add("UNH", "United Health");
            stocks.Add("MRK", "Merck & Co.");

            
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares:  50, price: 11.40));
            purchases.Add((ticker: "CAT", shares: 25, price: 27.26));
            purchases.Add((ticker: "HD", shares: 130, price: 278.11));
            purchases.Add((ticker: "SIRI", shares: 900, price: 6.11));
            purchases.Add((ticker: "KO", shares: 100, price: 49.32));
            purchases.Add((ticker: "NFLX", shares: 70, price: 550.20));
            purchases.Add((ticker: "GOOG", shares: 5, price: 2098.00));
            purchases.Add((ticker: "UNH", shares: 90, price: 324.51));
            purchases.Add((ticker: "MRK", shares: 300, price: 75.80));

            var myStocks = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if(!myStocks.ContainsKey(stocks[purchase.ticker]))
                {
                    double amount = purchase.shares * purchase.price;
                    myStocks.Add(stocks[purchase.ticker], amount);
                }
                else
                {
                    double newAmount = myStocks[stocks[purchase.ticker]] + purchase.shares * purchase.price;
                    myStocks[stocks[purchase.ticker]] = newAmount;
                }
            }

            foreach (var item in myStocks)
            {
                Console.WriteLine($"Name: {item.Key} | Value: {item.Value}");
            }
            
        }
    }
}
