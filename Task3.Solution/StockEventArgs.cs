namespace Task3.Solution
{
    using System;

    public class StockEventArgs : EventArgs
    {
        public StockEventArgs(int USD, int Euro)
        {
            this.USD = USD;
            this.Euro = Euro;
        }

        public int USD
        {
            get; private set;
        }

        public int Euro
        {
            get; private set;
        }
    }
}
