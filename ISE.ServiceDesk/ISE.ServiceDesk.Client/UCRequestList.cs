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
using ISE.ServiceDesk.Client.Entry;
using ISE.ClassLibrary;
using ISE.ServiceDesk.Client.View;
using ISE.ServiceDesk.Common.DTO;
using ISE.Framework.Utility.Utils;
using ISE.ServiceDesk.Common.Enum;
namespace ISE.ServiceDesk.Client
{
    public partial class UCRequestList : IUserControl
    {
        UserRequestView myView = new UserRequestView();
        UserInformation userInfo;
        BindingList<SdUserRequestDto> userReqBlist = new BindingList<SdUserRequestDto>();
        BindingSource userReqBs = new BindingSource();
        public UCRequestList(UserInformation info)
        {
            InitializeComponent();
            userInfo = info;
            ISE.UILibrary.Utils.GridEXUtils.SetingGrid(this.iGridEX1, true, false);
            
            LoadData();
           // MessageBox.Show(info.ActionId.ToString());
        }

        private void LoadData()
        {
            SdRequestStateDto all = new SdRequestStateDto()
            {
                StateTitle="همه",
                SdReqStateId=-1
            };
            var stateList = myView.bPresenter.GetStateList();
            stateList.Add(all);
            cmbState.DataSource = stateList;
            cmbState.DisplayMember = AssemblyReflector.GetMemberName((SdRequestStateDto c) => c.StateTitle);
            cmbState.ValueMember = AssemblyReflector.GetMemberName((SdRequestStateDto c) => c.SdReqStateId);
            LoadUserRequests();
        }

        private void LoadUserRequests(int currentState=-1,DateTime? date=null)
        {
            var requests = myView.presenter.LoadUserRequest(userInfo.PerId);
            userReqBlist.Clear();
            foreach (var item in requests)
            {
                if (item.CurrentState != null && item.CurrentState.SdReqStateId != (int)RquestState.NoCreated)
                {
                    bool added = true;
                    if (currentState >= 0 || date != null)
                    {
                        added = false;
                        if (currentState >= 0 && item.CurrentState != null && item.CurrentState.SdReqStateId == currentState)
                            added = true;
                        if (date != null && item.Createdate.HasValue && item.Createdate.Value.Date == date.Value.Date)
                            added = true;
                    }

                    if (added)
                        userReqBlist.Add(item);
                    
                }
               
            }
            userReqBs.DataSource = userReqBlist;
            iGridEX1.DataSource = userReqBs;
        }

        private void btnNewReq_Click(object sender, EventArgs e)
        {
            UCRequestEntry frm = new UCRequestEntry(userInfo);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "ایجاد درخواست", FormBorderStyle.Sizable);
        }

        private void iGridEX1_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            var dataRow = (SdUserRequestDto)iGridEX1.CurrentRow.DataRow;
            if (dataRow != null)
            {
                UCUserRequestView frm = new UCUserRequestView(TransMode.ViewRecord, dataRow, userInfo);
                ISE.UILibrary.Utils.UIUtils.SetFrmTrans(frm, "اطلاعات درخواست", FormBorderStyle.Sizable);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var item =(SdRequestStateDto) cmbState.SelectedItem;
            DateTime? dt = null;
            if (!dtpFrom.IsNull)
                dt = dtpFrom.Value;
            LoadUserRequests(item.SdReqStateId, dt);
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
