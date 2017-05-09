using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer
{
    public class FranchiseService : IFranchiseService
    {
        public Franchise GetFranchise(string key)
        {
            return Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.ObjectId =?", key).First;
        }
    }
}
