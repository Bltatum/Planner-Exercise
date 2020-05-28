using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Building1 = new Building("111 south st.")
            {
                Stories = 3,
                Width = 200,
                Depth = 100,

            };
            Building1.Construct();
            Building1.Purchase("John Wark");

            Building1.GetDetails();

        }

    }
}