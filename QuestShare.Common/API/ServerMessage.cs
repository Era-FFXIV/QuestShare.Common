using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common.API
{
    public sealed class ServerMessage
    {
        public sealed class Broadcast
        {
            public Broadcast() { }
            public ServerMessageType MessageType { get; set; }
            public string Message { get; set; } = null!;
        }
    }

    public enum ServerMessageType
    {
        ServerShutdown,
        ServerRestart,
        ServerUpdate,
        UserNotInPartyViolation,
    }
}
