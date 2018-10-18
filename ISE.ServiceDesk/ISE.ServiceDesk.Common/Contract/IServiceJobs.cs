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
    public interface IServiceJobs : IServiceBase
    {
        [OperationContract]
        [Process(false)]
        ServiceJobDtoContainer GetServiceJobTree();
        [OperationContract]
        [Process(false)]
        ServiceJobDtoContainer LoadServiceJobs(int serviceCategoryId);
        [OperationContract]
        [Process(false)]
        ServiceJobDtoContainer LoadServiceCategoryJobs(int serviceCategoryId);
        [OperationContract]
        [Process(false)]
        Common.DTOContainer.ServiceJobDtoContainer LoadByEnabledServiceJobs(int serviceCategoryId, bool enabled);
    }
}
