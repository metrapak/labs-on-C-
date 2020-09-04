using OOP_lab1.Modules.Engine;
using OOP_lab1.Modules.Engine.TypeOfEngine;
using OOP_lab1.Modules.Frame;
using OOP_lab1.Modules.Wings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Planes.TypeOfPlanes
{
    public class CargoPlane : Plane, ICargoFrame
    {
        public int Capacity { get; set; }

        public TurbopropEngine TurbopropEngine { get; set; }
        public MonoplaneWings MonoplaneWings { get; set; }

        protected override IEngine Engine => TurbopropEngine;
        protected override IWings Wings => MonoplaneWings;

        public CargoPlane(string name, int flightRange, int capacity) : base(name, flightRange)
        {
            Capacity = capacity;
        }
    }
}
