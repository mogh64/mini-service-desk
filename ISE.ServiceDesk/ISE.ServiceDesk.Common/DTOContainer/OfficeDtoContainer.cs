using ISE.Framework.Common.CommonBase;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ISE.ServiceDesk.Common.DTOContainer
{
    public class OfficeDtoContainer : DtoContainer
    {
        public OfficeDtoContainer()
        {
            ExpertList = new List<SdItExpertDto>();
            RoleList = new List<SdItRoleDto>();
            RoleExperts = new List<SdItRoleExpertDto>();
            Experts = new List<SdItExpertDto>();
        }
        [DataMember]
        public List<SdItExpertDto> ExpertList { get; set; }
        [DataMember]
        public List<SdItRoleDto> RoleList { get; set; }
         [DataMember]
        public List<SdItRoleExpertDto> RoleExperts { get; set; }
         [DataMember]
         public List<SdItExpertDto> Experts { get; set; }
    }
}
