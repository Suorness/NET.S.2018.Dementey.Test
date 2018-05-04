namespace Task3.Console
{
    using System;
    using Task3.Solution;

    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            var bank1 = new Bank("Gold Bank");
            var bank2 = new Bank("Silver Bank");
            var broker = new Broker("Best broker");

            stock.StockChange += bank1.Update;
            stock.StockChange += bank2.Update;
            stock.StockChange += broker.Update;

            stock.Market();

            stock.StockChange -= bank1.Update;

            stock.Market();

            stock.StockChange -= bank2.Update;

            stock.Market();

            stock.StockChange -= broker.Update;

            stock.Market();

            Console.ReadLine();



        }
    }
}
