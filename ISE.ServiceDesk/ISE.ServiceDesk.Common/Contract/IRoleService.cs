using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.Framework.Common.Service.ServiceBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ISE.ServiceDesk.Common.Contract
{
    [ServiceContract(Namespace = "http://www.iseikco.com/ServiceDesk")]
    public interface IRoleService : IServiceBase
    {
        [OperationContract]
        [Process(false)]
        OfficeDtoContainer GetRoleExperts(int roleId);
        [OperationContract]
        [Process(false)]
        SdItRoleExpertDto AddRoleExpert(SdItRoleExpertDto roleExpert);
        [OperationContract]
        [Process(false)]
        ResponseDto RemoveRoleExpert(SdItRoleExpertDto roleExpert);
        [OperationContract]
        [Process(false)]
        ResponseDto UpdateRoleExpert(SdItRoleExpertDto roleExpert);
       
        
    }
}
