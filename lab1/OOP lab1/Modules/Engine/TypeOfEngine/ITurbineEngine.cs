using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Modules.Engine.TypeOfEngine
{
    public interface ITurbineEngine : IEngine
    {
        Turbine Turbine { get; set; }
    }
}
