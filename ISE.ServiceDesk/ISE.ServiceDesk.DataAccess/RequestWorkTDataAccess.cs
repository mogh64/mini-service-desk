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
    public class RequestWorkTDataAccess : TDataAccess<SdRequestWork, SdRequestWorkDto, SdRequestWorkRepository>
    {
        public RequestWorkTDataAccess()
            : base(new SdRequestWorkRepository())
        {
        }
        public override void Insert(ISE.ServiceDesk.Common.DTO.SdRequestWorkDto entityDto)
        {
            try
            {
                base.Insert(entityDto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
