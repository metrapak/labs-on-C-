using OOP_lab1.Companies;
using OOP_lab1.Modules.Engine.TypeOfEngine;
using OOP_lab1.Modules.Wings;
using OOP_lab1.Planes;
using OOP_lab1.Planes.TypeOfPlanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            company.AddPlanes(new List<PassengerPlane>()
            {
                new PassengerPlane(name: "Stg-34", flightRange: 2800, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 470),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-44", flightRange: 2700, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 870),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-54", flightRange: 3100, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 770),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    },
                new PassengerPlane(name: "Stg-64", flightRange: 1900, numberOfSeats: 96)
                    {
                        TurbineEngine = new TurbojetEngine(power: 100, fuelConsumption: 670),
                        MonoplaneWings = new MonoplaneWings(loadCapacity: 47000)
                    }
            });

            Print(company.GetPlanes());

            Print(company.SortByFlightRange());
            Console.WriteLine();
            Console.WriteLine("Total capcity: {0} places", company.TotalNumberOfSeats);
            Console.WriteLine("Total load capacity: {0} kg", company.TotalLoadCapacity);

            Console.Write("Input low-bound fuel consumption: ");
            InputNumber(out int lowerFuelConsumption);

            Console.Write("Input up-bound fuel consumption: ");
            InputNumber(out int upperFuelConsumption);

            Console.Clear();
            Console.WriteLine("Plane/s suitable for parameters:");
            Print(company.FindPlane(lowerFuelConsumption, upperFuelConsumption));
            Console.ReadKey();
        }

        public static void Print(IEnumerable<Plane> list)
        {
            foreach (var plane in list)
            {
                Console.WriteLine(
                    "name: {0}, load capacity: {1}kg, fuel consumption: {2}, flight range: {3}km",
                    plane.Name,
                    plane.LoadCapacity,
                    plane.FuelConsumption,
                    plane.FlightRange
                    );
            }
        }

        public static void InputNumber(out int number)
        {
            bool isNumber = true;

            do
            {
                if (!isNumber)
                {
                    Console.Clear();
                    Console.Write("It's not a number, try again: ");
                }
                isNumber = int.TryParse(Console.ReadLine(), out number);
            } while (!isNumber);
        }

    }
}
