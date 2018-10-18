using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Client.Types
{
    public class PersonDevice
    {
        public PersonDevice(DeviceDto deviec, VwPersonelDto person)
        {
            this.Device = deviec;
            this.Person = person;
        }
        public DeviceDto Device { get; set; }
        public VwPersonelDto Person { get; set; }

    }
}
