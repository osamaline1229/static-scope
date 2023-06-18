
using System.Security.Cryptography;
using System.Text;

namespace static_scope
{
    internal class Car
    {
        string engine;
        int numberOfTyres;
        int numberOfDoors;
        string gearType;
        string color;

        public Car(string engine, int numberOfTyres, int numberOfDoors, string gearType, string color)
        {
            this.engine = engine;
            this.numberOfTyres = numberOfTyres;
            this.numberOfDoors = numberOfDoors;
            this.gearType = gearType;
            this.color = color;
        }
    }
}
