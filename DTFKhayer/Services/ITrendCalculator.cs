using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTFKhayerEntity;

namespace DTFKhayer.Services
{
    public interface ITrendCalculator
    {
       long Calculate(IEnumerable<TrendDataItem> values);
    }
}
