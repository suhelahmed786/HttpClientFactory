using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Interface
{
    public interface ITypedClient
    {
        Task<string> FetchData();
    }
}
