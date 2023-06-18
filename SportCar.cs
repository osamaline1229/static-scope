using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_scope
{
    internal class SportCar : Car
    {
        string nitros;
        string specialsearBelts;

        public SportCar(string engine, int numberOfTyres, int numberOfDoors, string gearType, string color, string nitros, string specialsearBelts) 
        {
            this.nitros = nitros;
            this.specialsearBelts = specialsearBelts;
        }
    }
    
}
