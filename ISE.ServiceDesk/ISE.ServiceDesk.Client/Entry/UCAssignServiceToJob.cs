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
    public partial class UCAssignServiceToJob : IUserControl
    {
        ServiceJobView myView;
        List<SdServiceCategoryJobDto> serviceCategoryJobs = new List<SdServiceCategoryJobDto>();
        public List<SdServiceCategoryJobDto> NewServiceCategoryJobs = new List<SdServiceCategoryJobDto>();
        
        SdServiceCategoryDto pRow;
        SdServiceJobDto mServiceJob;
        BindingSource catBs = new BindingSource();
        BindingList<SdServiceCategoryDto> ServiceCatBList;
        BindingList<SdServiceCategoryJobDto> ServiceCatJobBList;
        BindingSource serviceCatJobBs = new BindingSource();
        public UCAssignServiceToJob(ServiceJobView view,SdServiceJobDto mServiceJob)
        {           
            InitializeComponent();
            this.myView = view;
            this.mServiceJob = mServiceJob;
            var container = myView.LoadServiceCatJobsByJob(mServiceJob.ServiceJobId);
            ServiceCatBList = new BindingList<SdServiceCategoryDto>(container.ServiceCategoryDtos);
            ServiceCatJobBList = new BindingList<SdServiceCategoryJobDto>(container.ServiceCategoryJobs);
            catBs.DataSource = ServiceCatBList;
            igridServiceJob.DataSource = catBs;
            serviceCatJobBs.DataSource = ServiceCatJobBList;
            iGridServiceCatJob.DataSource = serviceCatJobBs;

            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridServiceJob, true, false);
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.iGridServiceCatJob, true, false);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (var row in igridServiceJob.GetCheckedRows())
            {
                var cat = (SdServiceCategoryDto)row.DataRow;
                SdServiceCategoryJobDto serviceCatJob = new SdServiceCategoryJobDto()
                {
                    Servicejobid = mServiceJob.ServiceJobId,
                    Servicecategoryid = cat.ServiceCatId,
                    ServiceCategory = cat,
                    State = Framework.Common.CommonBase.DtoObjectState.Inserted
                };
                ServiceCatBList.Remove(cat);
                ServiceCatJobBList.Add(serviceCatJob);
            } 
        }

        private void iGridServiceCatJob_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
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
                    serviceCatJobBs.ResetBindings(true);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rows = iGridServiceCatJob.GetRows();
            UpdatePackageBox box = new UpdatePackageBox();
            foreach (var item in rows)
            {
                var data = (SdServiceCategoryJobDto)item.DataRow;
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
            {
                ISE.Framework.Client.Win.Viewer.MessageViewer.ShowMessage(ISE.Framework.Client.Win.Viewer.OperationType.Insert);
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
                        serviceCatJobBs.Remove(data);
                        ServiceCatBList.Add(data.ServiceCategory);
                    }
                    else
                    {
                        deleteList.Add(data);
                        serviceCatJobBs.Remove(data);
                    }
                }
            }
            if (deleteList.Count > 0)
            {
                myView.RemoveServiceCatJobs(deleteList);


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
