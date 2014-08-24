using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class JSONSource:IDBSource
    {
        public string Save(string data)
        {
            return "Saved in the JSON File";
        }
    }
}
