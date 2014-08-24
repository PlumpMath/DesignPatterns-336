using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SQLServerSource : IDBSource
    {
        public string Save(string data)
        {
            return "Saved in the SQLServer Source";
        }
    }
}
