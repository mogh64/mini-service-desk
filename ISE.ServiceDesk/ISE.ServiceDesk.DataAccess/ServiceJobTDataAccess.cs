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
    public class ServiceJobTDataAccess : TDataAccess<SdServiceJob, SdServiceJobDto, SdServiceJobRepository>
    {
        public ServiceJobTDataAccess()
            : base(new SdServiceJobRepository())
        {
        }
        public List<SdServiceJobDto> Load(int serviceCatId)
        {
            List<SdServiceJobDto> lst = new List<SdServiceJobDto>();
            var query = from a in this.Repository.Context.SdServiceCategoryJobs
                        join c in this.Repository.Context.SdServiceJobs on a.Servicejobid equals c.ServiceJobId
                        where a.Servicecategoryid == serviceCatId 
                        select SdServiceJobRepository.GetDto(c);
            lst.AddRange(query.ToList());
            return lst;
        }
        public List<SdServiceJobDto> Load(int serviceCatId, bool enabled)
        {
            short enableVal = 1;
            if (!enabled)
                enableVal = 0;
            List<SdServiceJobDto> lst = new List<SdServiceJobDto>();
            var query = from a in this.Repository.Context.SdServiceCategoryJobs
                        join c in this.Repository.Context.SdServiceJobs on a.Servicejobid equals c.ServiceJobId
                        where a.Servicecategoryid == serviceCatId && a.Enabled == enableVal
                        select SdServiceJobRepository.GetDto(c);
            lst.AddRange(query.ToList());
            return lst;
        }
    }
}
