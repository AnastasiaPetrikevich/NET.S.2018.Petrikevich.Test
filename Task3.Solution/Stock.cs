using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Stock
    { 
        private StockInfo stocksInfo;

        public event EventHandler<StockEventArgs> Changed = delegate { };
    
        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnChanged(this, new StockEventArgs(stocksInfo.USD, stocksInfo.Euro));
        }

        private void OnChanged(object sender, StockEventArgs e) => Changed?.Invoke(sender, e);
    }
}
