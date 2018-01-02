using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_In_A_Nutshell
{
    class Car : Vehicle, ICombustionEngineDriven
    {

        public OilSystem OilSystem { get; set; }
        public Car()
        {
            OilSystem = new OilSystem();
        }
    }

}
