using ISE.Framework.Client.Common.ExceptionManager;
using ISE.Framework.Common.CommonBase;
using ISE.Framework.Common.PersistantPackage;
using ISE.Framework.Common.Service;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Client.Common.Presenter
{
    public class ServiceCategoryJobPresenter
    {
        private ServiceAdapter<IServiceJobs> ServiceJobServiceAdapter;
        private ServiceAdapter<IServiceCategoryJob> ServiceCatJobServiceAdapter;
        public ServiceCategoryJobPresenter()
        {
            IseBussinessExceptionManager exceptionManager = new IseBussinessExceptionManager();
            ServiceJobServiceAdapter = new ServiceAdapter<IServiceJobs>(exceptionManager);
            ServiceCatJobServiceAdapter = new ServiceAdapter<IServiceCategoryJob>(exceptionManager);

        }
        public bool InsertServiceJob(SdServiceJobDto dto)
        {
            SdServiceJobDto newJob = (SdServiceJobDto)ServiceJobServiceAdapter.Execute(it => it.Insert(dto));
            if (newJob.Response.HasException)
            {
                return false;
            }
            dto.ServiceJobId = newJob.ServiceJobId;
            return true;
        }
        public bool UpdateServiceJob(SdServiceJobDto dto)
        {
            ResponseDto response =  ServiceJobServiceAdapter.Execute(it => it.Update(dto));
            if (response.Response.HasException)
                return false;
            return true;
        }
        public bool DeleteServiceCategoryJobs(List<SdServiceCategoryJobDto> lst)
        {
            PersistanceBox box=new PersistanceBox();
            box.Add(lst.Cast<BaseDto>().ToList());
            ServiceCatJobServiceAdapter.Execute(e => e.DeleteBatch(box));
            return true;
        }
        public ServiceJobDtoContainer GetServiceJobTree()
        {
            var container = ServiceJobServiceAdapter.Execute(it => it.GetServiceJobTree());

            return container;
        }
        public ServiceJobDtoContainer LoadServiceJobs(int serviceCatId)
        {
            var container = ServiceJobServiceAdapter.Execute(it => it.LoadServiceJobs(serviceCatId));

            return container;
        }
        public ServiceJobDtoContainer LoadServiceJobs(int serviceCatId,bool enabled)
        {
            var container = ServiceJobServiceAdapter.Execute(it => it.LoadByEnabledServiceJobs(serviceCatId,enabled));

            return container;
        }
        public ServiceJobDtoContainer LoadServicCategoyeJobs(int serviceCatId)
        {
            var container = ServiceJobServiceAdapter.Execute(it => it.LoadServiceCategoryJobs(serviceCatId));

            return container;
        }
        public ServiceJobDtoContainer LoadServiceCatJobsByJob(int serviceJobId)
        {
            var container = ServiceCatJobServiceAdapter.Execute(it => it.LoadServiceCategoryJobsByJob(serviceJobId));

            return container;
        }
        public bool UpdateBatch(UpdatePackageBox box)
        {
            try
            {
                ServiceCatJobServiceAdapter.Execute(it => it.UpdatePackage(box));
                return true;
            }                
            catch (Exception ex)
            {
                return false;
            }
           
        }
        public bool Update(SdServiceCategoryJobDto catjobDto)
        {
           var response =  ServiceCatJobServiceAdapter.Execute(it => it.Update(catjobDto));
           if (response.Response.HasException)
           {
               return false;
           }
           return true;
        }
        public bool DeleteServiceJob(SdServiceJobDto job)
        {
            var response = ServiceJobServiceAdapter.Execute(it => it.Delete(job));
            return response.Response.HasException;
        }
        public SdServiceCategoryJobDto GetServiceCategoryJob(int serviceJobId, int serviceCatId)
        {
            var container =  ServiceCatJobServiceAdapter.Execute(it => it.GetServiceCategoryJob(serviceJobId, serviceCatId));
            if (container.ServiceCategoryJobs.Count > 0)
            {
                return container.ServiceCategoryJobs.FirstOrDefault();
            }
            return null;
        }
        public SdServiceCategoryJobDto GetCompleteServiceCategoryJob(int serviceCatjobId)
        {
            var container = ServiceCatJobServiceAdapter.Execute(it => it.GetCompleteServiceCategoryJob(serviceCatjobId));
            if (container.ServiceCategoryJobs.Count > 0)
            {
                return container.ServiceCategoryJobs.FirstOrDefault();
            }
            return null;
        }
    }
}
