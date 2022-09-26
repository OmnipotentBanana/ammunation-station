using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32582625_AmmunationStation.Classes
{
    class Employee : Person
    {
        public Employee(int _employeeID, string _firstName, string _surname, bool _isAdmin)
        {
            employeeID = _employeeID;
            employeeName = _firstName;
            employeeSurname = _surname;
            isAdmin = _isAdmin;
        }

        public Employee()
        {

        }
        public static int employeeID { get; set; }
        public static string employeeName { get; set; }
        public static string employeeSurname { get; set; }
        public static bool isAdmin { get; set; }

        public override string ToString()
        {
            return employeeID + " " + firstName + " " + surname + " " + isAdmin;
        }

        public string getEmployeeName()
        {
            return employeeName;
        }

        public string getEmployeeSurname()
        {
            return employeeSurname;
        }

        public bool getIsAdmin()
        {
            return isAdmin;
        }
    }
}
