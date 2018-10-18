using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ISE.UILibrary;
using ISE.Framework.Client.Win.Selector;
using ISE.ServiceDesk.Common.DTO;
using ISE.Framework.Utility.Utils;
using ISE.ServiceDesk.Client.Common.Presenter;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCExperts : IUserControl
    {
        BindingSource exBs = new BindingSource();
        BindingList<SdItExpertDto> expBList;

        BindingSource roleBs = new BindingSource();
        BindingList<SdItRoleDto> roleBList;

        BindingSource roleExpertBs = new BindingSource();
        BindingList<SdItRoleExpertDto> roleExpertBList;
        OfficePresenter officePresenter = new OfficePresenter();
        public UCExperts()
        {
            InitializeComponent();
            expBList = new BindingList<SdItExpertDto>();
            exBs.DataSource = expBList;
            iGridExperts.DataSource = exBs;
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.iGridExperts, true, false);
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.iGridRoles, true, false);
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.igridPersonToRole, true, false);
        }
        public UCItemListSelect<VwPersonelDto> ucExpertSelect { get; set; }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id =  cmbOffices.SelectedIndex+1;
            OfficePresenter presenter = new OfficePresenter();
            var container = presenter.GetOfficeDetails(id);
            expBList = new BindingList<SdItExpertDto>(container.ExpertList);
            roleBList = new BindingList<SdItRoleDto>(container.RoleList);
            exBs.DataSource = expBList;
            iGridExperts.DataSource = exBs;
            roleBs.DataSource = roleBList;
            iGridRoles.DataSource = roleBs;
        }

        private void iGridToolBar1_NewRecord(object sender, EventArgs e)
        {
            BaseDataServicePresenter presenter = new BaseDataServicePresenter();
            
            var personels = presenter.getPersonelListByInd(22852); // چارت مدیریت آی تی


            ucExpertSelect = new UCItemListSelect<VwPersonelDto>(personels);
            List<ColumnDescriptor> column = new List<ColumnDescriptor>();
            column.Add(new ColumnDescriptor() { Name = AssemblyReflector.GetMemberName((VwPersonelDto m) => m.PerNo), Caption = "شماره پرسنلی " });
            column.Add(new ColumnDescriptor() { Name = AssemblyReflector.GetMemberName((VwPersonelDto m) => m.NationalNo), Caption = "کد ملی " });
            column.Add(new ColumnDescriptor() { Name = AssemblyReflector.GetMemberName((VwPersonelDto m) => m.PerFname), Caption = "نام " });
            column.Add(new ColumnDescriptor() { Name = AssemblyReflector.GetMemberName((VwPersonelDto m) => m.PerLname), Caption = "نام خانوادگی " });

            ucExpertSelect.AddColumnDescriptor(column);
            
            
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(ucExpertSelect, "فرم انتخاب کارشناس", FormBorderStyle.FixedDialog);
            if (ucExpertSelect.HasSelected)
            {
                var selected = ucExpertSelect.SelectedItems.FirstOrDefault();
                SdItExpertDto expert = new SdItExpertDto()
                {
                    Officeid = cmbOffices.SelectedIndex+1,
                    Userid = selected.PerId,
                    Personel= selected,
                    IsEnabled = true
                };
                if(officePresenter.AddExpert(expert))
                   expBList.Add(expert);
            }
        }

        private void iGridToolBar2_NewRecord(object sender, EventArgs e)
        {
            UCRoleEntry frm = new UCRoleEntry(cmbOffices.SelectedIndex + 1, ClassLibrary.TransMode.NewRecord, roleBs);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "فرم گروه های کاری", FormBorderStyle.FixedDialog);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            ItRolePresenter rolePresenter = new ItRolePresenter();

            var role = (SdItRoleDto)this.iGridRoles.CurrentRow.DataRow;
            var expert = (SdItExpertDto)this.iGridExperts.CurrentRow.DataRow;
            if (role != null && expert != null)
            {
                UCWeight frm = new UCWeight();
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "وزن انجام کار", FormBorderStyle.FixedDialog);
                if (frm.DialogResult != DialogResult.OK)
                    return;
                SdItRoleExpertDto roleExpert = new SdItRoleExpertDto()
                {
                    Weight = frm.Weight,
                    Itroleid = role.RoleId,
                    Expertid = expert.ItExpertId,
                    Role = role,
                    Expert = expert,
                    Personel = expert.Personel
                };
               if( rolePresenter.AddRoleExpert(roleExpert)!=null)
               {
                   roleExpertBs.Add(roleExpert);
               }
            }
            
        }

        private void iGridRoles_SelectionChanged(object sender, EventArgs e)
        {
            ItRolePresenter rolePresenter = new ItRolePresenter();
            var row = (SdItRoleDto)this.iGridRoles.CurrentRow.DataRow;
            if (row != null)
            {
                var roleExperts = rolePresenter.GetRoleExperts(row.RoleId);
                roleExpertBList = new BindingList<SdItRoleExpertDto>(roleExperts);
                roleExpertBs.DataSource = roleExpertBList;
                this.igridPersonToRole.DataSource = roleExpertBs;
            }
        }

        private void iGridToolBar2_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = (SdItRoleExpertDto) this.igridPersonToRole.CurrentRow.DataRow;
            if (row != null)
            {
                ItRolePresenter rolePresenter = new ItRolePresenter();
                if( rolePresenter.RemoveRoleExpert(row))
                {
                    roleExpertBs.Remove(row);
                }
            }
        }

        private void btnChangeweight_Click(object sender, EventArgs e)
        {
            var row = (SdItRoleExpertDto)this.igridPersonToRole.CurrentRow.DataRow;
            if (row != null)
            {
                UCWeight frm = new UCWeight(row.Weight.Value);
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "وزن انجام کار", FormBorderStyle.FixedDialog);
                if (frm.DialogResult != DialogResult.OK)
                    return;
                row.Weight = frm.Weight;
                ItRolePresenter rolePresenter = new ItRolePresenter();
                if(rolePresenter.UpdateRoleExpert(row))
                {
                    roleExpertBs.EndEdit();
                    roleExpertBs.ResetBindings(false);
                }

            }
        }

        private void iGridToolBar1_EditRecord(object sender, EventArgs e)
        {
            var expert = (SdItExpertDto)this.iGridExperts.CurrentRow.DataRow;
            UCExpertEdit frm = new UCExpertEdit(expert);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "ویرایش کارشناس", FormBorderStyle.FixedDialog);
            if (frm.Result)
            {
                expBList.ResetBindings();
            }
        }

        private void iGridToolBar1_DeleteRecord(object sender, EventArgs e)
        {
            var expert = (SdItExpertDto)this.iGridExperts.CurrentRow.DataRow;
            if (officePresenter.RemoveExpert(expert))
            {
                exBs.Remove(expert);
            }
        }

    }
}
