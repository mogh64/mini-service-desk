using ISE.Framework.Common.Aspects;
using ISE.ServiceDesk.Bussiness.Dependency;
using Router.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ISE.ServiceDesk.Service.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.Configure();
            ServiceHostDecorator ServiceJobServiceHost = new ServiceHostDecorator(typeof(ServiceJobService));
            ServiceHostDecorator ServiceCategoryHost = new ServiceHostDecorator(typeof(ServiceCategoryService));
            ServiceHostDecorator BaseDataServiceHost = new ServiceHostDecorator(typeof(BaseDataService));
            ServiceHostDecorator ServiceCategoryJobHost = new ServiceHostDecorator(typeof(ServiceCategoryJobService));
            ServiceHostDecorator UserRequestHost = new ServiceHostDecorator(typeof(UserRequestService));

            ServiceHostDecorator worktHost = new ServiceHostDecorator(typeof(WorkService));
            ServiceHostDecorator officeHost = new ServiceHostDecorator(typeof(OfficeService));
            ServiceHostDecorator roleHost = new ServiceHostDecorator(typeof(RoleService));
            ServiceHostDecorator cartableHost = new ServiceHostDecorator(typeof(ServiceDeskCartableService));

            try
            {
                LogManager.GetLogger().Info("Service Opened.");

                ServiceJobServiceHost.Open();
                Console.WriteLine(ServiceJobServiceHost.OpenMessage);

                ServiceCategoryHost.Open();
                Console.WriteLine(ServiceCategoryHost.OpenMessage);

                BaseDataServiceHost.Open();
                Console.WriteLine(BaseDataServiceHost.OpenMessage);

                ServiceCategoryJobHost.Open();
                Console.WriteLine(ServiceCategoryJobHost.OpenMessage);

                UserRequestHost.Open();
                Console.WriteLine(UserRequestHost.OpenMessage);

                worktHost.Open();
                Console.WriteLine(worktHost.OpenMessage);

                officeHost.Open();
                Console.WriteLine(officeHost.OpenMessage);

                roleHost.Open();
                Console.WriteLine(roleHost.OpenMessage);

                cartableHost.Open();
                Console.WriteLine(cartableHost.OpenMessage);

               
                Console.WriteLine("Press <Enter> to stop the services");
                Console.ReadKey();

                //******************************************************************
            }
            catch (Exception ex)
            {
                // log exception
                LogManager.GetLogger().Error(ex);

                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            finally
            {

                if (ServiceJobServiceHost.State != CommunicationState.Faulted)
                    ServiceJobServiceHost.Close();

                if (ServiceCategoryHost.State != CommunicationState.Faulted)
                    ServiceCategoryHost.Close();

                if (BaseDataServiceHost.State != CommunicationState.Faulted)
                    BaseDataServiceHost.Close();

                if (ServiceCategoryJobHost.State != CommunicationState.Faulted)
                    ServiceCategoryJobHost.Close();

                if (ServiceCategoryJobHost.State != CommunicationState.Faulted)
                    ServiceCategoryJobHost.Close();

                if (worktHost.State != CommunicationState.Faulted)
                    worktHost.Close();

                if (officeHost.State != CommunicationState.Faulted)
                    officeHost.Close();

                if (roleHost.State != CommunicationState.Faulted)
                    roleHost.Close();

                if (cartableHost.State != CommunicationState.Faulted)
                    cartableHost.Close();

                LogManager.GetLogger().Info("Service Closed.");
            }
        }
    }
}
