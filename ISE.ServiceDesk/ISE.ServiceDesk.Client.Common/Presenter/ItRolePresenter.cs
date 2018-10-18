using ISE.Framework.Client.Common.ExceptionManager;
using ISE.Framework.Common.Service;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISE.ServiceDesk.Client.Common.Presenter
{
    public class ItRolePresenter
    {
        private ServiceAdapter<IRoleService> roleServiceAdapter;
        public ItRolePresenter()
        {
            IseBussinessExceptionManager exceptionManager = new IseBussinessExceptionManager();
            roleServiceAdapter = new ServiceAdapter<IRoleService>(exceptionManager);

        }
        public bool Insert(SdItRoleDto dto)
        {
            SdItRoleDto newJob = (SdItRoleDto)roleServiceAdapter.Execute(it => it.Insert(dto));
            if (newJob.Response.HasException)
            {
                return false;
            }
            dto.RoleId = newJob.RoleId;
            return true;
        }
        public List<SdItRoleDto> GetRoles()
        {
            OfficeDtoContainer response = (OfficeDtoContainer)roleServiceAdapter.Execute(s => s.GetAll());
            if (response.Response.HasException)
            {
                return null;
            }
            return response.RoleList.OrderBy(it=>it.Officeid).ToList();
        }
        public SdItRoleDto GetRole(int roleId)
        {
            SdItRoleDto role = (SdItRoleDto)roleServiceAdapter.Execute(it => it.GetSingle(roleId));
            if (role.Response.HasException)
            {
                return null;
            }
            
            return role;
        }
        public bool Update(SdItRoleDto dto)
        {
            ResponseDto response = roleServiceAdapter.Execute(s => s.Update(dto));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
        public List<SdItRoleExpertDto> GetRoleExperts(int roleId)
        {
            OfficeDtoContainer response = roleServiceAdapter.Execute(s => s.GetRoleExperts(roleId));
            if (response.Response.HasException)
            {
                return null;
            }
            return response.RoleExperts;
        }
        public SdItRoleExpertDto AddRoleExpert(SdItRoleExpertDto roleExpert)
        {
            SdItRoleExpertDto response = roleServiceAdapter.Execute(s => s.AddRoleExpert(roleExpert));
            if (response.Response.HasException)
            {
                return null;
            }
            roleExpert.RoleExpertId = response.RoleExpertId;
            return roleExpert;
        }
        public bool RemoveRoleExpert(SdItRoleExpertDto roleExpert)
        {
            ResponseDto response = roleServiceAdapter.Execute(s => s.RemoveRoleExpert(roleExpert));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
        public bool UpdateRoleExpert(SdItRoleExpertDto roleExpert)
        {
            ResponseDto response = roleServiceAdapter.Execute(s => s.UpdateRoleExpert(roleExpert));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
    }
}
