using ISE.Framework.Server.Core.DataAccessBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.ServiceDesk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.DataAccess
{
    public class BaseDataTDataAccess : TDataAccess<SdItRole, SdItRoleDto, SdItRoleRepository>
    {
        public BaseDataTDataAccess()
            : base(new SdItRoleRepository())
        {
        }
        public BaseDataContainer GetRoleList()
        {
            BaseDataContainer container = new BaseDataContainer();
            container.RoleDtoList = this.GetAll().ToList();
            return container;
        }
        public BaseDataContainer GetObjectTypeList()
        {
            BaseDataContainer container = new BaseDataContainer();
             var lst =this.Repository.Context.Objecttypes.ToList();
             foreach (var item in lst)
             {
                 var dto = ObjecttypeRepository.GetDto(item);
                 container.ObjecttypeDtoList.Add(dto);
             }
            return container;
        }
        public BaseDataContainer GetRequestStates()
        {           
            var container = this.GetRequestStates();
            return container;
        }
        public SdRequestStateDto GetState(int id)
        {
            var data = this.Repository.Context.SdRequestStates.FirstOrDefault(it => it.SdReqStateId == id);
            return SdRequestStateRepository.GetDto(data);
        }
        public List<SdWorkDto> GetWorks()
        {
            
            return SdWorkRepository.GetDtos(this.Repository.Context.SdWorks).ToList();
        }
        public List<SdWorkDto> GetWorks(int serviceCategoryId)
        {

            return SdWorkRepository.GetDtos(this.Repository.Context.SdWorks.Where(it=>it.SdServiceCatId==serviceCategoryId)).ToList();
        }
        public Requestcartablecycle GetRequestLatestCycle(int requestId)
        {
            return this.Repository.Context.Requestcartablecycles.Where(it => it.SerReqId == requestId).OrderByDescending(it => it.CycleRow).Take(1).FirstOrDefault();
        }
    }
}
