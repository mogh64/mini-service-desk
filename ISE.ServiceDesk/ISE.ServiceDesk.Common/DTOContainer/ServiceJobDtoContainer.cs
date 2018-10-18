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
    public class ServiceJobDtoContainer : DtoContainer
    {
        public ServiceJobDtoContainer()
        {
            ServiceCategoryJobs = new List<SdServiceCategoryJobDto>();
            ServiceCategoryDtos = new List<SdServiceCategoryDto>();
            ServiceJobs = new List<SdServiceJobDto>();
        }
        [DataMember]
        public List<SdServiceCategoryJobDto> ServiceCategoryJobs { get; set; }
        [DataMember]
        public List<SdServiceCategoryDto> ServiceCategoryDtos { get; set; }
        [DataMember]
        public List<SdServiceJobDto> ServiceJobs { get; set; }
    }
}
