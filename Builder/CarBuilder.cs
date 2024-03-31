using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ICarBuilder
    {
        void SetModel(string model);
        void SetColour(string colour);
        void SetWeight(double weight);
        Car Construct();
    }
}
