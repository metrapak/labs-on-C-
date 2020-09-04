using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Modules.Wings
{
    public class BiplaneWings : IWings
    {
        public int LoadCapacity { get; set; }

        public BiplaneWings(int loadCapacity)
        {
            LoadCapacity = loadCapacity;
        }
    }
}
