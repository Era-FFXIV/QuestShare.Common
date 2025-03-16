using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
#pragma warning disable CS0618 // Type or member is obsolete
    public sealed class AuthRequest : IAPIEndpoint<AuthRequest.Request, AuthRequest.Response>
#pragma warning restore CS0618 // Type or member is obsolete
    {
        [Obsolete("This constructor is for serialization only. Do not use it in code.")]
        public class Request : IRequest
        {
            public Request() { }
            public required string Version { get; set; }
            public required string Token { get; set; }
        }
        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public bool Success { get; set; } = true;
        }
    }
}
