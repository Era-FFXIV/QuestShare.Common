using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class Register : IAPIEndpoint<Register.Request, Register.Response>
    {
        public class Request : IRequest
        {
            public Request() { }
            public required string Token { get; set; }
            public required string Version { get; set; }
        }

        public class Response : IResponse
        {
            public Response() { }
            public Error Error { get; set; } = Error.None;
            public bool Success { get; set; } = false;
            public required string ShareCode { get; set; }
        }
    }
}
