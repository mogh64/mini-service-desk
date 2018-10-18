using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISE.UILibrary;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Client.View;
using ISE.Framework.Utility.Utils;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCServiceCatJob : IUserControl
    {
        SdServiceCategoryJobDto serviceCatJob;
        public DialogResult result = DialogResult.None;
        ServiceCategoryJobView view;
        public UCServiceCatJob(SdServiceCategoryJobDto serviceCatJob)
        {
            view = new ServiceCategoryJobView();
            InitializeComponent();
            cmbRoles.DataSource = view.LoadRoles();
            cmbRoles.DisplayMember = AssemblyReflector.GetMemberName((SdItRoleDto c) => c.Title);
            cmbRoles.ValueMember = AssemblyReflector.GetMemberName((SdItRoleDto c) => c.RoleId);
            this.serviceCatJob = serviceCatJob;
            if (serviceCatJob != null)
            {
                txtActionId.Text = serviceCatJob.Actionid.ToString();
                txtEstimateTime.Text = serviceCatJob.Estimatetimecost.ToString();
                chkAttch.Checked = serviceCatJob.HasAttachments ;
                chkCreditDate.Checked = serviceCatJob.HasCreditdates;
                chkDesc.Checked = serviceCatJob.HasDescriptions;
                chkMulti.Checked = serviceCatJob.IsMultipleReq;
                cmbRoles.SelectedValue = serviceCatJob.Roleid??1;
                chkEnabled.Checked = serviceCatJob.Enabled > 0;
                chkIsInserter.Checked = serviceCatJob.IsInserters;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int actionId=0;
            int timeCost = 0;
            if (serviceCatJob != null)
            {
                
                int.TryParse(txtActionId.Text, out actionId);
                int.TryParse(txtEstimateTime.Text,out timeCost);
                serviceCatJob.Actionid = actionId;
                serviceCatJob.Estimatetimecost = timeCost;
                serviceCatJob.HasAttachments = chkAttch.Checked;
                serviceCatJob.HasCreditdates = chkCreditDate.Checked;
                serviceCatJob.HasDescriptions = chkDesc.Checked;
                serviceCatJob.IsInserters = chkIsInserter.Checked;
                serviceCatJob.IsMultipleReq = chkMulti.Checked;
                serviceCatJob.Enabled = chkEnabled.Checked?(short)1:(short)0;
                if (cmbRoles.SelectedValue!=null)
                   serviceCatJob.Roleid = int.Parse( cmbRoles.SelectedValue.ToString());
                if (serviceCatJob.ServiceCatJobId > 0)
                {
                    serviceCatJob.State = Framework.Common.CommonBase.DtoObjectState.Updated;
                }
                else
                {
                    serviceCatJob.State = Framework.Common.CommonBase.DtoObjectState.Inserted;
                }
                result = DialogResult.OK;

            }
            this.ParentForm.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
