using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdServiceCategoryJobDto:BaseDto
    {
        public SdServiceCategoryJobDto()
        {
            this.PrimaryKeyName = "ServiceCatJobId";
          
        }
        [DataMember]
        public SdServiceJobDto ServiceJob { get; set; }
        [DataMember]
        public SdServiceCategoryDto ServiceCategory { get; set; }
        public string GetFullName()
        {
            if (ServiceCategory != null && ServiceJob != null)
            {
                return string.Format("{0}-{1}", ServiceCategory.Title, ServiceJob.Title);
                
            }
            return string.Empty;
        }
        
        public bool HasAttachments
        {
            get
            {
                return Hasattachment>0?true:false;
            }
            set
            {
                Hasattachment = (short)(value ? 1 : 0);
            }
        }
        public bool IsInserters
        {
            get
            {
                return IsInserter > 0 ? true : false;
            }
            set
            {
                IsInserter = (short)(value ? 1 : 0);
            }
        }
        public bool HasDescriptions
        {
            get
            {
                return Hasdescription > 0 ? true : false;
            }
            set
            {
                Hasdescription = (short)(value ? 1 : 0);
            }
        }
        public bool HasCreditdates
        {
            get
            {
                return Hascreditdate > 0 ? true : false;
            }
            set
            {
                Hascreditdate = (short)(value ? 1 : 0);
            }
        }
       
       
        public bool IsIntrees
        {
            get
            {
                return Isintree > 0 ? true : false;
            }
            set
            {
                Isintree = (short)(value ? 1 : 0);
            }
        }
        public bool IsMultipleReq
        {
            get
            {
                return Multirequest > 0 ? true : false;
            }
            set
            {
                Multirequest = (short)(value ? 1 : 0);
            }
        }
        public bool IsEnabled
        {
            get
            {
                return Enabled > 0 ? true : false;
            }
            set
            {
                Enabled = (short)(value ? 1 : 0);
            }
        }
    }
}
