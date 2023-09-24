using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab02_2
{
    public class Vehicle
    {
        protected int price;
        protected int speed;
        protected int years_of_issue;
        protected string model_name;

        public int Price
        {
            get { return this.price; }
        }

        public int Speed
        {
            get { return this.speed; }
        }

        public int Years_of_Issue
        {
            get { return this.years_of_issue; }
        }

        public string Model_Name
        {
            get { return this.model_name; }
        }

        public Vehicle(string Model_Name, int Price, int Speed, int Years_of_Issue)
        {
            this.price = Price;
            this.speed = Speed;
            this.years_of_issue = Years_of_Issue;
            this.model_name = Model_Name;
        }

        public virtual void Print() { }
    }

    class Plane : Vehicle
    {
        private int high;
        private int number_of_passengers;
        public Plane(string Model_Name, int Price, int Speed, int Years_of_Issue, int High, int Number_of_Passengers) : base(Model_Name, Price, Speed, Years_of_Issue)
        {
            this.high = High;
            this.number_of_passengers = Number_of_Passengers;
        }
        public override void Print()
        {
            Console.WriteLine($"Model Name: {this.model_name}\t Price: {this.price}\t Speed: {this.speed}\t Years of issue: {this.years_of_issue}\t High: {this.high}\t Number of passengers: {this.number_of_passengers}\t");
        }
    }

    class Car : Vehicle
    {

        public Car(string Model_Name, int Price, int Speed, int Years_of_Issue) : base(Model_Name, Price, Speed, Years_of_Issue) { }
        public override void Print()
        {
            Console.WriteLine($"Model Name: {this.model_name}\t Price: {this.price}\t Speed: {this.speed}\t Years of issue: {this.years_of_issue}\t");
        }
    }

    class Ship : Vehicle
    {
        private string port;
        private int number_of_passengers;
        public Ship(string Model_Name, int Price, int Speed, int Years_of_Issue, string Port, int Number_of_Passengers) : base(Model_Name, Price, Speed, Years_of_Issue)
        {
            this.port = Port;
            this.number_of_passengers = Number_of_Passengers;
        }
        public override void Print()
        {
            Console.WriteLine($"Model Name: {this.model_name}\t Price: {this.price}\t Speed: {this.speed}\t Years of issue: {this.years_of_issue}\t Port: {this.port}\t Number of passengers: {this.number_of_passengers}\t");
        }
    }
}
