using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Bussiness;
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
    public class ServiceCategoryJobService :ContextBoundObject, IServiceCategoryJob
    {
        ServiceCategoryJobBussiness bs = new ServiceCategoryJobBussiness();
        public Framework.Common.Service.Message.ResponseDto Delete(Framework.Common.CommonBase.BaseDto dto)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.Service.Message.ResponseDtoContainer DeleteBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            ResponseDtoContainer container = new ResponseDtoContainer();
            if (dtoList.PersistanceList.Count > 0)
            {
                bs.Delete(dtoList.PersistanceList.Cast<SdServiceCategoryJobDto>().ToList());
            }
            return container;
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
            throw new NotImplementedException();
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
            bs.Update((SdServiceCategoryJobDto)dto);
            return ResponseBuilder.GetResponse(dto);
        }

        public Framework.Common.Service.Message.ResponseDtoContainer UpdateBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public void UpdatePackage(Framework.Common.PersistantPackage.UpdatePackageBox updatePackage)
        {
          if(updatePackage.deleteBox.PersistanceList.Count>0){
              bs.Update(updatePackage.deleteBox.PersistanceList.Cast <SdServiceCategoryJobDto>().ToList());
          }
            if(updatePackage.insertBox.PersistanceList.Count>0){
                bs.Insert(updatePackage.insertBox.PersistanceList.Cast<SdServiceCategoryJobDto>().ToList());
          }
            if(updatePackage.updateBox.PersistanceList.Count>0){
                bs.Update(updatePackage.updateBox.PersistanceList.Cast<SdServiceCategoryJobDto>().ToList());
          }
        }

        public Common.DTOContainer.ServiceJobDtoContainer LoadServiceCategoryJobsByJob(int serviceJobId)
        {
            return bs.LoadServiceCategoryJobsByJob(serviceJobId);
        }


        public Common.DTOContainer.ServiceJobDtoContainer GetServiceCategoryJob(int serviceJobId, int serveceCatId)
        {
            ServiceJobDtoContainer container = new ServiceJobDtoContainer();
            var catJob = bs.GetSingle(it => it.Servicejobid == serviceJobId && it.Servicecategoryid == serveceCatId);
            container.ServiceCategoryJobs.Add(catJob);
            return container;
        }


        public ServiceJobDtoContainer GetCompleteServiceCategoryJob(int serviceCatJobId)
        {
            ServiceJobDtoContainer container = new ServiceJobDtoContainer();
            var catJob = bs.GetSingle(it => it.ServiceCatJobId == serviceCatJobId);
            ServiceJobTDataAccess serviceJobDa = new ServiceJobTDataAccess();
            ServiceCategoryTDataAccess serviceCatDa = new ServiceCategoryTDataAccess();
            var serviceCat =  serviceCatDa.GetSingle(it => it.ServiceCatId == catJob.Servicecategoryid);
            var serviceJob =  serviceJobDa.GetSingle(it => it.ServiceJobId == catJob.Servicejobid);
            catJob.ServiceCategory = serviceCat;
            catJob.ServiceJob = serviceJob;
            container.ServiceCategoryJobs.Add(catJob);           
            return container;
        }
    }
}
