using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class Update : IAPIEndpoint<Update.Request, Update.Response>
    {
        public class Request : IRequest
        {
            public Request() { }
            public required string Version { get; set; }
            public required string Token { get; set; }
            public required Objects.OwnedSession Session { get; set; }
            public List<string> PartyMembers { get; set; } = [];
            public bool IsQuestUpdate { get; set; } = false;
        }

        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public bool Success { get; set; } = false;
        }

        public class UpdateBroadcast
        {
            public UpdateBroadcast() { }
            public required Objects.Session Session { get; set; }
        }
    }
}
