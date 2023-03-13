using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        { }
        public class Car
        {
            // Class attributes
            public string Model;
            public string Manufacturer;
            public int Year;
            public double Price;
            public bool IsElectric;
            public string[] Features;
            public double[] Acceleration;
            public string[] Colors;

            // Constructors
            public Car()
            {
                Model = "Unknown";
                Manufacturer = "Unknown";
                Year = 2021;
                Price = 0;
                IsElectric = false;
                Features = new string[] { };
                Acceleration = new double[] { };
                Colors = new string[] { };
            }

            public Car(string model, string manufacturer, int year, double price, bool isElectric)
            {
                Model = model;
                Manufacturer = manufacturer;
                Year = year;
                Price = price;
                IsElectric = isElectric;
                Features = new string[] { };
                Acceleration = new double[] { };
                Colors = new string[] { };
            }

            public Car(string model, string manufacturer, int year, double price, bool isElectric, string[] features)
            {
                Model = model;
                Manufacturer = manufacturer;
                Year = year;
                Price = price;
                IsElectric = isElectric;
                Features = features;
                Acceleration = new double[] { };
                Colors = new string[] { };
            }

            public Car(string model, string manufacturer, int year, double price, bool isElectric, string[] features, double[] acceleration)
            {
                Model = model;
                Manufacturer = manufacturer;
                Year = year;
                Price = price;
                IsElectric = isElectric;
                Features = features;
                Acceleration = acceleration;
                Colors = new string[] { };
            }

            public Car(string model, string manufacturer, int year, double price, bool isElectric, string[] features, double[] acceleration, string[] colors)
            {
                Model = model;
                Manufacturer = manufacturer;
                Year = year;
                Price = price;
                IsElectric = isElectric;
                Features = features;
                Acceleration = acceleration;
                Colors = colors;
            }

            // Class methods
            public void DisplayInfo()
            {
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Manufacturer: {Manufacturer}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Price: {Price:C}");
                Console.WriteLine($"Is Electric: {IsElectric}");
                Console.WriteLine($"Features: {string.Join(", ", Features)}");
                Console.WriteLine($"Acceleration: {string.Join(", ", Acceleration)}");
                Console.WriteLine($"Colors: {string.Join(", ", Colors)}");
            }

            public void AddFeature(string feature)
            {
                Array.Resize(ref Features, Features.Length + 1);
                Features[Features.Length - 1] = feature;
            }

            public void AddAcceleration(double acceleration)
            {
                Array.Resize(ref Acceleration, Acceleration.Length + 1);
                Acceleration[Acceleration.Length - 1] = acceleration;
            }

            public void AddColor(string color)
            {
                Array.Resize(ref Colors, Colors.Length + 1);
                Colors[Colors.Length - 1] = color;
            }

            public double GetAverageAcceleration()
            {
                double sum = 0;
                foreach (double acceleration in Acceleration)
                {
                    sum += acceleration;
                }
                return sum / Acceleration.Length;
            }

            public bool IsSameModel(Car otherCar)
            {
                return Model == otherCar.Model;
            }

        }
    }
        

}


