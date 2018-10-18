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
    public class SdRoleTDataAccess : TDataAccess<SdItRole, SdItRoleDto, SdItRoleRepository>
    {
        public SdRoleTDataAccess()
            : base(new SdItRoleRepository())
        {
        }
        public override void Insert(SdItRoleDto entityDto)
        {
            try
            {
                base.Insert(entityDto);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public List<SdItRoleExpertDto> GetSdRoles(int roleId)
        {
            var roleExperts =this.Repository.Context.SdItRoleExperts.Where(it => it.Itroleid == roleId);
            var dtoList =  SdItRoleExpertRepository.GetDtos(roleExperts).ToList();
            return dtoList;
        }

    }
}
