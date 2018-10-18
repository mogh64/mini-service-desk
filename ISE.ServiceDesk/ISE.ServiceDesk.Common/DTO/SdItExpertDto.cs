using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdItExpertDto:BaseDto
    {
        public SdItExpertDto()
        {
            this.PrimaryKeyName = "ItExpertId";
        }
        [DataMember]
        public VwPersonelDto Personel { get; set; }
        public bool IsEnabled
        {
            get
            {
                return this.Enabled>0;
            }
            set
            {
                if (value)
                    this.Enabled = 1;
                else
                    this.Enabled = 0;
            }
        }
    }
}
