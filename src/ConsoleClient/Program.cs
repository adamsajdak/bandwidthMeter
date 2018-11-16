using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandwidthMeterService;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var meter = new Meter();
            foreach (var metric in meter.GetMetrics())
            {
                Console.WriteLine(metric);
            }

            Console.ReadKey();
        }
    }
}
