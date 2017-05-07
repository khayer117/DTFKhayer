using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTFKhayerEntity
{
    [Database]
    public class Corporation:BaseEntity
    {
        public string Name { get; set; }

        public QueryResultRows<Franchise> Franchises => Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.Corporation = ?", this);

    }
}
