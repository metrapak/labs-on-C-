using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Modules.Engine.TypeOfEngine
{
    public class TurbopropEngine : IScrewEngine, ITurbineEngine
    {
        public int Power { get; set; }
        public int FuelConsumption { get; set; }
        public Screw Screw { get; set; }
        public Turbine Turbine { get; set; }

        public TurbopropEngine(int power, int fuelConsumption)
        {
            Power = power;
            FuelConsumption = fuelConsumption;
            Screw = new Screw() { PaddlesCount = 4 };
            Turbine = new Turbine() { Pressure = 100 };
        }
    }
}
