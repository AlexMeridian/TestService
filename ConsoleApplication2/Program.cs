using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Program {

        public static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        static void Main(string[] args) {
            log4net.Config.XmlConfigurator.Configure();
            log.Debug("test");
            while(true) {
                try {
                    DateTime dt = DateTime.Now;
                    VendorSvc.VendorSvcClient svc = new VendorSvc.VendorSvcClient();
                    log.Info(string.Format("Attempting service at: {0}", dt.ToString()));
                    var test = svc.SaySomething();
                    log.Info(string.Format("Results: {0}", test));
                    Console.WriteLine(test);
                    if (!string.IsNullOrEmpty(test))
                        Console.WriteLine("Test Timestamp worked at: " + dt.ToString());
                } catch (Exception ex) {
                    log.Error("It Failed!");
                    log.Error(ex.Message);
                }
                Thread.Sleep(600000);
            }
            

        }
    }
}
