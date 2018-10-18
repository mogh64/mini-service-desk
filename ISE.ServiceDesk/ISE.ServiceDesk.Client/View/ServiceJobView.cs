using ISE.Framework.Common.PersistantPackage;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Client.View
{
    public class ServiceJobView
    {
        ServiceCategoryJobPresenter presenter = new ServiceCategoryJobPresenter();

        public bool AddServiceJob(SdServiceJobDto dto)
        {
            return presenter.InsertServiceJob(dto);            
        }
        public List<SdServiceJobDto> LoadServiceJobs(int serviceCatId)
        {
           var result = presenter.LoadServiceJobs(serviceCatId);
           return result.ServiceJobs.OrderBy(it=>it.Title).ToList();
        }
        public List<SdServiceJobDto> LoadServiceJobs(int serviceCatId,bool enabled)
        {
            var result = presenter.LoadServiceJobs(serviceCatId,enabled);
            return result.ServiceJobs.OrderBy(it => it.Title).ToList();
        }
        public bool UpdateServiceJob(SdServiceJobDto serviceJob)
        {
           return presenter.UpdateServiceJob(serviceJob);
        }
        public ServiceJobDtoContainer LoadServiceCatJobs(int serviceCatId)
        {
            var result = presenter.LoadServicCategoyeJobs(serviceCatId);
            return result;
        }
        public ServiceJobDtoContainer LoadServiceCatJobsByJob(int serviceJobId)
        {
            var result = presenter.LoadServiceCatJobsByJob(serviceJobId);
            return result;
        }
        public bool RemoveServiceCatJobs(List<SdServiceCategoryJobDto> lst)
        {
            return presenter.DeleteServiceCategoryJobs(lst);
        }
        public bool SaveServiceCatJobUpdate(UpdatePackageBox box)
        {
            return presenter.UpdateBatch(box);
        }

        public bool RemoveServiceJob(SdServiceJobDto job)
        {
            return presenter.DeleteServiceJob(job);
        }
    }
}
