using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ISE.UILibrary;
using ISE.ClassLibrary;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Common.DTO;
using ISE.Framework.Utility.Utils;
using ISE.ServiceDesk.Common;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCRequestWork : IUserControl
    {
        TransMode mode;
        int requestId;
        SdUserRequestDto request;
        UserRequestPresenter presenter = new UserRequestPresenter();
        BaseDataServicePresenter basePresenter = new BaseDataServicePresenter();
        BindingSource bs = new BindingSource();
        BindingList<SdRequestWorkDto> workBlist;
        VwPersonelDto person;
        public UCRequestWork(VwPersonelDto person,int requestId,TransMode mode)
        {
            
            this.mode = mode;
            this.requestId = requestId;
            request = presenter.GetRequest(requestId);
            this.person = person;
            InitializeComponent();
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridProcessList, true, false);
            InitUi();
            LoadRequests();
            LoadServiceCategoryJob();
            if (mode != TransMode.NewRecord)
            {               
                grpCreateWork.Visible = false;
            }
            if (mode == TransMode.ViewRecord)
            {
                btnChangeRequest.Visible = false;
            }
        }
        private void LoadServiceCategoryJob() {
            
            if (request != null)
            {
              
                ServiceCategoryJobPresenter serviceCatJobPresenter = new ServiceCategoryJobPresenter();

                var serviceCatJob = serviceCatJobPresenter.GetCompleteServiceCategoryJob(request.Servicecategoryjobid.Value);

                if (serviceCatJob != null)
                {
                    txtUserRequest.Text = serviceCatJob.GetFullName();
                    txtUserRequest.Tag = serviceCatJob;
                }
                if (request.Finalservicecategoryjobid.HasValue)
                {
                    var finalServiceCatJob = serviceCatJobPresenter.GetCompleteServiceCategoryJob(request.Finalservicecategoryjobid.Value);
                    if (finalServiceCatJob != null)
                    {
                        txtFinalRequest.Text = finalServiceCatJob.GetFullName();
                        txtFinalRequest.Tag = finalServiceCatJob;
                    }
                }

            }
            
           
        }
        public UCRequestWork(TransMode tMode, ISE.Cartable.DE.CartableDataSet.MY_CARTABLE_FOR_SERVICE_DESKRow row, UserInformation userInfo)
        {
            UserRequestPresenter requestPresenter = new UserRequestPresenter();
            BaseDataServicePresenter baseDataPresenter = new BaseDataServicePresenter();
            this.mode = tMode;
            request = requestPresenter.GetRequest(row.SER_REQ_ID);
            person = baseDataPresenter.getPersonel(request.Owneruserid ?? 0);
            InitializeComponent();
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridProcessList, true, false);
            InitUi();
            LoadRequests();
            LoadServiceCategoryJob();
        }
        private void InitUi()
        {
            cmbWork.DataSource = basePresenter.GetWorkListByServiceCatJob(request.Servicecategoryjobid.Value, true);
            cmbWork.DisplayMember = AssemblyReflector.GetMemberName((SdWorkDto m) => m.Title);
            cmbWork.ValueMember = AssemblyReflector.GetMemberName((SdWorkDto m) => m.WorkId);
        }
        private void LoadRequests()
        {
            var reqList =  presenter.GetRequestWorkList(requestId);
            
            workBlist = new BindingList<SdRequestWorkDto>(reqList.OrderBy(it=>it.RequestWorkId).ToList());
            bs.DataSource = workBlist;
            igridProcessList.DataSource = bs;
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            SdRequestWorkDto work = new SdRequestWorkDto()
            {
                Description = txtDescription.Text,
                RequestId = requestId,
                UserId = person.PerId,
                User = person,
                SdWorkId = (int) cmbWork.SelectedValue,
                WorkTime = ServiceDeskHelper.GetInt(txtTime.Text),
                WorkCost = ServiceDeskHelper.GetInt(txtCost.Text),
                Work = (SdWorkDto)cmbWork.SelectedItem
                
            };
            if (presenter.AddRequestWork(work) != null)
            {
                workBlist.Add(work);
            }
        }

        private void btnChangeRequest_Click(object sender, EventArgs e)
        {
            UCSelectServiceCategoryJob frm = new UCSelectServiceCategoryJob();
            UserRequestPresenter requestPresenter=new UserRequestPresenter();
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "فعالیت ها", FormBorderStyle.Sizable);
            if (frm.Result != DialogResult.OK)
                return;
            var selectedServiceCatJob = frm.SelectedServiceCategoryJob;
            if (selectedServiceCatJob != null) {
                if (request != null) {
                    request.Finalservicecategoryjobid = selectedServiceCatJob.ServiceCatJobId;
                    if (requestPresenter.Update(request))
                    {
                        
                        txtFinalRequest.Text = selectedServiceCatJob.GetFullName();
                        txtFinalRequest.Tag = selectedServiceCatJob;
                    }
                    
                }
            }

        }
    }
}
