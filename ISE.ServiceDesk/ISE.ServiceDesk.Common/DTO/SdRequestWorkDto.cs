using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdRequestWorkDto:BaseDto
    {
        public SdRequestWorkDto()
        {
            this.PrimaryKeyName = "RequestWorkId";
            
        }
        [DataMember]
        public VwPersonelDto User { get; set; }
        [DataMember]
        public SdWorkDto Work { get; set; }
    }
}
