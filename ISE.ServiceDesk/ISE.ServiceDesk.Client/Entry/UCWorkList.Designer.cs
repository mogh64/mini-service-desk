namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCWorkList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWorkList));
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.iGridToolBar1 = new ISE.UILibrary.IGridToolBar();
            this.iGridEX1 = new ISE.UILibrary.IGridEX();
            this.iGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.iGridToolBar1);
            this.iGroupBox1.Controls.Add(this.iGridEX1);
            this.iGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(700, 476);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "لیست کارها";
            // 
            // iGridToolBar1
            // 
            this.iGridToolBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.iGridToolBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iGridToolBar1.Location = new System.Drawing.Point(268, 443);
            this.iGridToolBar1.Name = "iGridToolBar1";
            this.iGridToolBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iGridToolBar1.Size = new System.Drawing.Size(426, 27);
            this.iGridToolBar1.TabIndex = 1;
            this.iGridToolBar1.NewRecord += new System.EventHandler(this.iGridToolBar1_NewRecord);
            this.iGridToolBar1.EditRecord += new System.EventHandler(this.iGridToolBar1_EditRecord);
            this.iGridToolBar1.DeleteRecord += new System.EventHandler(this.iGridToolBar1_DeleteRecord);
            this.iGridToolBar1.Close += new System.EventHandler(this.iGridToolBar1_Close);
            // 
            // iGridEX1
            // 
            iGridEX1_DesignTimeLayout.LayoutString = resources.GetString("iGridEX1_DesignTimeLayout.LayoutString");
            this.iGridEX1.DesignTimeLayout = iGridEX1_DesignTimeLayout;
            this.iGridEX1.Location = new System.Drawing.Point(6, 20);
            this.iGridEX1.Name = "iGridEX1";
            this.iGridEX1.Size = new System.Drawing.Size(688, 417);
            this.iGridEX1.TabIndex = 0;
            // 
            // UCWorkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCWorkList";
            this.Size = new System.Drawing.Size(700, 479);
            this.iGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iGridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.IGridToolBar iGridToolBar1;
        private UILibrary.IGridEX iGridEX1;
    }
}
