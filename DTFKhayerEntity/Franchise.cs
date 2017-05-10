using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTFKhayerEntity
{
    [Database]
    public class Franchise:BaseEntity
    {
        public Corporation Corporation { get; set;}
        public string Name { get; set; }

        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string Address => $"{Street},{Number},{City},{Country}";

        public QueryResultRows<Sale> Sales => Db.SQL<Sale>("SELECT f FROM Sale f WHERE f.Franchise = ?", this);
    }
}
