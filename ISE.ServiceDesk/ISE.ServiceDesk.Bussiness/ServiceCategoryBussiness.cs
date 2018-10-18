using ISE.Framework.Server.Core.BussinessBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.DataAccess;
using ISE.ServiceDesk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Bussiness
{
    public class ServiceCategoryBussiness : BussinessBase<SdServiceCategory, SdServiceCategoryDto>
    {
        public ServiceCategoryBussiness()
        {
            this.dataAccess = new ServiceCategoryTDataAccess();
        }
    }
}
