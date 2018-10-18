using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.ServiceDesk.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Service
{
    [Intercept]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, UseSynchronizationContext = false, AddressFilterMode = AddressFilterMode.Any)]
    public class OfficeService : ContextBoundObject, IOfficeService
    {
        public Common.DTOContainer.OfficeDtoContainer GetOfficeDetails(int officeId)
        {
            OfficeTDataAccess officeDa = new OfficeTDataAccess();
            var container =  officeDa.GetDetail(officeId);
            return container;
        }


        public SdItExpertDto AddExpert(Common.DTO.SdItExpertDto expert)
        {
            ExpertTDataAccess exDa = new ExpertTDataAccess();
            exDa.Insert(expert);
            return expert;
        }


        public Common.DTOContainer.OfficeDtoContainer GetExpertList()
        {
            OfficeDtoContainer container = new OfficeDtoContainer();
            ExpertTDataAccess exDa = new ExpertTDataAccess();
            var experts = exDa.GetAll();
            PersonelTDataAccess pda = new PersonelTDataAccess();
            foreach (var item in experts)
            {
               item.Personel =  pda.GetSingle(it => it.PerId == item.Userid);
            }
            container.ExpertList.AddRange(experts);
            return container;
        }


        public Framework.Common.Service.Message.ResponseDto UpdateExpert(SdItExpertDto expert)
        {
            ExpertTDataAccess exDa = new ExpertTDataAccess();
            exDa.Update(expert);
            return ResponseBuilder.GetResponse(expert); 
        }
        public Framework.Common.Service.Message.ResponseDto RemoveExpert(SdItExpertDto expert)
        {
            ExpertTDataAccess exDa = new ExpertTDataAccess();
            exDa.Delete(expert);
            return ResponseBuilder.GetResponse(expert);
        }
    }
}
