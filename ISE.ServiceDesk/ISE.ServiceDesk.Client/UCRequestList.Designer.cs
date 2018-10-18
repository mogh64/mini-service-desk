namespace ISE.ServiceDesk.Client
{
    partial class UCRequestList
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
            Janus.Windows.GridEX.GridEXLayout iGridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRequestList));
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.iGroupBox4 = new ISE.UILibrary.IGroupBox();
            this.iGridEX1 = new ISE.UILibrary.IGridEX();
            this.btnNewReq = new ISE.UILibrary.IButton();
            this.iGroupBox3 = new ISE.UILibrary.IGroupBox();
            this.btnFilter = new ISE.UILibrary.IButton();
            this.iLabel2 = new ISE.UILibrary.ILabel();
            this.iLabel1 = new ISE.UILibrary.ILabel();
            this.dtpFrom = new ISE.UILibrary.IDateTimePicker();
            this.cmbState = new ISE.UILibrary.IComboBox();
            this.iGroupBox1.SuspendLayout();
            this.iGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGridEX1)).BeginInit();
            this.iGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.iGroupBox4);
            this.iGroupBox1.Controls.Add(this.iGroupBox3);
            this.iGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(877, 497);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "فرم درخواست ها";
            // 
            // iGroupBox4
            // 
            this.iGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox4.Controls.Add(this.iGridEX1);
            this.iGroupBox4.Controls.Add(this.btnNewReq);
            this.iGroupBox4.Location = new System.Drawing.Point(3, 130);
            this.iGroupBox4.Name = "iGroupBox4";
            this.iGroupBox4.Size = new System.Drawing.Size(877, 367);
            this.iGroupBox4.TabIndex = 2;
            this.iGroupBox4.TabStop = false;
            this.iGroupBox4.Text = "لیست درخواست ها";
            // 
            // iGridEX1
            // 
            this.iGridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iGridEX1_DesignTimeLayout.LayoutString = resources.GetString("iGridEX1_DesignTimeLayout.LayoutString");
            this.iGridEX1.DesignTimeLayout = iGridEX1_DesignTimeLayout;
            this.iGridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iGridEX1.Location = new System.Drawing.Point(6, 49);
            this.iGridEX1.Name = "iGridEX1";
            this.iGridEX1.Size = new System.Drawing.Size(865, 312);
            this.iGridEX1.TabIndex = 1;
            this.iGridEX1.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.iGridEX1_RowDoubleClick);
            // 
            // btnNewReq
            // 
            this.btnNewReq.Location = new System.Drawing.Point(772, 20);
            this.btnNewReq.Name = "btnNewReq";
            this.btnNewReq.Size = new System.Drawing.Size(99, 23);
            this.btnNewReq.TabIndex = 0;
            this.btnNewReq.Text = "درخواست جدید";
            this.btnNewReq.UseVisualStyleBackColor = true;
            this.btnNewReq.Click += new System.EventHandler(this.btnNewReq_Click);
            // 
            // iGroupBox3
            // 
            this.iGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox3.Controls.Add(this.btnFilter);
            this.iGroupBox3.Controls.Add(this.iLabel2);
            this.iGroupBox3.Controls.Add(this.iLabel1);
            this.iGroupBox3.Controls.Add(this.dtpFrom);
            this.iGroupBox3.Controls.Add(this.cmbState);
            this.iGroupBox3.Location = new System.Drawing.Point(3, 14);
            this.iGroupBox3.Name = "iGroupBox3";
            this.iGroupBox3.Size = new System.Drawing.Size(877, 110);
            this.iGroupBox3.TabIndex = 1;
            this.iGroupBox3.TabStop = false;
            this.iGroupBox3.Text = "فیلتر";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(48, 62);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "فیلتر";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Location = new System.Drawing.Point(474, 38);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(76, 13);
            this.iLabel2.TabIndex = 3;
            this.iLabel2.Text = "تاریخ درخواست";
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Location = new System.Drawing.Point(808, 34);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(41, 13);
            this.iLabel1.TabIndex = 2;
            this.iLabel1.Text = "وضعیت";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Location = new System.Drawing.Point(208, 31);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(231, 20);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Text = "[هیج مقداری انتخاب نشده]";
            this.dtpFrom.Value = new System.DateTime(((long)(0)));
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(655, 31);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 0;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // UCRequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCRequestList";
            this.Size = new System.Drawing.Size(883, 503);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iGridEX1)).EndInit();
            this.iGroupBox3.ResumeLayout(false);
            this.iGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IGroupBox iGroupBox4;
        private UILibrary.IGroupBox iGroupBox3;
        private UILibrary.IGridEX iGridEX1;
        private UILibrary.IButton btnNewReq;
        private UILibrary.IButton btnFilter;
        private UILibrary.ILabel iLabel2;
        private UILibrary.ILabel iLabel1;
        private UILibrary.IDateTimePicker dtpFrom;
        private UILibrary.IComboBox cmbState;
    }
}
