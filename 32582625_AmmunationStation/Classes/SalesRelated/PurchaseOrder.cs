using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes.SalesRelated
{
    class PurchaseOrder : Order
    {
        public Supplier supplier { get; set; }
        public PurchaseOrderDetail[] purchaseOrderDetails { get; set; }
        public int size { get; set; }
        public override string ToString()
        {
            string returnString = "Date and Time: " + orderDate.ToString() +
                                  "\nPurchase Order Number: " + orderNumber +
                                  "\nSupplier: " + supplier.supplierName +
                                  "\n\nItems Purchased:";
            
            for (int a = 0; a < size; a++)
            {
                var ptr = purchaseOrderDetails[a].inventoryItem;
                returnString += "\nItem " + (a + 1).ToString() + ":";
                returnString += "\n\tSerial Number: " + ptr.itemSerialNumber +
                                "\n\tMake: " + ptr.itemMake +
                                "\n\tModel: " + ptr.itemModel +
                                "\n\tCaliber: " + ptr.itemCaliber +
                                "\n\tType: " + ptr.itemType +
                                "\n\tCost: " + ptr.itemCost +
                                "\n\tQuantity: " + ptr.itemQuantity;
            }
            return returnString;
        }
    }
}
