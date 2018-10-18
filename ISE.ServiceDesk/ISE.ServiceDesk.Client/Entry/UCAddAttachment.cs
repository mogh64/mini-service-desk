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
using ISE.ServiceDesk.Common.DTO;
using System.IO;

namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCAddAttachment : IUserControl
    {
        SdRequestAttachmentDto attachment = new SdRequestAttachmentDto();
        public UCAddAttachment()
        {
            InitializeComponent();
        }
        public DialogResult Result = DialogResult.None;
        private void btnOk_Click(object sender, EventArgs e)
        {
            attachment.Description = txtDesc.Text;

            this.ParentForm.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            txtFileName.Text = openFileDialog1.FileName;
            if (File.Exists(txtFileName.Text))
            {
                attachment.Content = File.ReadAllBytes(txtFileName.Text);
            }
            else
            {
                ISE.Framework.Client.Win.Viewer.MessageViewer.ShowException("فایل وجود ندارد!");
                return;
            }
            var file = openFileDialog1.FileName.Split('\\').LastOrDefault();
            attachment.Filename = file.Split('.')[0];
            attachment.Filetype = file.Split('.')[1];
            Result = DialogResult.OK;
            
        }
        public SdRequestAttachmentDto AttachmentFile
        {
            get
            {
                if (Result == DialogResult.OK)
                    return attachment;
                return null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.ParentForm.Close();
        }
    }
}
