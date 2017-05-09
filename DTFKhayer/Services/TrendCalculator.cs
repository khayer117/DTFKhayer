using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer.Services
{
    public class TrendCalculator:ITrendCalculator
    {
        public long Calculate(Franchise franchise)
        {
            long trend = 0;

            var maxDate = Db.SQL<DateTime>("SELECT Max(s.SalesDate) FROM Sale s WHERE s.Franchise = ?", franchise).First;
            var minDate = Db.SQL<DateTime>("SELECT Min(s.SalesDate) FROM Sale s WHERE s.Franchise = ?", franchise).First;

            var avgCommission = (long)Db.SQL<decimal>("SELECT AVG(s.Commission) FROM Sale s WHERE s.Franchise = ?", franchise).First;

            var timeDuration = (maxDate - minDate).TotalDays;

            if (timeDuration > 0)
            {
                trend = (long)(1000*((double)avgCommission/timeDuration));
            }

            return trend;
        }
    }
}
