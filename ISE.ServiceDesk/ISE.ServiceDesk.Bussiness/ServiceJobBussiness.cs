using ISE.Framework.Server.Core.BussinessBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.ServiceDesk.DataAccess;
using ISE.ServiceDesk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Bussiness
{
    public class ServiceJobBussiness : BussinessBase<SdServiceJob, SdServiceJobDto>
    {
        public ServiceJobBussiness()
        {
            this.dataAccess = new ServiceJobTDataAccess();
        }
        public Common.DTOContainer.ServiceJobDtoContainer GetServiceJobTree()
        {
            PersonelTDataAccess pers = new PersonelTDataAccess();
          
            ServiceJobDtoContainer container = new ServiceJobDtoContainer();
            ServiceCategoryTDataAccess serviceCatDa = new ServiceCategoryTDataAccess();
            ServiceCategoryJobTDataAccess serviceCategoryJobDa = new ServiceCategoryJobTDataAccess();
           

            var serviceCategoris=  serviceCatDa.GetAll();
            var serviceCatJobs = serviceCategoryJobDa.GetAll();
            var serviceJobs = this.dataAccess.GetAll();

            container.ServiceCategoryDtos.AddRange(serviceCategoris);
            container.ServiceCategoryJobs.AddRange(serviceCatJobs);
            container.ServiceJobs.AddRange(serviceJobs);

            return container;
        }
        public Common.DTOContainer.ServiceJobDtoContainer LoadServiceJobs(int serviceCategoryId)
        {
            ServiceJobDtoContainer container = new ServiceJobDtoContainer();
            if (serviceCategoryId > 0)
            {
                var lst = ((ServiceJobTDataAccess)this.dataAccess).Load(serviceCategoryId);
                container.ServiceJobs.AddRange(lst);
            }
            else
            {
                var lst =  this.GetAll();
                container.ServiceJobs.AddRange(lst);
            }
            
            return container;
        }
        public Common.DTOContainer.ServiceJobDtoContainer LoadServiceJobs(int serviceCategoryId,bool enabled)
        {
            ServiceJobDtoContainer container = new ServiceJobDtoContainer();
            if (serviceCategoryId > 0)
            {
                var lst = ((ServiceJobTDataAccess)this.dataAccess).Load(serviceCategoryId,enabled);
                container.ServiceJobs.AddRange(lst);
            }
            else
            {
                var lst = this.GetAll();
                container.ServiceJobs.AddRange(lst);
            }

            return container;
        }
        public Common.DTOContainer.ServiceJobDtoContainer LoadServiveCategoryJobs(int serviceCategoryId)
        {
            ServiceJobDtoContainer container = new ServiceJobDtoContainer();
            ServiceCategoryJobTDataAccess serviceCategoryJobDa = new ServiceCategoryJobTDataAccess();
            var serviceCatJobs =  serviceCategoryJobDa.GetAll(it => it.Servicecategoryid == serviceCategoryId);
            var serviceJobs = LoadServiceJobs(-1).ServiceJobs;
            foreach (var item in serviceJobs)
            {
                var serviceCat = serviceCatJobs.FirstOrDefault(it => it.Servicejobid == item.ServiceJobId);
                if (serviceCat != null)
                {
                    serviceCat.ServiceJob = item;
                    container.ServiceCategoryJobs.Add(serviceCat);
                }
                else
                {
                    container.ServiceJobs.Add(item);
                }
                
            }

            return container;
        }
        public override void Delete(SdServiceJobDto entityDto)
        {
            ServiceCategoryJobBussiness bs = new ServiceCategoryJobBussiness();
            var sjobs =  bs.GetAll(i => i.Servicejobid == entityDto.ServiceJobId);
            if (sjobs!=null && sjobs.Count > 0)
            {
                bs.Delete(sjobs.ToList());
            }
            base.Delete(entityDto);
        }
    }
}
