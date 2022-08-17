using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class Stock
    {


        public string _name;
        public string _symbol;
        public double _noOfShares;
        public double _sharePrice;

        public Stock(string name, string symbol, double noOfShares, double sharePrice)
        {
            this._name = name;
            this._symbol = symbol;
            this._noOfShares = noOfShares;
            this._sharePrice = sharePrice;
        }
    }
}
