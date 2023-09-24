using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plane_name = "Boing228";
            int plane_price = 10000000;
            int plane_speed = 480;
            int plane_years_of_issue = 2010;
            int plane_high = 2000;
            int plane_numbers_of_passengers = 100;
            Plane _plane = new Plane(plane_name, plane_price, plane_speed, plane_years_of_issue, plane_high, plane_numbers_of_passengers);
            _plane.Print();


            string car_name = "Dodge Charger"; 
            int car_price = 100000;
            int car_speed = 240;
            int car_years_of_issue = 1971;
            Car _car = new Car(car_name, car_price, car_speed, car_years_of_issue);
            _car.Print();

            string ship_name = "Cruise Ship";
            int ship_price = 20000000;
            int ship_speed = 100;
            int ship_years_of_issue = 2001;
            string ship_port = "Miami";
            int ship_numbers_of_passengers = 500;
            Ship _ship = new Ship(ship_name, ship_price, ship_speed, ship_years_of_issue, ship_port, ship_numbers_of_passengers);
            _ship.Print();
        }
    }
}
