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
using ISE.ClassLibrary;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Client.View;
using ISE.Framework.Utility.Utils;


namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCItServices : IUserControl
    {
        ServiceCategoryJobView myView = new ServiceCategoryJobView();
        ServiceJobView jobView = new ServiceJobView();
        UserInformation currentinfo;
        ServiceJobDtoContainer serviceJobContainer = null;
        public UCItServices(UserInformation info)
        {
            currentinfo = info;
            InitializeComponent();
            InitializeData();
            grpJobBtns.Enabled = false;
            grpJobBtns.Visible = false;

            grpServiceCatBtns.Enabled = true;
            grpServiceCatBtns.Visible = true;
        }
       
        private void InitializeData()
        {
            
            ServiceCategoryJobPresenter serviceJobPresenter = new ServiceCategoryJobPresenter();
            serviceJobContainer = serviceJobPresenter.GetServiceJobTree();
            var treeNodes = LoadServiceTree(serviceJobContainer.ServiceCategoryDtos);
            treeServices.Nodes.AddRange(treeNodes.ToArray());
        }

        private List<TreeNode> LoadServiceTree(List<SdServiceCategoryDto>serviceCategoryList,int parentId=-1)
        {
            List<SdServiceCategoryDto> nodes = new List<SdServiceCategoryDto>();
            List<TreeNode> treeNodes=new List<TreeNode>();
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

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            UCServiceCategory frm = new UCServiceCategory(TransMode.NewRecord,myView);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "طبقه بندی خدمات", FormBorderStyle.FixedDialog);
            foreach (var item in frm.InsertedList)
            {
                TreeNode node = new TreeNode();
                node.Text = item.Title;
                node.Tag = item;
                treeServices.Nodes.Add(node);
            }
        }

        private void btnAddSubnode_Click(object sender, EventArgs e)
        {
            var selected = (SdServiceCategoryDto) treeServices.SelectedNode.Tag;
            if (selected != null)
            {
                UCServiceCategory frm = new UCServiceCategory(TransMode.NewRecord, myView,selected.ServiceCatId);
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "طبقه بندی خدمات", FormBorderStyle.FixedDialog);
                foreach (var item in frm.InsertedList)
                {
                    TreeNode node = new TreeNode();
                    node.Text = item.Title;
                    node.Tag = item;
                    treeServices.SelectedNode.Nodes.Add(node);
                }
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
            if (selected != null)
            {
                UCServiceCategory frm = new UCServiceCategory(TransMode.EditRecord, myView, selected);
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "طبقه بندی خدمات", FormBorderStyle.FixedDialog);
                if (frm.Result == DialogResult.OK)
                {
                    myView.UpdateServiceCategory(selected);
                }
            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddSubJob();
        }

        private void AddSubJob()
        {
            UCServiceJob frm = new UCServiceJob(jobView);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "ایجاد زیر خدمت", FormBorderStyle.FixedDialog);
            if (frm.Result == DialogResult.OK)
            {
                if (frm.serviceJobList.Count > 0)
                {
                    var node = (TreeView)treeServices;

                    var selected = (SdServiceCategoryDto)node.SelectedNode.Tag;
                    if (selected != null)
                    {

                        lstJobs.Items.AddRange(frm.serviceJobList.ToArray());
                        lstJobs.DisplayMember = AssemblyReflector.GetMemberName((SdServiceJobDto c) => c.Title);
                    }

                }
            }
        }

        private void treeServices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = (TreeView)sender;

            var selected = (SdServiceCategoryDto)node.SelectedNode.Tag;
            if (selected != null)
            {
                lstJobs.Items.Clear();
                var jobList =  jobView.LoadServiceJobs(selected.ServiceCatId);
                lstJobs.Items.AddRange( jobList.ToArray());
                lstJobs.DisplayMember = AssemblyReflector.GetMemberName((SdServiceJobDto c) => c.Title);
            }
        }

        private void btnAssignToJob_Click(object sender, EventArgs e)
        {
            var node = treeServices.SelectedNode;
            if (node != null)
            {
                var selected = (SdServiceCategoryDto)node.Tag;
                if (selected != null && selected.Hasjob>0)
                {
                    UCAssignServiceJob frm = new UCAssignServiceJob(jobView, selected);

                    ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, " انتساب زیر خدمت  " + selected.Title, FormBorderStyle.FixedDialog);
                }
            }
          
            
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAllServiceJobs();
        }

        private void ViewAllServiceJobs()
        {
            var jobList = jobView.LoadServiceJobs(-1);
            lstJobs.Items.Clear();
            lstJobs.Items.AddRange(jobList.ToArray());
            lstJobs.DisplayMember = AssemblyReflector.GetMemberName((SdServiceJobDto c) => c.Title);
        }

        private void btnAsignToService_Click(object sender, EventArgs e)
        {
            AssigneToService();
        }

        private void AssigneToService()
        {
            var job = (SdServiceJobDto)lstJobs.SelectedItem;
            if (job != null)
            {
                UCAssignServiceToJob frm = new UCAssignServiceToJob(jobView, job);
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "انتساب خدمت", FormBorderStyle.FixedDialog);
            }
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            EditJob();
        }

        private void EditJob()
        {
            var job = (SdServiceJobDto)lstJobs.SelectedItem;
            UCServiceJob frm = new UCServiceJob(jobView, job, TransMode.EditRecord);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "اطلاعات ریز خدمت", FormBorderStyle.FixedDialog);
            if (frm.Result == DialogResult.OK)
            {
                jobView.UpdateServiceJob(job);
                lstJobs.SelectedItem = job;

            }
        }

        private void btnRemoveJob_Click(object sender, EventArgs e)
        {
            RemoveJob();
        }

        private void RemoveJob()
        {
            if (ISE.Framework.Client.Win.Viewer.MessageViewer.ShowDeleteAlert() == DialogResult.OK)
            {
                var job = (SdServiceJobDto)lstJobs.SelectedItem;
                jobView.RemoveServiceJob(job);
            }
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
            if (selected != null)
            {
                if (myView.RemoveServiceCategory(selected))
                {
                    if(ISE.Framework.Client.Win.Viewer.MessageViewer.ShowAlert("آیا از حذف مطئن هستید؟")==DialogResult.OK)
                       treeServices.Nodes.Remove(treeServices.SelectedNode);
                    
                }
            }
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
            if (selected != null)
            {
                UCWorkList frm = new UCWorkList(selected.ServiceCatId);
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "لیست کارهای قابل انجام", FormBorderStyle.FixedDialog);
            }
            

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            AddRoleSJob();
        }

        private void AddRoleSJob()
        {
            var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
            var job = (SdServiceJobDto)lstJobs.SelectedItem;
            if (selected != null && job != null)
            {

                ServiceCategoryJobPresenter cjPresenter = new ServiceCategoryJobPresenter();
                var serviceCatJob = cjPresenter.GetServiceCategoryJob(job.ServiceJobId, selected.ServiceCatId);
                if (serviceCatJob != null)
                {
                    UCChangeRole frm = new UCChangeRole(serviceCatJob);
                    ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "گروه کاری مرتبط", FormBorderStyle.FixedDialog);
                }

            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void iGroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rdServiceCat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdServiceCat.Checked)
            {
                grpJobBtns.Enabled = false;
                grpJobBtns.Visible = false;

                grpServiceCatBtns.Enabled = true;
                grpServiceCatBtns.Visible = true;
                treeServices.Enabled = true;
                lstJobs.Items.Clear();
            }
            if (rdServiceJob.Checked)
            {
                grpJobBtns.Enabled = true;
                grpJobBtns.Visible = true;

                grpServiceCatBtns.Enabled = false;
                grpServiceCatBtns.Visible = false;
                treeServices.Enabled = false;
                ViewAllServiceJobs();
            }
        }

        private void treeServices_DoubleClick(object sender, EventArgs e)
        {
            var node = treeServices.SelectedNode;
            if (node != null)
            {
                var selected = (SdServiceCategoryDto)node.Tag;
                if (selected != null && selected.Hasjob > 0)
                {
                    UCAssignServiceJob frm = new UCAssignServiceJob(jobView, selected);

                    ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, " انتساب زیر خدمت  " + selected.Title, FormBorderStyle.FixedDialog);
                }
            }
        }
           
    }
}
