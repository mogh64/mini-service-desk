using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.CommonBase;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Bussiness;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.ServiceDesk.DataAccess;
using ISE.ServiceDesk.Model;
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
    public class UserRequestService : ContextBoundObject, IRequestService
    {
        UserRequestBussiness requestBs = new UserRequestBussiness();
        public Framework.Common.Service.Message.ResponseDto Delete(Framework.Common.CommonBase.BaseDto dto)
        {
            requestBs.Delete((SdUserRequestDto)dto);
            return ResponseBuilder.GetResponse(dto);
        }

        public Framework.Common.Service.Message.ResponseDtoContainer DeleteBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public Framework.Common.CommonBase.DtoContainer GetAll()
        {
            UserRequestDtoContainer container = new UserRequestDtoContainer();
            container.UserRequestList = requestBs.GetAll().OrderByDescending(e=>e.SerReqId).ToList();
            return container;
        }

        public Framework.Common.CommonBase.DtoContainer GetAllByCondition(string predicate)
        {
            var pars = EntityHelper.ConvertExpression<SdUserRequest>(predicate);
            var lst =  requestBs.GetAll(pars);
            UserRequestDtoContainer container = new UserRequestDtoContainer();
            container.UserRequestList.AddRange(lst);
            return container;
        }

        public Framework.Common.CommonBase.BaseDto GetSingle(long id)
        {
            return  requestBs.GetSingle(it => it.SerReqId == id);
        }

        public Framework.Common.CommonBase.BaseDto Insert(Framework.Common.CommonBase.BaseDto dto)
        {
            requestBs.Insert((SdUserRequestDto)dto);
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
            requestBs.Update((SdUserRequestDto)dto);
             return ResponseBuilder.GetResponse(dto);
        }

        public Framework.Common.Service.Message.ResponseDtoContainer UpdateBatch(Framework.Common.PersistantPackage.PersistanceBox dtoList)
        {
            throw new NotImplementedException();
        }

        public void UpdatePackage(Framework.Common.PersistantPackage.UpdatePackageBox updatePackage)
        {
            throw new NotImplementedException();
        }

        public UserRequestDtoContainer GetRequestAttachment(int requestId)
        {
            UserRequestDtoContainer container = new UserRequestDtoContainer();
            RequestAttachmentTDataAccess attachmentDa = new RequestAttachmentTDataAccess();
            var attachments =  attachmentDa.GetAll(it => it.Requestid == requestId);
            container.RequestAttachmentList.AddRange(attachments);
            return container;
        }


        public SdRequestWorkDto AddRequestWork(SdRequestWorkDto work)
        {

            work.CreateDate = DateTime.Now;
            RequestWorkTDataAccess requestDa = new RequestWorkTDataAccess();
            requestDa.Insert(work);

            return work;
        }

        public UserRequestDtoContainer GetRequestWorkList(int requestId)
        {
            UserRequestDtoContainer container = new UserRequestDtoContainer();
            PersonelTDataAccess pda = new PersonelTDataAccess();
            RequestWorkTDataAccess requestDa = new RequestWorkTDataAccess();
            BaseDataTDataAccess baseDa = new BaseDataTDataAccess();
            var dtoList =  requestDa.GetAll(it => it.RequestId == requestId);
            var wList = baseDa.GetWorks();
            foreach (var item in dtoList)
            {
                var pers = pda.GetPersonId(item.UserId ?? 0);
                item.Work = wList.Where(it => it.WorkId == item.SdWorkId).FirstOrDefault();
                item.User = pers;
            }
            if(dtoList!=null)
                container.SdRequestWorkDtolist.AddRange(dtoList);
            return container;
        }
    }
}
