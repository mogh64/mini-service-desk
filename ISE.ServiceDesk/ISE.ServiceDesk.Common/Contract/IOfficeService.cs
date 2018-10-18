using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.Framework.Common.Service.Wcf;
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
    public interface IOfficeService : IServiceContract
    {
        [OperationContract]
        [Process(false)]
        OfficeDtoContainer GetOfficeDetails(int officeId);
        [OperationContract]
        [Process(false)]
        SdItExpertDto AddExpert(SdItExpertDto expert);
        [OperationContract]
        [Process(false)]
        OfficeDtoContainer GetExpertList();
        [OperationContract]
        [Process(false)]
        ResponseDto UpdateExpert(SdItExpertDto expert);
        [OperationContract]
        [Process(false)]
        ResponseDto RemoveExpert(SdItExpertDto expert);

    }
}
