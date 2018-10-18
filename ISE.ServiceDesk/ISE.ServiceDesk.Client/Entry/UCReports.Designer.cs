namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCReports
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
            this.cmbReportList = new ISE.UILibrary.IComboBox();
            this.iLabel1 = new ISE.UILibrary.ILabel();
            this.btnShowReport = new ISE.UILibrary.IButton();
            this.iGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.btnShowReport);
            this.iGroupBox1.Controls.Add(this.iLabel1);
            this.iGroupBox1.Controls.Add(this.cmbReportList);
            this.iGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(976, 527);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "گزارشات سرویس دسک";
            // 
            // cmbReportList
            // 
            this.cmbReportList.FormattingEnabled = true;
            this.cmbReportList.Items.AddRange(new object[] {
            "گزارش کارکرد کارشناسان",
            "درخواست ها به تفکیک هر حوزه",
            "تعمیرات تجهیزات و دستگاهها"});
            this.cmbReportList.Location = new System.Drawing.Point(332, 46);
            this.cmbReportList.Name = "cmbReportList";
            this.cmbReportList.Size = new System.Drawing.Size(514, 21);
            this.cmbReportList.TabIndex = 0;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Location = new System.Drawing.Point(890, 54);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(53, 13);
            this.iLabel1.TabIndex = 1;
            this.iLabel1.Text = "نام گزارش";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(225, 44);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(75, 23);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "نمایش";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // UCReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCReports";
            this.Size = new System.Drawing.Size(979, 530);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IButton btnShowReport;
        private UILibrary.ILabel iLabel1;
        private UILibrary.IComboBox cmbReportList;
    }
}
