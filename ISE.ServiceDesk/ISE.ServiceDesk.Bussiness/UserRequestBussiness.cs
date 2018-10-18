using ISE.Framework.Server.Core.BussinessBase;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.Enum;
using ISE.ServiceDesk.DataAccess;
using ISE.ServiceDesk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Bussiness
{
    public class UserRequestBussiness : BussinessBase<SdUserRequest, SdUserRequestDto>
    {
        public UserRequestBussiness()
        {
            this.dataAccess = new UserRequestTDataAccess();
        }
        public override IList<SdUserRequestDto> GetAll(System.Linq.Expressions.Expression<Func<SdUserRequest, bool>> whereCondition)
        {
            BaseDataTDataAccess baseDa = new BaseDataTDataAccess();
            PersonelTDataAccess persDa = new PersonelTDataAccess();
            ServiceCategoryJobTDataAccess scatJobDa = new ServiceCategoryJobTDataAccess();
            var result = base.GetAll(whereCondition);
            foreach (var item in result)
            {
                item.SdServiceCategoryJobDto =   scatJobDa.GetServiceCatJob(item.Servicecategoryjobid??0);
                item.CurrentCartableUser =  GetCurrentCartablePersonId(item.SerReqId);
                item.OwnerUser = persDa.GetPersonId(item.Owneruserid ?? 0);
                item.CreatorUser = persDa.GetPersonId(item.Createuserid ?? 0);
                if(item.Currentstateid.HasValue){
                    var state = baseDa.GetState(item.Currentstateid.Value);
                        item.CurrentState=state;
                }
               
            }
            return result;
        }
        public override IList<SdUserRequestDto> GetAll()
        {
            BaseDataTDataAccess baseDa = new BaseDataTDataAccess();
            ServiceCategoryJobTDataAccess scatJobDa = new ServiceCategoryJobTDataAccess();
            PersonelTDataAccess persDa = new PersonelTDataAccess();
            var result = base.GetAll();
            foreach (var item in result)
            {
                item.SdServiceCategoryJobDto = scatJobDa.GetServiceCatJob(item.Servicecategoryjobid ?? 0);
                item.CurrentCartableUser = GetCurrentCartablePersonId(item.SerReqId);
                item.OwnerUser = persDa.GetPersonId(item.Owneruserid ?? 0);
                item.CreatorUser = persDa.GetPersonId(item.Createuserid ?? 0);
                if (item.Currentstateid.HasValue)
                {
                    var state = baseDa.GetState(item.Currentstateid.Value);
                    item.CurrentState = state;
                }

            }
            return result;
        }
        public override void Insert(ISE.ServiceDesk.Common.DTO.SdUserRequestDto entityDto)
        {
            try
            {
                if (!entityDto.Owneruserid.HasValue)
                {
                    entityDto.Response.AddBusinessException("مالک درخواست باید مشخص شود!", Framework.Common.Service.Message.BusinessExceptionEnum.Validation);
                    return;
                }
                //var currentRequests = this.GetAll(it => it.Servicecategoryjobid == entityDto.Servicecategoryjobid &&  (it.Currentstateid != (int)RquestState.Ended && it.Currentstateid != (int)RquestState.Revoced) && it.Owneruserid == entityDto.Owneruserid).ToList();
                //if (currentRequests.Count > 0)
                //{
                //    entityDto.Response.AddBusinessException("درخواستی با این مشخصات هنوز در جریان می باشد!", Framework.Common.Service.Message.BusinessExceptionEnum.Validation);
                //    return;
                //}
                entityDto.Currentstateid = 0;
                entityDto.Createdate = DateTime.Now;
                base.Insert(entityDto);
                if (entityDto.AttachmentList.Count > 0)
                {

                    RequestAttachmentTDataAccess reqAttachDa = new RequestAttachmentTDataAccess();
                    foreach (var item in entityDto.AttachmentList)
                    {
                        item.Requestid = entityDto.SerReqId;
                    }
                    reqAttachDa.Insert(entityDto.AttachmentList);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        private VwPersonelDto GetCurrentCartablePersonId(int requestId)
        {
            BaseDataTDataAccess baseDa = new BaseDataTDataAccess();
            var currentCartable =  baseDa.GetRequestLatestCycle(requestId);
            if (currentCartable != null) {
                PersonelTDataAccess persDa = new PersonelTDataAccess();
                int perId = currentCartable.ReceiverPerId;
                var person = persDa.GetPersonId(perId);
                return person;
            }
            return null;
        }
    }
}
