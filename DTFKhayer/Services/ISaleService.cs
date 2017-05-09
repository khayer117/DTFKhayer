using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTFKhayerEntity;

namespace DTFKhayer.Services
{
    interface ISaleService
    {
        void Add(Sale sale);
        IList<Sale> GetAllSales();
    }
}
