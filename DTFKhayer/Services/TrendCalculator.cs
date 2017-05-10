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
        private decimal Weight = .01m;
        public long Calculate(IEnumerable<TrendDataItem> values)
        {
            var avgSlope = GetAvgSlope(values);

            var trend = Convert.ToInt64(avgSlope * Weight);

            return trend;
        }

        private decimal GetAvgSlope(IEnumerable<TrendDataItem> values)
        {
            var slopes = new List<decimal>();

            var counter = 1;
            var prevValue = new TrendDataItem();

            foreach (var value in values)
            {
                if (counter == 1)
                {
                    prevValue = value;
                    counter++;
                    continue;
                }

                var x1 = prevValue.X;
                var y1 = prevValue.Y;
                var x2 = value.X;
                var y2 = value.Y;
                var slope = 0m;

                var diffX = Math.Abs((x2 - x1));
                if (diffX != 0)
                {
                    slope = (y2 - y1)/(decimal)diffX;
                }
                slopes.Add(slope);

                prevValue = value;
                counter++;
            }

            return slopes.Count > 0 ? slopes.Average() : 0m;
        }
    }
}
