using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestShare.Common
{
    public enum Error
    {
        None,
        InvalidToken,
        InvalidSession,
        InvalidVersion,
        InvalidQuests,
        JoinRequestFailed,
        Unauthorized,
        UnknownError,
        InternalServerError,
        InvalidNotifyType,
        InvalidParty,
        InvalidMember,
        InvalidQuest,
        BannedTooManyBadRequests,
        AlreadyRegistered,
        AlreadyJoined,
        ServerMaintenance,
    }
}
