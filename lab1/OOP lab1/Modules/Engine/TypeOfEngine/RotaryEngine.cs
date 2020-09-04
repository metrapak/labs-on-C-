using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Modules.Engine.TypeOfEngine
{
    class RotaryEngine : IScrewEngine
    {
        public int Power { get; set; }
        public int FuelConsumption { get; set; }
        public Screw Screw { get; set; }

        public RotaryEngine(int power, int fuelConsumption)
        {
            Power = power;
            FuelConsumption = fuelConsumption;
            Screw = new Screw() { PaddlesCount = 4 };
        }
    }
}
