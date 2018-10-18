using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISE.ServiceDesk.Common.DTO;
using System.Runtime.Serialization;
namespace ISE.ServiceDesk.Common.DTOContainer
{
    public class UserRequestDtoContainer : DtoContainer
    {
        public UserRequestDtoContainer()
        {
            UserRequestList = new List<SdUserRequestDto>();
            RequestAttachmentList = new List<SdRequestAttachmentDto>();
            SdRequestWorkDtolist = new List<SdRequestWorkDto>();
            
        }
        [DataMember]
        public List<SdUserRequestDto> UserRequestList { get; set; }
        [DataMember]
        public List<SdRequestAttachmentDto> RequestAttachmentList { get; set; }
        [DataMember]
        public List<SdRequestWorkDto> SdRequestWorkDtolist { get; set; }
    }
}
