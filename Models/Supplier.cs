using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework2.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string NamaSupplier { get; set; }
        public string Jalan { get; set; }
        public string Kota { get; set; }
    }
}
