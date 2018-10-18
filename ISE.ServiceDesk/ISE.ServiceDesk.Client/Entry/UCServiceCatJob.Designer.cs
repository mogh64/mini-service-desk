namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCServiceCatJob
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
            this.chkIsInserter = new System.Windows.Forms.CheckBox();
            this.chkMulti = new System.Windows.Forms.CheckBox();
            this.cmbRoles = new ISE.UILibrary.IComboBox();
            this.btnClose = new ISE.UILibrary.IButton();
            this.btnOk = new ISE.UILibrary.IButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstimateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCreditDate = new System.Windows.Forms.CheckBox();
            this.chkDesc = new System.Windows.Forms.CheckBox();
            this.chkAttch = new System.Windows.Forms.CheckBox();
            this.txtActionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.iGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.chkEnabled);
            this.iGroupBox1.Controls.Add(this.chkIsInserter);
            this.iGroupBox1.Controls.Add(this.chkMulti);
            this.iGroupBox1.Controls.Add(this.cmbRoles);
            this.iGroupBox1.Controls.Add(this.btnClose);
            this.iGroupBox1.Controls.Add(this.btnOk);
            this.iGroupBox1.Controls.Add(this.label3);
            this.iGroupBox1.Controls.Add(this.txtEstimateTime);
            this.iGroupBox1.Controls.Add(this.label2);
            this.iGroupBox1.Controls.Add(this.chkCreditDate);
            this.iGroupBox1.Controls.Add(this.chkDesc);
            this.iGroupBox1.Controls.Add(this.chkAttch);
            this.iGroupBox1.Controls.Add(this.txtActionId);
            this.iGroupBox1.Controls.Add(this.label1);
            this.iGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(523, 243);
            this.iGroupBox1.TabIndex = 12;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "شرح خدمت";
            // 
            // chkIsInserter
            // 
            this.chkIsInserter.AutoSize = true;
            this.chkIsInserter.Location = new System.Drawing.Point(60, 148);
            this.chkIsInserter.Name = "chkIsInserter";
            this.chkIsInserter.Size = new System.Drawing.Size(57, 17);
            this.chkIsInserter.TabIndex = 23;
            this.chkIsInserter.Text = "ایجادی";
            this.chkIsInserter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIsInserter.UseVisualStyleBackColor = true;
            // 
            // chkMulti
            // 
            this.chkMulti.AutoSize = true;
            this.chkMulti.Location = new System.Drawing.Point(158, 148);
            this.chkMulti.Name = "chkMulti";
            this.chkMulti.Size = new System.Drawing.Size(108, 17);
            this.chkMulti.TabIndex = 22;
            this.chkMulti.Text = "درخواست چندگانه";
            this.chkMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMulti.UseVisualStyleBackColor = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(277, 66);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(137, 21);
            this.cmbRoles.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(243, 193);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(339, 193);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "تایید تغییرات";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "اجرا کننده";
            // 
            // txtEstimateTime
            // 
            this.txtEstimateTime.Location = new System.Drawing.Point(25, 22);
            this.txtEstimateTime.Name = "txtEstimateTime";
            this.txtEstimateTime.Size = new System.Drawing.Size(137, 21);
            this.txtEstimateTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "هزینه تخمین زمانی";
            // 
            // chkCreditDate
            // 
            this.chkCreditDate.AutoSize = true;
            this.chkCreditDate.Location = new System.Drawing.Point(311, 111);
            this.chkCreditDate.Name = "chkCreditDate";
            this.chkCreditDate.Size = new System.Drawing.Size(103, 17);
            this.chkCreditDate.TabIndex = 3;
            this.chkCreditDate.Text = "دارای تاریخ اعتبار";
            this.chkCreditDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCreditDate.UseVisualStyleBackColor = true;
            // 
            // chkDesc
            // 
            this.chkDesc.AutoSize = true;
            this.chkDesc.Location = new System.Drawing.Point(319, 148);
            this.chkDesc.Name = "chkDesc";
            this.chkDesc.Size = new System.Drawing.Size(94, 17);
            this.chkDesc.TabIndex = 7;
            this.chkDesc.Text = "دارای توضیحات";
            this.chkDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDesc.UseVisualStyleBackColor = true;
            // 
            // chkAttch
            // 
            this.chkAttch.AutoSize = true;
            this.chkAttch.Location = new System.Drawing.Point(179, 111);
            this.chkAttch.Name = "chkAttch";
            this.chkAttch.Size = new System.Drawing.Size(87, 17);
            this.chkAttch.TabIndex = 4;
            this.chkAttch.Text = "دارای ضمیمه";
            this.chkAttch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAttch.UseVisualStyleBackColor = true;
            // 
            // txtActionId
            // 
            this.txtActionId.Location = new System.Drawing.Point(277, 22);
            this.txtActionId.Name = "txtActionId";
            this.txtActionId.Size = new System.Drawing.Size(137, 21);
            this.txtActionId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "شناسه فعالیت";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(44, 111);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(73, 17);
            this.chkEnabled.TabIndex = 24;
            this.chkEnabled.Text = "فعال باشد";
            this.chkEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // UCServiceCatJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCServiceCatJob";
            this.Size = new System.Drawing.Size(526, 246);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IButton btnClose;
        private UILibrary.IButton btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstimateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCreditDate;
        private System.Windows.Forms.CheckBox chkDesc;
        private System.Windows.Forms.CheckBox chkAttch;
        private System.Windows.Forms.TextBox txtActionId;
        private System.Windows.Forms.Label label1;
        private UILibrary.IComboBox cmbRoles;
        private System.Windows.Forms.CheckBox chkMulti;
        private System.Windows.Forms.CheckBox chkIsInserter;
        private System.Windows.Forms.CheckBox chkEnabled;
    }
}
