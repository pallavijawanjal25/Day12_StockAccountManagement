using System;

namespace StockManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StockAccount stock = new StockAccount("C:\\Users\\palla\\source\\repos\\184-RFP\\StockManagement\\StockManagement\\Portfolio.json");

            Console.WriteLine(stock.welcome());
            stock.menu();
        }
    }
}