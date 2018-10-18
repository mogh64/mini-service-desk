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
using ISE.UILibrary.Lov;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCChangeRole : IUserControl
    {
        SdServiceCategoryJobDto serviceCatJob;
        ServiceCategoryJobPresenter scatPresenter = new ServiceCategoryJobPresenter();
        ItRolePresenter presenter = new ItRolePresenter();
        private ILov lovRoles;
        private LovFields lfRoles;
        public UCChangeRole(SdServiceCategoryJobDto catJob)
        {
            InitializeComponent();
            this.serviceCatJob = catJob;
            if (this.serviceCatJob.Roleid.HasValue)
                LoadRole(this.serviceCatJob.Roleid.Value);
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.iGridEXPersons, true, false);
        }
        private void LoadRole(int roleId)
        {
            var role = presenter.GetRole(roleId);
            if (role != null)
            {
                var experts = presenter.GetRoleExperts(roleId);
                this.iGridEXPersons.DataSource = experts.Select(it=>it.Personel).ToList();
                txtRole.Text = role.Title;
            }
            
        }

        private void iButton1_Click(object sender, EventArgs e)
        {
            var roles =  presenter.GetRoles();
            lfRoles = new LovFields();
            lfRoles.AddItem("Title", "عنوان", 80, true);
            lfRoles.AddItem("Description", "شرح", 80, true);
            
            var table = ISE.Framework.Utility.Utils.DataTableHelper.ConvertToDatatable<SdItRoleDto>(roles);
            lovRoles = new ILov(iButton1, "", table, lfRoles);
            var myRow = (DataRow)lovRoles.ShowDialog();

            if (myRow != null)
            {
                txtRole.Text = myRow["Title"].ToString();
                int id = int.Parse(myRow["RoleId"].ToString());
                txtRole.Tag = myRow;
                var roleExperts =  presenter.GetRoleExperts(id);
                var experts = roleExperts.Select(i => i.Personel).ToList();
                iGridEXPersons.DataSource = experts;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (serviceCatJob != null) { 
                var role = (DataRow) txtRole.Tag;
                
                if(role!=null)
                {
                    int roleId = (int)role["RoleId"];
                    serviceCatJob.Roleid = roleId;
                    if (scatPresenter.Update(serviceCatJob)) {
                        ISE.Framework.Client.Win.Viewer.MessageViewer.ShowMessage(ISE.Framework.Client.Win.Viewer.OperationType.Update);
                        this.ParentForm.Close();
                    }
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
