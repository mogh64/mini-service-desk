using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.ServiceBase;
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
    public interface IServiceCategoryJob : IServiceBase
    {
        [OperationContract]
        [Process(false)]
        ServiceJobDtoContainer LoadServiceCategoryJobsByJob(int serviceJobId);
        [OperationContract]
        [Process(false)]
        ServiceJobDtoContainer GetServiceCategoryJob(int serviceJobId, int serveceCatId);
        [OperationContract]
        [Process(false)]
        ServiceJobDtoContainer GetCompleteServiceCategoryJob(int serviceCatJobId);
    }
}
