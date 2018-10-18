using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdServiceCategoryDto:BaseDto
    {
        public SdServiceCategoryDto()
        {
            this.PrimaryKeyName = "ServiceCatId";
        }
        [DataMember]
        public SdFilterCategoryDto Filter { get; set; }
        public bool HasMenus
        {
            get
            {
                return Hasmenu > 0 ? true : false;
            }
            set
            {
                Hasmenu = (short)(value ? 1 : 0);
            }
        }
        public bool HasDevices
        {
            get
            {
                return Hasdevice > 0 ? true : false;
            }
            set
            {
                Hasdevice = (short)(value ? 1 : 0);
            }
        }
    }
}
