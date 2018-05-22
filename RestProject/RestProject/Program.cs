using System;
using Nancy.Hosting.Self;

namespace RestProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nancyHost = new NancyHost(new Uri("http://localhost:8888/"));

            nancyHost.Start();

            Console.WriteLine("Nancy is listening on http://localhost:8888/");
            Console.ReadKey();

            nancyHost.Stop();

            Console.WriteLine("Nancy is stopped");
        }
    }
}
