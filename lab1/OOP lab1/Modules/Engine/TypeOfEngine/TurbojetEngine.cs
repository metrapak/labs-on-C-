using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Modules.Engine.TypeOfEngine
{
    public class TurbojetEngine : ITurbineEngine
    {
        public int Power { get; set; }
        public int FuelConsumption { get; set; }
        public Turbine Turbine { get; set; }

        public TurbojetEngine(int power, int fuelConsumption)
        {
            Power = power;
            FuelConsumption = fuelConsumption;
            Turbine = new Turbine() { Pressure = 100 };
        }
    }
}