using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
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
    public class RoleService : ContextBoundObject, IRoleService
    {
        public Framework.Common.Service.Message.ResponseDto Delete(Framework.Common.CommonBase.BaseDto dto)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.Service.Message.ResponseDtoContainer DeleteBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.DtoContainer GetAll()
        {
            OfficeDtoContainer container = new OfficeDtoContainer();
            SdRoleTDataAccess roleDa = new SdRoleTDataAccess();
            var roles = roleDa.GetAll().ToList();
            container.RoleList.AddRange(roles);
            return container;
        }

        public Framework.Common.CommonBase.DtoContainer GetAllByCondition(string predicate)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.BaseDto GetSingle(long id)
        {
            SdRoleTDataAccess roleDa = new SdRoleTDataAccess();
            var dto =  roleDa.GetSingle(it => it.RoleId == id);
            return dto;
        }

        public Framework.Common.CommonBase.BaseDto Insert(Framework.Common.CommonBase.BaseDto dto)
        {
            SdRoleTDataAccess da = new SdRoleTDataAccess();
            da.Insert((SdItRoleDto)dto);
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
            throw new NotImplementedException();
        }

        public Framework.Common.Service.Message.ResponseDtoContainer UpdateBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public void UpdatePackage(Framework.Common.PersistantPackage.UpdatePackageBox updatePackage)
        {
            throw new NotImplementedException();
        }

        public Common.DTOContainer.OfficeDtoContainer GetRoleExperts(int roleId)
        {
            ExpertTDataAccess exDa = new ExpertTDataAccess();
            SdRoleTDataAccess da = new SdRoleTDataAccess();
            PersonelTDataAccess pDa = new PersonelTDataAccess();
            var role =da.GetSingle(it => it.RoleId == roleId);
            OfficeDtoContainer container = new OfficeDtoContainer();
            var dtoList = da.GetSdRoles(roleId);
            foreach (var dto in dtoList)
            {
                dto.Role = role;
                var expert =  exDa.GetSingle(it => it.ItExpertId == dto.Expertid);
                dto.Expert = expert;
                var personel =  pDa.GetSingle(it => it.PerId == expert.Userid);
                dto.Personel = personel;
            }
            container.RoleExperts.AddRange(dtoList);
            return container;
        }


        public SdItRoleExpertDto AddRoleExpert(SdItRoleExpertDto roleExpert)
        {
            RoleExpertTDataAccess da = new RoleExpertTDataAccess();
            da.Insert(roleExpert);
            return roleExpert;
        }

        public Framework.Common.Service.Message.ResponseDto RemoveRoleExpert(SdItRoleExpertDto roleExpert)
        {
            RoleExpertTDataAccess da = new RoleExpertTDataAccess();
            da.Delete(roleExpert);
            return ResponseBuilder.GetResponse(roleExpert);
        }

        public Framework.Common.Service.Message.ResponseDto UpdateRoleExpert(SdItRoleExpertDto roleExpert)
        {
            RoleExpertTDataAccess da = new RoleExpertTDataAccess();
            da.Update(roleExpert);
            return ResponseBuilder.GetResponse(roleExpert);
        }


        
    }
}
