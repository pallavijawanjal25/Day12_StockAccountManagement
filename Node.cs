using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class Node
    {
        public string symbol;
        public double units;
        public double price;
        public string type;
        public string date;
        public Node next;

        public Node(string symbol, double units, double price, string type, string date)
        {
            this.symbol = symbol;
            this.units = units;
            this.price = price;
            this.type = type;
            this.date = date;
            next = null;
        }
    }
}
