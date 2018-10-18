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
    public class RequestAssignedExpertTDataAccess : TDataAccess<SdRequestAssignedExpert, SdRequestAssignedExpertDto, SdRequestAssignedExpertRepository>
    {
        public RequestAssignedExpertTDataAccess()
            : base(new SdRequestAssignedExpertRepository())
        {
        }
        public SdRequestAssignedExpertDto GetLastRequest(int perId)
        {
            var work =  this.Repository.Context.SdRequestAssignedExperts.Where(it => it.ExpertPerId == perId).OrderByDescending(it => it.Assigndate).Take(1).FirstOrDefault();
            if(work!=null){
                var workDto = SdRequestAssignedExpertRepository.GetDto(work);
                return workDto;
            }
            return null;
        }
    }
}
