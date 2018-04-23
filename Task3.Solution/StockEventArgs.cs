using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class StockEventArgs
    {
        private int euro;
        private int usd;

        public StockEventArgs(int euro, int usd)
        {
            this.euro = euro;
            this.usd = usd;
        }

        public int Euro => euro;
        public int USD => usd;
    }
}
