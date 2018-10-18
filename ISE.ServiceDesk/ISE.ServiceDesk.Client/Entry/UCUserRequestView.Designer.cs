namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCUserRequestView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout igridDeviceList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserRequestView));
            Janus.Windows.GridEX.GridEXLayout igridAtch_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.iGroupBox2 = new ISE.UILibrary.IGroupBox();
            this.dtpDate = new ISE.UILibrary.IDateTimePicker();
            this.iLabel2 = new ISE.UILibrary.ILabel();
            this.txtRequester = new ISE.UILibrary.ITextBox();
            this.iLabel1 = new ISE.UILibrary.ILabel();
            this.iGroupBox3 = new ISE.UILibrary.IGroupBox();
            this.btnChangePriority = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownPriority = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalRequest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserRequest = new System.Windows.Forms.TextBox();
            this.grpOwner = new ISE.UILibrary.IGroupBox();
            this.btnViewWorks = new ISE.UILibrary.IButton();
            this.txtOwnername = new ISE.UILibrary.ITextBox();
            this.iLabel3 = new ISE.UILibrary.ILabel();
            this.grpDeviceList = new ISE.UILibrary.IGroupBox();
            this.igridDeviceList = new ISE.UILibrary.IGridEX();
            this.grpAttachments = new ISE.UILibrary.IGroupBox();
            this.btnMInAtc = new ISE.UILibrary.IButton();
            this.igridAtch = new ISE.UILibrary.IGridEX();
            this.btnSelectAttch = new ISE.UILibrary.IButton();
            this.txtDescription = new ISE.UILibrary.ITextBox();
            this.iLabel9 = new ISE.UILibrary.ILabel();
            this.dtpCreditDate = new ISE.UILibrary.IDateTimePicker();
            this.iLabel6 = new ISE.UILibrary.ILabel();
            this.txtContact = new ISE.UILibrary.ITextBox();
            this.iLabel4 = new ISE.UILibrary.ILabel();
            this.iGroupBox1.SuspendLayout();
            this.iGroupBox2.SuspendLayout();
            this.iGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPriority)).BeginInit();
            this.grpOwner.SuspendLayout();
            this.grpDeviceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igridDeviceList)).BeginInit();
            this.grpAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igridAtch)).BeginInit();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.iGroupBox2);
            this.iGroupBox1.Controls.Add(this.iGroupBox3);
            this.iGroupBox1.Controls.Add(this.grpOwner);
            this.iGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(1142, 607);
            this.iGroupBox1.TabIndex = 1;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "مشاهده درخواست";
            // 
            // iGroupBox2
            // 
            this.iGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox2.Controls.Add(this.dtpDate);
            this.iGroupBox2.Controls.Add(this.iLabel2);
            this.iGroupBox2.Controls.Add(this.txtRequester);
            this.iGroupBox2.Controls.Add(this.iLabel1);
            this.iGroupBox2.Location = new System.Drawing.Point(6, 41);
            this.iGroupBox2.Name = "iGroupBox2";
            this.iGroupBox2.Size = new System.Drawing.Size(1130, 36);
            this.iGroupBox2.TabIndex = 8;
            this.iGroupBox2.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(537, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Readonly = true;
            this.dtpDate.Size = new System.Drawing.Size(171, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Text = "[هیج مقداری انتخاب نشده]";
            this.dtpDate.Value = new System.DateTime(((long)(0)));
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Location = new System.Drawing.Point(792, 15);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(28, 13);
            this.iLabel2.TabIndex = 2;
            this.iLabel2.Text = "تاریخ";
            // 
            // txtRequester
            // 
            this.txtRequester.Location = new System.Drawing.Point(839, 12);
            this.txtRequester.Name = "txtRequester";
            this.txtRequester.ReadOnly = true;
            this.txtRequester.Size = new System.Drawing.Size(193, 21);
            this.txtRequester.TabIndex = 1;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Location = new System.Drawing.Point(1050, 17);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(79, 13);
            this.iLabel1.TabIndex = 0;
            this.iLabel1.Text = "درخواست کننده";
            // 
            // iGroupBox3
            // 
            this.iGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox3.Controls.Add(this.btnChangePriority);
            this.iGroupBox3.Controls.Add(this.label1);
            this.iGroupBox3.Controls.Add(this.numUpDownPriority);
            this.iGroupBox3.Controls.Add(this.label5);
            this.iGroupBox3.Controls.Add(this.txtFinalRequest);
            this.iGroupBox3.Controls.Add(this.label4);
            this.iGroupBox3.Controls.Add(this.txtUserRequest);
            this.iGroupBox3.Location = new System.Drawing.Point(6, 83);
            this.iGroupBox3.Name = "iGroupBox3";
            this.iGroupBox3.Size = new System.Drawing.Size(1130, 64);
            this.iGroupBox3.TabIndex = 7;
            this.iGroupBox3.TabStop = false;
            this.iGroupBox3.Text = "خدمات";
            // 
            // btnChangePriority
            // 
            this.btnChangePriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePriority.Location = new System.Drawing.Point(220, 24);
            this.btnChangePriority.Name = "btnChangePriority";
            this.btnChangePriority.Size = new System.Drawing.Size(75, 23);
            this.btnChangePriority.TabIndex = 9;
            this.btnChangePriority.Text = "اعمال تغییر";
            this.btnChangePriority.UseVisualStyleBackColor = true;
            this.btnChangePriority.Visible = false;
            this.btnChangePriority.Click += new System.EventHandler(this.btnChangePriority_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "اولویت";
            // 
            // numUpDownPriority
            // 
            this.numUpDownPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownPriority.Enabled = false;
            this.numUpDownPriority.Location = new System.Drawing.Point(301, 26);
            this.numUpDownPriority.Name = "numUpDownPriority";
            this.numUpDownPriority.ReadOnly = true;
            this.numUpDownPriority.Size = new System.Drawing.Size(86, 21);
            this.numUpDownPriority.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "تشخیص کارشناس";
            // 
            // txtFinalRequest
            // 
            this.txtFinalRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinalRequest.Location = new System.Drawing.Point(514, 26);
            this.txtFinalRequest.Name = "txtFinalRequest";
            this.txtFinalRequest.ReadOnly = true;
            this.txtFinalRequest.Size = new System.Drawing.Size(194, 21);
            this.txtFinalRequest.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1050, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "درخواست کاربر";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserRequest.Location = new System.Drawing.Point(839, 26);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.ReadOnly = true;
            this.txtUserRequest.Size = new System.Drawing.Size(193, 21);
            this.txtUserRequest.TabIndex = 4;
            // 
            // grpOwner
            // 
            this.grpOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOwner.Controls.Add(this.btnViewWorks);
            this.grpOwner.Controls.Add(this.txtOwnername);
            this.grpOwner.Controls.Add(this.iLabel3);
            this.grpOwner.Controls.Add(this.grpDeviceList);
            this.grpOwner.Controls.Add(this.grpAttachments);
            this.grpOwner.Controls.Add(this.txtDescription);
            this.grpOwner.Controls.Add(this.iLabel9);
            this.grpOwner.Controls.Add(this.dtpCreditDate);
            this.grpOwner.Controls.Add(this.iLabel6);
            this.grpOwner.Controls.Add(this.txtContact);
            this.grpOwner.Controls.Add(this.iLabel4);
            this.grpOwner.Location = new System.Drawing.Point(6, 153);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(1130, 448);
            this.grpOwner.TabIndex = 6;
            this.grpOwner.TabStop = false;
            this.grpOwner.Text = "اطلاعات درخواست";
            // 
            // btnViewWorks
            // 
            this.btnViewWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewWorks.Location = new System.Drawing.Point(917, 409);
            this.btnViewWorks.Name = "btnViewWorks";
            this.btnViewWorks.Size = new System.Drawing.Size(194, 37);
            this.btnViewWorks.TabIndex = 32;
            this.btnViewWorks.Text = "مشاهده کارهای انجام شده";
            this.btnViewWorks.UseVisualStyleBackColor = true;
            this.btnViewWorks.Click += new System.EventHandler(this.btnViewWorks_Click);
            // 
            // txtOwnername
            // 
            this.txtOwnername.BackColor = System.Drawing.SystemColors.Window;
            this.txtOwnername.Location = new System.Drawing.Point(882, 158);
            this.txtOwnername.Name = "txtOwnername";
            this.txtOwnername.ReadOnly = true;
            this.txtOwnername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOwnername.Size = new System.Drawing.Size(150, 21);
            this.txtOwnername.TabIndex = 30;
            // 
            // iLabel3
            // 
            this.iLabel3.AutoSize = true;
            this.iLabel3.Location = new System.Drawing.Point(1038, 166);
            this.iLabel3.Name = "iLabel3";
            this.iLabel3.Size = new System.Drawing.Size(81, 13);
            this.iLabel3.TabIndex = 29;
            this.iLabel3.Text = " مالک درخواست";
            // 
            // grpDeviceList
            // 
            this.grpDeviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDeviceList.Controls.Add(this.igridDeviceList);
            this.grpDeviceList.Location = new System.Drawing.Point(50, 220);
            this.grpDeviceList.Name = "grpDeviceList";
            this.grpDeviceList.Size = new System.Drawing.Size(1067, 189);
            this.grpDeviceList.TabIndex = 28;
            this.grpDeviceList.TabStop = false;
            this.grpDeviceList.Text = "تجهیزات";
            // 
            // igridDeviceList
            // 
            this.igridDeviceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            igridDeviceList_DesignTimeLayout.LayoutString = resources.GetString("igridDeviceList_DesignTimeLayout.LayoutString");
            this.igridDeviceList.DesignTimeLayout = igridDeviceList_DesignTimeLayout;
            this.igridDeviceList.Location = new System.Drawing.Point(6, 20);
            this.igridDeviceList.Name = "igridDeviceList";
            this.igridDeviceList.Size = new System.Drawing.Size(1055, 163);
            this.igridDeviceList.TabIndex = 0;
            // 
            // grpAttachments
            // 
            this.grpAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAttachments.Controls.Add(this.btnMInAtc);
            this.grpAttachments.Controls.Add(this.igridAtch);
            this.grpAttachments.Controls.Add(this.btnSelectAttch);
            this.grpAttachments.Location = new System.Drawing.Point(60, 15);
            this.grpAttachments.Name = "grpAttachments";
            this.grpAttachments.Size = new System.Drawing.Size(648, 182);
            this.grpAttachments.TabIndex = 27;
            this.grpAttachments.TabStop = false;
            this.grpAttachments.Text = "ضمائم";
            // 
            // btnMInAtc
            // 
            this.btnMInAtc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMInAtc.Location = new System.Drawing.Point(538, 155);
            this.btnMInAtc.Name = "btnMInAtc";
            this.btnMInAtc.Size = new System.Drawing.Size(47, 23);
            this.btnMInAtc.TabIndex = 25;
            this.btnMInAtc.Text = "-";
            this.btnMInAtc.UseVisualStyleBackColor = true;
            // 
            // igridAtch
            // 
            this.igridAtch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            igridAtch_DesignTimeLayout.LayoutString = resources.GetString("igridAtch_DesignTimeLayout.LayoutString");
            this.igridAtch.DesignTimeLayout = igridAtch_DesignTimeLayout;
            this.igridAtch.Location = new System.Drawing.Point(10, 18);
            this.igridAtch.Name = "igridAtch";
            this.igridAtch.Size = new System.Drawing.Size(628, 134);
            this.igridAtch.TabIndex = 24;
            this.igridAtch.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.igridAtch_RowDoubleClick);
            // 
            // btnSelectAttch
            // 
            this.btnSelectAttch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAttch.Location = new System.Drawing.Point(591, 155);
            this.btnSelectAttch.Name = "btnSelectAttch";
            this.btnSelectAttch.Size = new System.Drawing.Size(47, 23);
            this.btnSelectAttch.TabIndex = 23;
            this.btnSelectAttch.Text = "+";
            this.btnSelectAttch.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(726, 15);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(306, 48);
            this.txtDescription.TabIndex = 17;
            // 
            // iLabel9
            // 
            this.iLabel9.AutoSize = true;
            this.iLabel9.Location = new System.Drawing.Point(1065, 44);
            this.iLabel9.Name = "iLabel9";
            this.iLabel9.Size = new System.Drawing.Size(47, 13);
            this.iLabel9.TabIndex = 16;
            this.iLabel9.Text = "توضیحات";
            // 
            // dtpCreditDate
            // 
            this.dtpCreditDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCreditDate.Enabled = false;
            this.dtpCreditDate.Location = new System.Drawing.Point(880, 75);
            this.dtpCreditDate.Name = "dtpCreditDate";
            this.dtpCreditDate.Readonly = true;
            this.dtpCreditDate.Size = new System.Drawing.Size(152, 20);
            this.dtpCreditDate.TabIndex = 9;
            this.dtpCreditDate.Text = "[هیج مقداری انتخاب نشده]";
            this.dtpCreditDate.Value = new System.DateTime(((long)(0)));
            // 
            // iLabel6
            // 
            this.iLabel6.AutoSize = true;
            this.iLabel6.Location = new System.Drawing.Point(1056, 82);
            this.iLabel6.Name = "iLabel6";
            this.iLabel6.Size = new System.Drawing.Size(56, 13);
            this.iLabel6.TabIndex = 8;
            this.iLabel6.Text = "تاریخ اعتبار";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtContact.Location = new System.Drawing.Point(882, 127);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContact.Size = new System.Drawing.Size(150, 21);
            this.txtContact.TabIndex = 4;
            // 
            // iLabel4
            // 
            this.iLabel4.AutoSize = true;
            this.iLabel4.Location = new System.Drawing.Point(1046, 135);
            this.iLabel4.Name = "iLabel4";
            this.iLabel4.Size = new System.Drawing.Size(73, 13);
            this.iLabel4.TabIndex = 3;
            this.iLabel4.Text = "اطلاعات تماس";
            // 
            // UCUserRequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCUserRequestView";
            this.Size = new System.Drawing.Size(1148, 625);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox2.ResumeLayout(false);
            this.iGroupBox2.PerformLayout();
            this.iGroupBox3.ResumeLayout(false);
            this.iGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPriority)).EndInit();
            this.grpOwner.ResumeLayout(false);
            this.grpOwner.PerformLayout();
            this.grpDeviceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.igridDeviceList)).EndInit();
            this.grpAttachments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.igridAtch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IGroupBox iGroupBox2;
        private UILibrary.IDateTimePicker dtpDate;
        private UILibrary.ILabel iLabel2;
        private UILibrary.ITextBox txtRequester;
        private UILibrary.ILabel iLabel1;
        private UILibrary.IGroupBox iGroupBox3;
        private UILibrary.IGroupBox grpOwner;
        private UILibrary.IButton btnViewWorks;
        private UILibrary.ITextBox txtOwnername;
        private UILibrary.ILabel iLabel3;
        private UILibrary.IGroupBox grpDeviceList;
        private UILibrary.IGridEX igridDeviceList;
        private UILibrary.IGroupBox grpAttachments;
        private UILibrary.IButton btnMInAtc;
        private UILibrary.IGridEX igridAtch;
        private UILibrary.IButton btnSelectAttch;
        private UILibrary.ITextBox txtDescription;
        private UILibrary.ILabel iLabel9;
        private UILibrary.IDateTimePicker dtpCreditDate;
        private UILibrary.ILabel iLabel6;
        private UILibrary.ITextBox txtContact;
        private UILibrary.ILabel iLabel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinalRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownPriority;
        private System.Windows.Forms.Button btnChangePriority;
    }
}
