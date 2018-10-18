namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCRequestEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRequestEntry));
            Janus.Windows.GridEX.GridEXLayout igridAtch_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.iGroupBox2 = new ISE.UILibrary.IGroupBox();
            this.dtpDate = new ISE.UILibrary.IDateTimePicker();
            this.iLabel2 = new ISE.UILibrary.ILabel();
            this.txtRequester = new ISE.UILibrary.ITextBox();
            this.iLabel1 = new ISE.UILibrary.ILabel();
            this.iGroupBox3 = new ISE.UILibrary.IGroupBox();
            this.lstJobs = new ISE.UILibrary.IListBox();
            this.treeServices = new ISE.UILibrary.ITreeView();
            this.grpOwner = new ISE.UILibrary.IGroupBox();
            this.btnViewWorks = new ISE.UILibrary.IButton();
            this.btnSelectOwner = new ISE.UILibrary.IButton();
            this.txtOwnername = new ISE.UILibrary.ITextBox();
            this.iLabel3 = new ISE.UILibrary.ILabel();
            this.grpDeviceList = new ISE.UILibrary.IGroupBox();
            this.igridDeviceList = new ISE.UILibrary.IGridEX();
            this.grpAttachments = new ISE.UILibrary.IGroupBox();
            this.btnMInAtc = new ISE.UILibrary.IButton();
            this.igridAtch = new ISE.UILibrary.IGridEX();
            this.btnSelectAttch = new ISE.UILibrary.IButton();
            this.btnCreateRequest = new ISE.UILibrary.IButton();
            this.txtDescription = new ISE.UILibrary.ITextBox();
            this.iLabel9 = new ISE.UILibrary.ILabel();
            this.btnSelectMenu = new ISE.UILibrary.IButton();
            this.txtMenu = new ISE.UILibrary.ITextBox();
            this.iLabel8 = new ISE.UILibrary.ILabel();
            this.dtpCreditDate = new ISE.UILibrary.IDateTimePicker();
            this.iLabel6 = new ISE.UILibrary.ILabel();
            this.txtContact = new ISE.UILibrary.ITextBox();
            this.iLabel4 = new ISE.UILibrary.ILabel();
            this.iGroupBox1.SuspendLayout();
            this.iGroupBox2.SuspendLayout();
            this.iGroupBox3.SuspendLayout();
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
            this.iGroupBox1.Size = new System.Drawing.Size(1060, 790);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "ایجاد درخواست";
            // 
            // iGroupBox2
            // 
            this.iGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox2.Controls.Add(this.dtpDate);
            this.iGroupBox2.Controls.Add(this.iLabel2);
            this.iGroupBox2.Controls.Add(this.txtRequester);
            this.iGroupBox2.Controls.Add(this.iLabel1);
            this.iGroupBox2.Location = new System.Drawing.Point(6, 20);
            this.iGroupBox2.Name = "iGroupBox2";
            this.iGroupBox2.Size = new System.Drawing.Size(1048, 36);
            this.iGroupBox2.TabIndex = 5;
            this.iGroupBox2.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(534, 12);
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
            this.iLabel2.Location = new System.Drawing.Point(727, 19);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(28, 13);
            this.iLabel2.TabIndex = 2;
            this.iLabel2.Text = "تاریخ";
            // 
            // txtRequester
            // 
            this.txtRequester.Location = new System.Drawing.Point(810, 12);
            this.txtRequester.Name = "txtRequester";
            this.txtRequester.ReadOnly = true;
            this.txtRequester.Size = new System.Drawing.Size(152, 21);
            this.txtRequester.TabIndex = 1;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Location = new System.Drawing.Point(968, 17);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(79, 13);
            this.iLabel1.TabIndex = 0;
            this.iLabel1.Text = "درخواست کننده";
            // 
            // iGroupBox3
            // 
            this.iGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox3.Controls.Add(this.lstJobs);
            this.iGroupBox3.Controls.Add(this.treeServices);
            this.iGroupBox3.Location = new System.Drawing.Point(6, 62);
            this.iGroupBox3.Name = "iGroupBox3";
            this.iGroupBox3.Size = new System.Drawing.Size(1048, 280);
            this.iGroupBox3.TabIndex = 4;
            this.iGroupBox3.TabStop = false;
            this.iGroupBox3.Text = "خدمات";
            // 
            // lstJobs
            // 
            this.lstJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.Location = new System.Drawing.Point(60, 27);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(451, 251);
            this.lstJobs.TabIndex = 1;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.lstJobs_SelectedIndexChanged);
            // 
            // treeServices
            // 
            this.treeServices.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeServices.FullRowSelect = true;
            this.treeServices.HideSelection = false;
            this.treeServices.Location = new System.Drawing.Point(517, 25);
            this.treeServices.Name = "treeServices";
            this.treeServices.Size = new System.Drawing.Size(523, 253);
            this.treeServices.TabIndex = 0;
            this.treeServices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServices_AfterSelect);
            // 
            // grpOwner
            // 
            this.grpOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOwner.Controls.Add(this.btnViewWorks);
            this.grpOwner.Controls.Add(this.btnSelectOwner);
            this.grpOwner.Controls.Add(this.txtOwnername);
            this.grpOwner.Controls.Add(this.iLabel3);
            this.grpOwner.Controls.Add(this.grpDeviceList);
            this.grpOwner.Controls.Add(this.grpAttachments);
            this.grpOwner.Controls.Add(this.btnCreateRequest);
            this.grpOwner.Controls.Add(this.txtDescription);
            this.grpOwner.Controls.Add(this.iLabel9);
            this.grpOwner.Controls.Add(this.btnSelectMenu);
            this.grpOwner.Controls.Add(this.txtMenu);
            this.grpOwner.Controls.Add(this.iLabel8);
            this.grpOwner.Controls.Add(this.dtpCreditDate);
            this.grpOwner.Controls.Add(this.iLabel6);
            this.grpOwner.Controls.Add(this.txtContact);
            this.grpOwner.Controls.Add(this.iLabel4);
            this.grpOwner.Location = new System.Drawing.Point(6, 344);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(1048, 449);
            this.grpOwner.TabIndex = 3;
            this.grpOwner.TabStop = false;
            this.grpOwner.Text = "اطلاعات درخواست";
            // 
            // btnViewWorks
            // 
            this.btnViewWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewWorks.Location = new System.Drawing.Point(633, 410);
            this.btnViewWorks.Name = "btnViewWorks";
            this.btnViewWorks.Size = new System.Drawing.Size(194, 37);
            this.btnViewWorks.TabIndex = 32;
            this.btnViewWorks.Text = "مشاهده کارهای انجام شده";
            this.btnViewWorks.UseVisualStyleBackColor = true;
            this.btnViewWorks.Visible = false;
            this.btnViewWorks.Click += new System.EventHandler(this.btnViewWorks_Click);
            // 
            // btnSelectOwner
            // 
            this.btnSelectOwner.Location = new System.Drawing.Point(705, 168);
            this.btnSelectOwner.Name = "btnSelectOwner";
            this.btnSelectOwner.Size = new System.Drawing.Size(47, 23);
            this.btnSelectOwner.TabIndex = 31;
            this.btnSelectOwner.Text = "...";
            this.btnSelectOwner.UseVisualStyleBackColor = true;
            this.btnSelectOwner.Click += new System.EventHandler(this.btnSelectOwner_Click);
            // 
            // txtOwnername
            // 
            this.txtOwnername.BackColor = System.Drawing.SystemColors.Window;
            this.txtOwnername.Location = new System.Drawing.Point(776, 168);
            this.txtOwnername.Mandatory = true;
            this.txtOwnername.Name = "txtOwnername";
            this.txtOwnername.ReadOnly = true;
            this.txtOwnername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOwnername.Size = new System.Drawing.Size(150, 21);
            this.txtOwnername.TabIndex = 30;
            this.txtOwnername.TextChanged += new System.EventHandler(this.txtOwnername_TextChanged);
            // 
            // iLabel3
            // 
            this.iLabel3.AutoSize = true;
            this.iLabel3.Location = new System.Drawing.Point(932, 173);
            this.iLabel3.Name = "iLabel3";
            this.iLabel3.Size = new System.Drawing.Size(110, 13);
            this.iLabel3.TabIndex = 29;
            this.iLabel3.Text = "انتخاب مالک درخواست";
            // 
            // grpDeviceList
            // 
            this.grpDeviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDeviceList.Controls.Add(this.igridDeviceList);
            this.grpDeviceList.Location = new System.Drawing.Point(50, 195);
            this.grpDeviceList.Name = "grpDeviceList";
            this.grpDeviceList.Size = new System.Drawing.Size(985, 215);
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
            this.igridDeviceList.Size = new System.Drawing.Size(973, 189);
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
            this.grpAttachments.Location = new System.Drawing.Point(50, 15);
            this.grpAttachments.Name = "grpAttachments";
            this.grpAttachments.Size = new System.Drawing.Size(566, 183);
            this.grpAttachments.TabIndex = 27;
            this.grpAttachments.TabStop = false;
            this.grpAttachments.Text = "ضمائم";
            // 
            // btnMInAtc
            // 
            this.btnMInAtc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMInAtc.Location = new System.Drawing.Point(456, 156);
            this.btnMInAtc.Name = "btnMInAtc";
            this.btnMInAtc.Size = new System.Drawing.Size(47, 23);
            this.btnMInAtc.TabIndex = 25;
            this.btnMInAtc.Text = "-";
            this.btnMInAtc.UseVisualStyleBackColor = true;
            this.btnMInAtc.Click += new System.EventHandler(this.btnMInAtc_Click_1);
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
            this.igridAtch.Size = new System.Drawing.Size(546, 135);
            this.igridAtch.TabIndex = 24;
            this.igridAtch.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.igridAtch_RowDoubleClick);
            // 
            // btnSelectAttch
            // 
            this.btnSelectAttch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAttch.Location = new System.Drawing.Point(509, 156);
            this.btnSelectAttch.Name = "btnSelectAttch";
            this.btnSelectAttch.Size = new System.Drawing.Size(47, 23);
            this.btnSelectAttch.TabIndex = 23;
            this.btnSelectAttch.Text = "+";
            this.btnSelectAttch.UseVisualStyleBackColor = true;
            this.btnSelectAttch.Click += new System.EventHandler(this.btnSelectAttch_Click_1);
            // 
            // btnCreateRequest
            // 
            this.btnCreateRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateRequest.Location = new System.Drawing.Point(833, 410);
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(194, 37);
            this.btnCreateRequest.TabIndex = 18;
            this.btnCreateRequest.Text = "ثبت درخواست";
            this.btnCreateRequest.UseVisualStyleBackColor = true;
            this.btnCreateRequest.Click += new System.EventHandler(this.btnCreateRequest_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(622, 15);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(306, 48);
            this.txtDescription.TabIndex = 17;
            // 
            // iLabel9
            // 
            this.iLabel9.AutoSize = true;
            this.iLabel9.Location = new System.Drawing.Point(983, 44);
            this.iLabel9.Name = "iLabel9";
            this.iLabel9.Size = new System.Drawing.Size(47, 13);
            this.iLabel9.TabIndex = 16;
            this.iLabel9.Text = "توضیحات";
            // 
            // btnSelectMenu
            // 
            this.btnSelectMenu.Location = new System.Drawing.Point(705, 99);
            this.btnSelectMenu.Name = "btnSelectMenu";
            this.btnSelectMenu.Size = new System.Drawing.Size(47, 23);
            this.btnSelectMenu.TabIndex = 15;
            this.btnSelectMenu.Text = "...";
            this.btnSelectMenu.UseVisualStyleBackColor = true;
            this.btnSelectMenu.Visible = false;
            this.btnSelectMenu.Click += new System.EventHandler(this.btnSelectMenu_Click);
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(776, 96);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMenu.Size = new System.Drawing.Size(150, 21);
            this.txtMenu.TabIndex = 14;
            this.txtMenu.Visible = false;
            // 
            // iLabel8
            // 
            this.iLabel8.AutoSize = true;
            this.iLabel8.Location = new System.Drawing.Point(976, 104);
            this.iLabel8.Name = "iLabel8";
            this.iLabel8.Size = new System.Drawing.Size(54, 13);
            this.iLabel8.TabIndex = 13;
            this.iLabel8.Text = "انتخاب منو";
            this.iLabel8.Visible = false;
            // 
            // dtpCreditDate
            // 
            this.dtpCreditDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCreditDate.Location = new System.Drawing.Point(776, 69);
            this.dtpCreditDate.Name = "dtpCreditDate";
            this.dtpCreditDate.Size = new System.Drawing.Size(152, 20);
            this.dtpCreditDate.TabIndex = 9;
            this.dtpCreditDate.Text = "[هیج مقداری انتخاب نشده]";
            this.dtpCreditDate.Value = new System.DateTime(((long)(0)));
            // 
            // iLabel6
            // 
            this.iLabel6.AutoSize = true;
            this.iLabel6.Location = new System.Drawing.Point(974, 82);
            this.iLabel6.Name = "iLabel6";
            this.iLabel6.Size = new System.Drawing.Size(56, 13);
            this.iLabel6.TabIndex = 8;
            this.iLabel6.Text = "تاریخ اعتبار";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Window;
            this.txtContact.Location = new System.Drawing.Point(776, 127);
            this.txtContact.Mandatory = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContact.Size = new System.Drawing.Size(150, 21);
            this.txtContact.TabIndex = 4;
            // 
            // iLabel4
            // 
            this.iLabel4.AutoSize = true;
            this.iLabel4.Location = new System.Drawing.Point(957, 135);
            this.iLabel4.Name = "iLabel4";
            this.iLabel4.Size = new System.Drawing.Size(73, 13);
            this.iLabel4.TabIndex = 3;
            this.iLabel4.Text = "اطلاعات تماس";
            // 
            // UCRequestEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCRequestEntry";
            this.Size = new System.Drawing.Size(1066, 796);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox2.ResumeLayout(false);
            this.iGroupBox2.PerformLayout();
            this.iGroupBox3.ResumeLayout(false);
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
        private UILibrary.IGroupBox grpOwner;
        private UILibrary.IButton btnCreateRequest;
        private UILibrary.ITextBox txtDescription;
        private UILibrary.ILabel iLabel9;
        private UILibrary.IButton btnSelectMenu;
        private UILibrary.ITextBox txtMenu;
        private UILibrary.ILabel iLabel8;
        private UILibrary.IDateTimePicker dtpCreditDate;
        private UILibrary.ILabel iLabel6;
        private UILibrary.ITextBox txtContact;
        private UILibrary.ILabel iLabel4;
        private UILibrary.IGroupBox iGroupBox3;
        private UILibrary.IListBox lstJobs;
        private UILibrary.ITreeView treeServices;
        private UILibrary.IGroupBox iGroupBox2;
        private UILibrary.IDateTimePicker dtpDate;
        private UILibrary.ILabel iLabel2;
        private UILibrary.ITextBox txtRequester;
        private UILibrary.ILabel iLabel1;
        private UILibrary.IGroupBox grpAttachments;
        private UILibrary.IButton btnMInAtc;
        private UILibrary.IGridEX igridAtch;
        private UILibrary.IButton btnSelectAttch;
        private UILibrary.IGroupBox grpDeviceList;
        private UILibrary.IGridEX igridDeviceList;
        private UILibrary.IButton btnSelectOwner;
        private UILibrary.ITextBox txtOwnername;
        private UILibrary.ILabel iLabel3;
        private UILibrary.IButton btnViewWorks;
    }
}
