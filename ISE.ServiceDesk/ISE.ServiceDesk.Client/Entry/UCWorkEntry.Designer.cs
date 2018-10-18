namespace ISE.ServiceDesk.Client.Entry
{
    partial class UCWorkEntry
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
            this.iTransToolBar1 = new ISE.UILibrary.ITransToolBar();
            this.txtTime = new ISE.UILibrary.ITextBox();
            this.iLabel3 = new ISE.UILibrary.ILabel();
            this.txtTitle = new ISE.UILibrary.ITextBox();
            this.iLabel1 = new ISE.UILibrary.ILabel();
            this.iGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iGroupBox1
            // 
            this.iGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iGroupBox1.Controls.Add(this.iTransToolBar1);
            this.iGroupBox1.Controls.Add(this.txtTime);
            this.iGroupBox1.Controls.Add(this.iLabel3);
            this.iGroupBox1.Controls.Add(this.txtTitle);
            this.iGroupBox1.Controls.Add(this.iLabel1);
            this.iGroupBox1.Location = new System.Drawing.Point(0, 3);
            this.iGroupBox1.Name = "iGroupBox1";
            this.iGroupBox1.Size = new System.Drawing.Size(455, 309);
            this.iGroupBox1.TabIndex = 0;
            this.iGroupBox1.TabStop = false;
            this.iGroupBox1.Text = "ثبت تعریف کار ";
            // 
            // iTransToolBar1
            // 
            this.iTransToolBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.iTransToolBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.iTransToolBar1.Location = new System.Drawing.Point(131, 195);
            this.iTransToolBar1.Name = "iTransToolBar1";
            this.iTransToolBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iTransToolBar1.Size = new System.Drawing.Size(259, 27);
            this.iTransToolBar1.TabIndex = 3;
            this.iTransToolBar1.SaveRecord += new System.EventHandler(this.iTransToolBar1_SaveRecord);
            this.iTransToolBar1.SaveAndNewRecord += new System.EventHandler(this.iTransToolBar1_SaveAndNewRecord);
            this.iTransToolBar1.Close += new System.EventHandler(this.iTransToolBar1_Close);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(131, 79);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(207, 21);
            this.txtTime.TabIndex = 1;
            // 
            // iLabel3
            // 
            this.iLabel3.AutoSize = true;
            this.iLabel3.Location = new System.Drawing.Point(369, 87);
            this.iLabel3.Name = "iLabel3";
            this.iLabel3.Size = new System.Drawing.Size(66, 13);
            this.iLabel3.TabIndex = 4;
            this.iLabel3.Text = "زمان تخمینی";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(131, 40);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(207, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Location = new System.Drawing.Point(402, 48);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(33, 13);
            this.iLabel1.TabIndex = 0;
            this.iLabel1.Text = "عنوان";
            // 
            // UCWorkEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iGroupBox1);
            this.Name = "UCWorkEntry";
            this.Size = new System.Drawing.Size(455, 312);
            this.iGroupBox1.ResumeLayout(false);
            this.iGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UILibrary.IGroupBox iGroupBox1;
        private UILibrary.ITransToolBar iTransToolBar1;
        private UILibrary.ITextBox txtTime;
        private UILibrary.ILabel iLabel3;
        private UILibrary.ITextBox txtTitle;
        private UILibrary.ILabel iLabel1;
    }
}
