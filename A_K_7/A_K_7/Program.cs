
using System;
using System.Diagnostics.Metrics;
using System.Linq;
namespace AK7
{
    public class Vehicle
    {
        protected string Make, Model;
        protected int Year;


        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }


    public class MotorVehicle : Vehicle
    {
        public MotorVehicle(string make, string model, int year)
            : base(make, model, year)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Type: MotorVehicle");
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }


    public class Car : MotorVehicle
    {
        protected int Doors;

        public Car(string make, string model, int year, int doors)
            : base(make, model, year)
        {
            Doors = doors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Type: MotorVehicle");
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
            Console.WriteLine($"Doors: {Doors}");
        }
    }


    public class Truck : MotorVehicle
    {
        public double LoadCapacity { get; set; }

        public Truck(string make, string model, int year, double loadCapacity)
            : base(make, model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Type: MotorVehicle");
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
            Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {


            Car car = new Car("Toyota", "Corolla", 2022, 4);
            Truck truck = new Truck("Ford", "F-150", 2023, 2.5);

            Console.WriteLine("Car Details:");
            car.DisplayInfo();

            Console.WriteLine("\nTruck Details:");
            truck.DisplayInfo();


            Console.ReadKey();

        }
    }
}



