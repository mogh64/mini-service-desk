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
using ISE.ServiceDesk.Client.View;
using ISE.ServiceDesk.Common.DTO;
using ISE.Framework.Common.PersistantPackage;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCAssignServiceJob : IUserControl
    {
        ServiceJobView myView;
        List<SdServiceCategoryJobDto> serviceCategoryJobs = new List<SdServiceCategoryJobDto>();
        public List<SdServiceCategoryJobDto> NewServiceCategoryJobs = new List<SdServiceCategoryJobDto>();
        SdServiceCategoryDto myServiceCategory;
        SdServiceJobDto pRow;
        BindingSource jobBs = new BindingSource();
        BindingList<SdServiceJobDto> ServiceJobBList;
        BindingList<SdServiceCategoryJobDto> ServiceCatBList;
        BindingSource serviceCatBs = new BindingSource();
        public UCAssignServiceJob(ServiceJobView view,SdServiceCategoryDto serviceCategory)
        {
            myServiceCategory = serviceCategory;
            InitializeComponent();
            this.myView = view;
            var container = myView.LoadServiceCatJobs(myServiceCategory.ServiceCatId);
            ServiceJobBList = new BindingList<SdServiceJobDto>(container.ServiceJobs);
            ServiceCatBList = new BindingList<SdServiceCategoryJobDto>(container.ServiceCategoryJobs);
            jobBs.DataSource = ServiceJobBList;
            igridServiceJob.DataSource = jobBs;
            serviceCatBs.DataSource = ServiceCatBList;
            iGridServiceCatJob.DataSource = serviceCatBs;

            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridServiceJob, true, false);
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.iGridServiceCatJob, true, false);
            
        }

        private void iGridEX1_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rows = iGridServiceCatJob.GetRows();
            UpdatePackageBox box = new UpdatePackageBox();
            foreach (var item in rows)
            {
                var data =(SdServiceCategoryJobDto) item.DataRow;
                if (data != null)
                {
                    
                    if (data.State == Framework.Common.CommonBase.DtoObjectState.Inserted)
                    {
                        box.insertBox.Add(data);
                    }
                    if (data.State == Framework.Common.CommonBase.DtoObjectState.Updated)
                    {
                        box.updateBox.Add(data);
                    }
                    if (data.State == Framework.Common.CommonBase.DtoObjectState.Deleted)
                    {
                        box.deleteBox.Add(data);
                    }                   
                }
            }
            if (myView.SaveServiceCatJobUpdate(box))
                ISE.Framework.Client.Win.Viewer.MessageViewer.ShowMessage(ISE.Framework.Client.Win.Viewer.OperationType.Update);


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (var row in igridServiceJob.GetCheckedRows())
            {
                var job =(SdServiceJobDto) row.DataRow;
                SdServiceCategoryJobDto serviceCatJob = new SdServiceCategoryJobDto()
                {
                    Servicejobid = job.ServiceJobId,
                    Servicecategoryid = myServiceCategory.ServiceCatId,
                    ServiceJob = job,
                    State = Framework.Common.CommonBase.DtoObjectState.Inserted
                };
                ServiceJobBList.Remove(job);
                ServiceCatBList.Add(serviceCatJob);
            } 
        }

        private void iGridServiceCatJob_DoubleClick(object sender, EventArgs e)
        {
            var row = (SdServiceCategoryJobDto)iGridServiceCatJob.CurrentRow.DataRow;
            if (row != null)
            {
                UCServiceCatJob frm = new UCServiceCatJob(row);
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "شرح خدمت", FormBorderStyle.FixedSingle);
                if (frm.result == DialogResult.OK)
                {
                    if (row.ServiceCatJobId > 0)
                    {
                        row.State = Framework.Common.CommonBase.DtoObjectState.Updated;
                    }
                    else
                    {
                        row.State = Framework.Common.CommonBase.DtoObjectState.Inserted;
                    }
                    serviceCatBs.ResetBindings(true);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<SdServiceCategoryJobDto> deleteList = new List<SdServiceCategoryJobDto>();
            foreach (var item in iGridServiceCatJob.GetCheckedRows())
	         {
                 var data = (SdServiceCategoryJobDto)item.DataRow;
                 if (data != null)
                 {
                     if (data.State == Framework.Common.CommonBase.DtoObjectState.Inserted)
                     {
                         serviceCatBs.Remove(data);
                         ServiceJobBList.Add(data.ServiceJob);
                     }
                     else
                     {
                         deleteList.Add(data);
                         serviceCatBs.Remove(data);
                     }
                 }
	         }
            if (deleteList.Count > 0)
            {
                myView.RemoveServiceCatJobs(deleteList);
               

            }
        }
        
    }
}
