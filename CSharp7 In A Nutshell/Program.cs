using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_In_A_Nutshell
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car
            {
                GrossWeight = 1500,
                Mileage = 14222
            };

            var oilSystem = new OilSystem
            {
                OilTypes = new List<OilType>
                {
                    OilType.Oil_0W30_Diesel
                },
                OilChangeInterval = 10000,
                Quantity = 5,
            };

            car1.OilSystem = oilSystem;
            car1.OilSystem.OilChanged += Announce_OilChange;
            car1.OilSystem.ChangeOil(car1.Mileage);
            Console.ReadKey();
        }
        static void Announce_OilChange(object sender, OilChangeEventArgs e)
        {
            Console.WriteLine($"next oil change will be at {e.NextOilChange} kms.");
        }
    }
    
}
