using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes.SalesRelated
{
    class SalesOrder : Order
    {
        public Client client { get; set; }
        public SalesOrderDetail[] salesOrderDetail { get; set; }
        public int size { get; set; }

        public override string ToString()
        {
            string returnString = "Date and Time: " + orderDate.ToString() +
                                  "\nSales Order Number: " + orderNumber +
                                  "\nClient: " + client.firstName + " " + client.surname +
                                  "\n\nItems Sold:";

            for (int a = 0; a < size; a++)
            {
                var ptr = salesOrderDetail[a].inventoryItem;
                returnString += "\nItem " + (a + 1).ToString() + ":";
                returnString += "\n\tSerial Number: " + ptr.itemSerialNumber +
                                "\n\tMake: " + ptr.itemMake +
                                "\n\tModel: " + ptr.itemModel +
                                "\n\tCaliber: " + ptr.itemCaliber +
                                "\n\tType: " + ptr.itemType +
                                "\n\tItem Cost: " + ptr.itemCost +
                                "\n\tSold For: " + salesOrderDetail[a].unitPricePaid +
                                "\n\tQuantity: " + salesOrderDetail[a].quantitySold +
                                "\n\tTotal: " + salesOrderDetail[a].unitPricePaid * salesOrderDetail[a].quantitySold;
            }
            return returnString;
        }
    }

    
}
