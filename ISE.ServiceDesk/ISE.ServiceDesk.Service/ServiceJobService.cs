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
    public class ServiceJobService : ContextBoundObject, IServiceJobs
    {
        ServiceJobBussiness bs = new ServiceJobBussiness();
        public Common.DTOContainer.ServiceJobDtoContainer GetServiceJobTree()
        {
            
            return bs.GetServiceJobTree();
        }

        public Framework.Common.Service.Message.ResponseDto Delete(Framework.Common.CommonBase.BaseDto dto)
        {
             bs.Delete((SdServiceJobDto)dto);
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
             bs.Insert((SdServiceJobDto)dto);
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
             bs.Update((SdServiceJobDto)dto);
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


        public Common.DTOContainer.ServiceJobDtoContainer LoadServiceJobs(int serviceCategoryId)
        {
            return bs.LoadServiceJobs(serviceCategoryId);
        }

        public Common.DTOContainer.ServiceJobDtoContainer LoadByEnabledServiceJobs(int serviceCategoryId,bool enabled)
        {
            return bs.LoadServiceJobs(serviceCategoryId, enabled);
        }
        public Common.DTOContainer.ServiceJobDtoContainer LoadServiceCategoryJobs(int serviceCategoryId)
        {
            return bs.LoadServiveCategoryJobs(serviceCategoryId);
        }
    }
}
