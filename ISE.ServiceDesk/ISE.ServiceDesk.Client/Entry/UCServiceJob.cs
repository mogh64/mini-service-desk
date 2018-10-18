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
using ISE.ClassLibrary;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCServiceJob : IUserControl
    {
        ServiceJobView myView;
        SdServiceJobDto serviceJob = null;
        public List<SdServiceJobDto> serviceJobList = new List<SdServiceJobDto>();
        public DialogResult Result = DialogResult.None;
        TransMode mode = TransMode.NewRecord;
        public UCServiceJob(ServiceJobView view)
        {
            InitializeComponent();
            myView = view;
         
        }
        public UCServiceJob(ServiceJobView view,SdServiceJobDto serviceJob,TransMode mode)
        {
            InitializeComponent();
            myView = view;
           
            this.serviceJob = serviceJob;
            this.mode = mode;
            if (mode == TransMode.EditRecord || mode == TransMode.ViewRecord)
            {
                txtDescription.Text = serviceJob.Description;
                txtTitle.Text = serviceJob.Title;
                chkEnabled.Checked = serviceJob.Enabled > 0;
            }
        }
        private void iTransToolBar1_SaveRecord(object sender, EventArgs e)
        {
            if (mode == TransMode.NewRecord)
            {
                serviceJob = new SdServiceJobDto()
                {
                    Description = txtDescription.Text,
                    Title = txtTitle.Text,
                    Enabled = (short)(chkEnabled.Checked ? 1 : 0)
                };
                if (myView.AddServiceJob(serviceJob))
                {
                    Result = DialogResult.OK;
                    serviceJobList.Add(serviceJob);
                }
                Result = DialogResult.OK;
            }
            if (mode == TransMode.EditRecord)
            {
                if (serviceJob != null)
                {
                    serviceJob.Description = txtDescription.Text;
                    serviceJob.Title = txtTitle.Text;
                    serviceJob.Enabled = (short)(chkEnabled.Checked ? 1 : 0);
                    Result = DialogResult.OK;
                }
            }
            this.ParentForm.Close();
        }

        private void iTransToolBar1_SaveAndNewRecord(object sender, EventArgs e)
        {

        }

        private void iTransToolBar1_Close(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnService_Click(object sender, EventArgs e)
        {

        }
    }
}
