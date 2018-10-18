using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public class DeviceDto:BaseDto
    {
        public DeviceDto()
        {
            this.PrimaryKeyName = "transfer_id";
        }
        [DataMember]
        public string support_code { get; set; }
        [DataMember]
        public string assetno { get; set; }
        [DataMember]
        public string objecttype_desc { get; set; }
        [DataMember]
        public int transfer_id { get; set; }
    }
}
