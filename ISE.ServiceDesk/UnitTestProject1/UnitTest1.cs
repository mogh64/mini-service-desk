using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISE.ServiceDesk.Service;
using ISE.ServiceDesk.Common.DTO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceDeskCartableService service = new ServiceDeskCartableService();
            ExternalResultDto res = service.GetRecieverExpert(new System.Collections.Generic.List<int>() { 4445, 2379, 874, 6937, 4205 });
            
        }
    }
}
