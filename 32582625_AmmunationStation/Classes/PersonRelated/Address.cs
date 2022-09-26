using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes
{
    public class Address
    {
        public int addressID { get; set; }
        public int streetNumber { get; set; }
        public string streetName { get; set; }
        public string cityName { get; set; }
       
        public Address(int addressID, int streetNumber, string streetName, string cityName)
        {
            this.addressID = addressID;
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.cityName = cityName;
        }

        public Address()
        {

        }

        public override string ToString()
        {
            return addressID + " " + streetNumber + " " + streetName + " " + cityName;
        }
    }
}
