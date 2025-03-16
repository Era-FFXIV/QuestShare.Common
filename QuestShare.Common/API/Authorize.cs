using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class Authorize : IAPIEndpoint<Authorize.Request, Authorize.Response>
    {
        public class Request : IRequest
        {
            public Request() { }
            public string Version { get; set; } = null!;
            public string Token { get; set; } = null!;
            public List<Objects.ShareCode> ShareCodes { get; set; } = [];
        }

        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public bool Success { get; set; }
            public string Token { get; set; } = null!;
            public List<Objects.Session> Sessions { get; set; } = [];
            public Objects.OwnedSession? OwnedSession { get; set; }
        }
    }
}
