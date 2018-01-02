using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_In_A_Nutshell
{
    public abstract class Vehicle
    {
        public string Vin { get; set; }
        public double GrossWeight { get; set; }
        public Engine Engine { get; set; }
        public int Mileage { get; set; }

    }
}
