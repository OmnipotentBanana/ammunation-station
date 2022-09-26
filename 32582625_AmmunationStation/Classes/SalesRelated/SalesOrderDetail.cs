using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes.SalesRelated
{
    class SalesOrderDetail
    {
        public SalesOrderDetail(int salesOrderNumber, Inventory inventoryItem, int quantitySold, float unitPricePaid)
        {
            this.salesOrderNumber = salesOrderNumber;
            this.inventoryItem = inventoryItem;
            this.quantitySold = quantitySold;
            this.unitPricePaid = unitPricePaid;
        }

        public int salesOrderNumber { get; set; }
        public Inventory inventoryItem { get; set; }
        public int quantitySold { get; set; }
        public float unitPricePaid { get; set; }
    }
}
