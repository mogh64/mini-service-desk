using ISE.Framework.Client.Common.ExceptionManager;
using ISE.Framework.Common.Service;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Client.Common.Presenter
{
    public class ServiceCategoryPresenter
    {
        private ServiceAdapter<IServiceCategory> ServiceCategoryServiceAdapter;
        public ServiceCategoryPresenter()
        {
            IseBussinessExceptionManager exceptionManager = new IseBussinessExceptionManager();
            ServiceCategoryServiceAdapter = new ServiceAdapter<IServiceCategory>(exceptionManager);
        }
        public SdServiceCategoryDto Insert(SdServiceCategoryDto ServiceCategory)
        {
            SdServiceCategoryDto result = (SdServiceCategoryDto)ServiceCategoryServiceAdapter.Execute(s => s.Insert(ServiceCategory));
            if (result.Response.HasException)
            {
                return null;
            }
            ServiceCategory.ServiceCatId = result.ServiceCatId;
            return ServiceCategory;
        }
        public bool Update(SdServiceCategoryDto ServiceCategory)
        {
            ResponseDto response = ServiceCategoryServiceAdapter.Execute(s => s.Update(ServiceCategory));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
        public bool Remove(SdServiceCategoryDto ServiceCategory)
        {
            ResponseDto response = ServiceCategoryServiceAdapter.Execute(s => s.Delete(ServiceCategory));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
    }
}
