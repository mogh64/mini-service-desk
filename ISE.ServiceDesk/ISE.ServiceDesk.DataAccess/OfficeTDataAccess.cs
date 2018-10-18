using ISE.Framework.Common.Service.Message;
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
    public class OfficeTDataAccess : TDataAccess<SdOffice, SdOfficeDto, SdOfficeRepository>
    {
        public OfficeTDataAccess()
            : base(new SdOfficeRepository())
        {

        }
        public OfficeDtoContainer GetDetail(int officeId)
        {
            PersonelTDataAccess pda = new PersonelTDataAccess();
            OfficeDtoContainer container = new OfficeDtoContainer();
            var experts =SdItExpertRepository.GetDtos( this.Repository.Context.SdItExperts.Where(it => it.Officeid == officeId));
            var roles = SdItRoleRepository.GetDtos(this.Repository.Context.SdItRoles.Where(it => it.Officeid == officeId));
            if (experts != null)
                container.ExpertList.AddRange(experts);
            if (roles != null)
                container.RoleList.AddRange(roles);
            foreach (var item in experts)
            {
                item.Personel =  pda.GetSingle(it => it.PerId == item.Userid);
            }
            return container;
        }
       
    }
}
