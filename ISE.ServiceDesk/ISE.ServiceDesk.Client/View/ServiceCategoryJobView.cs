using ISE.ServiceDesk.Client.Common.Presenter;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Client.View
{
    public class ServiceCategoryJobView
    {
       
        public ServiceCategoryPresenter scPresenter = new ServiceCategoryPresenter();
        public ServiceCategoryJobPresenter cjPresenter = new ServiceCategoryJobPresenter();
        public BaseDataServicePresenter baseDataPresenter = new BaseDataServicePresenter();

        public bool AddServiceCategory(SdServiceCategoryDto category)
        {
            var result = scPresenter.Insert(category);
            if (result != null)
               return true;
            return false;
        }
        public bool UpdateServiceCategory(SdServiceCategoryDto category)
        {
            var result = scPresenter.Update(category);

            return result;
        }
        public bool RemoveServiceCategory(SdServiceCategoryDto category)
        {
            var result = scPresenter.Remove(category);

            return result;
        }
        public List<SdItRoleDto> LoadRoles()
        {
           return  baseDataPresenter.GetRoleList();
        }
    }
}
