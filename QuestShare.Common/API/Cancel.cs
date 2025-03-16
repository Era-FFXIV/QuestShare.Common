using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class Cancel : IAPIEndpoint<Cancel.Request, Cancel.Response>
    {
        public class Request : IRequest
        {
            public Request() { }
            public required string Version { get; set; }
            public required string Token { get; set; }
            public required string ShareCode { get; set; }
            public required string OwnerCharacterId { get; set; }
        }

        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public required bool Success { get; set; }
        }

        public class CancelBroadcast
        {
            public CancelBroadcast() { }
            public required string ShareCode { get; set; }
        }
    }
}
