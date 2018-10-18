using ISE.Framework.Client.Common.ExceptionManager;
using ISE.Framework.Common.Service;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Client.Common.Presenter
{
    public class BaseDataServicePresenter
    {
        private ServiceAdapter<IBaseDateService> BaseDataServiceAdapter;
         public BaseDataServicePresenter()
        {
            IseBussinessExceptionManager exceptionManager = new IseBussinessExceptionManager();
            BaseDataServiceAdapter = new ServiceAdapter<IBaseDateService>(exceptionManager);

        }
         public List<SdItRoleDto> GetRoleList()
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetRoleList());
             return result.RoleDtoList;
         }
         public List<VwPersonelDto> getPersonelList(int chartId)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetPersonelList(chartId));
             return result.PersonelDtoList;
         }
         public List<VwPersonelDto> getPersonelListByInd(int independentId)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetPersonelListByIndependentId(independentId));
             return result.PersonelDtoList;
         }
         public VwPersonelDto getPersonel(int perId)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetPersonId(perId));
             if (result.Response.HasException)
             {
                 return null;
             }
             return result;
         }
         public List<ObjecttypeDto> GetObjectTypeList()
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetObjectTypeList());
             if (result.Response.HasException)
             {
                 return null;
             }
             return result.ObjecttypeDtoList;
         }
         public bool AddFilter(SdFilterCategoryDto filter)
         {

             var result = BaseDataServiceAdapter.Execute(it => it.AddFilter(filter));
             if (result.Response.HasException)
             {
                 return false;
             }
             return true;
         }
         public bool RemoveFilter(SdFilterCategoryDto filter)
         {

             var result = BaseDataServiceAdapter.Execute(it => it.RemoveFilter(filter));
             if (result.Response.HasException)
             {
                 return false;
             }
             return true;
         }
         public SdFilterCategoryDto GetFilter(int serviceCatId)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetFilter(serviceCatId));
             if (result==null || result.Response.HasException)
             {
                 return null;
             }
             return result;
         }
         public List<DeviceDto> GetDeviceList(int perId, int objTypeId)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetDeviceList(perId,objTypeId));
             if ( result.Response.HasException)
             {
                 return null;
             }
             return result.DeviceList;
         }
         public DeviceDto GetDevice(int transferId)
         {
             if (transferId > 0)
             {
                 var result = BaseDataServiceAdapter.Execute(it => it.GetDevice(transferId));
                 if (result.Response.HasException)
                 {
                     return null;
                 }
                 return result;
             }
             return null;
         } 
         public List<SdRequestStateDto> GetStateList()
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetRequestStateList());
             if (result.Response.HasException)
             {
                 return null;
             }
             return result.RequestStateList;
         }
         public List<SdWorkDto> GetWorkList(int serviceCatId,bool loadParents)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetWorkList(serviceCatId,loadParents));
             if (result.Response.HasException)
             {
                 return null;
             }
             return result.WorkList;
         }
         public List<SdWorkDto> GetWorkListByServiceCatJob(int serviceCatJobId, bool loadParents)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetWorkListByServiceCatJob(serviceCatJobId, loadParents));
             if (result.Response.HasException)
             {
                 return null;
             }
             return result.WorkList;
         }
         public VwHokmDto GetHokm(int perId)
         {
             var result = BaseDataServiceAdapter.Execute(it => it.GetPersonHokm(perId));
             if (result.Response.HasException)
             {
                 return null;
             }
             return result;
         }
    }
}
