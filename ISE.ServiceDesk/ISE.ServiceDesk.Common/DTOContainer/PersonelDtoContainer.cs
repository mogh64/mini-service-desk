using ISE.Framework.Common.CommonBase;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTOContainer
{
    public class PersonelDtoContainer : DtoContainer
    {
        public PersonelDtoContainer(){
            PersonelDtoList=new List<VwPersonelDto>();
        }
        public List<VwPersonelDto> PersonelDtoList{get;set;}
    }
}
