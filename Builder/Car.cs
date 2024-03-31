using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public double Weight { get; set; }
        public static int Counter { get; set; }

        public Car(string model, string colour, double weight) 
        {
            Id = Counter++;
            Model = model;
            Colour = colour;
            Weight = weight;
        }

        public void Drive()
        {
            Console.WriteLine($"{Colour} {Model} is moving. It weights {Weight} tons");
        }
    }
}
