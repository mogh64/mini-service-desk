using ISE.ClassLibrary;
using ISE.ServiceDesk.Client;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Client.Entry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE.ServiceDesk.Winfom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       UserInformation info = new UserInformation(1, "userName", "mori", "gh", 4205, 1, false);
        //UserInformation info = new UserInformation(1, "userName", "mori", "gh", 388, 1, false);
        
        private void btnRequests_Click(object sender, EventArgs e)
        {
            ActionIdForm aform = new ActionIdForm();
            if (aform.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            info.ActionId = aform.ActionId;
            UCRequestList frm = new UCRequestList(info);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "درخواست ها", FormBorderStyle.Sizable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCItServices frm = new UCItServices(info);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "اطلاعات پایه", FormBorderStyle.Sizable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCExperts frm = new UCExperts();
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "درخواست ها", FormBorderStyle.Sizable);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaseDataServicePresenter presenrter = new BaseDataServicePresenter();
            var hokm =  presenrter.GetHokm(388);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRoleExpert_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UCReports frm = new UCReports();
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "گزارشات", FormBorderStyle.Sizable);
        }

        private void btnManageRequest_Click(object sender, EventArgs e)
        {
            UCRequestManagement frm = new UCRequestManagement();
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "درخواست ها", FormBorderStyle.Sizable);
        }
    }
}
