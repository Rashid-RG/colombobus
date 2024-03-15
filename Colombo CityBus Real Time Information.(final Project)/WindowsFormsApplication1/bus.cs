using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBusManagement
{
    class bus
    {
       public static string busNo;
       public static string transit;
       public static string fare;
       public static string routeName;



        public bus()
        {


        }
       
      public string getbusNo()
        {
            return busNo;
        }
        public void setBusNo(string busno)
        {
            busNo = busno;

        }
        public string getTansit()
        {
            return transit;
        }
        public void setTransit(string transit_)
        {
            transit = transit_;
        }
        public string getFare()
        {
            return fare;
        }
        public void setFare(string fare_)
        {
            fare = fare_;
        }
        public string getRoute()
        {
            return routeName;
        }
        public void setRoute(string route)
        {
            routeName = route;
        }
        public override string ToString()
        {
            return busNo + " " + transit + " " + fare + " " + routeName + " "  +"\n";
        }
        


        }
    }

