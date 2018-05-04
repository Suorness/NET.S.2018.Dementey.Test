namespace Task3.Solution
{
    using System;

    public class Broker
    {
        public Broker(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Update(object sender, StockEventArgs e)
        {
            if (e.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, e.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, e.USD);
        }
    }
}
