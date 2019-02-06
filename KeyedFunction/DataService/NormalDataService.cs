using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedFunction.DataService
{
    public class NormalDataService : IDataService
    {
        public string GetData()
        {
            return "This is a normal data service";
        }
    }
}
