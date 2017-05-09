using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace DTFKhayerEntity
{
    [Database]
    public class Sale:BaseEntity
    {
        public Home Home { get; set; }
        public Franchise Franchise {get; set; }
        public DateTime SalesDate { get; set; }
        public long Price { get; set; }
        public long Commission { get; set; }
    }
}
