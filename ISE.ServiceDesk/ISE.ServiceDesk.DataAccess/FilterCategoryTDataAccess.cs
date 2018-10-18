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
    public class FilterCategoryTDataAccess : TDataAccess<SdFilterCategory, SdFilterCategoryDto, SdFilterCategoryRepository>
    {
        public FilterCategoryTDataAccess()
            : base(new SdFilterCategoryRepository())
        {
        }
        public override void Delete(SdFilterCategoryDto entityDto)
        {
            if (entityDto.FilterId <= 0)
            {
                if(entityDto.Objecttypeid>0){
                    var scat = this.GetSingle(it => it.Objecttypeid == entityDto.Objecttypeid && it.Servicecaegoryid == entityDto.Servicecaegoryid);
                    this.Delete(scat);
                }
                else if (entityDto.Menuparentid > 0)
                {
                    var mcat = this.GetSingle(it => it.Menuparentid == entityDto.Menuparentid && it.Servicecaegoryid == entityDto.Servicecaegoryid);
                    this.Delete(mcat);
                }
                
            }
            else
            {
                base.Delete(entityDto);
            }
            
        }
        public override void Insert(SdFilterCategoryDto entityDto)
        {
            var exist = this.GetSingle(it => it.Objecttypeid == entityDto.Objecttypeid && it.Servicecaegoryid == entityDto.Servicecaegoryid);
            if (exist != null)
            {
                this.Delete(exist);
            }
            base.Insert(entityDto);
        }
        public override SdFilterCategoryDto GetSingle(System.Linq.Expressions.Expression<Func<SdFilterCategory, bool>> whereCondition)
        {
            var result = base.GetSingle(whereCondition);
            if (result != null)
            {
                var objType = this.Repository.Context.Objecttypes.FirstOrDefault(it => it.ObjecttypeId == result.Objecttypeid);
                if(objType!=null){
                    result.ObjectType = ObjecttypeRepository.GetDto(objType);
                }
                
            }
            
            return result;
        }
    }
}
