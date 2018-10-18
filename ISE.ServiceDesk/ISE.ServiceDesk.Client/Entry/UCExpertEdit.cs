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

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCExpertEdit : IUserControl
    {
        SdItExpertDto expert;
        public bool Result = false;
        public UCExpertEdit(SdItExpertDto expert)
        {
            this.expert = expert;
            InitializeComponent();
            chkEnabled.Checked = expert.IsEnabled;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            expert.IsEnabled = chkEnabled.Checked;
            OfficePresenter presenter = new OfficePresenter();
            Result = presenter.UpdateExpert(expert);
            this.ParentForm.Close();
        }
    }
}
