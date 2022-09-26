using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes
{
    class Client : Person
    {
        public Client()
        {

        }

        public Client(int clientID, string stateID, string firstName, string surname, float moneySpent, Address address)
        {
            this.clientID = clientID;
            this.stateID = stateID;
            this.firstName = firstName;
            this.surname = surname;
            this.moneySpent = moneySpent;
            this.address = address;
        }
        public int clientID { get; set; }
        public string stateID { get; set; }
        public float moneySpent { get; set; }
        public Address address { get; set; }

        

        public override string ToString()
        {
            return clientID + " " + stateID + " " + moneySpent;
        }
    } 
}
