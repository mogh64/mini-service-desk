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
    public class UserRequestTDataAccess : TDataAccess<SdUserRequest, SdUserRequestDto, SdUserRequestRepository>
    {
        public UserRequestTDataAccess()
            : base(new SdUserRequestRepository())
        {
        }
        public List<SdRequestStateDto> GetStateList()
        {
            List<SdRequestStateDto> lst = new List<SdRequestStateDto>();
            var dataList =this.Repository.Context.SdRequestStates.ToList();
            foreach (var item in dataList)
            {
                var dto =SdRequestStateRepository.GetDto(item);
                lst.Add(dto);
                
            }
            return lst;
        }
        public override void Delete(SdUserRequestDto entityDto)
        {
            try
            {
                RequestAttachmentTDataAccess recAttDa = new RequestAttachmentTDataAccess();
                var attachs =  recAttDa.GetAll(t => t.Requestid == entityDto.SerReqId).ToList();
                if(attachs.Count>0)
                   recAttDa.Delete(attachs);
                base.Delete(entityDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
