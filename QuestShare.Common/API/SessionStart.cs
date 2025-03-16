using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class SessionStart : IAPIEndpoint<SessionStart.Request, SessionStart.Response>
    {
        public class Request : IRequest
        {
            public Request() { }
            public string Version { get; set; } = null!;
            public string Token { get; set; } = null!;
            public Objects.OwnedSession Session { get; set; } = null!;
        }
        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public required bool Success { get; set; }
            public Objects.OwnedSession? Session { get; set; }
        }
    }
}
