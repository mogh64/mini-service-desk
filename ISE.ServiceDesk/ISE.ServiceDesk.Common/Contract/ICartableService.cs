using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.Framework.Common.Service.Wcf;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ISE.ServiceDesk.Common.Contract
{
     [ServiceContract(Namespace = "http://www.iseikco.com/ServiceDesk")]
    public interface ICartableService : IServiceContract
    {
         [OperationContract]
         [Process(false)]
         ExternalResultDto GetRecieverExpert(List<int> perIdList);
         [OperationContract]
         [Process(false)]
         ResponseDto AssignExpert(int requestId, int isHead, int expertPerId, int assignType, DateTime assignDate);
         [OperationContract]
         [Process(false)]
         Framework.Common.Service.Message.ResponseDto SetRequestCurrentCartableUser(int requestId, int perId);
    }
}
