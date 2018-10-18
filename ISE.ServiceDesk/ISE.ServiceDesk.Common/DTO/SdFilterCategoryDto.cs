using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdFilterCategoryDto:BaseDto
    {
        public SdFilterCategoryDto()
        {
            this.PrimaryKeyName = "FilterId";
        }
        [DataMember]
        public ObjecttypeDto ObjectType { get; set; }
    }
}
