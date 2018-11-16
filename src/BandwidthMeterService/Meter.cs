using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandwidthMeterService
{
    public class Meter
    {
        public IReadOnlyCollection<int> GetMetrics()
        {
            var metrics = new List<int>();
            var random = new Random();
            const int n = 100;
            for (var i = 0; i < n; i++)
            {
                metrics.Add(random.Next());
            }
            return metrics;
        }
    }
}
