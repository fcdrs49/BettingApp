using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.UnitTests.Mocks
{
    public static class MemoryCacheMock
    {
        public static IMemoryCache Instance
        {
            get
            {
                var services = new ServiceCollection();
                services.AddMemoryCache();
                var serviceProvider = services.BuildServiceProvider();
                return serviceProvider.GetService<IMemoryCache>();
            }
        }
    }
}
