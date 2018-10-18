using ISE.Framework.Common.CommonBase;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTOContainer
{
    public class BaseDataContainer : DtoContainer
    {
        public BaseDataContainer()
        {
            RoleDtoList = new List<SdItRoleDto>();
            ObjecttypeDtoList = new List<ObjecttypeDto>();
            DeviceList = new List<DeviceDto>();
            RequestStateList = new List<SdRequestStateDto>();
        }
        [DataMember]
        public List<SdItRoleDto> RoleDtoList { get; set; }
        [DataMember]
        public List<ObjecttypeDto> ObjecttypeDtoList { get; set; }
        [DataMember]
        public List<DeviceDto> DeviceList { get; set; }
        [DataMember]
        public List<SdRequestStateDto> RequestStateList { get; set; }
        [DataMember]
        public List<SdWorkDto> WorkList { get; set; }
        
    }
}
