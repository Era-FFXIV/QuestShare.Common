using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common
{
    public interface IRequest
    {
        string Version { get; set; }
        string Token { get; set; }
    }

    public interface IResponse
    {
        Error Error { get; set; }
        bool Success { get; set; }
    }

    public interface IAPIEndpoint<T1, T2> where T1 : IRequest where T2 : IResponse;

    public interface IBroadcast
    {
        string Message { get; set; }
    }
}
