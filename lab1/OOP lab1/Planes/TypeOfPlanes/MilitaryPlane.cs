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
    class MilitaryPlane : Plane, IMilitaryFrame
    {
        public int NumberOfRockets { get; set; }

        public ITurbineEngine TurbineEngine { get; set; }
        public MonoplaneWings MonoplaneWings { get; set; }

        protected override IEngine Engine => TurbineEngine;
        protected override IWings Wings => MonoplaneWings;

        public MilitaryPlane(string name, int flightRange, int numberOfRockets) : base(name, flightRange)
        {
            NumberOfRockets = numberOfRockets;
        }
    }
    
}
