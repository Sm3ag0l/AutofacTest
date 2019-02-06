using KeyedFunction.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeyedFunction.DataService
{
    public class PremiumDataService : IDataService
    {
        public string GetData()
        {
            return "this is a premium data service";
        }
    }
}
