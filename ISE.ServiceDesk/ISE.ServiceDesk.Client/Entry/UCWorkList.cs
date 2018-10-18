using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ISE.UILibrary;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Common.DTO;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCWorkList : IUserControl
    {
        int serviceCategoryId;
        BindingList<SdWorkDto> bList;
        BindingSource Bs = new BindingSource();
        public UCWorkList(int serviceCategoryId)
        {
            InitializeComponent();
            this.serviceCategoryId = serviceCategoryId;
            LoadWorks();
            
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.iGridEX1, true, false);
        }

        private void LoadWorks()
        {
            BaseDataServicePresenter presenter = new BaseDataServicePresenter();
            var works =  presenter.GetWorkList(serviceCategoryId, false);
            bList = new BindingList<SdWorkDto>(works);
            Bs.DataSource = bList;
            iGridEX1.DataSource = Bs;
        }

        private void iGridToolBar1_NewRecord(object sender, EventArgs e)
        {
            UCWorkEntry entry = new UCWorkEntry(serviceCategoryId, ClassLibrary.TransMode.NewRecord,Bs);

            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(entry, "تعریف کار", FormBorderStyle.Sizable);
        }

        private void iGridToolBar1_EditRecord(object sender, EventArgs e)
        {
            SdWorkDto work = (SdWorkDto)this.iGridEX1.CurrentRow.DataRow;
            if (work != null)
            {
                UCWorkEntry entry = new UCWorkEntry(work, ClassLibrary.TransMode.EditRecord,Bs);

                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(entry, "تعریف کار", FormBorderStyle.Sizable);
            }
           
        }

        private void iGridToolBar1_DeleteRecord(object sender, EventArgs e)
        {
            SdWorkDto work = (SdWorkDto)this.iGridEX1.CurrentRow.DataRow;
            if (work != null)
            {
                WorkPresenter presenter = new WorkPresenter();
                if (presenter.Remove(work))
                {
                    Bs.Remove(work);
                }
            }
        }

        private void iGridToolBar1_Close(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

      
    }
}
