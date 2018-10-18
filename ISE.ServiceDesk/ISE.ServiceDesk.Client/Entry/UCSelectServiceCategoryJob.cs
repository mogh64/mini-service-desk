using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ISE.UILibrary;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Client.View;
using ISE.Framework.Utility.Utils;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCSelectServiceCategoryJob : IUserControl
    {
        private SdServiceCategoryJobDto _SelectedServiceCategoryJob;
        public DialogResult Result = DialogResult.Cancel;
        public SdServiceCategoryJobDto SelectedServiceCategoryJob { get { return _SelectedServiceCategoryJob; } }
        public UCSelectServiceCategoryJob()
        {
            InitializeComponent();
            ServiceCategoryJobPresenter serviceJobPresenter = new ServiceCategoryJobPresenter();
            var serviceJobContainer = serviceJobPresenter.GetServiceJobTree();
            var treeNodes = LoadServiceTree(serviceJobContainer.ServiceCategoryDtos);
            treeServices.Nodes.AddRange(treeNodes.ToArray());
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
            var node = (TreeView)sender;
            ServiceJobView jobView = new ServiceJobView();
            var selected = (SdServiceCategoryDto)node.SelectedNode.Tag;
            if (selected != null)
            {
                var jobList = jobView.LoadServiceJobs(selected.ServiceCatId);
                lstJobs.DataSource = jobList;
                lstJobs.DisplayMember = AssemblyReflector.GetMemberName((SdServiceJobDto c) => c.Title);
            }
        }
        private SdServiceCategoryJobDto GetSelectedServiceCategoryJob()
        {
            ServiceCategoryJobView myView = new ServiceCategoryJobView();
            var selected = (SdServiceCategoryDto)treeServices.SelectedNode.Tag;
            var job = (SdServiceJobDto)lstJobs.SelectedItem;
            if (selected != null && job != null)
            {
                var scatJob = myView.cjPresenter.GetServiceCategoryJob(job.ServiceJobId, selected.ServiceCatId);
                scatJob.ServiceCategory = selected;
                scatJob.ServiceJob = job;
                return scatJob;
            }
            return null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _SelectedServiceCategoryJob = GetSelectedServiceCategoryJob();
            Result = DialogResult.OK;
            this.ParentForm.Close();
        }
    }
}
