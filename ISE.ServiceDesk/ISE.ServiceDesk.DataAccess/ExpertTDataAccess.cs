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
    public class ExpertTDataAccess : TDataAccess<SdItExpert, SdItExpertDto, SdItExpertRepository>
    {
        public ExpertTDataAccess()
            : base(new SdItExpertRepository())
        {

        }
        public override void Insert(SdItExpertDto entityDto)
        {
            int count = this.Repository.Context.SdItExperts.Count(it => it.Userid == entityDto.Userid);
            if(count==0){
                base.Insert(entityDto);
            }
            else
            {
                entityDto.Response.AddBusinessException("این فرد قبلا ثبت شده است!!", Framework.Common.Service.Message.BusinessExceptionEnum.Validation);
            }
        }
    }
}
