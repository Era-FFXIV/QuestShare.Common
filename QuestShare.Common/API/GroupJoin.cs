using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class GroupJoin : IAPIEndpoint<GroupJoin.Request, GroupJoin.Response>
    {
        public class Request : IRequest
        {
            public Request() { }
            public required string Token { get; set; }
            public required string Version { get; set; }
            public required Objects.ShareCode SessionInfo { get; set; }
        }

        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public bool Success { get; set; } = false;
            public Objects.Session? Session { get; set; }
        }

        public class GroupJoinBroadcast
        {
            public GroupJoinBroadcast() { }
            public required Objects.Session Session { get; set; }
        }
    }
}
