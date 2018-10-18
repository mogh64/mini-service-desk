using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Bussiness;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
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
    public class ServiceDeskCartableService : ContextBoundObject,ICartableService
    {
       
        public Common.DTO.ExternalResultDto GetRecieverExpert(List<int> perIdList)
        {
            int resultId = perIdList.FirstOrDefault();            
           
            DateTime lastDate=DateTime.Now.AddYears(-10);
            if (perIdList.Count > 1)
            {
                ExpertTDataAccess expertDa = new ExpertTDataAccess();
                RequestAssignedExpertTDataAccess assignedDa = new RequestAssignedExpertTDataAccess();
                foreach (var perId in perIdList)
                {
                    var expert = expertDa.GetSingle(it => it.Userid == perId);
                    if (expert != null)
                    {
                        if (expert.IsEnabled)
                        {
                            var req = assignedDa.GetLastRequest(perId);
                            if (req != null)
                            {
                                if (req.Assigndate > lastDate)
                                {
                                    resultId = req.ExpertPerId.Value;
                                }
                            }
                            else
                            {
                                resultId = perId;
                            }
                        }
                    }
                    
                }
            }
            
            ExternalResultDto result=new ExternalResultDto(){
                Result = resultId
            };
            return result;
        }


        public Framework.Common.Service.Message.ResponseDto AssignExpert(int requestId, int isHead, int expertPerId, int assignType, DateTime assignDate)
        {
            throw new NotImplementedException();
        }
        public Framework.Common.Service.Message.ResponseDto SetRequestCurrentCartableUser(int requestId, int perId)
        {
            ResponseDto response = new ResponseDto();
            UserRequestBussiness reqBs = new UserRequestBussiness();

            var request =  reqBs.GetSingle(it => it.SerReqId == requestId);
            if (request != null)
            {
              
                reqBs.Update(request);
            }
            else
            {
                response.Response.AddBusinessException("Request doesnt exist!",BusinessExceptionEnum.Validation);
            }
            return response;
        }
   
    }
}
