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
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Client.Common.Presenter;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCRoleEntry : IUserControl
    {
        BindingSource bs;
        int officeId;
        TransMode mode;
        SdItRoleDto role;
        ItRolePresenter presenter = new ItRolePresenter();
        public UCRoleEntry(SdItRoleDto role, TransMode mode, BindingSource bs)
        {
            InitializeComponent();
            this.bs = bs;
            this.mode = mode;
            
            this.role = role;
            if (mode != TransMode.NewRecord)
            {
                txtTitle.Text = role.Title;
                txtDescription.Text  = role.Description;
            }
        }
        public UCRoleEntry(int officeId,TransMode mode,BindingSource bs)
        {
            this.officeId = officeId;
            InitializeComponent();
            this.bs = bs;
            this.mode = mode;
            
        }

        private void iTransToolBar1_SaveRecord(object sender, EventArgs e)
        {
            if (mode == TransMode.NewRecord)
            {
                SdItRoleDto role = new SdItRoleDto()
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Officeid = officeId
                };
                if (presenter.Insert(role))
                {
                    bs.Add(role);
                }
                
                MakeEmpty();
            }
            if (mode == TransMode.EditRecord)
            {
                role.Title = txtTitle.Text;
                role.Description = txtDescription.Text;
                if (presenter.Update(role))
                {
                    bs.EndEdit();
                    bs.ResetBindings(false);
                }
               
             
            }
            this.ParentForm.Close();
        }

        private void MakeEmpty()
        {
            txtDescription.Text = string.Empty;
            txtTitle.Text = string.Empty;
            mode = TransMode.NewRecord;
        }

        private void iTransToolBar1_Close(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

    }
}
