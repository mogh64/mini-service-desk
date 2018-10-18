namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCItServices
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
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.rdServiceJob = new System.Windows.Forms.RadioButton();
            this.rdServiceCat = new System.Windows.Forms.RadioButton();
            this.iGroupBox3 = new ISE.UILibrary.IGroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpJobBtns = new ISE.UILibrary.IGroupBox();
            this.btnAddRole = new ISE.UILibrary.IButton();
            this.btnRemoveJob = new ISE.UILibrary.IButton();
            this.btnAsignToService = new ISE.UILibrary.IButton();
            this.btnEditJob = new ISE.UILibrary.IButton();
            this.btnAddJob = new ISE.UILibrary.IButton();
            this.lstJobs = new ISE.UILibrary.IListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpServiceCatBtns = new ISE.UILibrary.IGroupBox();
            this.btnAddWork = new ISE.UILibrary.IButton();
            this.btnDeleteCat = new ISE.UILibrary.IButton();
            this.btnAssignToJob = new ISE.UILibrary.IButton();
            this.btnAddSubnode = new ISE.UILibrary.IButton();
            this.btnEditService = new ISE.UILibrary.IButton();
            this.btnAddRoot = new ISE.UILibrary.IButton();
            this.treeServices = new ISE.UILibrary.ITreeView();
            this.iGroupBox1.SuspendLayout();
            this.iGroupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpJobBtns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpServiceCatBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.rdServiceJob);
            this.iGroupBox1.Controls.Add(this.rdServiceCat);
            this.iGroupBox1.Controls.Add(this.iGroupBox3);
            this.iGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(1025, 570);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "فرم اطلاعات پایه";
            // 
            // rdServiceJob
            // 
            this.rdServiceJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdServiceJob.AutoSize = true;
            this.rdServiceJob.Location = new System.Drawing.Point(806, 30);
            this.rdServiceJob.Name = "rdServiceJob";
            this.rdServiceJob.Size = new System.Drawing.Size(78, 17);
            this.rdServiceJob.TabIndex = 3;
            this.rdServiceJob.Text = "چه کارهایی";
            this.rdServiceJob.UseVisualStyleBackColor = true;
            this.rdServiceJob.CheckedChanged += new System.EventHandler(this.rdServiceCat_CheckedChanged);
            // 
            // rdServiceCat
            // 
            this.rdServiceCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdServiceCat.AutoSize = true;
            this.rdServiceCat.Checked = true;
            this.rdServiceCat.Location = new System.Drawing.Point(920, 30);
            this.rdServiceCat.Name = "rdServiceCat";
            this.rdServiceCat.Size = new System.Drawing.Size(77, 17);
            this.rdServiceCat.TabIndex = 2;
            this.rdServiceCat.TabStop = true;
            this.rdServiceCat.Text = "چه خدماتی";
            this.rdServiceCat.UseVisualStyleBackColor = true;
            this.rdServiceCat.CheckedChanged += new System.EventHandler(this.rdServiceCat_CheckedChanged);
            // 
            // iGroupBox3
            // 
            this.iGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox3.Controls.Add(this.groupBox2);
            this.iGroupBox3.Controls.Add(this.groupBox1);
            this.iGroupBox3.Location = new System.Drawing.Point(0, 53);
            this.iGroupBox3.Name = "iGroupBox3";
            this.iGroupBox3.Size = new System.Drawing.Size(1022, 511);
            this.iGroupBox3.TabIndex = 1;
            this.iGroupBox3.TabStop = false;
            this.iGroupBox3.Text = "خدمات";
            this.iGroupBox3.Enter += new System.EventHandler(this.iGroupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grpJobBtns);
            this.groupBox2.Controls.Add(this.lstJobs);
            this.groupBox2.Location = new System.Drawing.Point(0, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 474);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // grpJobBtns
            // 
            this.grpJobBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpJobBtns.Controls.Add(this.btnAddRole);
            this.grpJobBtns.Controls.Add(this.btnRemoveJob);
            this.grpJobBtns.Controls.Add(this.btnAsignToService);
            this.grpJobBtns.Controls.Add(this.btnEditJob);
            this.grpJobBtns.Controls.Add(this.btnAddJob);
            this.grpJobBtns.Location = new System.Drawing.Point(0, 19);
            this.grpJobBtns.Name = "grpJobBtns";
            this.grpJobBtns.Size = new System.Drawing.Size(495, 35);
            this.grpJobBtns.TabIndex = 6;
            this.grpJobBtns.TabStop = false;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(420, 9);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(69, 23);
            this.btnAddRole.TabIndex = 10;
            this.btnAddRole.Text = "گروه کاری";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.Location = new System.Drawing.Point(107, 9);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(47, 23);
            this.btnRemoveJob.TabIndex = 8;
            this.btnRemoveJob.Text = "حذف";
            this.btnRemoveJob.UseVisualStyleBackColor = true;
            this.btnRemoveJob.Click += new System.EventHandler(this.btnRemoveJob_Click);
            // 
            // btnAsignToService
            // 
            this.btnAsignToService.Location = new System.Drawing.Point(218, 9);
            this.btnAsignToService.Name = "btnAsignToService";
            this.btnAsignToService.Size = new System.Drawing.Size(95, 23);
            this.btnAsignToService.TabIndex = 9;
            this.btnAsignToService.Text = "انتساب به خدمت";
            this.btnAsignToService.UseVisualStyleBackColor = true;
            this.btnAsignToService.Click += new System.EventHandler(this.btnAsignToService_Click);
            // 
            // btnEditJob
            // 
            this.btnEditJob.Location = new System.Drawing.Point(160, 9);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(52, 23);
            this.btnEditJob.TabIndex = 7;
            this.btnEditJob.Text = "ویرایش";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(319, 9);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(95, 23);
            this.btnAddJob.TabIndex = 6;
            this.btnAddJob.Text = "افزودن زیرخدمت";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // lstJobs
            // 
            this.lstJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.Location = new System.Drawing.Point(6, 73);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(483, 381);
            this.lstJobs.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grpServiceCatBtns);
            this.groupBox1.Controls.Add(this.treeServices);
            this.groupBox1.Location = new System.Drawing.Point(496, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 474);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // grpServiceCatBtns
            // 
            this.grpServiceCatBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpServiceCatBtns.Controls.Add(this.btnAddWork);
            this.grpServiceCatBtns.Controls.Add(this.btnDeleteCat);
            this.grpServiceCatBtns.Controls.Add(this.btnAssignToJob);
            this.grpServiceCatBtns.Controls.Add(this.btnAddSubnode);
            this.grpServiceCatBtns.Controls.Add(this.btnEditService);
            this.grpServiceCatBtns.Controls.Add(this.btnAddRoot);
            this.grpServiceCatBtns.Location = new System.Drawing.Point(4, 20);
            this.grpServiceCatBtns.Name = "grpServiceCatBtns";
            this.grpServiceCatBtns.Size = new System.Drawing.Size(503, 35);
            this.grpServiceCatBtns.TabIndex = 5;
            this.grpServiceCatBtns.TabStop = false;
            // 
            // btnAddWork
            // 
            this.btnAddWork.Location = new System.Drawing.Point(61, 12);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(87, 23);
            this.btnAddWork.TabIndex = 11;
            this.btnAddWork.Text = "لیست کارها";
            this.btnAddWork.UseVisualStyleBackColor = true;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(8, 12);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(47, 23);
            this.btnDeleteCat.TabIndex = 10;
            this.btnDeleteCat.Text = "حذف";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnAssignToJob
            // 
            this.btnAssignToJob.Location = new System.Drawing.Point(154, 12);
            this.btnAssignToJob.Name = "btnAssignToJob";
            this.btnAssignToJob.Size = new System.Drawing.Size(100, 23);
            this.btnAssignToJob.TabIndex = 5;
            this.btnAssignToJob.Text = "انتساب زیر خدمت";
            this.btnAssignToJob.UseVisualStyleBackColor = true;
            this.btnAssignToJob.Click += new System.EventHandler(this.btnAssignToJob_Click);
            // 
            // btnAddSubnode
            // 
            this.btnAddSubnode.Location = new System.Drawing.Point(341, 12);
            this.btnAddSubnode.Name = "btnAddSubnode";
            this.btnAddSubnode.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubnode.TabIndex = 3;
            this.btnAddSubnode.Text = "افزودن زیرنود";
            this.btnAddSubnode.UseVisualStyleBackColor = true;
            this.btnAddSubnode.Click += new System.EventHandler(this.btnAddSubnode_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.Location = new System.Drawing.Point(260, 12);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(75, 23);
            this.btnEditService.TabIndex = 4;
            this.btnEditService.Text = "ویرایش";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(422, 12);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoot.TabIndex = 2;
            this.btnAddRoot.Text = "افزودن ریشه";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
            // 
            // treeServices
            // 
            this.treeServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeServices.HideSelection = false;
            this.treeServices.Location = new System.Drawing.Point(12, 75);
            this.treeServices.Name = "treeServices";
            this.treeServices.Size = new System.Drawing.Size(495, 377);
            this.treeServices.TabIndex = 0;
            this.treeServices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServices_AfterSelect);
            this.treeServices.DoubleClick += new System.EventHandler(this.treeServices_DoubleClick);
            // 
            // UCItServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCItServices";
            this.Size = new System.Drawing.Size(1031, 588);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox1.PerformLayout();
            this.iGroupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpJobBtns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpServiceCatBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IGroupBox iGroupBox3;
        private UILibrary.IListBox lstJobs;
        private UILibrary.ITreeView treeServices;
        private UILibrary.IGroupBox grpServiceCatBtns;
        private UILibrary.IButton btnAddSubnode;
        private UILibrary.IButton btnEditService;
        private UILibrary.IButton btnAddRoot;
        private UILibrary.IGroupBox grpJobBtns;
        private UILibrary.IButton btnEditJob;
        private UILibrary.IButton btnAddJob;
        private UILibrary.IButton btnAssignToJob;
        private UILibrary.IButton btnRemoveJob;
        private UILibrary.IButton btnAsignToService;
        private UILibrary.IButton btnDeleteCat;
        private UILibrary.IButton btnAddWork;
        private UILibrary.IButton btnAddRole;
        private System.Windows.Forms.RadioButton rdServiceJob;
        private System.Windows.Forms.RadioButton rdServiceCat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
