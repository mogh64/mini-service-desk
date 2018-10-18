using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ISE.UILibrary;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCReports : IUserControl
    {
        public UCReports()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
           switch( cmbReportList.SelectedIndex )
           {             
               case  0: //  گزارش کارکرد کارشناسان

                   break;
               case 1: // درخواست ها به تفکیک هر حوزه

                   break;
               case 2: // تعمیرات تجهیزات و دستگاهها

                   break;
           }
        }
    }
}
