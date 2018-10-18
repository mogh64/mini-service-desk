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
using ISE.ClassLibrary;
using ISE.ServiceDesk.Client.Common.Presenter;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCWorkEntry : IUserControl
    {
        SdWorkDto work;
        TransMode mode;
        WorkPresenter presenter = new WorkPresenter();
        BindingSource Bs;
        int serviceCatId;
        public UCWorkEntry(SdWorkDto work,TransMode mode,BindingSource bsource)
        {
            this.Bs = bsource;
            this.work = work;
            this.mode = mode;
         
            InitializeComponent();
            if (mode != TransMode.NewRecord)
            {
                txtTitle.Text = work.Title;
                txtTime.Text = work.EstimateTime.ToString();
                
            }
        }
        public UCWorkEntry(int serviceCategoryId, TransMode mode, BindingSource bsource)
        {
            this.serviceCatId = serviceCategoryId;
            this.Bs = bsource;
            
            this.mode = mode;
            InitializeComponent();
            if (mode == TransMode.NewRecord)
            {
                txtTitle.Text =string.Empty;
                txtTime.Text = string.Empty;
                
            }
        }
        public SdWorkDto ResultWork { get { return this.work; } }
     
        private void iTransToolBar1_SaveRecord(object sender, EventArgs e)
        {
            if (mode == TransMode.EditRecord)
            {
                work.Title = txtTitle.Text;
                int n = 0;
                
                int.TryParse(txtTime.Text, out n);
                work.EstimateTime = n;
                presenter.Update(work);
                Bs.EndEdit();
                Bs.ResetBindings(false);
            }
            if (mode == TransMode.NewRecord)
            {
                work = new SdWorkDto();
                work.Title = txtTitle.Text;
                work.SdServiceCatId = serviceCatId;
                int n = 0;
                
                int.TryParse(txtTime.Text, out n);
                work.EstimateTime = n;
                presenter.Insert(work);
                Bs.Add(work);
            }
            this.ParentForm.Close();
        }

        private void iTransToolBar1_SaveAndNewRecord(object sender, EventArgs e)
        {
            if (mode == TransMode.EditRecord)
            {
                work.Title = txtTitle.Text;
                int n = 0;
                
                int.TryParse(txtTime.Text, out n);
                work.EstimateTime = n;
                presenter.Update(work);
                Bs.EndEdit();
                
            }
            if (mode == TransMode.NewRecord)
            {
                work = new SdWorkDto();
                work.Title = txtTitle.Text;
                int n = 0;
               
                int.TryParse(txtTime.Text, out n);
                work.EstimateTime = n;
                work.SdServiceCatId = serviceCatId;
                presenter.Insert(work);
                Bs.Add(work);
            }
          
            txtTime.Text = string.Empty;
            txtTitle.Text = string.Empty;
            mode = TransMode.NewRecord;
            work = null;
        }

        private void iTransToolBar1_Close(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
