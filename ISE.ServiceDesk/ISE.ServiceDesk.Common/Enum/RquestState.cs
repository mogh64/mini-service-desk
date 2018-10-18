using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISE.ServiceDesk.Common.Enum
{
    public enum RquestState
    {
        NoCreated=-2,
        InProcess = 1,
        Ended = 3,
        Revoced = 2,
        Suspended = 4
    }
}
