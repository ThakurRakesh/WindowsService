using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Rakesh_Kumar_HelloWorldWindowsService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Rakesh_Kumar_HelloWorldWindowsService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
