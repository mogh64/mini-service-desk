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
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.Contract
{
      [ServiceContract(Namespace = "http://www.iseikco.com/ServiceDesk")]
    public interface IRequestService : IServiceBase
    {
          [OperationContract]
          [Process(false)]
          UserRequestDtoContainer GetRequestAttachment(int requestId);
          [OperationContract]
          [Process(false)]
          SdRequestWorkDto AddRequestWork(SdRequestWorkDto work);
          [OperationContract]
          [Process(false)]
          UserRequestDtoContainer GetRequestWorkList(int requestId);

    }
}
