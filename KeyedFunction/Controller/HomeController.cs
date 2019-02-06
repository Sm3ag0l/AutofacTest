using KeyedFunction.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedFunction.Controller
{
    public class HomeController : IHomeController
    {
        private readonly Func<RoleName, IDataService> _dataServiceFactory;

        public HomeController(Func<RoleName, IDataService> dataServiceFactory)
        {
            _dataServiceFactory = dataServiceFactory;
        }

        public void UseService(RoleName roleName)
        {
            var Service = _dataServiceFactory(roleName);

            Console.WriteLine(Service.GetData());
        }
    }
}
