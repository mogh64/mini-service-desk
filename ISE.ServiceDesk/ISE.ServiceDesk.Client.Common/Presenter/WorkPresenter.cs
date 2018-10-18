using ISE.Framework.Client.Common.ExceptionManager;
using ISE.Framework.Common.Service;
using ISE.Framework.Common.Service.Message;
using ISE.ServiceDesk.Common.Contract;
using ISE.ServiceDesk.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISE.ServiceDesk.Client.Common.Presenter
{
    public class WorkPresenter
    {
        private ServiceAdapter<IWorkService> WorkServiceAdapter;
        public WorkPresenter()
        {
            IseBussinessExceptionManager exceptionManager = new IseBussinessExceptionManager();
            WorkServiceAdapter = new ServiceAdapter<IWorkService>(exceptionManager);
        }
        public SdWorkDto Insert(SdWorkDto work)
        {
            SdWorkDto result = (SdWorkDto)WorkServiceAdapter.Execute(s => s.Insert(work));
            if (result.Response.HasException)
            {
                return null;
            }
            work.WorkId = result.WorkId;
            return work;
        }
        public bool Update(SdWorkDto work)
        {
            ResponseDto response = WorkServiceAdapter.Execute(s => s.Update(work));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
        public bool Remove(SdWorkDto work)
        {
            ResponseDto response = WorkServiceAdapter.Execute(s => s.Delete(work));
            if (response.Response.HasException)
            {
                return false;
            }
            return true;
        }
    }
}
