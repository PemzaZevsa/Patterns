using BuilderPattern;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ConcreteCarBuilder builder = new ConcreteCarBuilder();
            director.BuildLambo(builder);
            Car car1 = builder.Construct();

            car1.Drive();

            director.BuildBugatti(builder);
            Car car2 = builder.Construct();

            car2.Drive();

            builder.SetModel("BMW M5");
            builder.SetColour("Black");
            builder.SetWeight(2.4);
            Car car3 = builder.Construct();

            car3.Drive();
        }
    }
}
