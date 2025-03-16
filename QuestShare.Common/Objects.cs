using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common
{
    public abstract class Objects
    {
        public record ShareCode
        {
            public required string Code { get; set; }
            public required string CharacterId { get; set; }
        }

        public record Session
        {
            public required string ShareCode { get; set; }
            public required string OwnerCharacterId { get; set; }
            public int ActiveQuestId { get; set; }
            public byte ActiveQuestStep { get; set; }
            public bool IsValid { get; set; } = true;
        }

        public record OwnedSession
        {
            public required Session Session { get; set; }
            public string ShareCode => Session.ShareCode;

            [JsonIgnore]
            public string OwnerCharacterId => Session.OwnerCharacterId;

            [JsonIgnore]
            public int ActiveQuestId => Session.ActiveQuestId;

            [JsonIgnore]
            public byte ActiveQuestStep => Session.ActiveQuestStep;
            public required bool AllowJoins { get; set; }
            public required bool SkipPartyCheck { get; set; }
            public required bool IsActive { get; set; }
        }
    }
}
