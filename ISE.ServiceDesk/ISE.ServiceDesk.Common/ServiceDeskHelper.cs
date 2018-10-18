using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISE.ServiceDesk.Common
{
    public class ServiceDeskHelper
    {
        public static int GetInt(string number)
        {
            int n = 0;
            int.TryParse(number, out n);
            return n;
        }
    }
}
