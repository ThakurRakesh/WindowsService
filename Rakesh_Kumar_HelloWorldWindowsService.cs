using System;
using System.ServiceProcess;
using System.Timers;

namespace Rakesh_Kumar_HelloWorldWindowsService
{
    public partial class Rakesh_Kumar_HelloWorldWindowsService : ServiceBase
    {
        private Timer timer;

        public Rakesh_Kumar_HelloWorldWindowsService()
        {
        }

         protected override void OnStart(string[] args)
        {
            // Set up a timer to call the TimerElapsed method every 10 seconds
            timer = new Timer
            {
                Interval = TimeSpan.FromSeconds(10).TotalMilliseconds
            };
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }

        protected override void OnStop()
        {
            // Stop the timer when the service is stopped
            timer.Stop();
            timer.Dispose();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Write "Hello, World!" to the console
            Console.WriteLine("Hello, World!");
        }
    }
}
