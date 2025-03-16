using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class GroupLeave : IAPIEndpoint<GroupLeave.Request, GroupLeave.Response>
    {
        public class Request : IRequest
        {
            public Request() { }
            public string Version { get; set; } = null!;
            public string Token { get; set; } = null!;
            public required Objects.Session Session { get; set; }
        }
        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public bool Success { get; set; } = false;
            public Objects.Session? Session { get; set; }
        }

        public class GroupLeaveBroadcast
        {
            public GroupLeaveBroadcast() { }
            public required Objects.Session Session { get; set; }
        }
    }
}
