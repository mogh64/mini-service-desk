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
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Client.Common.Presenter
{
    public class UserRequestPresenter
    {
        private ServiceAdapter<IRequestService> UserRequestAdapter;
        public UserRequestPresenter()
        {
            IseBussinessExceptionManager exceptionManager = new IseBussinessExceptionManager();
            UserRequestAdapter = new ServiceAdapter<IRequestService>(exceptionManager);
        }
        public List<SdUserRequestDto> LoadUserRequest(int perId)
        {
            
            string condition = ISE.Framework.Utility.Utils.ExpressionHelper.PredicateToDynamicString<SdUserRequestDto>(it => it.Createuserid == perId || it.Owneruserid == perId);
            var container = (UserRequestDtoContainer)UserRequestAdapter.Execute(it => it.GetAllByCondition(condition));
            return container.UserRequestList;
        }
        public List<SdUserRequestDto> LoadAllUserRequest()
        {

            
            var container = (UserRequestDtoContainer)UserRequestAdapter.Execute(it => it.GetAll());
            return container.UserRequestList;
        }
        public SdUserRequestDto GetRequest(int userRequestId)
        {
            SdUserRequestDto result = (SdUserRequestDto)UserRequestAdapter.Execute(s => s.GetSingle(userRequestId));
            if (result.Response.HasException)
            {
                return null;
            }
            
            return result;
        }
        public SdUserRequestDto Insert(SdUserRequestDto ServiceRequest)
        {
            SdUserRequestDto result = (SdUserRequestDto)UserRequestAdapter.Execute(s => s.Insert(ServiceRequest));
            if (result.Response.HasException)
            {
                return null;
            }
            ServiceRequest.SerReqId = result.SerReqId;
            ServiceRequest.Createdate = result.Createdate;

            return result;
        }
        public bool Update(SdUserRequestDto ServiceRequest)
        {
            ResponseDto response = UserRequestAdapter.Execute(s => s.Update(ServiceRequest));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
        public bool Remove(SdUserRequestDto ServiceRequest)
        {
            ResponseDto response = UserRequestAdapter.Execute(s => s.Delete(ServiceRequest));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
        public List<SdRequestAttachmentDto> GetRequestAttachments(int requestId)
        {
            var container = (UserRequestDtoContainer)UserRequestAdapter.Execute(it => it.GetRequestAttachment(requestId));
            return container.RequestAttachmentList;
        }
        public List<SdRequestWorkDto> GetRequestWorkList(int requestId)
        {
            var container = (UserRequestDtoContainer)UserRequestAdapter.Execute(it => it.GetRequestWorkList(requestId));
            return container.SdRequestWorkDtolist;
        }
        public SdRequestWorkDto AddRequestWork(SdRequestWorkDto work)
        {
            SdRequestWorkDto result = (SdRequestWorkDto)UserRequestAdapter.Execute(s => s.AddRequestWork(work));
            if (result.Response.HasException)
            {
                return null;
            }
            work.RequestWorkId = result.RequestWorkId;
            work.CreateDate = result.CreateDate;
            return work;
        }
    }
}
