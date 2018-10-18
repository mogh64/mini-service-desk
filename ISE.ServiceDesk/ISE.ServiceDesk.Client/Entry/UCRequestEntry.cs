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
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Client.View;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.ServiceDesk.Common.DTO;
using ISE.Framework.Utility.Utils;
using ISE.ClassLibrary;
using ISE.Framework.Client.Win.Selector;
using ISE.ServiceDesk.Client.Types;
using ISE.Cartable.UI.UC;
using System.IO;
using System.Diagnostics;
using ISE.UILibrary.Lov;
using ISE.ServiceDesk.Common.Enum;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCRequestEntry : IUserControl
    {
        UserRequestView reqView = new UserRequestView();
        ServiceCategoryJobView myView = new ServiceCategoryJobView();
        ServiceJobView jobView = new ServiceJobView();
        VwPersonelDto person;
        
        ServiceJobDtoContainer serviceJobContainer = null;
        TransMode tMode;
        BindingList<SdRequestAttachmentDto> attachBlist = new BindingList<SdRequestAttachmentDto>();
        BindingSource attachBs = new BindingSource();
        SdUserRequestDto userRequest;
        UserInformation userInfo;
        private ILov lovPers;
        private LovFields lfPersons;
        ISE.Cartable.DE.CartableDataSet.MY_CARTABLE_FOR_SERVICE_DESKRow servieDeskRow;
        public UCRequestEntry(UserInformation userInfo)
        {
         
            this.userInfo = userInfo;
            InitializeComponent();
            ServiceCategoryJobPresenter serviceJobPresenter = new ServiceCategoryJobPresenter();
            serviceJobContainer = serviceJobPresenter.GetServiceJobTree();
            var treeNodes = LoadServiceTree(serviceJobContainer.ServiceCategoryDtos);
            treeServices.Nodes.AddRange(treeNodes.ToArray());
            txtRequester.Text = userInfo.FirstName + " " + userInfo.LastName;
            dtpDate.Value = DateTime.Now;
            person = myView.baseDataPresenter.getPersonel(userInfo.PerId);
            txtOwnername.Text = person.FullName;
            txtOwnername.Tag = person;
         
            attachBs.DataSource = attachBlist;
            igridAtch.DataSource = attachBs;

            if (userInfo.ActionId == (int)RequestAction.All || userInfo.ActionId == (int)RequestAction.IndChart)
            {
                btnSelectOwner.Enabled = true;
            }
            else
            {
                btnSelectOwner.Enabled = false;
            }
            grpDeviceList.Enabled = false;
            grpOwner.Enabled = false;

            SetGrid();
           
           
        }
        private void SetGrid()
        {
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridAtch, true, false);
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridDeviceList, true, false);
        }
        public UCRequestEntry(TransMode tMode,SdUserRequestDto request, UserInformation userInfo)
        {

            this.userInfo = userInfo;
            InitializeComponent();
            this.userRequest = request;
            this.tMode = tMode;
            this.userInfo = userInfo;
            if (tMode == TransMode.ViewRecord || tMode == TransMode.EditRecord)
            {
                UserRequestPresenter requestPresenter = new UserRequestPresenter();
                BaseDataServicePresenter baseDataPresenter = new BaseDataServicePresenter();
                ServiceCategoryJobPresenter serviceCatJobPresenter = new ServiceCategoryJobPresenter();

                
                var creatorPers = baseDataPresenter.getPersonel(request.Createuserid.Value);
                txtRequester.Text = creatorPers.FullName;
                if (userRequest.Owneruserid.HasValue)
                {
                    var ownerUser = baseDataPresenter.getPersonel(request.Owneruserid.Value);
                    txtOwnername.Text = ownerUser.FullName;
                }

                
                if (request.Createdate!=null)
                dtpDate.Value = request.Createdate.Value;
                var serviceCatJob = serviceCatJobPresenter.GetCompleteServiceCategoryJob(request.Servicecategoryjobid.Value);

                lstJobs.DataSource = new List<string>() { serviceCatJob.ServiceJob.Title};

                treeServices.Nodes.Add(serviceCatJob.ServiceCategory.Title);

                

                txtDescription.Text = userRequest.Description;
                if (userRequest.Creditdate.HasValue)
                    dtpCreditDate.Value = userRequest.Creditdate.Value;

                

                if (serviceCatJob.ServiceCategory.HasMenus)
                {

                }

                txtContact.Text = userRequest.Callnumber;

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
               
                btnCreateRequest.Visible = false;
                txtContact.ReadOnly = true;
                txtDescription.ReadOnly = true;
                txtMenu.ReadOnly = true;
                txtRequester.ReadOnly = true;
                btnMInAtc.Enabled = false;
                btnSelectAttch.Enabled = false;
                btnSelectMenu.Enabled = false;
                if (tMode == TransMode.ViewRecord)
                {
                    btnSelectOwner.Enabled = false;
                }
                igridDeviceList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                LoadAttachment(request.SerReqId);
                igridAtch.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                
            }
            SetGrid();
        }
        public UCRequestEntry(TransMode tMode, ISE.Cartable.DE.CartableDataSet.MY_CARTABLE_FOR_SERVICE_DESKRow row, UserInformation userInfo)
        {
            
            this.userInfo = userInfo;
            InitializeComponent();
            servieDeskRow = row;
            this.tMode = tMode;
            this.userInfo = userInfo;
            if (tMode == TransMode.ViewRecord || tMode == TransMode.EditRecord)
            {
                UserRequestPresenter requestPresenter = new UserRequestPresenter();
                BaseDataServicePresenter baseDataPresenter=new BaseDataServicePresenter();
                ServiceCategoryJobPresenter serviceCatJobPresenter = new ServiceCategoryJobPresenter();


                treeServices.Visible = false;
                lstJobs.Visible = false;
                txtRequester.Text = row.PERSONELNAME;
                

                if(row.IsCREATEDATENull()==false)
                dtpDate.Value = row.CREATEDATE;


               lstJobs.DataSource = new List<string>() { row.SERVICEJOB };
                
                treeServices.Nodes.Add(row.SERVICECATEGORY);
                
                userRequest =  requestPresenter.GetRequest(row.SER_REQ_ID);
                if (userRequest.Owneruserid.HasValue)
                {
                    var ownerUser = baseDataPresenter.getPersonel(userRequest.Owneruserid.Value);
                    txtOwnername.Text = ownerUser.FullName;
                }
                txtDescription.Text = userRequest.Description;
                if (userRequest.Creditdate.HasValue)
                    dtpCreditDate.Value = userRequest.Creditdate.Value;
                
                var serviceCatJob =  serviceCatJobPresenter.GetCompleteServiceCategoryJob(userRequest.Servicecategoryjobid.Value);
                
                if (serviceCatJob.ServiceCategory.HasMenus)
                {
                   
                }
                
                txtContact.Text = userRequest.Callnumber;
                
                if (serviceCatJob.HasAttachments)
                {
                    
                   var attachments =  requestPresenter.GetRequestAttachments(userRequest.SerReqId);
                   
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
                    var device =  baseDataPresenter.GetDevice(userRequest.Transferid??0);
                   
                    if (device != null)
                    {
                        PersonDevice pd = new PersonDevice(device, person);
                        igridDeviceList.DataSource = new List<PersonDevice>() { pd };
                    }
                }
                if (userRequest.Owneruserid != userRequest.Createuserid)
                {
                    txtOwnername.Text = person.FullName;
                }
                btnCreateRequest.Visible = false;
                txtContact.ReadOnly = true;
                txtDescription.ReadOnly = true;
                txtMenu.ReadOnly = true;
                txtRequester.ReadOnly = true;
                btnMInAtc.Enabled= false;
                btnSelectAttch.Enabled = false;
                btnSelectMenu.Enabled = false;
                btnSelectOwner.Enabled = false;
                btnViewWorks.Visible = true;
                igridDeviceList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                LoadAttachment(row.SER_REQ_ID);
                igridAtch.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            
            }
            SetGrid();
        }
        private void LoadAttachment(int requestId)
        {
            UserRequestPresenter presenter = new UserRequestPresenter();
            var attachment = presenter.GetRequestAttachments(requestId);
            igridAtch.DataSource = attachment;
        }
        private List<TreeNode> LoadServiceTree(List<SdServiceCategoryDto> serviceCategoryList, int parentId = -1)
        {
            List<SdServiceCategoryDto> nodes = new List<SdServiceCategoryDto>();
            List<TreeNode> treeNodes = new List<TreeNode>();
            if (parentId == -1)
            {
                nodes = serviceCategoryList.Where(it => it.Parentid == null).ToList();
            }
            else
            {
                nodes = serviceCategoryList.Where(it => it.Parentid == parentId).ToList();
            }
            if (nodes != null)
            {
                foreach (var item in nodes)
                {
                    TreeNode node = new TreeNode()
                    {
                        Text = item.Title,
                        Tag = item
                    };
                    var childNodes = serviceCategoryList.Where(it => it.Parentid == item.ServiceCatId).ToList();
                    if (childNodes != null)
                    {
                        var treeChildNodes = LoadServiceTree(serviceCategoryList, item.ServiceCatId);
                        if (treeChildNodes != null)
                            node.Nodes.AddRange(treeChildNodes.ToArray());
                    }
                    treeNodes.Add(node);
                }
            }
            return treeNodes;
        }

        private void treeServices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string s = "";
            try
            {
               
                grpOwner.Enabled = false;
                var node = (TreeView)sender;
                if (node != null)
                {
                    
                    var selected = (SdServiceCategoryDto)node.SelectedNode.Tag;
                    if (selected != null)
                    {
                        
                        var jobList = jobView.LoadServiceJobs(selected.ServiceCatId, true);
                       
                        lstJobs.DataSource = jobList;
                       
                        lstJobs.DisplayMember = AssemblyReflector.GetMemberName((SdServiceJobDto c) => c.Title);
                        
                        grpDeviceList.Enabled = selected.HasDevices;
                      
                        btnSelectMenu.Enabled = selected.HasMenus;
                     
                        txtMenu.Enabled = selected.HasMenus;
                       
                        var filter = myView.baseDataPresenter.GetFilter(selected.ServiceCatId);
                      
                        var job = (SdServiceJobDto)lstJobs.SelectedItem;
                        if (job != null)
                        {
                            var catJob = myView.cjPresenter.GetServiceCategoryJob(job.ServiceJobId, selected.ServiceCatId);

                            if (selected.HasDevices)
                            {

                                int objTypeId = -1;
                                if (filter != null)
                                {
                                    objTypeId = filter.Objecttypeid ?? -1;
                                }
                                //if (userInfo.ActionId == (int)RequestAction.All)
                                //{
                                //    LoadChartDevice(person.IndependentId.Value, objTypeId);
                                //}
                                //else
                                //{
                                //    LoadPersonDevice(userInfo.PerId, objTypeId);
                                //}
                                LoadPersonDevice(userInfo.PerId, objTypeId);

                            }
                            else
                            {
                                grpDeviceList.Visible = false;
                            }

                            if (!(catJob.IsInserter > 0))
                            {
                                grpDeviceList.Visible = false;
                            }
                        }
                   
                      
                    }
                }
            }
            catch (Exception ex)
            {
              
                throw ex;
            }
                  
        }
        
        //private void LoadPersonDevice()
        private void lstJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var job = (SdServiceJobDto)((IListBox)sender).SelectedItem;


            var selectedCat = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
            if (selectedCat != null && job != null)
            {
                var catJob = myView.cjPresenter.GetServiceCategoryJob(job.ServiceJobId, selectedCat.ServiceCatId);
                if (catJob != null)
                {
                    grpOwner.Enabled = true;
                    if (catJob.IsInserter.HasValue && catJob.IsInserter > 0)
                    {
                        grpDeviceList.Visible = false;
                    }
                    else
                    {
                        grpDeviceList.Visible = true;
                    }
                    SetOwnerUi(catJob);
                }
                else
                {
                    grpOwner.Enabled = false;
                }
            }
        }
       
        private void SetOwnerUi(SdServiceCategoryJobDto scJob)
        {
           
            grpAttachments.Enabled = scJob.HasAttachments;

            dtpCreditDate.Enabled = scJob.HasCreditdates;

            txtDescription.Enabled = scJob.HasDescriptions;
  
        }

        private void btnSelectPers_Click(object sender, EventArgs e)
        {
           
            
        }

       
        private void btnSelectDevice_Click(object sender, EventArgs e)
        {

        }


        private void LoadChartDevice(int chartId,int objTypeId)
        {
            List<PersonDevice> personDevices = new List<PersonDevice>();
            if (treeServices.SelectedNode != null)
            {
                var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
                
                if (selected.HasDevices)
                {
                   
                    var personList = myView.baseDataPresenter.getPersonelListByInd(chartId);
                    foreach (var p in personList)
                    {
                        var devices = myView.baseDataPresenter.GetDeviceList(p.PerId, objTypeId);
                        foreach (var d in devices)
                        {
                            PersonDevice pd = new PersonDevice(d, p);
                           
                            personDevices.Add(pd);
                        }
                       
                    }
                    igridDeviceList.DataSource = personDevices;
                }
            }

        }
        private void LoadPersonDevice(int perId, int objTypeId)
        {
            List<PersonDevice> personDevices = new List<PersonDevice>();
            var myPerson = myView.baseDataPresenter.getPersonel(perId);
            if (treeServices.SelectedNode != null)
            {
                var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
              
                if (selected.HasDevices)
                {
                   
                    var devices = myView.baseDataPresenter.GetDeviceList(perId, objTypeId);
                    foreach (var d in devices)
                    {
                        PersonDevice pd = new PersonDevice(d, myPerson);

                        personDevices.Add(pd);
                    }
                    igridDeviceList.DataSource = personDevices;
                }
            }
           
        }
        private SdServiceCategoryJobDto GetSelectedServiceCategoryJob()
        {
            var selected =(SdServiceCategoryDto) treeServices.SelectedNode.Tag;
            var job = (SdServiceJobDto) lstJobs.SelectedItem;
            if (selected != null && job != null)
            {
                var scatJob = myView.cjPresenter.GetServiceCategoryJob(job.ServiceJobId, selected.ServiceCatId);
                scatJob.ServiceCategory = selected;
                scatJob.ServiceJob = job;
                return scatJob;
            }
            return null;
        }
        private void btnSelectAttch_Click_1(object sender, EventArgs e)
        {
            UCAddAttachment frm = new UCAddAttachment();
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "افزودن ضمیه", FormBorderStyle.FixedDialog);
            if (frm.AttachmentFile != null)
            {
                frm.AttachmentFile.State = Framework.Common.CommonBase.DtoObjectState.Inserted;
                attachBlist.Add(frm.AttachmentFile);
            }
        }

        private void btnMInAtc_Click_1(object sender, EventArgs e)
        {
            var rows = igridAtch.GetCheckedRows();
            foreach (var item in rows)
            {
                var itemRow = (SdRequestAttachmentDto)item.DataRow;
                attachBlist.Remove(itemRow);
            }
        }

  

       
        private void igridOwner_SelectionChanged(object sender, EventArgs e)
        {
                   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }
        private void Clear()
        {
            
            igridDeviceList.DataSource = null;
        }

        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
            {
                ISE.Framework.Client.Win.Viewer.MessageViewer.ShowAlert("اطلاعات را کامل وارد کنید!");
            }
            var serviceCategoryJob =  GetSelectedServiceCategoryJob();
            if (serviceCategoryJob!=null)
            {
               

                if (serviceCategoryJob.ServiceCategory.HasDevices && !serviceCategoryJob.IsInserters)
                {
                    if (igridDeviceList.GetCheckedRows().Count()!=1)
                    {
                        ISE.Framework.Client.Win.Viewer.MessageViewer.ShowException(" یک تجهیز باید انتخاب شود!!");
                        return;
                    }
                }
                CreateRequest(serviceCategoryJob);
            }
            else
            {
                ISE.Framework.Client.Win.Viewer.MessageViewer.ShowException("سرویس مورد نظر را درست انتخاب کنید!");
                return;
            }
            
        }
        private bool CheckInputs()
        {
            if (!string.IsNullOrWhiteSpace(txtContact.Text))
            {
                if (StringHelper.IsNumeric(txtContact.Text))
                    return true;
            }
            if (!string.IsNullOrWhiteSpace(txtOwnername.Text))
            {

                return true;
            }
            return false;
        }
        private void CreateRequest(SdServiceCategoryJobDto serviceCatJob)
        {
            
            SdUserRequestDto request = new SdUserRequestDto()
            {
                Owneruserid=GetOwnerId(),
                Callnumber = txtContact.Text,
                Description = txtDescription.Text,
                Createuserid = userInfo.PerId,
                Servicecategoryjobid = serviceCatJob.ServiceCatJobId
            };
            if (serviceCatJob.ServiceCategory.HasDevices) {
                if (igridDeviceList.GetCheckedRows().Count() > 0) {
                    foreach (var prow in igridDeviceList.GetCheckedRows())
                    {
                        var owner = (PersonDevice)prow.DataRow;


                        var device = owner.Device;
                        if (device != null)
                        {
                            request.Transferid = device.transfer_id;
                        }
                    }
                }
                
            }
            else
            {
                foreach (var row in igridAtch.GetRows())
                {
                    var attachment = (SdRequestAttachmentDto)row.DataRow;
                    request.AttachmentList.Add(attachment);
                }

            }
            if (serviceCatJob.HasCreditdates)
            {
                request.Creditdate = dtpCreditDate.Value;
            }
                var ownerPers = (VwPersonelDto)txtOwnername.Tag;
                request.Owneruserid = ownerPers.PerId;
               
                var result =  reqView.presenter.Insert(request);
                if (result != null)
                {
                    UserInformation uInfo = new UserInformation(ownerPers.PerNo, "", "", "", ownerPers.PerId, 1, false);
                    UCSend cartableFrm = new UCSend(uInfo, request.SerReqId, ISE.Cartable.BR.Cartable.Programs.ServiceDesk, -1, -1, serviceCatJob.Actionid ?? -1);
                    ISE.UILibrary.Utils.UIUtils.SetFrmTrans(cartableFrm, "درخواست ", FormBorderStyle.Sizable);
                    if (cartableFrm.Result != DialogResult.OK)
                    {

                        reqView.presenter.Remove(request);
                    }
                    else
                    {
                        request.Currentstateid = (int)RquestState.InProcess;
                        BaseDataServicePresenter basePresenter = new BaseDataServicePresenter();
                        request.CurrentState = basePresenter.GetStateList().Where(it => it.SdReqStateId == request.Currentstateid).FirstOrDefault();
                        reqView.presenter.Update(request);
                    }
                }
               
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

        private void btnSelectOwner_Click(object sender, EventArgs e)
        {
            List<VwPersonelDto> personList = new List<VwPersonelDto>();
            if (userInfo.ActionId == (int)RequestAction.All) // all personels
            {
                personList = myView.baseDataPresenter.getPersonelList(0);
                
            }
            if (userInfo.ActionId == (int)RequestAction.IndChart) // own chart personels
            {
                personList = myView.baseDataPresenter.getPersonelListByInd(person.IndependentId??0);
            }
            lfPersons = new LovFields();
            lfPersons.AddItem("PerNo", "شماره پرسنلي", 80, true);
            
            lfPersons.AddItem("PerFname", "نام ", 200, true);
            lfPersons.AddItem("PerLname", "نام خانوادگي", 200, true);
            var table =  ISE.Framework.Utility.Utils.DataTableHelper.ConvertToDatatable<VwPersonelDto>(personList);
            lovPers = new ILov(btnSelectOwner, "", table, lfPersons);
            var myRow =(DataRow) lovPers.ShowDialog();
           
            if (myRow != null)
            {
                myView.baseDataPresenter.getPersonel(int.Parse(myRow["PerId"].ToString()));
                txtOwnername.Text = myRow["FullName"].ToString();
                txtOwnername.Tag = myView.baseDataPresenter.getPersonel(int.Parse(myRow["PerId"].ToString())); ;

                var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
                if (selected != null)
                {
                    int perId = int.Parse(myRow["PerId"].ToString());
                    var filter = myView.baseDataPresenter.GetFilter(selected.ServiceCatId);
                    if (selected.HasDevices)
                    {
                        int objTypeId = -1;
                        if (filter != null)
                        {
                            objTypeId = filter.Objecttypeid ?? -1;
                        }

                        LoadPersonDevice(perId, objTypeId);
                    }

                }
            }

        }
        private int GetOwnerId()
        {
            VwPersonelDto ownerPerson = (VwPersonelDto)txtOwnername.Tag;
            if (ownerPerson != null)
                return ownerPerson.PerId;
            return 0;
        }
        private void btnWork_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewWorks_Click(object sender, EventArgs e)
        {
            TransMode mode = TransMode.ViewRecord;
          //  if (servieDeskRow.BE_TERMINATED > 0)
            {
                mode = TransMode.ViewRecord;
            }
            UCRequestWork ucForm = new UCRequestWork(person, userRequest.SerReqId, mode);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(ucForm, "فعالیت ها", FormBorderStyle.Sizable);
        }

        private void btnSelectMenu_Click(object sender, EventArgs e)
        {

        }

        private void txtOwnername_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
