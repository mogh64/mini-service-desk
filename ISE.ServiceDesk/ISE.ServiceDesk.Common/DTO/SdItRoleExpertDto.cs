using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdItRoleExpertDto:BaseDto
    {
        public SdItRoleExpertDto()
        {
            this.PrimaryKeyName = "OfficeId";
        }
        [DataMember]
        public SdItRoleDto Role { get; set; }
        [DataMember]
        public SdItExpertDto Expert { get; set; }
        [DataMember]
        public VwPersonelDto Personel { get; set; }
    }
}
