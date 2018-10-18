using ISE.Framework.Server.Core.DataAccessBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.DataAccess
{
    public class ServiceCategoryTDataAccess : TDataAccess<SdServiceCategory, SdServiceCategoryDto, SdServiceCategoryRepository>
    {
        public ServiceCategoryTDataAccess()
            : base(new SdServiceCategoryRepository())
        {
        }
        public override SdServiceCategoryDto GetSingle(System.Linq.Expressions.Expression<Func<SdServiceCategory, bool>> whereCondition)
        {
            return base.GetSingle(whereCondition);
        }
        public override void Insert(SdServiceCategoryDto entityDto)
        {
            try
            {
                base.Insert(entityDto);
                if (entityDto.Filter != null)
                {
                    FilterCategoryTDataAccess filterda = new FilterCategoryTDataAccess();
                    entityDto.Filter.Servicecaegoryid = entityDto.ServiceCatId;
                    filterda.Insert(entityDto.Filter);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public override void Delete(SdServiceCategoryDto entityDto)
        {

            base.Delete(entityDto);
            FilterCategoryTDataAccess filterda = new FilterCategoryTDataAccess();
            var filters =  filterda.GetAll(it => it.Servicecaegoryid == entityDto.ServiceCatId);
            if (filters != null && filters.Count > 0)
            {
                filterda.Delete(filters.ToList());
            }
            
        }
        public override void Update(SdServiceCategoryDto entityDto)
        {
            base.Update(entityDto);
            if (entityDto.Filter != null && entityDto.Filter.State==Framework.Common.CommonBase.DtoObjectState.Updated)
            {

                FilterCategoryTDataAccess filterda = new FilterCategoryTDataAccess();
                var oldFilter= filterda.GetAll(it => it.Servicecaegoryid == entityDto.ServiceCatId );
                if (oldFilter != null && oldFilter.Count>0)
                {
                    filterda.Delete(oldFilter.ToList());
                }
                entityDto.Filter.Servicecaegoryid = entityDto.ServiceCatId;
                filterda.Insert(entityDto.Filter);
            }
            if (entityDto.Filter != null && entityDto.Filter.State == Framework.Common.CommonBase.DtoObjectState.Deleted)
            {

                FilterCategoryTDataAccess filterda = new FilterCategoryTDataAccess();
                var oldFilter = filterda.GetAll(it => it.Servicecaegoryid == entityDto.ServiceCatId);
                if (oldFilter != null && oldFilter.Count > 0)
                {
                    filterda.Delete(oldFilter.ToList());
                }               
            }
        }
    }
}
