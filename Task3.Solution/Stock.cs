namespace Task3.Solution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stock
    {
        public EventHandler<StockEventArgs> StockChange = delegate {};


        public void  Market()
        {
            Random rnd = new Random();
            var stockEventArgs = new StockEventArgs(rnd.Next(20, 40), rnd.Next(30, 50));
            Notify(stockEventArgs);
        }


        protected virtual void  Notify(StockEventArgs stockEventArgs)
        {
            StockChange(this, stockEventArgs);
        }
    }
}
