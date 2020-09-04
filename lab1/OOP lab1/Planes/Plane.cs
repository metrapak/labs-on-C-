using OOP_lab1.Modules.Engine;
using OOP_lab1.Modules.Wings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Planes
{
    public abstract class Plane
    {
        public string Name { get; private set; }

        public int LoadCapacity => Wings.LoadCapacity;
        public int FuelConsumption => Engine.FuelConsumption;
        public int FlightRange { get; }
        protected abstract IEngine Engine { get; }
        protected abstract IWings Wings { get; }

        public Plane(string name, int flightRange)
        {
            Name = name;
            FlightRange = flightRange;
        }
    }
}
