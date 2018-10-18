using ISE.Framework.Client.Common.Environment;
using ISE.Framework.Client.Win.Viewer;
using ISE.Framework.Common.Service.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISE.ServiceDesk.Winfom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetEnvironment();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void SetEnvironment()
        {
            EnvironmentVariables.CurrentEnvironment = EnvironmentType.Win;
            EnvironmentVariables.RegisterViewer(new IseWinBussinessExceptionViewer(), EnvironmentVariables.CurrentEnvironment);
            ISE.Framework.Common.Service.Security.LoginContext.ServiceLogin = new ServiceLogin() { UserName = "92000711:IseSec", Password = "4285705761" };
        }
    }
}
