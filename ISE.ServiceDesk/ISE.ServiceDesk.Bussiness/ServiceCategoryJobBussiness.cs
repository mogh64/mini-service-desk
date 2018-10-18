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
    public class ServiceCategoryJobBussiness : BussinessBase<SdServiceCategoryJob, SdServiceCategoryJobDto>
    {
        public ServiceCategoryJobBussiness()
        {
            this.dataAccess = new ServiceCategoryJobTDataAccess();
        }
        public Common.DTOContainer.ServiceJobDtoContainer LoadServiceCategoryJobsByJob(int serviceJobId)
        {
            ServiceCategoryTDataAccess serviceCatDa = new ServiceCategoryTDataAccess();
            ServiceJobDtoContainer container = new ServiceJobDtoContainer();
            var catList = serviceCatDa.GetAll();
            
            foreach (var item in catList)
            {
                var cat = this.GetSingle(it => it.Servicecategoryid == item.ServiceCatId && it.Servicejobid==serviceJobId);
                if (cat != null)
                {
                    cat.ServiceCategory = item;
                    container.ServiceCategoryJobs.Add(cat);
                }
                else
                {
                    container.ServiceCategoryDtos.Add(item);
                }

            }
           
            return container;
        }
        public override void Insert(SdServiceCategoryJobDto entityDto)
        {
            var catJob = this.GetSingle(it => it.Servicejobid == entityDto.Servicejobid && it.Servicecategoryid == entityDto.Servicecategoryid);
            if (catJob == null)
            {
                base.Insert(entityDto);
            }
           
        }
        public override void Insert(List<SdServiceCategoryJobDto> entityDtoList)
        {
            List<SdServiceCategoryJobDto> insertList = new List<SdServiceCategoryJobDto>();
            foreach (var entityDto in entityDtoList)
            {
                 var catJob = this.GetSingle(it => it.Servicejobid == entityDto.Servicejobid && it.Servicecategoryid == entityDto.Servicecategoryid);
                 if (catJob == null)
                 {
                     insertList.Add(entityDto);
                 }
            }
            base.Insert(insertList);
        }
        
    }
}
