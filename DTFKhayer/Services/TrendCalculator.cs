using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer.Services
{
    public class TrendCalculator:ITrendCalculator
    {
        private long Weight = 100000000000000;
        public long Calculate(IDictionary<long, long> values)
        {
            var avgSlope = GetAvgSlope(values);

            var trend = Convert.ToInt64(avgSlope * Weight);

            return trend;
        }

        private decimal GetAvgSlope(IDictionary<long, long> values)
        {
            var slopes = new List<decimal>();

            var counter = 1;
            var prevValue = new KeyValuePair<long, long>();

            foreach (var value in values)
            {
                if (counter == 1)
                {
                    prevValue = value;
                    counter++;
                    continue;
                }

                var x1 = prevValue.Key;
                var y1 = prevValue.Value;
                var x2 = value.Key;
                var y2 = value.Value;
                var slope = 0m;

                var diffX = (x1 - x2);
                if (diffX != 0)
                {
                    slope = Math.Abs((y1 - y2)/(decimal)diffX);
                }
                slopes.Add(slope);

                prevValue = value;
                counter++;
            }

            return slopes.Count > 0 ? slopes.Average() : 0m;
        }
    }
}
