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
using ISE.ServiceDesk.Client.View;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.UILibrary.Lov;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Client.Types;
using System.IO;
using System.Diagnostics;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCUserRequestView : IUserControl
    {
        UserRequestView reqView = new UserRequestView();
        ServiceCategoryJobView myView = new ServiceCategoryJobView();
        BaseDataServicePresenter basePresenter = new BaseDataServicePresenter();
        ServiceJobView jobView = new ServiceJobView();
        VwPersonelDto person;
        UserRequestPresenter requestPresenter = new UserRequestPresenter();
        ServiceJobDtoContainer serviceJobContainer = null;
        TransMode tMode;
        BindingList<SdRequestAttachmentDto> attachBlist = new BindingList<SdRequestAttachmentDto>();
        BindingSource attachBs = new BindingSource();
        SdUserRequestDto userRequest;
        UserInformation userInfo;
        private ILov lovPers;
        private LovFields lfPersons;
        ISE.Cartable.DE.CartableDataSet.MY_CARTABLE_FOR_SERVICE_DESKRow servieDeskRow;
        public UCUserRequestView()
        {
            InitializeComponent();
        }
        public UCUserRequestView(TransMode tMode, ISE.Cartable.DE.CartableDataSet.MY_CARTABLE_FOR_SERVICE_DESKRow row, UserInformation userInfo)
        {
            try
            {
                this.userInfo = userInfo;
                InitializeComponent();
                servieDeskRow = row;
                this.tMode = tMode;
                this.userInfo = userInfo;
                if (tMode == TransMode.ViewRecord || tMode == TransMode.EditRecord)
                {
                    var hokm = basePresenter.GetHokm(userInfo.PerId);
                   
                    if ((hokm.Positionlevel == 5 || hokm.Positionlevel == 4) && hokm.EmcostoIndependSrl == 22852) // is in IT and masul ya modir
                    {
                       
                        btnChangePriority.Visible = true;
                        numUpDownPriority.ReadOnly = false;
                        numUpDownPriority.Enabled = true;
                    }
                    else
                    {
                       
                        btnChangePriority.Visible = false;
                        numUpDownPriority.ReadOnly = true;
                        numUpDownPriority.Enabled = false;
                    }
                    txtRequester.Text = row.PERSONELNAME;

                    if (row.IsCREATEDATENull() == false)
                        dtpDate.Value = row.CREATEDATE;

                    userRequest = requestPresenter.GetRequest(row.SER_REQ_ID);

                    SetUI(userRequest);

                    igridDeviceList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                    LoadAttachment(row.SER_REQ_ID);
                    igridAtch.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                    if (tMode == TransMode.ViewRecord)
                    {
                        btnMInAtc.Visible = false;
                        btnSelectAttch.Visible = false;
                    }
                    
                }
                SetGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public UCUserRequestView(TransMode tMode, SdUserRequestDto request, UserInformation userInfo)
        {

            this.userInfo = userInfo;
            InitializeComponent();
            this.userRequest = request;
            this.tMode = tMode;
            this.userInfo = userInfo;
            if (tMode == TransMode.ViewRecord || tMode == TransMode.EditRecord)
            {
                SetUI(userRequest);


                if (tMode == TransMode.ViewRecord)
                {
                    btnMInAtc.Visible = false;
                    btnSelectAttch.Visible = false;
                }
                igridDeviceList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                LoadAttachment(request.SerReqId);
                igridAtch.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;

            }
            SetGrid();
        }
        private void SetUI(SdUserRequestDto _userRequest)
        {
            ServiceCategoryJobPresenter serviceCatJobPresenter = new ServiceCategoryJobPresenter();
            BaseDataServicePresenter baseDataPresenter = new BaseDataServicePresenter();
            if (userRequest != null)
            {
                numUpDownPriority.Value = userRequest.Priority ?? 0;
                var serviceCatJob = serviceCatJobPresenter.GetCompleteServiceCategoryJob(userRequest.Servicecategoryjobid.Value);
                if (serviceCatJob != null)
                {
                    txtUserRequest.Text = serviceCatJob.GetFullName();
                    txtUserRequest.Tag = serviceCatJob;
                }
                if (userRequest.Finalservicecategoryjobid.HasValue)
                {
                    var finalserviceCatJob = serviceCatJobPresenter.GetCompleteServiceCategoryJob(userRequest.Finalservicecategoryjobid.Value);
                    if (finalserviceCatJob != null)
                    {
                        txtFinalRequest.Text = finalserviceCatJob.GetFullName();
                        txtFinalRequest.Tag = finalserviceCatJob;
                    }
                }
                if (userRequest.Createuserid.HasValue)
                {
                    var creatorUser = baseDataPresenter.getPersonel(userRequest.Createuserid.Value);
                    txtRequester.Text = creatorUser.FullName;
                }
                if (userRequest.Owneruserid.HasValue)
                {
                    var ownerUser = baseDataPresenter.getPersonel(userRequest.Owneruserid.Value);
                    txtOwnername.Text = ownerUser.FullName;
                }
                if (serviceCatJob.HasAttachments)
                {

                    var attachments = requestPresenter.GetRequestAttachments(userRequest.SerReqId);

                    attachBs.DataSource = attachBlist;
                    igridAtch.DataSource = attachBs;
                    foreach (var item in attachments)
                    {
                        attachBs.Add(item);
                    }

                }
                person = myView.baseDataPresenter.getPersonel(userRequest.Owneruserid ?? 0);
                if (serviceCatJob.ServiceCategory.HasDevices)
                {
                    var device = baseDataPresenter.GetDevice(userRequest.Transferid ?? 0);

                    if (device != null)
                    {
                        PersonDevice pd = new PersonDevice(device, person);
                        igridDeviceList.DataSource = new List<PersonDevice>() { pd };
                    }
                }
                else
                {
                    grpDeviceList.Visible = false;
                }
                txtDescription.Text = userRequest.Description;
                if (userRequest.Creditdate.HasValue)
                    dtpCreditDate.Value = userRequest.Creditdate.Value;


                txtContact.Text = userRequest.Callnumber;
                
            }

        }
       
        private void LoadAttachment(int requestId)
        {
            UserRequestPresenter presenter = new UserRequestPresenter();
            var attachment = presenter.GetRequestAttachments(requestId);
            igridAtch.DataSource = attachment;
        }
        private void SetGrid()
        {
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridAtch, true, false);
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridDeviceList, true, false);
        }

        private void btnViewWorks_Click(object sender, EventArgs e)
        {

            UCRequestWork ucForm = new UCRequestWork(person, userRequest.SerReqId, tMode);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(ucForm, "فعالیت ها", FormBorderStyle.Sizable);
        }

        private void igridAtch_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            var row = (SdRequestAttachmentDto)igridAtch.CurrentRow.DataRow;
            string path = "";
            if (row != null)
            {

                path = Path.GetTempPath() + "\\" + Guid.NewGuid().ToString().Replace("-", "") + "." + row.Filetype;
                File.WriteAllBytes(path, row.Content);
                Process.Start(path);
            }
        }

        private void btnChangePriority_Click(object sender, EventArgs e)
        {
            if (userRequest != null)
            {
                short number = short.Parse(numUpDownPriority.Value.ToString());
                
                userRequest.Priority = number;
               if( requestPresenter.Update(userRequest))
               {
                   ISE.Framework.Client.Win.Viewer.MessageViewer.ShowMessage(ISE.Framework.Client.Win.Viewer.OperationType.Update);
               }
               
            }
        }
    }
}
