using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdItRoleDto:BaseDto
    {
        public SdItRoleDto()
        {
            this.PrimaryKeyName = "RoleId";
        }
    }
}
