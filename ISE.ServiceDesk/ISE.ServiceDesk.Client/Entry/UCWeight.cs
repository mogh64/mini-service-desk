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
    public partial class UCWeight : IUserControl
    {
        public DialogResult DialogResult { get; set; }
        public UCWeight(int weight=0)
        {
            InitializeComponent();
            txtWeight.Text = weight.ToString();
        }
        public short Weight = 0;
        private void btnOk_Click(object sender, EventArgs e)
        {
           
            short.TryParse(txtWeight.Text, out Weight);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ParentForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ParentForm.Close();
        }
    }
}
