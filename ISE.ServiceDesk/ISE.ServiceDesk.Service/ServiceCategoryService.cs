using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Bussiness;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
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
    public class ServiceCategoryService :ContextBoundObject, IServiceCategory
    {
        ServiceCategoryBussiness serviceCategoryBussiness = new ServiceCategoryBussiness();
        public Framework.Common.Service.Message.ResponseDto Delete(Framework.Common.CommonBase.BaseDto dto)
        {
            serviceCategoryBussiness.Delete((SdServiceCategoryDto)dto);
            return ResponseBuilder.GetResponse(dto);
        }
       
        public Framework.Common.Service.Message.ResponseDtoContainer DeleteBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.DtoContainer GetAll()
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.DtoContainer GetAllByCondition(string predicate)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.BaseDto GetSingle(long id)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.BaseDto Insert(Framework.Common.CommonBase.BaseDto dto)
        {
            serviceCategoryBussiness.Insert((SdServiceCategoryDto)dto);
            return dto;
        }

        public Framework.Common.CommonBase.DtoContainer InsertBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.DtoContainer PagedResultGetAll(int page, int pageCount)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.DtoContainer PagedResultGetAllByCondition(string predicate, int page, int pageCount)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.Service.Message.ResponseDto Update(Framework.Common.CommonBase.BaseDto dto)
        {
            serviceCategoryBussiness.Update((SdServiceCategoryDto)dto);
            return ResponseBuilder.GetResponse(dto);
        }

        public Framework.Common.Service.Message.ResponseDtoContainer UpdateBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public void UpdatePackage(Framework.Common.PersistantPackage.UpdatePackageBox updatePackage)
        {
            throw new NotImplementedException();
        }
    }
}
