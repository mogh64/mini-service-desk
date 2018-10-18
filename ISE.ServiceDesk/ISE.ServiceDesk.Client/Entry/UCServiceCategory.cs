using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISE.UILibrary;
using ISE.ClassLibrary;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Client.View;
using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.UILibrary.Lov;
using ISE.Framework.Utility.Utils;
using ISE.Framework.Client.Win.Selector;


namespace ISE.ServiceDesk.Client.Entry
{
    public partial class UCServiceCategory : IUserControl
    {
        int? _parentId = null;
        ServiceCategoryJobView view;
        TransMode mode;
        SdServiceCategoryDto service;
        public DialogResult Result { get; set; }
        public List<SdServiceCategoryDto> InsertedList { get; set; }
        SdFilterCategoryDto fcat;
        SdFilterCategoryDto mcat;
        public UCServiceCategory(TransMode _mode,ServiceCategoryJobView view, int parentId=-1)
        {
            this.view = view;
            InsertedList = new List<SdServiceCategoryDto>();
            mode = _mode;
            InitializeComponent();
            Result = DialogResult.None;
            if (parentId > 0)
            {
                _parentId = parentId;
            }
            grpDeviceFilter.Enabled = false;
            grpMenuFilter.Enabled = false;
        
        }
        public UCServiceCategory(TransMode _mode, ServiceCategoryJobView view, SdServiceCategoryDto service)
        {
            this.view = view;
            InsertedList = new List<SdServiceCategoryDto>();
            mode = _mode;
            InitializeComponent();
            Result = DialogResult.None;
            this.service = service;
            grpDeviceFilter.Enabled = false;
            grpMenuFilter.Enabled = false;
            if (mode == TransMode.EditRecord || mode == TransMode.ViewRecord)
            {
                if (service != null)
                {
                    txtDescription.Text = service.Description;
                    txtTitle.Text = service.Title;
                    chkEnabled.Checked = service.Enabled > 0 ? true : false;
                    
                    chkHasJob.Checked = service.Hasjob > 0 ? true : false;
                    service.Filter = view.baseDataPresenter.GetFilter(service.ServiceCatId);
                    chkHasDevice.Checked = service.HasDevices;
                    if (service.Filter != null && service.Filter.ObjectType!=null)
                    {
                        grpDeviceFilter.Enabled = true;                        
                        txtDeviceFilter.Text = service.Filter.ObjectType.ObjecttypeDesc;
                        txtDeviceFilter.Tag = service.Filter.ObjectType;
                    }
                }

            }
            
        }
        private void iTransToolBar1_SaveRecord(object sender, EventArgs e)
        {
            Save();
            this.ParentForm.Close();
           
        }

        private void iTransToolBar1_SaveAndNewRecord(object sender, EventArgs e)
        {
            Save();
            MakeEmptyForm();
            this.mode = TransMode.NewRecord;
        }

        private void iTransToolBar1_Close(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
        private void MakeEmptyForm()
        {
            txtDescription.Text = string.Empty;
            txtTitle.Text = string.Empty;
            chkEnabled.Checked = true;
          
            chkHasJob.Checked = false;
            
        }
        private void Save()
        {

            if (mode == TransMode.NewRecord)
            {
                SdFilterCategoryDto filter = new SdFilterCategoryDto()
                {                   
                    State = Framework.Common.CommonBase.DtoObjectState.Inserted
                };
                SdServiceCategoryDto dto = new SdServiceCategoryDto()
                {
                    Description = txtDescription.Text,
                    Enabled = chkEnabled.Checked ? (short)1 : (short)0,
                    Hasjob = chkHasJob.Checked ? (short)1 : (short)0,
                    Title = txtTitle.Text,
                    Parentid = _parentId,
                    Hasdevice = (short)(chkHasDevice.Checked?1:0)
                };
                if (txtDeviceFilter.Tag != null)
                {
                    var obj = (ObjecttypeDto)txtDeviceFilter.Tag;
                    filter.Objecttypeid = obj.ObjecttypeId;
                    filter.ObjectType = obj;
                    dto.Filter = filter;
                }
                if (view.AddServiceCategory(dto))
                {
                    InsertedList.Add(dto);
                }
                Result = DialogResult.OK;
            }
            if (mode == TransMode.EditRecord)
            {
                service.Description = txtDescription.Text;
                service.Title = txtTitle.Text;
                service.Enabled = chkEnabled.Checked ? (short)1 : (short)0;
                service.Hasjob = chkHasJob.Checked ? (short)1 : (short)0;
                service.Hasdevice = (short)(chkHasDevice.Checked ? 1 : 0);
                if (txtDeviceFilter.Tag != null)
                {
                    var obj = (ObjecttypeDto)txtDeviceFilter.Tag;
                    if (obj.State == Framework.Common.CommonBase.DtoObjectState.Updated)
                    {
                        SdFilterCategoryDto filter = new SdFilterCategoryDto()
                        {
                            Objecttypeid=obj.ObjecttypeId,
                            ObjectType =obj,
                            Servicecaegoryid = service.ServiceCatId,                            
                            State = Framework.Common.CommonBase.DtoObjectState.Updated
                        };
                        service.Filter = filter;
                        
                    }
                }
                view.scPresenter.Update(service);
            }
        }
       

        private void chkHasDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHasDevice.Checked)
                grpDeviceFilter.Enabled = true;
            else
                grpDeviceFilter.Enabled = false;
        }

        private void chkHasMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHasMenu.Checked)
                grpMenuFilter.Enabled = true;
            else
                grpMenuFilter.Enabled = false;
        }

        private void btnAddMenuFilter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddDevFilter_Click(object sender, EventArgs e)
        {
            BaseDataServicePresenter presenter = new BaseDataServicePresenter();
            var list = presenter.GetObjectTypeList().ToList();
            UCItemListSelect<ObjecttypeDto> ucObjTypeSelect;
            ucObjTypeSelect = new UCItemListSelect<ObjecttypeDto>(list);
            List<ColumnDescriptor> columnDescriptor = new List<ColumnDescriptor>();
            columnDescriptor.Add(new ColumnDescriptor() { Name = AssemblyReflector.GetMemberName((ObjecttypeDto m) => m.ObjecttypeDesc), Caption = "نام", Width = 150 });
            ucObjTypeSelect.AddColumnDescriptor(columnDescriptor);
            ISE.UILibrary.Utils.UIUtils.SetFrmTrans(ucObjTypeSelect, "انتخاب نوع تجهیز", FormBorderStyle.FixedDialog);
            if (ucObjTypeSelect.HasSelected)
            {
                var selected =  ucObjTypeSelect.SelectedItems.FirstOrDefault();
                selected.State = Framework.Common.CommonBase.DtoObjectState.Updated;
                txtDeviceFilter.Text = selected.ObjecttypeDesc;
                txtDeviceFilter.Tag = selected;
                if (mode == TransMode.EditRecord)
                {
                    fcat = new SdFilterCategoryDto()
                    {
                        Objecttypeid = ((ObjecttypeDto)selected).ObjecttypeId,
                        Servicecaegoryid = service.ServiceCatId,
                        State = Framework.Common.CommonBase.DtoObjectState.Updated
                    }; 
                }
                                                         
            }
        }

        private void btnMinDevFilter_Click(object sender, EventArgs e)
        {                                 
            txtDeviceFilter.Tag = null;
            txtDeviceFilter.Text = string.Empty;
            if (service.Filter != null)
            {
                service.Filter.State = Framework.Common.CommonBase.DtoObjectState.Deleted;
            }
        }
    }
}
