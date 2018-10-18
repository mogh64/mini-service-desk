namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCAssignServiceJob
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
            Janus.Windows.GridEX.GridEXLayout iGridServiceCatJob_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAssignServiceJob));
            Janus.Windows.GridEX.GridEXLayout igridServiceJob_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.btnDelete = new ISE.UILibrary.IButton();
            this.btnSelect = new ISE.UILibrary.IButton();
            this.btnSave = new ISE.UILibrary.IButton();
            this.btnClose = new ISE.UILibrary.IButton();
            this.iGridServiceCatJob = new ISE.UILibrary.IGridEX();
            this.igridServiceJob = new ISE.UILibrary.IGridEX();
            this.iGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGridServiceCatJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igridServiceJob)).BeginInit();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.btnDelete);
            this.iGroupBox1.Controls.Add(this.btnSelect);
            this.iGroupBox1.Controls.Add(this.btnSave);
            this.iGroupBox1.Controls.Add(this.btnClose);
            this.iGroupBox1.Controls.Add(this.iGridServiceCatJob);
            this.iGroupBox1.Controls.Add(this.igridServiceJob);
            this.iGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(821, 526);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "انتساب زیر خدمت";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(634, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(735, 221);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 46);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "انتخاب";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(716, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "ذخیره تغییرات";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(552, 488);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iGridServiceCatJob
            // 
            iGridServiceCatJob_DesignTimeLayout.LayoutString = resources.GetString("iGridServiceCatJob_DesignTimeLayout.LayoutString");
            this.iGridServiceCatJob.DesignTimeLayout = iGridServiceCatJob_DesignTimeLayout;
            this.iGridServiceCatJob.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.iGridServiceCatJob.Location = new System.Drawing.Point(12, 273);
            this.iGridServiceCatJob.Name = "iGridServiceCatJob";
            this.iGridServiceCatJob.Size = new System.Drawing.Size(809, 209);
            this.iGridServiceCatJob.TabIndex = 1;
            this.iGridServiceCatJob.DoubleClick += new System.EventHandler(this.iGridServiceCatJob_DoubleClick);
            // 
            // igridServiceJob
            // 
            this.igridServiceJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            igridServiceJob_DesignTimeLayout.LayoutString = resources.GetString("igridServiceJob_DesignTimeLayout.LayoutString");
            this.igridServiceJob.DesignTimeLayout = igridServiceJob_DesignTimeLayout;
            this.igridServiceJob.Location = new System.Drawing.Point(6, 20);
            this.igridServiceJob.Name = "igridServiceJob";
            this.igridServiceJob.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.igridServiceJob.Size = new System.Drawing.Size(809, 195);
            this.igridServiceJob.TabIndex = 0;
            this.igridServiceJob.SelectionChanged += new System.EventHandler(this.iGridEX1_SelectionChanged);
            // 
            // UCAssignServiceJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCAssignServiceJob";
            this.Size = new System.Drawing.Size(824, 572);
            this.iGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iGridServiceCatJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igridServiceJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IGridEX igridServiceJob;
        private UILibrary.IButton btnSave;
        private UILibrary.IButton btnClose;
        private UILibrary.IGridEX iGridServiceCatJob;
        private UILibrary.IButton btnSelect;
        private UILibrary.IButton btnDelete;
    }
}
