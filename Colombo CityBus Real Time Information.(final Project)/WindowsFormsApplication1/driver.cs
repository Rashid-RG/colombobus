using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBusManagement
{
    class driver
    {
       public static string ID;
    public static    string firstname;
     public static   string lastname;
        
       public driver()
        {

        }
        public void setID(string id)
        {
            ID = id;
        }
        public string getID()
        {
            return ID;
        }
        public void setFirstName(string first)
        {
            firstname = first;
        }
        public string getFirstName()
        {

            return firstname;
        }
        public void setLastName(string last)
        {
            lastname = last;

        }
        public string getLastName()
        {
            return lastname;
        }
        public override string ToString()
        {
            return getID()+ "  " + getFirstName() +"  " +getLastName();
        }

    }

}
