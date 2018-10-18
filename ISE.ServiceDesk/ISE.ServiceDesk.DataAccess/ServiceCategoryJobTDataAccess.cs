using ISE.Framework.Server.Core.DataAccessBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.DataAccess
{
    public class ServiceCategoryJobTDataAccess : TDataAccess<SdServiceCategoryJob, SdServiceCategoryJobDto, SdServiceCategoryJobRepository>
    {
        public ServiceCategoryJobTDataAccess()
            : base(new SdServiceCategoryJobRepository())
        {
        }
        public SdServiceCategoryJobDto GetServiceCatJob(int id)
        {
            ServiceCategoryTDataAccess scatDa = new ServiceCategoryTDataAccess();
            ServiceJobTDataAccess sJobDa = new ServiceJobTDataAccess();

            var scatJob =  this.GetSingle(it => it.ServiceCatJobId == id);
            if (scatJob != null)
            {
                scatJob.ServiceCategory = scatDa.GetSingle(it => it.ServiceCatId == scatJob.Servicecategoryid);
                scatJob.ServiceJob = sJobDa.GetSingle(it => it.ServiceJobId == scatJob.Servicejobid);
            }
            
            return scatJob;
        }
    }
}
