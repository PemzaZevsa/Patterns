using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteCarBuilder : ICarBuilder
    {
        private string colour;
        private string model;
        private double weight;

        public ConcreteCarBuilder()
        {
            colour = "Black";
            model = "Car";
        }

        public void SetColour(string colour)
        {
            this.colour = colour;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }
        public Car Construct()
        {
            return new Car(model, colour, weight);
        }
    }
}
