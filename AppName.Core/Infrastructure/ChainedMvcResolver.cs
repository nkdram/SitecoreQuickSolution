using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AppName.Core.Infrastructure
{
    public class ChainedMvcResolver : IDependencyResolver
    {
        IDependencyResolver _fallbackResolver;
        IDependencyResolver _newResolver;

        public ChainedMvcResolver(IDependencyResolver newResolver, IDependencyResolver fallbackResolver)
        {
            _newResolver = newResolver;
            _fallbackResolver = fallbackResolver;
        }

        public object GetService(Type serviceType)
        {
            object result = null;

            result = _newResolver.GetService(serviceType);

            if (result != null)
            {
                return result;
            }

            return _fallbackResolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            IEnumerable<object> results = null;

            results = _newResolver.GetServices(serviceType);

            if (results != null)
            {
                return results;
            }

            return _fallbackResolver.GetServices(serviceType);
        }
    }
}
