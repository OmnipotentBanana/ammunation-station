using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes.SalesRelated
{
    class Inventory
    {
        public Inventory(int itemID, string itemSerialNumber, string itemMake, string itemModel, string itemCaliber, string itemType, float itemCost, int itemQuantity)
        {
            this.itemID = itemID;
            this.itemSerialNumber = itemSerialNumber;
            this.itemMake = itemMake;
            this.itemModel = itemModel;
            this.itemCaliber = itemCaliber;
            this.itemType = itemType;
            this.itemCost = itemCost;
            this.itemQuantity = itemQuantity;
        }
        public int itemID { get; set; }
        public string itemSerialNumber { get; set; }
        public string itemMake { get; set; }
        public string itemModel { get; set; }
        public string itemCaliber { get; set; }
        public string itemType { get; set; }
        public float itemCost { get; set; }
        public int itemQuantity { get; set; }

        public override string ToString()
        {
            return itemID + " " + itemSerialNumber + " " + itemMake + " " + itemModel + " " + itemCaliber + " " + itemType + " " + itemCost + " " + itemQuantity;
        }
    }
}
