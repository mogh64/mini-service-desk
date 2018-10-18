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
    public class RequestAttachmentTDataAccess : TDataAccess<SdRequestAttachment, SdRequestAttachmentDto, SdRequestAttachmentRepository>
    {
        public RequestAttachmentTDataAccess()
            : base(new SdRequestAttachmentRepository())
        {
        }
      
    }
}
