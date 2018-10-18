using ISE.Framework.Common.Aspects;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using ISE.ServiceDesk.Common.DTOContainer;
using ISE.ServiceDesk.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Service
{
    [Intercept]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, UseSynchronizationContext = false, AddressFilterMode = AddressFilterMode.Any)]
    public class BaseDataService :ContextBoundObject, IBaseDateService,IDisposable
    {
        public Common.DTOContainer.BaseDataContainer GetRoleList()
        {
            BaseDataTDataAccess da = new BaseDataTDataAccess();
            return da.GetRoleList();
        }


        public Common.DTOContainer.PersonelDtoContainer GetPersonelList(int chartId)
        {
            PersonelTDataAccess da = new PersonelTDataAccess();
            PersonelDtoContainer container = new PersonelDtoContainer();
            var personels =  da.GetPersonel(chartId);
            container.PersonelDtoList.AddRange(personels);
            return container;
        }


        public Common.DTO.VwPersonelDto GetPersonId(int perId)
        {
            PersonelTDataAccess da = new PersonelTDataAccess();
            return da.GetPersonId(perId);
        }


        public BaseDataContainer GetObjectTypeList()
        {
            BaseDataTDataAccess da = new BaseDataTDataAccess();
            return da.GetObjectTypeList();
        }


        public Framework.Common.Service.Message.ResponseDto AddFilter(Common.DTO.SdFilterCategoryDto filter)
        {
            FilterCategoryTDataAccess da = new FilterCategoryTDataAccess();
            da.Insert(filter);
            return ResponseBuilder.GetResponse(filter);
        }

        public Framework.Common.Service.Message.ResponseDto RemoveFilter(Common.DTO.SdFilterCategoryDto filter)
        {
            FilterCategoryTDataAccess da = new FilterCategoryTDataAccess();
            da.Delete(filter);
            return ResponseBuilder.GetResponse(filter);
        }


        public Common.DTO.SdFilterCategoryDto GetFilter(int serviceCategoryId)
        {
            FilterCategoryTDataAccess da = new FilterCategoryTDataAccess();
            var filter =da.GetSingle(it => it.Servicecaegoryid == serviceCategoryId);
            return filter;
        }


        public BaseDataContainer GetDeviceList(int perid, int objTypeId)
        {
            BaseDataContainer container = new BaseDataContainer();
            PersonelTDataAccess pDa = new PersonelTDataAccess();
            var lst = pDa.GetDeviceList(perid, objTypeId);
            container.DeviceList = lst;
            return container;
        }
        public DeviceDto GetDevice(int transferId)
        {
            DeviceDto result = new DeviceDto();
            PersonelTDataAccess pDa = new PersonelTDataAccess();
            var lst = pDa.GetDeviceList(transferId);
            if (lst.Count > 0)
                result =  lst.FirstOrDefault();
            else
                result.Response.AddBusinessException("there is no device", BusinessExceptionEnum.Validation);
            return result;
        }

        public BaseDataContainer GetRequestStateList()
        {
            BaseDataContainer container = new BaseDataContainer();
            UserRequestTDataAccess da = new UserRequestTDataAccess();
            container.RequestStateList.AddRange( da.GetStateList());
            return container;
        }

        public void Dispose()
        {
            Console.WriteLine("dispose called");
           // GC.SuppressFinalize(this);
        }


        public BaseDataContainer GetWorkList(int serviceCatId, bool loadParents)
        {
            BaseDataTDataAccess da = new BaseDataTDataAccess();
            ServiceCategoryTDataAccess scDa = new ServiceCategoryTDataAccess();
            var serviceCat = scDa.GetSingle(it => it.ServiceCatId == serviceCatId);
            List<SdWorkDto> workList = new List<SdWorkDto>();
            workList = da.GetWorks(serviceCatId); 
            if (loadParents)
            {

                if (serviceCat.Parentid.HasValue != null)
                {
                    SdServiceCategoryDto temp = scDa.GetSingle(it => it.ServiceCatId == serviceCat.Parentid.Value);
                    while (temp!=null)
                    {
                        
                        var tworkList = da.GetWorks(temp.ServiceCatId);
                        if(tworkList!=null)
                           workList.AddRange(tworkList);
                        if (temp.Parentid.HasValue)
                            temp = scDa.GetSingle(it => it.ServiceCatId == temp.Parentid.Value);
                        else
                            temp = null;
                    }
                }
            }
            
           
            BaseDataContainer container = new BaseDataContainer()
            {
                WorkList = workList
            };
            return container;
        }


        public BaseDataContainer GetWorkListByServiceCatJob(int serviceCatJobId, bool loadParents)
        {
            BaseDataTDataAccess da = new BaseDataTDataAccess();
            ServiceCategoryJobTDataAccess scJobDa = new ServiceCategoryJobTDataAccess();
            var scjob = scJobDa.GetSingle(it => it.ServiceCatJobId == serviceCatJobId);
            var serviceCatId = scjob.Servicecategoryid.Value;
            ServiceCategoryTDataAccess scDa = new ServiceCategoryTDataAccess();
            var serviceCat = scDa.GetSingle(it => it.ServiceCatId == serviceCatId);
            List<SdWorkDto> workList = new List<SdWorkDto>();
            workList = da.GetWorks(serviceCatId);
            if (loadParents)
            {

                if (serviceCat.Parentid.HasValue != null)
                {
                    SdServiceCategoryDto temp = scDa.GetSingle(it => it.ServiceCatId == serviceCat.Parentid.Value);
                    while (temp != null)
                    {

                        var tworkList = da.GetWorks(temp.ServiceCatId);
                        if (tworkList != null)
                            workList.AddRange(tworkList);
                        if (temp.Parentid.HasValue)
                            temp = scDa.GetSingle(it => it.ServiceCatId == temp.Parentid.Value);
                        else
                            temp = null;
                    }
                }
            }


            BaseDataContainer container = new BaseDataContainer()
            {
                WorkList = workList
            };
            return container;
        }


        public PersonelDtoContainer GetPersonelListByIndependentId(int independentId)
        {
            PersonelTDataAccess da = new PersonelTDataAccess();
            PersonelDtoContainer container = new PersonelDtoContainer();
            var personels = da.GetPersonelByIndependentId(independentId);
            container.PersonelDtoList.AddRange(personels);
            return container;
        }


        public VwHokmDto GetPersonHokm(int perId)
        {
            VwHokmTDataAccess da = new VwHokmTDataAccess();
            var hokm =  da.GetSingle(it => it.PerId == perId);
            return hokm;
        }
    }
}
