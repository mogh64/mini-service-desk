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
    public class VwHokmTDataAccess : TDataAccess<VwHokm, VwHokmDto, VwHokmRepository>
    {
        public VwHokmTDataAccess()
            : base(new VwHokmRepository())
        {
        }
    }
}
