using ISE.Framework.Common.CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Common.DTO
{
    public partial class SdUserRequestDto:BaseDto
    {
        public SdUserRequestDto()
        {
            this.PrimaryKeyName = "SerReqId";
            AttachmentList = new List<SdRequestAttachmentDto>();
        }
        [DataMember]

        public List<SdRequestAttachmentDto> AttachmentList { get; set; }
        public string CurrentStateStr
        {
            get
            {
                if (CurrentState != null)
                {
                    return CurrentState.StateTitle;
                }
                return string.Empty;
            }
        }
        public string Title
        {
            get
            {
                return ServiceJobTitle + " " + ServiceCategoryTitle;
            }
        }
        public string ServiceCategoryTitle
        {
            get
            {
                if (this.SdServiceCategoryJobDto != null)
                {
                    if (this.SdServiceCategoryJobDto.ServiceCategory != null)
                    {
                        return this.SdServiceCategoryJobDto.ServiceCategory.Title; 
                    }
                }
                return "";
            }
        }
        public string ServiceJobTitle
        {
            get
            {
                if (this.SdServiceCategoryJobDto != null)
                {
                    if (this.SdServiceCategoryJobDto.ServiceJob != null)
                    {
                        return this.SdServiceCategoryJobDto.ServiceJob.Title;
                    }
                }
                return "";
            }
        }
        [DataMember]
        public SdRequestStateDto CurrentState { get; set; }
        [DataMember]
        public SdServiceCategoryJobDto SdServiceCategoryJobDto { get; set; }
        [DataMember]
        public VwPersonelDto CurrentCartableUser { get; set; }
        [DataMember]
        public VwPersonelDto OwnerUser { get; set; }
        [DataMember]
        public VwPersonelDto CreatorUser { get; set; }
    }
}
