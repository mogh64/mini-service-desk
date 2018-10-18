namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCServiceCategory
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
            this.grpDeviceFilter = new ISE.UILibrary.IGroupBox();
            this.txtDeviceFilter = new ISE.UILibrary.ITextBox();
            this.btnMinDevFilter = new ISE.UILibrary.IButton();
            this.btnAddDevFilter = new ISE.UILibrary.IButton();
            this.grpMenuFilter = new ISE.UILibrary.IGroupBox();
            this.btnMinMenuFilter = new ISE.UILibrary.IButton();
            this.btnAddMenuFilter = new ISE.UILibrary.IButton();
            this.igridMenuF = new ISE.UILibrary.IGridEX();
            this.chkHasMenu = new ISE.UILibrary.ICheckBox();
            this.chkHasDevice = new ISE.UILibrary.ICheckBox();
            this.iTransToolBar1 = new ISE.UILibrary.ITransToolBar();
            this.chkHasJob = new ISE.UILibrary.ICheckBox();
            this.chkEnabled = new ISE.UILibrary.ICheckBox();
            this.iLabel2 = new ISE.UILibrary.ILabel();
            this.txtDescription = new ISE.UILibrary.ITextBox();
            this.iLabel1 = new ISE.UILibrary.ILabel();
            this.txtTitle = new ISE.UILibrary.ITextBox();
            this.iGroupBox1.SuspendLayout();
            this.grpDeviceFilter.SuspendLayout();
            this.grpMenuFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igridMenuF)).BeginInit();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.grpDeviceFilter);
            this.iGroupBox1.Controls.Add(this.grpMenuFilter);
            this.iGroupBox1.Controls.Add(this.chkHasMenu);
            this.iGroupBox1.Controls.Add(this.chkHasDevice);
            this.iGroupBox1.Controls.Add(this.iTransToolBar1);
            this.iGroupBox1.Controls.Add(this.chkHasJob);
            this.iGroupBox1.Controls.Add(this.chkEnabled);
            this.iGroupBox1.Controls.Add(this.iLabel2);
            this.iGroupBox1.Controls.Add(this.txtDescription);
            this.iGroupBox1.Controls.Add(this.iLabel1);
            this.iGroupBox1.Controls.Add(this.txtTitle);
            this.iGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(642, 292);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "گروه بندی خدمات";
            // 
            // grpDeviceFilter
            // 
            this.grpDeviceFilter.Controls.Add(this.txtDeviceFilter);
            this.grpDeviceFilter.Controls.Add(this.btnMinDevFilter);
            this.grpDeviceFilter.Controls.Add(this.btnAddDevFilter);
            this.grpDeviceFilter.Location = new System.Drawing.Point(6, 154);
            this.grpDeviceFilter.Name = "grpDeviceFilter";
            this.grpDeviceFilter.Size = new System.Drawing.Size(259, 102);
            this.grpDeviceFilter.TabIndex = 12;
            this.grpDeviceFilter.TabStop = false;
            this.grpDeviceFilter.Text = "فیلتر نوع تجهیزات";
            // 
            // txtDeviceFilter
            // 
            this.txtDeviceFilter.Location = new System.Drawing.Point(19, 39);
            this.txtDeviceFilter.Name = "txtDeviceFilter";
            this.txtDeviceFilter.Size = new System.Drawing.Size(234, 21);
            this.txtDeviceFilter.TabIndex = 5;
            // 
            // btnMinDevFilter
            // 
            this.btnMinDevFilter.Location = new System.Drawing.Point(169, 66);
            this.btnMinDevFilter.Name = "btnMinDevFilter";
            this.btnMinDevFilter.Size = new System.Drawing.Size(39, 25);
            this.btnMinDevFilter.TabIndex = 4;
            this.btnMinDevFilter.Text = "-";
            this.btnMinDevFilter.UseVisualStyleBackColor = true;
            this.btnMinDevFilter.Click += new System.EventHandler(this.btnMinDevFilter_Click);
            // 
            // btnAddDevFilter
            // 
            this.btnAddDevFilter.Location = new System.Drawing.Point(214, 66);
            this.btnAddDevFilter.Name = "btnAddDevFilter";
            this.btnAddDevFilter.Size = new System.Drawing.Size(39, 25);
            this.btnAddDevFilter.TabIndex = 3;
            this.btnAddDevFilter.Text = "+";
            this.btnAddDevFilter.UseVisualStyleBackColor = true;
            this.btnAddDevFilter.Click += new System.EventHandler(this.btnAddDevFilter_Click);
            // 
            // grpMenuFilter
            // 
            this.grpMenuFilter.Controls.Add(this.btnMinMenuFilter);
            this.grpMenuFilter.Controls.Add(this.btnAddMenuFilter);
            this.grpMenuFilter.Controls.Add(this.igridMenuF);
            this.grpMenuFilter.Location = new System.Drawing.Point(6, 10);
            this.grpMenuFilter.Name = "grpMenuFilter";
            this.grpMenuFilter.Size = new System.Drawing.Size(259, 126);
            this.grpMenuFilter.TabIndex = 11;
            this.grpMenuFilter.TabStop = false;
            this.grpMenuFilter.Text = "فیلتر منو";
            // 
            // btnMinMenuFilter
            // 
            this.btnMinMenuFilter.Location = new System.Drawing.Point(168, 97);
            this.btnMinMenuFilter.Name = "btnMinMenuFilter";
            this.btnMinMenuFilter.Size = new System.Drawing.Size(39, 25);
            this.btnMinMenuFilter.TabIndex = 2;
            this.btnMinMenuFilter.Text = "-";
            this.btnMinMenuFilter.UseVisualStyleBackColor = true;
            // 
            // btnAddMenuFilter
            // 
            this.btnAddMenuFilter.Location = new System.Drawing.Point(213, 97);
            this.btnAddMenuFilter.Name = "btnAddMenuFilter";
            this.btnAddMenuFilter.Size = new System.Drawing.Size(39, 25);
            this.btnAddMenuFilter.TabIndex = 1;
            this.btnAddMenuFilter.Text = "+";
            this.btnAddMenuFilter.UseVisualStyleBackColor = true;
            this.btnAddMenuFilter.Click += new System.EventHandler(this.btnAddMenuFilter_Click);
            // 
            // igridMenuF
            // 
            this.igridMenuF.Location = new System.Drawing.Point(6, 15);
            this.igridMenuF.Name = "igridMenuF";
            this.igridMenuF.Size = new System.Drawing.Size(247, 80);
            this.igridMenuF.TabIndex = 0;
            // 
            // chkHasMenu
            // 
            this.chkHasMenu.AutoSize = true;
            this.chkHasMenu.Location = new System.Drawing.Point(323, 163);
            this.chkHasMenu.Name = "chkHasMenu";
            this.chkHasMenu.Size = new System.Drawing.Size(72, 17);
            this.chkHasMenu.TabIndex = 10;
            this.chkHasMenu.Text = "شامل منو";
            this.chkHasMenu.UseVisualStyleBackColor = true;
            this.chkHasMenu.CheckedChanged += new System.EventHandler(this.chkHasMenu_CheckedChanged);
            // 
            // chkHasDevice
            // 
            this.chkHasDevice.AutoSize = true;
            this.chkHasDevice.Location = new System.Drawing.Point(313, 129);
            this.chkHasDevice.Name = "chkHasDevice";
            this.chkHasDevice.Size = new System.Drawing.Size(82, 17);
            this.chkHasDevice.TabIndex = 9;
            this.chkHasDevice.Text = "شامل تجهیز";
            this.chkHasDevice.UseVisualStyleBackColor = true;
            this.chkHasDevice.CheckedChanged += new System.EventHandler(this.chkHasDevice_CheckedChanged);
            // 
            // iTransToolBar1
            // 
            this.iTransToolBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.iTransToolBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iTransToolBar1.Location = new System.Drawing.Point(368, 249);
            this.iTransToolBar1.Name = "iTransToolBar1";
            this.iTransToolBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iTransToolBar1.Size = new System.Drawing.Size(259, 27);
            this.iTransToolBar1.TabIndex = 8;
            this.iTransToolBar1.SaveRecord += new System.EventHandler(this.iTransToolBar1_SaveRecord);
            this.iTransToolBar1.SaveAndNewRecord += new System.EventHandler(this.iTransToolBar1_SaveAndNewRecord);
            this.iTransToolBar1.Close += new System.EventHandler(this.iTransToolBar1_Close);
            // 
            // chkHasJob
            // 
            this.chkHasJob.AutoSize = true;
            this.chkHasJob.Location = new System.Drawing.Point(430, 163);
            this.chkHasJob.Name = "chkHasJob";
            this.chkHasJob.Size = new System.Drawing.Size(102, 17);
            this.chkHasJob.TabIndex = 5;
            this.chkHasJob.Text = "مرتبط با چه کاری";
            this.chkHasJob.UseVisualStyleBackColor = true;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Location = new System.Drawing.Point(485, 129);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(47, 17);
            this.chkEnabled.TabIndex = 4;
            this.chkEnabled.Text = "فعال";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Location = new System.Drawing.Point(583, 68);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(47, 13);
            this.iLabel2.TabIndex = 3;
            this.iLabel2.Text = "توضیحات";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(284, 60);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 47);
            this.txtDescription.TabIndex = 2;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Location = new System.Drawing.Point(597, 32);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(33, 13);
            this.iLabel1.TabIndex = 1;
            this.iLabel1.Text = "عنوان";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(284, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(248, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // UCServiceCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCServiceCategory";
            this.Size = new System.Drawing.Size(648, 298);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox1.PerformLayout();
            this.grpDeviceFilter.ResumeLayout(false);
            this.grpDeviceFilter.PerformLayout();
            this.grpMenuFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.igridMenuF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.ICheckBox chkHasJob;
        private UILibrary.ICheckBox chkEnabled;
        private UILibrary.ILabel iLabel2;
        private UILibrary.ITextBox txtDescription;
        private UILibrary.ILabel iLabel1;
        private UILibrary.ITextBox txtTitle;
        private UILibrary.ITransToolBar iTransToolBar1;
        private UILibrary.IGroupBox grpDeviceFilter;
        private UILibrary.IButton btnMinDevFilter;
        private UILibrary.IButton btnAddDevFilter;
        private UILibrary.IGroupBox grpMenuFilter;
        private UILibrary.IButton btnMinMenuFilter;
        private UILibrary.IButton btnAddMenuFilter;
        private UILibrary.IGridEX igridMenuF;
        private UILibrary.ICheckBox chkHasMenu;
        private UILibrary.ICheckBox chkHasDevice;
        private UILibrary.ITextBox txtDeviceFilter;
    }
}
