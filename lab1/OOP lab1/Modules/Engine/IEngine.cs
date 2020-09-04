using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Modules.Engine
{
    public interface IEngine
    {
        int Power { get; set; }
        int FuelConsumption { get; set; }

    }
}
