using ISE.Framework.Client.Common.ExceptionManager;
using ISE.Framework.Common.Service;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISE.ServiceDesk.Client.Common.Presenter
{
    public class OfficePresenter
    {
         private ServiceAdapter<IOfficeService> OfficeServiceAdapter;
         public OfficePresenter()
        {
            IseBussinessExceptionManager exceptionManager = new IseBussinessExceptionManager();
            OfficeServiceAdapter = new ServiceAdapter<IOfficeService>(exceptionManager);

        }
         public OfficeDtoContainer GetOfficeDetails(int officeId)
         {
             var container =  OfficeServiceAdapter.Execute(it => it.GetOfficeDetails(officeId));
             if (container.Response.HasException)
             {
                 return null;
             }
             return container;
         }
         public bool AddExpert(SdItExpertDto dto)
         {
             var response = OfficeServiceAdapter.Execute(it => it.AddExpert(dto));
             if (response.Response.HasException)
             {
                 return false;
             }
             dto.ItExpertId = response.ItExpertId;
             return true;
         }
         public List<SdItExpertDto> GetExpertList()
         {
             var response = OfficeServiceAdapter.Execute(it => it.GetExpertList());
             if (response.Response.HasException)
             {
                 return null;
             }
             
             return response.ExpertList;
         }
        public bool UpdateExpert(SdItExpertDto expert)
        {
            var response = OfficeServiceAdapter.Execute(it => it.UpdateExpert(expert));
            if (response.Response.HasException)
            {
                return false;
            }

            return true;
        }
        public bool RemoveExpert(SdItExpertDto expert)
        {
            var response = OfficeServiceAdapter.Execute(it => it.RemoveExpert(expert));
            if (response.Response.HasException)
            {
                return false;
            }

            return true;
        }
    }
}
