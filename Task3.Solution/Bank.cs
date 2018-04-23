﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Bank
    { 

        public string Name { get; set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        public void Subscribe(Stock stock) => stock.Changed += Update;
        public void Unsubscribe(Stock stock) => stock.Changed -= Update;


        public void Update(object info, StockEventArgs sInfo)
        {
            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }
    }
}
