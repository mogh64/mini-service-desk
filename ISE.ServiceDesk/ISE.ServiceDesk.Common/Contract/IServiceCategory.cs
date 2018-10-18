using ISE.Framework.Common.Service.ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.Contract
{
    [ServiceContract(Namespace = "http://www.iseikco.com/ServiceDesk")]
    public interface IServiceCategory : IServiceBase
    {
    }
}
