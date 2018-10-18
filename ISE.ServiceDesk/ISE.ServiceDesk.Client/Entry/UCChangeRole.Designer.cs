namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCChangeRole
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
            Janus.Windows.GridEX.GridEXLayout iGridEXPersons_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChangeRole));
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.iGridEXPersons = new ISE.UILibrary.IGridEX();
            this.txtRole = new ISE.UILibrary.ITextBox();
            this.iButton1 = new ISE.UILibrary.IButton();
            this.btnOk = new ISE.UILibrary.IButton();
            this.btnCancel = new ISE.UILibrary.IButton();
            this.iGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGridEXPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.btnCancel);
            this.iGroupBox1.Controls.Add(this.btnOk);
            this.iGroupBox1.Controls.Add(this.iGridEXPersons);
            this.iGroupBox1.Controls.Add(this.txtRole);
            this.iGroupBox1.Controls.Add(this.iButton1);
            this.iGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(472, 418);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "گروه کاری";
            // 
            // iGridEXPersons
            // 
            this.iGridEXPersons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iGridEXPersons_DesignTimeLayout.LayoutString = resources.GetString("iGridEXPersons_DesignTimeLayout.LayoutString");
            this.iGridEXPersons.DesignTimeLayout = iGridEXPersons_DesignTimeLayout;
            this.iGridEXPersons.Location = new System.Drawing.Point(6, 73);
            this.iGridEXPersons.Name = "iGridEXPersons";
            this.iGridEXPersons.Size = new System.Drawing.Size(463, 274);
            this.iGridEXPersons.TabIndex = 2;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(212, 46);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(240, 21);
            this.txtRole.TabIndex = 1;
            // 
            // iButton1
            // 
            this.iButton1.Location = new System.Drawing.Point(98, 44);
            this.iButton1.Name = "iButton1";
            this.iButton1.Size = new System.Drawing.Size(98, 23);
            this.iButton1.TabIndex = 0;
            this.iButton1.Text = "تغییر گروه کاری";
            this.iButton1.UseVisualStyleBackColor = true;
            this.iButton1.Click += new System.EventHandler(this.iButton1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(363, 366);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ذخیره";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(266, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCChangeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCChangeRole";
            this.Size = new System.Drawing.Size(472, 421);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGridEXPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.ITextBox txtRole;
        private UILibrary.IButton iButton1;
        private UILibrary.IGridEX iGridEXPersons;
        private UILibrary.IButton btnCancel;
        private UILibrary.IButton btnOk;
    }
}
