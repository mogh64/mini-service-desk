using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.Framework.Common.Service.Wcf;
using ISE.ServiceDesk.Common.DTO;
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
    public interface IBaseDateService : IServiceContract
    {
         [OperationContract]
         [Process(false)]
         BaseDataContainer GetRoleList();
         [OperationContract]
         [Process(false)]
         BaseDataContainer GetObjectTypeList();
         [OperationContract]
         [Process(false)]
         PersonelDtoContainer GetPersonelList(int chartId);
         [OperationContract]
         [Process(false)]
         PersonelDtoContainer GetPersonelListByIndependentId(int independentId);
         [OperationContract]
         [Process(false)]
         VwPersonelDto GetPersonId(int perId);
         [OperationContract]
         [Process(false)]
         ResponseDto AddFilter(SdFilterCategoryDto filter);
         [OperationContract]
         [Process(false)]
         ResponseDto RemoveFilter(SdFilterCategoryDto filter);
         [OperationContract]
         [Process(false)]
         SdFilterCategoryDto GetFilter(int serviceCategoryId);
         [OperationContract]
         [Process(false)]
         BaseDataContainer GetDeviceList(int perid, int objTypeId);
         [OperationContract]
         [Process(false)]
         BaseDataContainer GetRequestStateList();
         [OperationContract]
         [Process(false)]
         DeviceDto GetDevice(int transferId);
         [OperationContract]
         [Process(false)]
         BaseDataContainer GetWorkList(int serviceCatId,bool loadParents);
         [OperationContract]
         [Process(false)]
         BaseDataContainer GetWorkListByServiceCatJob(int serviceCatJobId, bool loadParents);
         [OperationContract]
         [Process(false)]
         VwHokmDto GetPersonHokm(int perId);
    }
}
