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
    public class SdWorkTDataAccess : TDataAccess<SdWork, SdWorkDto, SdWorkRepository>
    {
        public SdWorkTDataAccess()
            : base(new SdWorkRepository())
        {
        }
        public override void Insert(SdWorkDto entityDto)
        {
            try
            {
                base.Insert(entityDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
