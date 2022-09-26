using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes.SalesRelated
{
    class PurchaseOrderDetail
    {
        public PurchaseOrderDetail(int ID, int purchaseOrderNumber, Inventory inventoryItem, int quantityOrdered, float unitPricePaid)
        {
            this.ID = ID;
            this.purchaseOrderNumber = purchaseOrderNumber;
            this.inventoryItem = inventoryItem;
            this.quantityOrdered = quantityOrdered;
            this.unitPricePaid = unitPricePaid;
        }
        public int ID { get; set; }
        public int purchaseOrderNumber { get; set; }
        public Inventory inventoryItem { get; set; }
        public int quantityOrdered { get; set; }
        public float unitPricePaid { get; set; }
        
    }
}
