using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTFKhayerEntity;

namespace DTFKhayer
{
    public interface IFranchiseService
    {
        Franchise GetFranchise(string name);          
    }
}
