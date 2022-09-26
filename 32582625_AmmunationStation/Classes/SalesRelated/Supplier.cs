using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes.SalesRelated
{
    public class Supplier
    {
        public Supplier(int supplierID, string supplierName, string supplierLocation, string supplierEmail)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.supplierLocation = supplierLocation;
            this.supplierEmail = supplierEmail;
        }

        public Supplier()
        {

        }

        public int supplierID { get; set; }
        public string supplierName { get; set; }
        public string supplierLocation { get; set; }
        public string supplierEmail { get; set; }
    }
}
