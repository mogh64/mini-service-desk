namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCRequestWork
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
            Janus.Windows.GridEX.GridEXLayout igridProcessList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRequestWork));
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.iGroupBox3 = new ISE.UILibrary.IGroupBox();
            this.igridProcessList = new ISE.UILibrary.IGridEX();
            this.iGroupBoxNew = new ISE.UILibrary.IGroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangeRequest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinalRequest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserRequest = new System.Windows.Forms.TextBox();
            this.grpCreateWork = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iLabel1 = new ISE.UILibrary.ILabel();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cmbWork = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new ISE.UILibrary.ITextBox();
            this.btnAddWork = new ISE.UILibrary.IButton();
            this.iGroupBox1.SuspendLayout();
            this.iGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igridProcessList)).BeginInit();
            this.iGroupBoxNew.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpCreateWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.iGroupBox3);
            this.iGroupBox1.Controls.Add(this.iGroupBoxNew);
            this.iGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(794, 500);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "کارهای انجام شده بر روی درخواست";
            // 
            // iGroupBox3
            // 
            this.iGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox3.Controls.Add(this.igridProcessList);
            this.iGroupBox3.Location = new System.Drawing.Point(6, 184);
            this.iGroupBox3.Name = "iGroupBox3";
            this.iGroupBox3.Size = new System.Drawing.Size(782, 316);
            this.iGroupBox3.TabIndex = 1;
            this.iGroupBox3.TabStop = false;
            this.iGroupBox3.Text = "لیست کارها";
            // 
            // igridProcessList
            // 
            this.igridProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            igridProcessList_DesignTimeLayout.LayoutString = resources.GetString("igridProcessList_DesignTimeLayout.LayoutString");
            this.igridProcessList.DesignTimeLayout = igridProcessList_DesignTimeLayout;
            this.igridProcessList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.igridProcessList.Location = new System.Drawing.Point(6, 20);
            this.igridProcessList.Name = "igridProcessList";
            this.igridProcessList.Size = new System.Drawing.Size(770, 290);
            this.igridProcessList.TabIndex = 0;
            // 
            // iGroupBoxNew
            // 
            this.iGroupBoxNew.Controls.Add(this.groupBox2);
            this.iGroupBoxNew.Controls.Add(this.grpCreateWork);
            this.iGroupBoxNew.Location = new System.Drawing.Point(6, 20);
            this.iGroupBoxNew.Name = "iGroupBoxNew";
            this.iGroupBoxNew.Size = new System.Drawing.Size(782, 158);
            this.iGroupBoxNew.TabIndex = 0;
            this.iGroupBoxNew.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangeRequest);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFinalRequest);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUserRequest);
            this.groupBox2.Location = new System.Drawing.Point(459, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 138);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "درخواست";
            // 
            // btnChangeRequest
            // 
            this.btnChangeRequest.Location = new System.Drawing.Point(77, 108);
            this.btnChangeRequest.Name = "btnChangeRequest";
            this.btnChangeRequest.Size = new System.Drawing.Size(121, 23);
            this.btnChangeRequest.TabIndex = 4;
            this.btnChangeRequest.Text = "اصلاح درخواست کاربر";
            this.btnChangeRequest.UseVisualStyleBackColor = true;
            this.btnChangeRequest.Click += new System.EventHandler(this.btnChangeRequest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "تشخیص کارشناس";
            // 
            // txtFinalRequest
            // 
            this.txtFinalRequest.Location = new System.Drawing.Point(5, 60);
            this.txtFinalRequest.Name = "txtFinalRequest";
            this.txtFinalRequest.ReadOnly = true;
            this.txtFinalRequest.Size = new System.Drawing.Size(194, 21);
            this.txtFinalRequest.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "درخواست کاربر";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.Location = new System.Drawing.Point(5, 25);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.ReadOnly = true;
            this.txtUserRequest.Size = new System.Drawing.Size(193, 21);
            this.txtUserRequest.TabIndex = 0;
            // 
            // grpCreateWork
            // 
            this.grpCreateWork.Controls.Add(this.label1);
            this.grpCreateWork.Controls.Add(this.txtCost);
            this.grpCreateWork.Controls.Add(this.label3);
            this.grpCreateWork.Controls.Add(this.iLabel1);
            this.grpCreateWork.Controls.Add(this.txtTime);
            this.grpCreateWork.Controls.Add(this.cmbWork);
            this.grpCreateWork.Controls.Add(this.label2);
            this.grpCreateWork.Controls.Add(this.txtDescription);
            this.grpCreateWork.Controls.Add(this.btnAddWork);
            this.grpCreateWork.Location = new System.Drawing.Point(16, 23);
            this.grpCreateWork.Name = "grpCreateWork";
            this.grpCreateWork.Size = new System.Drawing.Size(442, 131);
            this.grpCreateWork.TabIndex = 9;
            this.grpCreateWork.TabStop = false;
            this.grpCreateWork.Text = "ثبت کار جدید";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "کار";
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.Location = new System.Drawing.Point(44, 20);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(55, 21);
            this.txtCost.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "هزینه";
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Location = new System.Drawing.Point(410, 63);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(30, 13);
            this.iLabel1.TabIndex = 1;
            this.iLabel1.Text = "شرح";
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.Location = new System.Drawing.Point(44, 62);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(55, 21);
            this.txtTime.TabIndex = 6;
            // 
            // cmbWork
            // 
            this.cmbWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWork.FormattingEnabled = true;
            this.cmbWork.Location = new System.Drawing.Point(195, 20);
            this.cmbWork.Name = "cmbWork";
            this.cmbWork.Size = new System.Drawing.Size(206, 21);
            this.cmbWork.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "زمان (ساعت)";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(195, 48);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(206, 41);
            this.txtDescription.TabIndex = 0;
            // 
            // btnAddWork
            // 
            this.btnAddWork.Location = new System.Drawing.Point(326, 95);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(75, 23);
            this.btnAddWork.TabIndex = 2;
            this.btnAddWork.Text = "ثبت کار";
            this.btnAddWork.UseVisualStyleBackColor = true;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // UCRequestWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCRequestWork";
            this.Size = new System.Drawing.Size(794, 506);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.igridProcessList)).EndInit();
            this.iGroupBoxNew.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpCreateWork.ResumeLayout(false);
            this.grpCreateWork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IGroupBox iGroupBox3;
        private UILibrary.IGroupBox iGroupBoxNew;
        private UILibrary.IGridEX igridProcessList;
        private UILibrary.IButton btnAddWork;
        private UILibrary.ILabel iLabel1;
        private UILibrary.ITextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangeRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinalRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserRequest;
        private System.Windows.Forms.GroupBox grpCreateWork;
    }
}
