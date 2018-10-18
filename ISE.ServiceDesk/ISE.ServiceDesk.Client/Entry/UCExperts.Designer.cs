namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCExperts
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout iGridExperts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCExperts));
            Janus.Windows.GridEX.GridEXLayout iGridRoles_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout igridPersonToRole_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.cmbOffices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iGroupBox1 = new ISE.UILibrary.IGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.iGroupBox2 = new ISE.UILibrary.IGroupBox();
            this.iGridToolBar1 = new ISE.UILibrary.IGridToolBar();
            this.iGridExperts = new ISE.UILibrary.IGridEX();
            this.iGroupBox3 = new ISE.UILibrary.IGroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.iGridRoles = new ISE.UILibrary.IGridEX();
            this.iGridToolBar2 = new ISE.UILibrary.IGridToolBar();
            this.iToolStrip1 = new ISE.UILibrary.IToolStrip(this.components);
            this.btnChangeweight = new ISE.UILibrary.IButton();
            this.btnDelete = new ISE.UILibrary.IButton();
            this.igridPersonToRole = new ISE.UILibrary.IGridEX();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.iGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.iGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGridExperts)).BeginInit();
            this.iGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iGridRoles)).BeginInit();
            this.iGridToolBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igridPersonToRole)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOffices
            // 
            this.cmbOffices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOffices.FormattingEnabled = true;
            this.cmbOffices.Items.AddRange(new object[] {
            "اداره سخت افزار",
            "اداره نرم افزار",
            "اداره شبکه و امنیت"});
            this.cmbOffices.Location = new System.Drawing.Point(439, 25);
            this.cmbOffices.Name = "cmbOffices";
            this.cmbOffices.Size = new System.Drawing.Size(338, 21);
            this.cmbOffices.TabIndex = 0;
            this.cmbOffices.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اداره";
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.splitContainer1);
            this.iGroupBox1.Controls.Add(this.cmbOffices);
            this.iGroupBox1.Controls.Add(this.label1);
            this.iGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(828, 519);
            this.iGroupBox1.TabIndex = 2;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "مدیریت آی تی";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.iGroupBox2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.iGroupBox3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(822, 455);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 2;
            // 
            // iGroupBox2
            // 
            this.iGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox2.Controls.Add(this.iGridToolBar1);
            this.iGroupBox2.Controls.Add(this.iGridExperts);
            this.iGroupBox2.Location = new System.Drawing.Point(3, 3);
            this.iGroupBox2.Name = "iGroupBox2";
            this.iGroupBox2.Size = new System.Drawing.Size(406, 449);
            this.iGroupBox2.TabIndex = 0;
            this.iGroupBox2.TabStop = false;
            this.iGroupBox2.Text = "کارشناسان";
            // 
            // iGridToolBar1
            // 
            this.iGridToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGridToolBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.iGridToolBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iGridToolBar1.Location = new System.Drawing.Point(6, 416);
            this.iGridToolBar1.Name = "iGridToolBar1";
            this.iGridToolBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iGridToolBar1.Size = new System.Drawing.Size(394, 27);
            this.iGridToolBar1.TabIndex = 1;
            this.iGridToolBar1.NewRecord += new System.EventHandler(this.iGridToolBar1_NewRecord);
            this.iGridToolBar1.EditRecord += new System.EventHandler(this.iGridToolBar1_EditRecord);
            this.iGridToolBar1.DeleteRecord += new System.EventHandler(this.iGridToolBar1_DeleteRecord);
            // 
            // iGridExperts
            // 
            this.iGridExperts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iGridExperts_DesignTimeLayout.LayoutString = resources.GetString("iGridExperts_DesignTimeLayout.LayoutString");
            this.iGridExperts.DesignTimeLayout = iGridExperts_DesignTimeLayout;
            this.iGridExperts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iGridExperts.Location = new System.Drawing.Point(6, 20);
            this.iGridExperts.Name = "iGridExperts";
            this.iGridExperts.Size = new System.Drawing.Size(394, 396);
            this.iGridExperts.TabIndex = 0;
            // 
            // iGroupBox3
            // 
            this.iGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox3.Controls.Add(this.splitContainer2);
            this.iGroupBox3.Location = new System.Drawing.Point(3, 3);
            this.iGroupBox3.Name = "iGroupBox3";
            this.iGroupBox3.Size = new System.Drawing.Size(400, 449);
            this.iGroupBox3.TabIndex = 0;
            this.iGroupBox3.TabStop = false;
            this.iGroupBox3.Text = "گروه های کاری";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 17);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.iGridRoles);
            this.splitContainer2.Panel1.Controls.Add(this.iGridToolBar2);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnChangeweight);
            this.splitContainer2.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer2.Panel2.Controls.Add(this.igridPersonToRole);
            this.splitContainer2.Panel2.Controls.Add(this.btnAddPerson);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(394, 429);
            this.splitContainer2.SplitterDistance = 208;
            this.splitContainer2.TabIndex = 0;
            // 
            // iGridRoles
            // 
            this.iGridRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iGridRoles_DesignTimeLayout.LayoutString = resources.GetString("iGridRoles_DesignTimeLayout.LayoutString");
            this.iGridRoles.DesignTimeLayout = iGridRoles_DesignTimeLayout;
            this.iGridRoles.Location = new System.Drawing.Point(3, 3);
            this.iGridRoles.Name = "iGridRoles";
            this.iGridRoles.Size = new System.Drawing.Size(388, 168);
            this.iGridRoles.TabIndex = 1;
            this.iGridRoles.SelectionChanged += new System.EventHandler(this.iGridRoles_SelectionChanged);
            // 
            // iGridToolBar2
            // 
            this.iGridToolBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGridToolBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.iGridToolBar2.Controls.Add(this.iToolStrip1);
            this.iGridToolBar2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iGridToolBar2.Location = new System.Drawing.Point(3, 171);
            this.iGridToolBar2.Name = "iGridToolBar2";
            this.iGridToolBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iGridToolBar2.Size = new System.Drawing.Size(388, 34);
            this.iGridToolBar2.TabIndex = 2;
            this.iGridToolBar2.NewRecord += new System.EventHandler(this.iGridToolBar2_NewRecord);
            this.iGridToolBar2.Load += new System.EventHandler(this.iGridToolBar2_Load);
            // 
            // iToolStrip1
            // 
            this.iToolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.iToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.iToolStrip1.Name = "iToolStrip1";
            this.iToolStrip1.Size = new System.Drawing.Size(426, 27);
            this.iToolStrip1.TabIndex = 0;
            this.iToolStrip1.Text = "iToolStrip1";
            this.iToolStrip1.Visible = false;
            // 
            // btnChangeweight
            // 
            this.btnChangeweight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeweight.Location = new System.Drawing.Point(235, 191);
            this.btnChangeweight.Name = "btnChangeweight";
            this.btnChangeweight.Size = new System.Drawing.Size(75, 23);
            this.btnChangeweight.TabIndex = 6;
            this.btnChangeweight.Text = "تغییر وزن";
            this.btnChangeweight.UseVisualStyleBackColor = true;
            this.btnChangeweight.Click += new System.EventHandler(this.btnChangeweight_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(316, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // igridPersonToRole
            // 
            this.igridPersonToRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            igridPersonToRole_DesignTimeLayout.LayoutString = resources.GetString("igridPersonToRole_DesignTimeLayout.LayoutString");
            this.igridPersonToRole.DesignTimeLayout = igridPersonToRole_DesignTimeLayout;
            this.igridPersonToRole.Location = new System.Drawing.Point(3, 39);
            this.igridPersonToRole.Name = "igridPersonToRole";
            this.igridPersonToRole.Size = new System.Drawing.Size(388, 148);
            this.igridPersonToRole.TabIndex = 2;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.Location = new System.Drawing.Point(3, 6);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(388, 35);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "انتساب کارشناس به گروه کاری";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // UCExperts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCExperts";
            this.Size = new System.Drawing.Size(834, 522);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.iGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iGridExperts)).EndInit();
            this.iGroupBox3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iGridRoles)).EndInit();
            this.iGridToolBar2.ResumeLayout(false);
            this.iGridToolBar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igridPersonToRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOffices;
        private System.Windows.Forms.Label label1;
        private UILibrary.IGroupBox iGroupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UILibrary.IGroupBox iGroupBox2;
        private UILibrary.IGroupBox iGroupBox3;
        private UILibrary.IGridEX iGridExperts;
        private UILibrary.IGridEX iGridRoles;
        private UILibrary.IGridToolBar iGridToolBar1;
        private UILibrary.IGridToolBar iGridToolBar2;
        private UILibrary.IToolStrip iToolStrip1;
        private UILibrary.IGridEX igridPersonToRole;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private UILibrary.IButton btnDelete;
        private UILibrary.IButton btnChangeweight;
    }
}
