using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            City Nashville = new City()
            {
                Name = "Nashville",
                Mayor = "Big Dummy",
                Established = 1862,

            };

            Building Building1 = new Building("111 south st.")
            {
                Stories = 3,
                Width = 200,
                Depth = 100,

            };
            Building1.Construct();
            Building1.Purchase("John Wark");
            Nashville.allBuildings.Add(Building1);

            Building Building2 = new Building("100 North st.")
            {
                Stories = 2,
                Width = 50,
                Depth = 500,

            };
            Building2.Construct();
            Building2.Purchase("Bob Evans");
            Nashville.allBuildings.Add(Building2);

            Building Building3 = new Building("300 west st.")
            {
                Stories = 4,
                Width = 250,
                Depth = 250,
            };
            Building3.Construct();
            Building3.Purchase("Jimy Dean");
            Nashville.allBuildings.Add(Building3);

            // Building1.GetDetails();

            foreach (Building building in Nashville.allBuildings)
            {
                building.GetDetails();
            }

        }

    }
}