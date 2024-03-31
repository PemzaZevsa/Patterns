using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public void BuildBugatti(ICarBuilder builder)
        {
            builder.SetModel("Bugatti");
            builder.SetColour("Yellow");
            builder.SetWeight(1.5);
        }

        public void BuildLambo(ICarBuilder builder)
        {
            builder.SetModel("Lamborghini");
            builder.SetColour("Blue");
            builder.SetWeight(2.1);
        }
    }
}
