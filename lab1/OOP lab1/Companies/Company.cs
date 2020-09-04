using OOP_lab1.Modules.Frame;
using OOP_lab1.Planes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Companies
{
    public class Company
    {
        public Company()
        {
            planes = new List<Plane>();
        }

        public void AddPlane(Plane plane)
        {
            planes.Add(plane);
        }

        public void AddPlanes(IEnumerable<Plane> list)
        {
            foreach (var plane in list)
            {
                planes.Add(plane);
            }
        }

        public int TotalNumberOfSeats
        {
            get
            {
                return planes
                    .Where(plane => plane is IPassangerFrame)
                    .Select(plane => plane as IPassangerFrame)
                    .Sum(plane => plane.NumberOfSeats);
            }
        }
        public int TotalLoadCapacity
        {
            get
            {
                return planes.Sum(plane => plane.LoadCapacity);
            }
        }
        public IList<Plane> GetPlanes()
        {
            return planes;
        }
        public IList<Plane> SortByFlightRange()
        {
            return planes.OrderBy(plane => plane.FlightRange).ToList();
        }
        public IList<Plane> FindPlane(int lowerFuelConsumption, int upperFuelConsumption)
        {
            return planes.Where(plane => plane.FuelConsumption >= lowerFuelConsumption && plane.FuelConsumption <= upperFuelConsumption).ToList();
        }

        List<Plane> planes;
    }
}

